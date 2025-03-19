using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
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

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<M1Dto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        public Task<M1Dto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<M1Dto> Post(M1Dto dto)
        {
            throw new NotImplementedException();
        }

        public Task<M1Dto> Put(int id, M1Dto dto)
        {
            throw new NotImplementedException();
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

        [HttpGet("{id}/Milestones/{formId}", Name = "GetMilestone")]
        public async Task<M1Dto> GetMilestone(int id, int formId)
        {
            return await _context.M1s.Where(m => m.FormId == formId).Select(m => m.ToDto()).FirstOrDefaultAsync();
        }

        [HttpPut("{id}/Milestones/{formId}", Name = "PutMilestone")]
        public async Task PutMilestone(int id, int formId, [FromBody] M1Dto dto)
        {
            if (formId == dto.Id)
            {
                var milestone = dto.ToEntity();

                _context.M1s.Update(milestone);

                await _context.SaveChangesAsync();
            }
        }

    }
}

