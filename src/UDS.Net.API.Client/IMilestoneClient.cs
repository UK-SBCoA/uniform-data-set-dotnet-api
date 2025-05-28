using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IMilestoneClient : IBaseClient<M1Dto>
    {
        Task<List<M1Dto>> GetMilestonesByParticipation(int participationId, int pageSize = 10, int pageIndex = 1);
        Task<List<M1Dto>> GetMilestonesByLegacyIdAndStatus(string legacyId, string[] statuses, int pageSize = 10, int pageIndex = 1);
    }
}

