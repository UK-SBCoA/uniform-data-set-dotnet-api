using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IMilestoneClient : IBaseClient<M1Dto>
    {
        Task<List<M1Dto>> GetMilestones(int participationId, int pageSize = 10, int pageIndex = 1);
    }
}

