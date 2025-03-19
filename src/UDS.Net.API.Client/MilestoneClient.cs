using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class MilestoneClient : AuthenticatedClient<M1Dto>, IMilestoneClient
    {
        const string BASEPATH = "Milestones";

        public MilestoneClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public Task<M1Dto> GetMilestone(int id, int formId)
        {
            throw new NotImplementedException();
        }

        public Task<List<M1Dto>> GetMilestones(int id)
        {
            throw new NotImplementedException();
        }

        public Task PostMilestone(int id, M1Dto dto)
        {
            throw new NotImplementedException();
        }

        public Task PutMilestone(int id, int formId, M1Dto dto)
        {
            throw new NotImplementedException();
        }
    }
}

