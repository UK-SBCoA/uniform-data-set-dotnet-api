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

        public async Task<LookupDrugCodeDto> SearchDrugCodes(int pageSize = 10, int pageIndex = 1, string searchTerm = "")
        {
            var response = await GetRequest($"{_BasePath}/DrugCodes/Search?pageSize={pageSize}&pageIndex={pageIndex}&searchTerm={searchTerm}");

            LookupDrugCodeDto? dto = JsonSerializer.Deserialize<LookupDrugCodeDto>(response, options);

            return dto;
        }

        public async Task<LookupDrugCodeDto> FindDrugCode(int rxCUI)
        {
            var response = await GetRequest($"{_BasePath}/DrugCodes/Find/{rxCUI}");

            LookupDrugCodeDto? dto = JsonSerializer.Deserialize<LookupDrugCodeDto>(response, options);

            return dto;
        }

        public async Task<DrugCodeDto> AddDrugCode(DrugCodeDto dto)
        {
            string json = JsonSerializer.Serialize(dto);

            var response = await PostRequest($"{_BasePath}/DrugCodes", json);

            DrugCodeDto? added = JsonSerializer.Deserialize<DrugCodeDto>(response, options);

            return added;
        }

        public async Task<LookupCountryCodeDto> LookupCountryCode(string? countryCode)
        {
            var response = await GetRequest($"{_BasePath}/CountryCode?countryCode={countryCode}");

            LookupCountryCodeDto? dto = JsonSerializer.Deserialize<LookupCountryCodeDto>(response, options);

            return dto;
        }


    }
}

