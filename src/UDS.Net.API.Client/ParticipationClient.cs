using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class ParticipationClient : AuthenticatedClient<ParticipationDto>, IParticipationClient
    {
        const string BASEPATH = "Participations";

        public ParticipationClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<List<M1Dto>> GetMilestones(int id)
        {
            var response = await GetRequest($"{_BasePath}/{id}/Milestones");

            List<M1Dto> m1s = JsonSerializer.Deserialize<List<M1Dto>>(response, options);

            return m1s;
        }

        public async Task PostMilestone(int id, M1Dto dto)
        {
            string json = JsonSerializer.Serialize(dto);

            var response = await PostRequest($"{_BasePath}/{id}/Milestones", json);
        }

        public async Task PutMilestone(int id, int formId, M1Dto dto)
        {
            string json = JsonSerializer.Serialize(dto);

            var response = await PutRequest($"{_BasePath}/{id}/Milestones/{formId}", json);
        }

        public async Task<ParticipationDto> GetByLegacyId(string legacyId)
        {
            var response = await GetRequest($"{_BasePath}/LegacyId/{legacyId}");

            return JsonSerializer.Deserialize<ParticipationDto>(response, options);
            
        }
    }
}

