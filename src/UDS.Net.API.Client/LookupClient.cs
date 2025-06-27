using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<LookupDrugCodeDto> LookupDrugCodes(int pageSize = 10, int pageIndex = 1, bool? includePopular = null, bool? includeOverTheCounter = null)
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

        public async Task<LookupDrugCodeDto> FindDrugCodes(int[] rxCUIs)
        {
            // Example: Find?rxCUIs=11&rxCUIs=12
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append($"{_BasePath}/DrugCodes/Find?");

            if (rxCUIs != null)
            {
                // TODO? System.Uri.EscapeDataString
                foreach (var cuid in rxCUIs) { urlBuilder.Append(System.Uri.EscapeDataString("rxCUIs") + "=").Append(cuid.ToString()).Append("&"); }
            }

            urlBuilder.Length--;// remove the final &

            var response = await GetRequest(urlBuilder.ToString());

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

