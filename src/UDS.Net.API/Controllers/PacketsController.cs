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
    /// A packet is a visit that is ready to be submitted or has been submitted at least once
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
            return await _context.Packets
                .CountAsync();
        }

        /// <summary>
        /// Returns visits as packets
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<PacketDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.Packets
                .Include(v => v.PacketSubmissions)
                    .ThenInclude(p => p.PacketSubmissionErrors)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(p => p.ToPacketDto())
                .ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<PacketDto> Get(int id)
        {
            var dto = await _context.Packets
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
            var dto = await _context.Packets
                .Include(v => v.PacketSubmissions)
                    .ThenInclude(p => p.PacketSubmissionErrors)
                .Where(v => v.Id == id)
                .AsNoTracking()
                .Select(v => v.ToPacketDto())
                .FirstOrDefaultAsync();

            if (dto != null)
            {
                var visit = await _context.Packets
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

                if (visit != null)
                {
                    // for finalization we need the forms on the main object
                    dto.Forms.Add(visit.A1.ToFullDto());
                    dto.Forms.Add(visit.A1a.ToFullDto());
                    dto.Forms.Add(visit.A2.ToFullDto());
                    dto.Forms.Add(visit.A3.ToFullDto());
                    dto.Forms.Add(visit.A4.ToFullDto());
                    dto.Forms.Add(visit.A4a.ToFullDto());
                    dto.Forms.Add(visit.A5D2.ToFullDto());
                    dto.Forms.Add(visit.B1.ToFullDto());
                    dto.Forms.Add(visit.B3.ToFullDto());
                    dto.Forms.Add(visit.B4.ToFullDto());
                    dto.Forms.Add(visit.B5.ToFullDto());
                    dto.Forms.Add(visit.B6.ToFullDto());
                    dto.Forms.Add(visit.B7.ToFullDto());
                    dto.Forms.Add(visit.B8.ToFullDto());
                    dto.Forms.Add(visit.B9.ToFullDto());
                    dto.Forms.Add(visit.C2.ToFullDto());
                    dto.Forms.Add(visit.D1a.ToFullDto());
                    dto.Forms.Add(visit.D1b.ToFullDto());
                }
                if (dto.PacketSubmissions != null && dto.PacketSubmissions.Count() > 0)
                {
                    // TODO implement temporality so that older versions can be pulled
                    // select all the forms at the state of submission.SubmissionDate
                    // for now it will just be the current state
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

        [HttpGet("IncludeForms")]
        public async Task<List<PacketDto>> GetPacketsWithForms(int[] ids)
        {
            var dtos = await _context.Packets
                .Include(v => v.PacketSubmissions)
                .ThenInclude(p => p.PacketSubmissionErrors)
                .Where(v => ids.Contains(v.Id))
                .AsNoTracking()
                .Select(v => v.ToPacketDto())
                .ToListAsync();

            if (dtos.Count == 0)
                return dtos;

            var visits = await _context.Packets
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
                .Where(v => ids.Contains(v.Id))
                .AsNoTracking()
                .ToListAsync();

            foreach (var dto in dtos)
            {
                var visit = visits.FirstOrDefault(v => v.Id == dto.Id);
                if (visit == null) continue;

                var forms = new List<FormDto?>
                {
                   visit.A1?.ToFullDto(),
                   visit.A1a?.ToFullDto(),
                   visit.A2?.ToFullDto(),
                   visit.A3?.ToFullDto(),
                   visit.A4?.ToFullDto(),
                   visit.A4a?.ToFullDto(),
                   visit.A5D2?.ToFullDto(),
                   visit.B1?.ToFullDto(),
                   visit.B3?.ToFullDto(),
                   visit.B4?.ToFullDto(),
                   visit.B5?.ToFullDto(),
                   visit.B6?.ToFullDto(),
                   visit.B7?.ToFullDto(),
                   visit.B8?.ToFullDto(),
                   visit.B9?.ToFullDto(),
                   visit.C2?.ToFullDto(),
                   visit.D1a?.ToFullDto(),
                   visit.D1b?.ToFullDto()
                }.Where(f => f != null).ToList();

                dto.Forms.AddRange(forms);

                if (dto.PacketSubmissions != null && dto.PacketSubmissions.Count > 0)
                {
                    //TODO Use temporal data to pull the state of the packet at the time the submission record was created
                    foreach (var submission in dto.PacketSubmissions)
                    {
                        submission.Forms.AddRange(forms);
                    }
                }
            }

            return dtos;
        }

        /// <summary>
        /// Packets are not created, visits are the initial object
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public async Task<PacketDto> Post(PacketDto dto)
        {
            throw new NotImplementedException("Packets are not created, use Visits.");
        }

        /// <summary>
        /// Put updates the status of the visit, submissions errors
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<PacketDto> Put(int id, [FromBody] PacketDto dto)
        {
            if (dto != null)
            {
                var existingPacket = await _context.Packets
                    .Include(v => v.PacketSubmissions)
                        .ThenInclude(p => p.PacketSubmissionErrors)
                    .Where(p => p.Id == id)
                    .FirstOrDefaultAsync();

                if (existingPacket != null)
                {
                    existingPacket.Status = dto.Status.Convert();
                    existingPacket.ModifiedBy = dto.ModifiedBy;

                    foreach (var submissionDto in dto.PacketSubmissions)
                    {
                        if (submissionDto.Id == 0)
                        {
                            // new submission needs to be created
                            var newSubmission = submissionDto.Convert();
                            existingPacket.PacketSubmissions.Add(newSubmission);
                        }
                        else
                        {
                            // existing submission needs to be updated and could affect visit status
                            var existingSubmission = existingPacket.PacketSubmissions.Where(p => p.Id == submissionDto.Id).FirstOrDefault();
                            if (existingSubmission != null)
                            {
                                existingSubmission.ErrorCount = submissionDto.ErrorCount;
                                existingSubmission.ModifiedBy = submissionDto.ModifiedBy;
                                existingSubmission.IsDeleted = submissionDto.IsDeleted;
                                existingSubmission.DeletedBy = submissionDto.DeletedBy;

                                // iterate errors
                                foreach (var errorDto in submissionDto.PacketSubmissionErrors)
                                {
                                    if (errorDto.Id == 0)
                                    {
                                        // new error needs to be created and could affect
                                        var newError = errorDto.Convert();
                                        existingSubmission.PacketSubmissionErrors.Add(newError);
                                    }
                                    else
                                    {
                                        // existing error needs to be updated
                                        var existingError = existingSubmission.PacketSubmissionErrors.Where(e => e.Id == errorDto.Id).FirstOrDefault();
                                        if (existingError != null)
                                        {
                                            existingError.AssignedTo = errorDto.AssignedTo;
                                            existingError.StatusChangedBy = errorDto.StatusChangedBy;
                                            existingError.FormKind = errorDto.FormKind;
                                            existingError.Message = errorDto.Message;
                                            existingError.ModifiedBy = errorDto.ModifiedBy;
                                            existingError.IsDeleted = errorDto.IsDeleted;
                                            existingError.DeletedBy = errorDto.DeletedBy;
                                            existingError.Location = errorDto.Location;
                                            existingError.Value = errorDto.Value;

                                            if (!string.IsNullOrWhiteSpace(errorDto.Status))
                                            {
                                                if (Enum.TryParse(errorDto.Status, true, out PacketSubmissionErrorStatus status))
                                                    existingError.Status = status;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    _context.Packets.Update(existingPacket);
                    await _context.SaveChangesAsync();

                    return existingPacket.ToPacketDto();
                }
            }

            return dto;
        }

        /// <summary>
        /// Import nacc errors and modify packet statuses
        /// </summary>
        /// <param name="errorDtos"></param>
        /// <returns></returns>
        [HttpPut("UpdateMultiplePacketsSubmissionsErrors")]
        public async Task<List<NACCErrorDto>> UpdateMultiplePacketsSubmissionsErrors(string username, [FromBody] List<NACCErrorDto> errors)
        {
            //DEVNOTE: a list of packetsubmission errors to return 
            List<PacketSubmissionErrorDto> errorsImported = new List<PacketSubmissionErrorDto>();

            //Group errors by PTID
            var groupedErrors = errors.GroupBy(e => e.Ptid);

            foreach(var errorGroup in groupedErrors)
            {
                var groupPtid = errorGroup.First().Ptid;

                var groupParticipation = await _context.Participations
                    .Include(p => p.Packets)
                        .ThenInclude(ps => ps.PacketSubmissions)
                    .Where(p => p.LegacyId == groupPtid)
                    .FirstOrDefaultAsync();

                //DEVNOTE: should errors in a file of the same PTID should be the same visit number?
                var groupPacket = groupParticipation?.Packets.Where(p => p.VISITNUM.ToString() == errorGroup.First().Visitnum).FirstOrDefault();

                var groupSubmission = groupPacket?.PacketSubmissions.Where(p => p.ErrorCount == null).FirstOrDefault();

                //DEVNOTE: If group packet and group submission are found
                List<PacketSubmissionError> errorsToAddCreate = new List<PacketSubmissionError>();

                foreach (var error in errorGroup)
                {
                    PacketSubmissionError newPacketSubmissionError = new PacketSubmissionError()
                    {
                        Id = 0,
                        PacketSubmissionId = groupSubmission.Id,
                        FormKind = error.Code.Split("-")[0].ToUpper(),
                        Message = error.Message,
                        AssignedTo = groupPacket.CreatedBy,
                        Level = GetErrorLevel(error.Type),
                        Status = PacketSubmissionErrorStatus.Pending,
                        StatusChangedBy = null,
                        CreatedAt = DateTime.Now,
                        CreatedBy = username,
                        ModifiedBy = null,
                        DeletedBy = null,
                        IsDeleted = false,
                        Location = error.Location?.ToUpper(),
                        Value = error.Value
                    };

                    errorsToAddCreate.Add(newPacketSubmissionError);
                }

                //DEVNOTE: Update the packet with new data
                groupPacket.Status = PacketStatus.FailedErrorChecks;
                groupPacket.PacketSubmissions.Last().ErrorCount = errorsToAddCreate.Count;
                groupPacket.PacketSubmissions.Last().PacketSubmissionErrors = errorsToAddCreate;

                //Update the packet

                //var packetUpdating = groupPacket;
                _context.Packets.Update(groupPacket);
            }

            await _context.SaveChangesAsync();

            return errors;
        }

        private static PacketSubmissionErrorLevel GetErrorLevel(string errorType)
        {
            if (errorType.Trim().ToLower() == "alert")
            {
                return PacketSubmissionErrorLevel.Information;
            }
            else if (errorType.Trim().ToLower() == "error")
            {
                return PacketSubmissionErrorLevel.Error;
            }

            //return information as default
            return PacketSubmissionErrorLevel.Information;
        }

        //[{
        //  "message": "Test error",
        //  "code": "NACCCODE",
        //  "value": "test",
        //  "location": "MOMYOB",
        //  "timestamp": "00:00:0000",
        //  "approved": "false",
        //  "type": "error",
        //  "visitnum": "2",
        //  "file": "test.csv",
        //  "ptid": "1"
        //}]

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Count/ByStatus", Name = "PacketsCountByStatusAndAssignee")]
        public async Task<int> CountByStatusAndAssignee([FromQuery] string[] statuses, string assignedTo)
        {
            var enumStatuses = statuses.Convert();

            if (enumStatuses != null && enumStatuses.Count() > 0)
            {
                if (string.IsNullOrWhiteSpace(assignedTo))
                {
                    return await _context.Packets
                        .Where(v => enumStatuses.Contains(v.Status))
                        .CountAsync();
                }
                else
                {
                    var visitsAtStatus = await _context.Packets
                        .Include(v => v.PacketSubmissions)
                            .ThenInclude(p => p.PacketSubmissionErrors)
                        .Where(v => enumStatuses.Contains(v.Status))
                        .ToListAsync();

                    int count = 0;

                    foreach (var visit in visitsAtStatus)
                    {
                        bool assigneeAssignedToThisVisit = false;
                        foreach (var submission in visit.PacketSubmissions)
                        {
                            if (submission.PacketSubmissionErrors.Any(p => String.IsNullOrWhiteSpace(p.StatusChangedBy) == true && p.AssignedTo == assignedTo))
                                assigneeAssignedToThisVisit = true;
                        }
                        if (assigneeAssignedToThisVisit)
                            count++;
                    }

                    return count;
                }
            }
            return 0;
        }

        [HttpGet("ByStatus", Name = "GetPacketsByStatusAndAssignee")]
        public async Task<List<PacketDto>> GetPacketsByStatusAndAssignee([FromQuery] string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            var dto = new List<PacketDto>();
            var enumStatuses = statuses.Convert();
            if (enumStatuses != null && enumStatuses.Count() > 0)
            {
                if (string.IsNullOrWhiteSpace(assignedTo))
                {
                    dto = await _context.Packets
                        .Include(v => v.PacketSubmissions)
                            .ThenInclude(p => p.PacketSubmissionErrors)
                        .Where(v => enumStatuses.Contains(v.Status))
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(p => p.ToPacketDto())
                        .ToListAsync();
                }
                else
                {
                    var visitsAtStatus = await _context.Packets
                        .Include(v => v.PacketSubmissions)
                            .ThenInclude(p => p.PacketSubmissionErrors)
                        .Where(v => enumStatuses.Contains(v.Status))
                        .ToListAsync();

                    foreach (var visit in visitsAtStatus)
                    {
                        bool assigneeAssignedToThisVisit = false;
                        foreach (var submission in visit.PacketSubmissions)
                        {
                            if (submission.PacketSubmissionErrors.Any(p => String.IsNullOrWhiteSpace(p.StatusChangedBy) == true && p.AssignedTo == assignedTo))
                                assigneeAssignedToThisVisit = true;
                        }

                        if (assigneeAssignedToThisVisit)
                        {
                            dto.Add(visit.ToPacketDto());
                        }
                    }
                }
            }

            return dto;
        }
    }
}