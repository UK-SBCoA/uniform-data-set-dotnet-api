using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    /// <summary>
    /// A packet is a visit that is not pending (finalized or after)
    /// </summary>
    [Route("api/[controller]")]
    public class PacketsController : Controller, IPacketClient
    {
        private readonly ApiDbContext _context;

        public PacketsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("Count", Name = "PacketsCount")]
        public async Task<int> Count()
        {
            return await _context.Visits
                .Where(v => v.Status != PacketStatus.Pending)
                .CountAsync();
        }

        /// <summary>
        /// Returns visits that are finalized or after
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<PacketDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.Visits
                .Include(v => v.PacketSubmissions)
                    .ThenInclude(p => p.PacketSubmissionErrors)
                .AsNoTracking()
                .Where(v => v.Status != PacketStatus.Pending)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToPacketDto())
                .ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<PacketDto> Get(int id)
        {
            var dto = await _context.Visits
                .Include(v => v.PacketSubmissions)
                    .ThenInclude(p => p.PacketSubmissionErrors)
                .Where(v => v.Id == id)
                .Select(v => v.ToPacketDto())
                .FirstOrDefaultAsync();

            return dto;
        }

        [HttpGet("{id}/IncludeForms")]
        public async Task<PacketDto> GetPacketWithForms(int id)
        {
            var dto = await _context.Visits
                .Include(v => v.PacketSubmissions)
                    .ThenInclude(p => p.PacketSubmissionErrors)
                .Where(v => v.Id == id)
                .AsNoTracking()
                .Select(v => v.ToPacketDto())
                .FirstOrDefaultAsync();

            if (dto != null)
            {
                var visit = await _context.Visits
                    .Include(v => v.A1)
                    .Include(v => v.A1a)
                    .Include(v => v.A2)
                    .Include(v => v.A3)
                    .Include(v => v.A4)
                    .Include(v => v.A4a)
                    .Include(v => v.A5D2)
                    .Include(v => v.B1)
                    .Include(v => v.B3)
                    .Include(v => v.B4)
                    .Include(v => v.B5)
                    .Include(v => v.B6)
                    .Include(v => v.B7)
                    .Include(v => v.B8)
                    .Include(v => v.B9)
                    .Include(v => v.C2)
                    .Include(v => v.D1a)
                    .Include(v => v.D1b)
                    .Where(v => v.Id == id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (dto.PacketSubmissions != null && dto.PacketSubmissions.Count() > 0)
                {
                    // TODO implement temporality so that older versions can be pulled
                    foreach (var submission in dto.PacketSubmissions)
                    {
                        submission.Forms.Add(visit.A1.ToFullDto());
                        submission.Forms.Add(visit.A1a.ToFullDto());
                        submission.Forms.Add(visit.A2.ToFullDto());
                        submission.Forms.Add(visit.A3.ToFullDto());
                        submission.Forms.Add(visit.A4.ToFullDto());
                        submission.Forms.Add(visit.A4a.ToFullDto());
                        submission.Forms.Add(visit.A5D2.ToFullDto());
                        submission.Forms.Add(visit.B1.ToFullDto());
                        submission.Forms.Add(visit.B3.ToFullDto());
                        submission.Forms.Add(visit.B4.ToFullDto());
                        submission.Forms.Add(visit.B5.ToFullDto());
                        submission.Forms.Add(visit.B6.ToFullDto());
                        submission.Forms.Add(visit.B7.ToFullDto());
                        submission.Forms.Add(visit.B8.ToFullDto());
                        submission.Forms.Add(visit.B9.ToFullDto());
                        submission.Forms.Add(visit.C2.ToFullDto());
                        submission.Forms.Add(visit.D1a.ToFullDto());
                        submission.Forms.Add(visit.D1b.ToFullDto());
                    }
                }
            }

            return dto;
        }

        /// <summary>
        /// Packets are not created, visits are the initial object
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public async Task Post(PacketDto dto)
        {
            throw new NotImplementedException("Packets are not created, use Visits.");
        }

        /// <summary>
        /// Put updates the status of the visit, packet submissions, and errors
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] PacketDto dto)
        {
            if (dto != null)
            {
                var existingPacket = await _context.Visits
                    .Include(v => v.PacketSubmissions)
                        .ThenInclude(p => p.PacketSubmissionErrors)
                    .Where(p => p.Id == id)
                    .FirstOrDefaultAsync();

                if (existingPacket != null)
                {
                    existingPacket.Status = dto.Status.Convert();
                    existingPacket.ModifiedBy = dto.ModifiedBy;

                    // iterate dto submissions, see if there are any new

                    // see if there are any updates to existing

                    // iterate dto errors, see if there are any new

                    _context.Visits.Update(existingPacket);
                    await _context.SaveChangesAsync();
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Count/ByStatus/{status}", Name = "PacketsCountByStatusAndAssignee")]
        public async Task<int> CountByStatusAndAssignee(string[] statuses, string assignedTo)
        {
            if (string.IsNullOrWhiteSpace(assignedTo))
            {
                return await _context.Visits
                    .Where(v => EF.Constant(statuses).Contains(v.Status.ToString()))
                    .CountAsync();
            }
            else
            {
                var visitsAtStatus = await _context.Visits
                    .Include(v => v.PacketSubmissions)
                        .ThenInclude(p => p.PacketSubmissionErrors)
                    .Where(v => EF.Constant(statuses).Contains(v.Status.ToString()))
                    .ToListAsync();

                int count = 0;

                foreach (var visit in visitsAtStatus)
                {
                    bool assigneeAssignedToThisVisit = false;
                    foreach (var submission in visit.PacketSubmissions)
                    {
                        if (submission.PacketSubmissionErrors.Any(p => String.IsNullOrWhiteSpace(p.ResolvedBy) == true && p.AssignedTo == assignedTo))
                            assigneeAssignedToThisVisit = true;
                    }
                    if (assigneeAssignedToThisVisit)
                        count++;
                }

                return count;
            }
        }

        [HttpGet("ByStatus/{status}", Name = "GetPacketsByStatusAndAssignee")]
        public async Task<List<PacketDto>> GetPacketsByStatusAndAssignee(string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            var dto = new List<PacketDto>();
            if (string.IsNullOrWhiteSpace(assignedTo))
            {
                dto = await _context.Visits
                    .Include(v => v.PacketSubmissions)
                        .ThenInclude(p => p.PacketSubmissionErrors)
                    .Where(v => EF.Constant(statuses).Contains(v.Status.ToString()))
                    .AsNoTracking()
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => p.ToPacketDto())
                    .ToListAsync();
            }
            else
            {
                var visitsAtStatus = await _context.Visits
                    .Include(v => v.PacketSubmissions)
                        .ThenInclude(p => p.PacketSubmissionErrors)
                    .Where(v => EF.Constant(statuses).Contains(v.Status.ToString()))
                    .ToListAsync();

                foreach (var visit in visitsAtStatus)
                {
                    bool assigneeAssignedToThisVisit = false;
                    foreach (var submission in visit.PacketSubmissions)
                    {
                        if (submission.PacketSubmissionErrors.Any(p => String.IsNullOrWhiteSpace(p.ResolvedBy) == true && p.AssignedTo == assignedTo))
                            assigneeAssignedToThisVisit = true;
                    }

                    if (assigneeAssignedToThisVisit)
                    {
                        dto.Add(visit.ToPacketDto());
                    }
                }
            }

            return dto;
        }








        //[HttpGet("ByVisit/{visitId}", Name = "GetPacketSubmissionByVisit")]
        //public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        //{
        //    var dto = await _context.PacketSubmissions
        //        .Include(p => p.Visit)
        //        .Include(p => p.PacketSubmissionErrors)
        //        .Where(p => p.VisitId == visitId)
        //        .AsNoTracking()
        //        .Skip((pageIndex - 1) * pageSize)
        //        .Take(pageSize)
        //        .Select(p => p.ToDto(p.PacketSubmissionErrors.Count()))
        //        .ToListAsync();

        //    return dto;
        //}


        //[HttpGet("Errors/Count", Name = "PacketSubmissionErrorsCount")]
        //public async Task<int> PacketSubmissionErrorsCount(bool includeResolved = false)
        //{
        //    if (includeResolved)
        //    {
        //        return await _context.PacketSubmissionErrors
        //            .Where(e => String.IsNullOrWhiteSpace(e.ResolvedBy) == false)
        //            .CountAsync();
        //    }
        //    else
        //    {
        //        return await _context.PacketSubmissionErrors
        //            .CountAsync();
        //    }
        //}

        //[HttpGet("Errors/Count/ByVisit/{visitId}", Name = "PacketSubmissionErrorsCountByVisit")]
        //public async Task<int?> PacketSubmissionsErrorsCountByVisit(int visitId)
        //{
        //    return await _context.PacketSubmissions
        //        .Where(e => e.VisitId == visitId)
        //        .Select(p => p.ErrorCount)
        //        .FirstOrDefaultAsync();
        //}

        //[HttpGet("Errors/Count/ByAssignee/{assignedTo}", Name = "PacketSubmissionErrorsCountByAssignee")]
        //public async Task<int> PacketSubmissionsErrorsCountByAssignee(string assignedTo)
        //{
        //    return await _context.PacketSubmissionErrors
        //        .Where(e => e.AssignedTo.ToLower().Trim() == assignedTo.ToLower().Trim())
        //        .CountAsync();
        //}

        //[HttpGet("Errors", Name = "GetPacketSubmissionErrors")]
        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1)
        //{
        //    if (includeResolved)
        //    {
        //        return await _context.PacketSubmissionErrors
        //            .Where(e => String.IsNullOrWhiteSpace(e.ResolvedBy) == false)
        //            .AsNoTracking()
        //            .Skip((pageIndex - 1) * pageSize)
        //            .Take(pageSize)
        //            .Select(p => p.ToDto())
        //            .ToListAsync();
        //    }
        //    else
        //    {
        //        return await _context.PacketSubmissionErrors
        //            .AsNoTracking()
        //            .Skip((pageIndex - 1) * pageSize)
        //            .Take(pageSize)
        //            .Select(p => p.ToDto())
        //            .ToListAsync();
        //    }
        //}

        //[HttpGet("Errors/ByVisit/{visitId}", Name = "GetPacketSubmissionErrorsByVisit")]
        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        //{
        //    return await _context.PacketSubmissionErrors
        //        .Include(e => e.PacketSubmission)
        //        .Where(e => e.PacketSubmission.VisitId == visitId)
        //        .AsNoTracking()
        //        .Skip((pageIndex - 1) * pageSize)
        //        .Take(pageSize)
        //        .Select(p => p.ToDto())
        //        .ToListAsync();
        //}

        //[HttpGet("Errors/ByAssignee/{assignedTo}", Name = "GetPacketSubmissionErrorsByAssignee")]
        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1)
        //{
        //    return await _context.PacketSubmissionErrors
        //        .Where(e => e.AssignedTo.ToLower().Trim() == assignedTo.ToLower().Trim())
        //        .AsNoTracking()
        //        .Skip((pageIndex - 1) * pageSize)
        //        .Take(pageSize)
        //        .Select(p => p.ToDto())
        //        .ToListAsync();
        //}

        //[HttpPost("{packetSubmissionId}/Errors", Name = "PostPacketSubmissionError")]
        //public async Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        //{
        //    var packetSubmission = await _context.PacketSubmissions
        //        .Include(p => p.PacketSubmissionErrors)
        //        .Where(p => p.Id == packetSubmissionId)
        //        .FirstOrDefaultAsync();

        //    if (packetSubmission != null)
        //    {
        //        var error = dto.Convert();

        //        packetSubmission.PacketSubmissionErrors.Add(error);
        //        packetSubmission.ErrorCount += 1;

        //        _context.PacketSubmissions.Update(packetSubmission);
        //        await _context.SaveChangesAsync();
        //    }
        //}

        //[HttpPut("{packetSubmissionId}/Errors/{id}", Name = "PutPacketSubmissionError")]
        //public async Task PutPacketSubmissionError(int packetSubmissionId, int id, PacketSubmissionErrorDto dto)
        //{
        //    var packetSubmission = await _context.PacketSubmissions
        //        .Include(p => p.PacketSubmissionErrors)
        //        .Where(p => p.Id == packetSubmissionId)
        //        .FirstOrDefaultAsync();

        //    if (packetSubmission != null)
        //    {
        //        var existingError = packetSubmission.PacketSubmissionErrors.Where(e => e.Id == id).FirstOrDefault();

        //        if (existingError != null)
        //        {
        //            if (!string.IsNullOrWhiteSpace(dto.Level))
        //            {
        //                if (Enum.TryParse(dto.Level, true, out PacketSubmissionErrorLevel level))
        //                    existingError.Level = level;
        //            }

        //            existingError.FormKind = dto.FormKind;
        //            existingError.AssignedTo = dto.AssignedTo;
        //            existingError.ResolvedBy = dto.ResolvedBy;
        //            existingError.Message = dto.Message;
        //            existingError.ModifiedBy = dto.ModifiedBy;

        //            if (dto.IsDeleted)
        //            {
        //                existingError.IsDeleted = dto.IsDeleted;
        //                existingError.DeletedBy = dto.DeletedBy;
        //                if (packetSubmission.ErrorCount > 1)
        //                    packetSubmission.ErrorCount -= 1;
        //            }
        //        }
        //    }
        //}

        //Task<int> IPacketSubmissionClient.PacketSubmissionsErrorsCountByVisit(int visitId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

