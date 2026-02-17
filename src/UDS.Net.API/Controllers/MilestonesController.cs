using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    // TODO Removed navigation property to Participation, does this break anything?
    [Route("api/[controller]")]
    public class MilestonesController : Controller, IMilestoneClient
    {
        private readonly ApiDbContext _context;

        public MilestonesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("Count", Name = "MilestonesCount")]
        public async Task<int> Count()
        {
            return await _context.M1s.CountAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<M1Dto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            var dto = await _context.M1s
                .Include(m => m.M1Submissions)
                    .ThenInclude(s => s.M1SubmissionErrors)                   
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m.ToDto())
                .ToListAsync();

            foreach (var m1 in dto)
            {
                m1.Participation = await _context.Participations
                    .AsNoTracking()
                    .Where(p => p.Id == m1.ParticipationId)
                    .Select(p => p.ToDto())
                    .FirstOrDefaultAsync();
            }

            return dto;
        }

        [HttpGet("{id}")]
        public async Task<M1Dto> Get(int id)
        {
            var dto = await _context.M1s
                .Include(m => m.M1Submissions)
                    .ThenInclude(s => s.M1SubmissionErrors)
                .Where(m => m.FormId == id)
                .Select(m => m.ToDto())
                .FirstOrDefaultAsync();

            dto.Participation = await _context.Participations
                .Where(p => p.Id == dto.ParticipationId)
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();

            return dto;
        }

        [HttpPost]
        public async Task<M1Dto> Post([FromBody] M1Dto dto)
        {
            var participation = await _context.Participations.FindAsync(dto.ParticipationId);

            if (participation != null)
            {
                var milestone = dto.ToEntity();
                participation.M1s.Add(milestone);

                await _context.SaveChangesAsync();

                return milestone.ToDto();
            }
            return null;
        }

        private void MapErrorDtoToError(M1SubmissionErrorDto dto, M1SubmissionError entity)
        {
            entity.AssignedTo = dto.AssignedTo;
            entity.StatusChangedBy = dto.StatusChangedBy;
            entity.FormKind = dto.FormKind;
            entity.Message = dto.Message;
            entity.ModifiedBy = dto.ModifiedBy;
            entity.IsDeleted = dto.IsDeleted;
            entity.DeletedBy = dto.DeletedBy;
            entity.Location = dto.Location;
            entity.Value = dto.Value;

            if (!string.IsNullOrWhiteSpace(dto.Status) &&
                Enum.TryParse(dto.Status, true, out M1SubmissionErrorStatus status))
            {
                entity.Status = status;
            }
        }

        [HttpPut("{id}")]
        public async Task<M1Dto> Put(int id, [FromBody] M1Dto dto)
        {
            if (dto != null)
            {
                var existingM1 = await _context.M1s
                    .Include(v => v.M1Submissions)
                        .ThenInclude(p => p.M1SubmissionErrors)
                    .Where(m => m.FormId == id)
                    .FirstOrDefaultAsync();

                if (existingM1 != null)
                {
                    existingM1.Status = dto.Status;
                    existingM1.ModifiedBy = dto.ModifiedBy;

                    foreach (var submissionDto in dto.M1Submissions ?? Enumerable.Empty<M1SubmissionDto>())
                    {
                        if (submissionDto.Id == 0)
                        {
                            var newSubmission = submissionDto.Convert(existingM1.FormId);
                            existingM1.M1Submissions.Add(newSubmission);
                        }
                        else
                        {
                            var existingSubmission = existingM1.M1Submissions.Where(p => p.Id == submissionDto.Id).FirstOrDefault();
                            if (existingSubmission != null)
                            {
                                existingSubmission.ErrorCount = submissionDto.ErrorCount;
                                existingSubmission.ModifiedBy = submissionDto.ModifiedBy;
                                existingSubmission.IsDeleted = submissionDto.IsDeleted;
                                existingSubmission.DeletedBy = submissionDto.DeletedBy;

                                foreach (var errorDto in submissionDto.M1SubmissionErrors ?? Enumerable.Empty<M1SubmissionErrorDto>())
                                {
                                    if (errorDto.Id == 0)
                                    {
                                        var newError = errorDto.Convert();
                                        existingSubmission.M1SubmissionErrors.Add(newError);
                                    }
                                    else
                                    {
                                        var existingError = existingSubmission.M1SubmissionErrors.Where(e => e.Id == errorDto.Id).FirstOrDefault();
                                        if (existingError != null)
                                        {
                                            MapErrorDtoToError(errorDto, existingError);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _context.M1s.Update(existingM1);
                    await _context.SaveChangesAsync();

                    return existingM1.ToDto();
                }
            }
            return dto;
        }

        [HttpGet("ByParticipation", Name = "GetMilestonesByParticipation")]
        public async Task<List<M1Dto>> GetMilestonesByParticipation(int participationId, int pageSize = 10, int pageIndex = 1)
        {
            var participation = await _context.Participations
                .Where(p => p.Id == participationId)
                .AsNoTracking()
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();

            var milestones = await _context.M1s
                .Where(m => m.ParticipationId == participationId)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m.ToDto())
                .ToListAsync();

            foreach (var milestone in milestones)
            {
                milestone.Participation = participation;
            }

            return milestones;
        }

        [HttpGet("ByLegacyIdAndStatus", Name = "GetMilestonesByLegacyIdAndStatus")]
        public async Task<List<M1Dto>> GetMilestonesByLegacyIdAndStatus(
            [FromQuery] string legacyId,
            [FromQuery] string[] statuses,
            [FromQuery] int pageSize = 10,
            [FromQuery] int pageIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(legacyId) || statuses == null || statuses.Length == 0)
                return new List<M1Dto>();

            var participation = await _context.Participations
                .Include(p => p.M1s)
                .Where(p => p.LegacyId == legacyId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            var dto = new List<M1Dto>();

            if (participation != null && participation.M1s != null)
            {
                dto = participation.M1s
                    .Where(m => statuses.Contains(m.Status))
                    .OrderBy(m => m.CHANGEYR)
                    .ThenBy(m => m.CHANGEMO)
                    .ThenBy(m => m.CHANGEDY)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .Select(m => m.ToDto())
                    .ToList();

                // add the participation record
                var participationDto = participation.ToDto();
                foreach (var milestone in dto)
                {
                    milestone.Participation = participationDto;
                }
            }

            return dto;
        }

        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

