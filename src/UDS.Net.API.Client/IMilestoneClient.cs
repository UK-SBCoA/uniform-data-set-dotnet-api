using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IMilestoneClient : IBaseClient<M1Dto>
    {
        Task<List<M1Dto>> GetMilestones(int id);

        Task PostMilestone(int id, M1Dto dto);

        Task<M1Dto> GetMilestone(int id, int formId);

        Task PutMilestone(int id, int formId, M1Dto dto);
    }
}

