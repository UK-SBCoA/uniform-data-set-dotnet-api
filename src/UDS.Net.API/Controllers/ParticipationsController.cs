using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    public static class ParticipationMapper
    {
        public static ParticipationDto ToDto(this Participation participation)
        {
            var dto = new ParticipationDto()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                CreatedAt = participation.CreatedAt,
                CreatedBy = participation.CreatedBy,
                ModifiedBy = participation.ModifiedBy,
                DeletedBy = participation.DeletedBy,
                IsDeleted = participation.IsDeleted,
                Visits = participation.Packets.Select(v => v.ToDto()).ToList(),
                VisitCount = participation.Packets != null ? participation.Packets.Count() : 0,
                LastVisitNumber = participation.Packets != null ? (participation.Packets.Any() ? participation.Packets.OrderByDescending(v => v.VISITNUM).Select(v => v.VISITNUM).First() : 0) : 0
            };

            return dto;
        }
    }

    [Route("api/[controller]")]
    public class ParticipationsController : Controller, IParticipationClient
    {
        private readonly ApiDbContext _context;

        public ParticipationsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ParticipationDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.Participations
                .Include(p => p.Packets)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
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
                .Include(p => p.Packets)
                .Where(p => p.Id == id)
                .Select(p => p.ToDto())
                .FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<ParticipationDto> Post([FromBody] ParticipationDto dto)
        {
            var existingLegacyid = await _context.Participations.AnyAsync(p => p.LegacyId == dto.LegacyId);

            if (existingLegacyid)
            {
                return dto;

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

                return newParticipation.ToDto();
            }
        }

        [HttpPut("{id}")]
        public async Task<ParticipationDto> Put(int id, [FromBody] ParticipationDto dto)
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

                return participation.ToDto();
            }

            return dto;
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