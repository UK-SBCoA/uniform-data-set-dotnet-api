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

        public async Task<ParticipationDto> GetByLegacyId(string legacyId)
        {
            var response = await GetRequest($"{_BasePath}/LegacyId/{legacyId}");

            return JsonSerializer.Deserialize<ParticipationDto>(response, options);
        }
    }
}

