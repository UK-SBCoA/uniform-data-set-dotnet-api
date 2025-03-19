using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
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

        public async Task<List<M1Dto>> GetMilestones(int participationId, int pageSize = 10, int pageIndex = 1)
        {
            List<M1Dto> dto = new List<M1Dto>();


            var response = await GetRequest($"{_BasePath}/ByParticipation?{participationId}&pageSize={pageSize}&pageIndex={pageIndex}");

            dto = JsonSerializer.Deserialize<List<M1Dto>>(response, options);

            return dto;
        }
    }
}

