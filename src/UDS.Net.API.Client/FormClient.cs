using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class FormClient : AuthenticatedClient<FormDto>, IFormClient
    {
        const string BASEPATH = "Forms";

        public FormClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<int> Count(string kind)
        {
            var response = await GetRequest($"{_BasePath}/{kind}/Count");

            int count = JsonSerializer.Deserialize<int>(response, options);

            return count;
        }

        public async Task<IEnumerable<FormDto>> Get(string kind, int pageSize = 10, int pageIndex = 1)
        {
            string response = await GetRequest($"{_BasePath}/{kind}?pageSize={pageSize}&pageIndex={pageIndex}");

            List<FormDto> forms = JsonSerializer.Deserialize<List<FormDto>>(response, options);

            return forms;
        }

        public async Task<IEnumerable<FormDto>> GetSummaries(string kind, int pageSize = 10, int pageIndex = 1)
        {
            string response = await GetRequest($"{_BasePath}/{kind}/Summary?pageSize={pageSize}&pageIndex={pageIndex}");

            List<FormDto> forms = JsonSerializer.Deserialize<List<FormDto>>(response, options);

            return forms;
        }
    }
}

