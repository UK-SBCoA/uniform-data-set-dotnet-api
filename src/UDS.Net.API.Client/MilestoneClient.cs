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

        public async Task<List<M1Dto>> GetMilestonesByParticipation(int participationId, int pageSize = 10, int pageIndex = 1)
        {
            List<M1Dto> dto = new List<M1Dto>();

            var response = await GetRequest($"{_BasePath}/ByParticipation?participationId={participationId}&pageSize={pageSize}&pageIndex={pageIndex}");

            dto = JsonSerializer.Deserialize<List<M1Dto>>(response, options);

            return dto;
        }

        public async Task<List<M1Dto>> GetMilestonesByLegacyIdAndStatus(string legacyId, string[] statuses, int pageSize = 10, int pageIndex = 1)
        {
            List<M1Dto> dto = new List<M1Dto>();
            if (!string.IsNullOrWhiteSpace(legacyId) && statuses != null && statuses.Length > 0)
            {
                var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
                query.Add("legacyId", legacyId);
                foreach (var status in statuses)
                {
                    query.Add("statuses", status);
                }
                query.Add("pageSize", pageSize.ToString());
                query.Add("pageIndex", pageIndex.ToString());
                var response = await GetRequest($"{_BasePath}/ByLegacyIdAndStatus?{query.ToString()}");
                dto = JsonSerializer.Deserialize<List<M1Dto>>(response, options);
            }
            return dto;
        }
    }
}

