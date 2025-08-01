using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
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
            return await _context.M1s
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m.ToDto())
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<M1Dto> Get(int id)
        {
            return await _context.M1s
                .Where(m => m.FormId == id)
                .Select(m => m.ToDto())
                .FirstOrDefaultAsync();
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

        [HttpPut("{id}")]
        public async Task<M1Dto> Put(int id, [FromBody] M1Dto dto)
        {
            var existingMilestone = await _context.M1s
                .Where(m => m.FormId == id)
                .FirstOrDefaultAsync();

            if (existingMilestone != null)
            {
                existingMilestone.Update(dto);
                _context.M1s.Update(existingMilestone);

                await _context.SaveChangesAsync();
                return existingMilestone.ToDto();
            }

            return dto;
        }

        [HttpGet("ByParticipation", Name = "GetMilestonesByParticipation")]
        public async Task<List<M1Dto>> GetMilestonesByParticipation(int participationId, int pageSize = 10, int pageIndex = 1)
        {
            var milestones = await _context.M1s
                .Where(m => m.ParticipationId == participationId)
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m.ToDto())
                .ToListAsync();

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
                    .Where(m => EF.Constant(statuses).Contains(m.Status))
                    .OrderBy(m => m.CHANGEYR)
                    .ThenBy(m => m.CHANGEMO)
                    .ThenBy(m => m.CHANGEDY)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .Select(m => m.ToDto())
                    .ToList();
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

