using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class LookupClient : AuthenticatedClient<LookupDto>, ILookupClient
    {
        const string BASEPATH = "Lookups";

        public LookupClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<LookupDrugCodeDto> LookupDrugCodes(int pageSize = 10, int pageIndex = 1)
        {
            var response = await GetRequest($"{_BasePath}/DrugCodes?pageSize={pageSize}&pageIndex={pageIndex}");

            LookupDrugCodeDto? dto = JsonSerializer.Deserialize<LookupDrugCodeDto>(response, options);

            return dto;
        }

        public async Task<LookupDrugCodeDto> SearchDrugCodes(int pageSize = 10, int pageIndex = 1, bool onlyPopular = true, string searchTerm = "")
        {
            var response = await GetRequest($"{_BasePath}/DrugCodes/Search?pageSize={pageSize}&pageIndex={pageIndex}&onlyPopular={onlyPopular}&searchTerm={searchTerm}");

            LookupDrugCodeDto? dto = JsonSerializer.Deserialize<LookupDrugCodeDto>(response, options);

            return dto;
        }
    }
}

