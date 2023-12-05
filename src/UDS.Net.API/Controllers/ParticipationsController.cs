using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class ParticipationsController : Controller, IParticipationClient
    {
        private readonly ApiDbContext _context;

        public ParticipationsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ParticipationDto>> Get()
        {
            return await _context.Participations
               .Include(p => p.Visits)
               .Select(p => p.ToDto())
               .ToListAsync();

        }

        [HttpGet("Count", Name = "ParticipationsCount")]
        public async Task<int> Count()
        {
            return await _context.Participations.CountAsync();
        }

        [HttpGet("{id}")]
        public async Task<ParticipationDto> Get(int id)
        {
            return await _context.Participations
                .Include(p => p.Visits)
                .Where(p => p.Id == id)
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task Post([FromBody] ParticipationDto dto)
        {
            var existingLegacyid = await _context.Participations.AnyAsync(p => p.LegacyId == dto.LegacyId);

            if (existingLegacyid)
            {
                return;

            }
            else
            {
                var newParticipation = new Participation
                {
                    CreatedBy = dto.CreatedBy,
                    CreatedAt = dto.CreatedAt,
                    ModifiedBy = dto.ModifiedBy,
                    IsDeleted = dto.IsDeleted,
                    DeletedBy = dto.DeletedBy,
                    LegacyId = dto.LegacyId
                };
                _context.Participations.Add(newParticipation);
                await _context.SaveChangesAsync();
            }
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ParticipationDto dto)
        {
            var participation = await _context.Participations.FindAsync(id);

            if (participation != null)
            {
                participation.CreatedBy = dto.CreatedBy;
                participation.CreatedAt = dto.CreatedAt;
                participation.ModifiedBy = dto.ModifiedBy;
                participation.IsDeleted = dto.IsDeleted;
                participation.DeletedBy = dto.DeletedBy;
                participation.LegacyId = dto.LegacyId;

                _context.Participations.Update(participation);
                await _context.SaveChangesAsync();
            }

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var participation = await _context.Participations.FindAsync(id);

            if (participation == null)
                return;

            _context.Participations.Remove(participation);

            await _context.SaveChangesAsync();
        }

        [HttpGet("{id}/Milestones", Name = "GetMilestones")]
        public async Task<List<M1Dto>> GetMilestones(int id)
        {
            var milestones = await _context.M1s.Where(m => m.ParticipationId == id).Select(m => m.ToDto()).ToListAsync();

            return milestones;
        }

        [HttpPost("{id}/Milestones", Name = "PostMilestone")]
        public async Task PostMilestone(int id, [FromBody] M1Dto dto)
        {
            if (id == dto.ParticipationId)
            {
                var participation = await _context.Participations.FindAsync(id);

                if (participation != null)
                {
                    var milestone = dto.ToEntity();
                    participation.M1s.Add(milestone);

                    await _context.SaveChangesAsync();
                }
            }
        }

        [HttpPut("{id}/Milestones/{formId}", Name = "PutMilestone")]
        public async Task PutMilestone(int id, int milestoneId, [FromBody] M1Dto dto)
        {
            if (milestoneId == dto.Id)
            {
                var milestone = dto.ToEntity();

                _context.M1s.Update(milestone);

                await _context.SaveChangesAsync();
            }
        }

        [HttpGet("LegacyId/{legacyId}", Name = "GetByLegacyId")]
        public async Task<ParticipationDto> GetByLegacyId(string legacyId)
        {
            var participation = await _context.Participations
                .Where(p => p.LegacyId == legacyId)
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();

            return participation;
        }

    }
}