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
    public class MilestonesController : Controller, IMilestoneClient
    {
        private readonly ApiDbContext _context;

        public MilestonesController(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<int> Count()
        {
            return await _context.M1s.CountAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<M1Dto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.M1s
                .AsNoTracking()
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m.ToDto())
                .ToListAsync();
        }

        public async Task<M1Dto> Get(int id)
        {
            return await _context.M1s.Where(m => m.FormId == id).Select(m => m.ToDto()).FirstOrDefaultAsync();
        }

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

        public async Task<M1Dto> Put(int id, [FromBody] M1Dto dto)
        {
            var milestone = dto.ToEntity();

            _context.M1s.Update(milestone);

            await _context.SaveChangesAsync();

            return milestone.ToDto();
        }

        public async Task<List<M1Dto>> GetMilestones(int participationId, int pageSize = 10, int pageIndex = 1)
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

    }
}

