using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    [Route("api/[controller]")]
    public class PacketSubmissionsController : Controller, IPacketSubmissionClient
    {
        private readonly ApiDbContext _context;

        public PacketSubmissionsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("Count", Name = "PacketSubmissionsCount")]
        public async Task<int> Count()
        {
            return await _context.PacketSubmissions
                .CountAsync();
        }

        [HttpGet("Count/ByVisit/{visitId}", Name = "PacketSubmissionsCountByVisit")]
        public async Task<int> PacketSubmissionsCountByVisit(int visitId)
        {
            return await _context.PacketSubmissions
                .Where(p => p.VisitId == visitId)
                .CountAsync();
        }

        [HttpGet("Count/ByStatus/{packetStatus}", Name = "PacketSubmissionsCountByStatus")]
        public async Task<int> PacketSubmissionsCountByStatus(string packetStatus)
        {
            return await _context.PacketSubmissions
                .Include(p => p.Visit)
                .Where(p => p.Visit.Status.ToString() == packetStatus)
                .CountAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<PacketSubmissionDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.PacketSubmissions
                .Include(p => p.Visit)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToDto())
                .ToListAsync();
        }

        [HttpGet("ByVisit/{visitId}", Name = "GetPacketSubmissionByVisit")]
        public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            var dto = await _context.PacketSubmissions
                .Include(p => p.Visit)
                .Include(p => p.PacketSubmissionErrors)
                .Where(p => p.VisitId == visitId)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToDto(p.PacketSubmissionErrors.Count()))
                .ToListAsync();

            return dto;
        }

        [HttpGet("ByStatus/{packetStatus}", Name = "GetPacketSubmissionByStatus")]
        public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByStatus(string packetStatus, int pageSize = 10, int pageIndex = 1)
        {
            var dto = await _context.PacketSubmissions
                .Include(p => p.Visit)
                .Where(p => p.Visit.Status.ToString() == packetStatus)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToDto())
                .ToListAsync();

            return dto;
        }


        [HttpGet("{id}")]
        public async Task<PacketSubmissionDto> Get(int id)
        {
            var dto = await _context.PacketSubmissions
                .Include(p => p.PacketSubmissionErrors)
                .Where(p => p.Id == id)
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();

            return dto;
        }

        [HttpPost]
        public async Task Post(PacketSubmissionDto dto)
        {
            var packetSubmission = dto.Convert();

            _context.PacketSubmissions.Add(packetSubmission);

            await _context.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] PacketSubmissionDto dto)
        {
            if (dto != null)
            {
                var existingSubmission = await _context.PacketSubmissions
                    .Include(p => p.PacketSubmissionErrors)
                    .Where(p => p.Id == id)
                    .FirstOrDefaultAsync();

                if (existingSubmission != null)
                {
                    existingSubmission.SubmissionDate = dto.SubmissionDate;
                    existingSubmission.ModifiedBy = dto.ModifiedBy;

                    _context.PacketSubmissions.Update(existingSubmission);
                    await _context.SaveChangesAsync();
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var existingSubmission = await _context.PacketSubmissions
                .Include(p => p.PacketSubmissionErrors)
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();

            if (existingSubmission != null)
            {
                _context.PacketSubmissions.Remove(existingSubmission);
                await _context.SaveChangesAsync();
            }
        }

        [HttpGet("Errors/Count", Name = "PacketSubmissionErrorsCount")]
        public async Task<int> PacketSubmissionErrorsCount(bool includeResolved = false)
        {
            if (includeResolved)
            {
                return await _context.PacketSubmissionErrors
                    .Where(e => String.IsNullOrWhiteSpace(e.ResolvedBy) == false)
                    .CountAsync();
            }
            else
            {
                return await _context.PacketSubmissionErrors
                    .CountAsync();
            }
        }

        [HttpGet("Errors/Count/ByVisit/{visitId}", Name = "PacketSubmissionErrorsCountByVisit")]
        public async Task<int> PacketSubmissionsErrorsCountByVisit(int visitId)
        {
            return await _context.PacketSubmissionErrors
                .Include(e => e.PacketSubmission)
                .Where(e => e.PacketSubmission.VisitId == visitId)
                .CountAsync();
        }

        [HttpGet("Errors/Count/ByAssignee/{assignedTo}", Name = "PacketSubmissionErrorsCountByAssignee")]
        public async Task<int> PacketSubmissionsErrorsCountByAssignee(string assignedTo)
        {
            return await _context.PacketSubmissionErrors
                .Where(e => e.AssignedTo.ToLower().Trim() == assignedTo.ToLower().Trim())
                .CountAsync();
        }

        [HttpGet("Errors", Name = "GetPacketSubmissionErrors")]
        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1)
        {
            if (includeResolved)
            {
                return await _context.PacketSubmissionErrors
                    .Where(e => String.IsNullOrWhiteSpace(e.ResolvedBy) == false)
                    .AsNoTracking()
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => p.ToDto())
                    .ToListAsync();
            }
            else
            {
                return await _context.PacketSubmissionErrors
                    .AsNoTracking()
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => p.ToDto())
                    .ToListAsync();
            }
        }

        [HttpGet("Errors/ByVisit/{visitId}", Name = "GetPacketSubmissionErrorsByVisit")]
        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            return await _context.PacketSubmissionErrors
                .Include(e => e.PacketSubmission)
                .Where(e => e.PacketSubmission.VisitId == visitId)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToDto())
                .ToListAsync();
        }

        [HttpGet("Errors/ByAssignee/{assignedTo}", Name = "GetPacketSubmissionErrorsByAssignee")]
        public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            return await _context.PacketSubmissionErrors
                .Where(e => e.AssignedTo.ToLower().Trim() == assignedTo.ToLower().Trim())
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToDto())
                .ToListAsync();
        }

        [HttpPost("{packetSubmissionId}/Errors", Name = "PostPacketSubmissionError")]
        public async Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        {
            var packetSubmission = await _context.PacketSubmissions
                .Include(p => p.PacketSubmissionErrors)
                .Where(p => p.Id == packetSubmissionId)
                .FirstOrDefaultAsync();

            if (packetSubmission != null)
            {
                var error = dto.Convert();

                packetSubmission.PacketSubmissionErrors.Add(error);

                _context.PacketSubmissions.Update(packetSubmission);
                await _context.SaveChangesAsync();
            }
        }

        [HttpPut("{packetSubmissionId}/Errors/{id}", Name = "PutPacketSubmissionError")]
        public async Task PutPacketSubmissionError(int packetSubmissionId, int id, PacketSubmissionErrorDto dto)
        {
            var packetSubmission = await _context.PacketSubmissions
                .Include(p => p.PacketSubmissionErrors)
                .Where(p => p.Id == packetSubmissionId)
                .FirstOrDefaultAsync();

            if (packetSubmission != null)
            {
                var existingError = packetSubmission.PacketSubmissionErrors.Where(e => e.Id == id).FirstOrDefault();

                if (existingError != null)
                {
                    if (!string.IsNullOrWhiteSpace(dto.Level))
                    {
                        if (Enum.TryParse(dto.Level, true, out PacketSubmissionErrorLevel level))
                            existingError.Level = level;
                    }

                    existingError.FormKind = dto.FormKind;
                    existingError.AssignedTo = dto.AssignedTo;
                    existingError.ResolvedBy = dto.ResolvedBy;
                    existingError.Message = dto.Message;
                    existingError.ModifiedBy = dto.ModifiedBy;
                    existingError.IsDeleted = dto.IsDeleted;
                    existingError.DeletedBy = dto.DeletedBy;
                }
            }
        }


    }
}

