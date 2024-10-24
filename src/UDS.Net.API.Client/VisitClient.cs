using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class VisitClient : AuthenticatedClient<VisitDto>, IVisitClient
    {
        const string BASEPATH = "Visits";

        public VisitClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<List<VisitDto>> GetVisitsAtStatus(string[] statuses, int pageSize = 10, int pageIndex = 1)
        {
            List<VisitDto> dto = new List<VisitDto>();

            if (statuses != null && statuses.Length > 0)
            {
                NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

                foreach (var status in statuses)
                {
                    query.Add("statuses", status);
                }

                var response = await GetRequest($"{_BasePath}/ByStatus?{query.ToString()}&pageSize={pageSize}&pageIndex={pageIndex}");

                dto = JsonSerializer.Deserialize<List<VisitDto>>(response, options);
            }

            return dto;
        }

        public async Task<int> GetCountOfVisitsAtStatus(string[] statuses)
        {
            if (statuses != null && statuses.Length > 0)
            {
                NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

                foreach (var status in statuses)
                {
                    query.Add("statuses", status);
                }

                var response = await GetRequest($"{_BasePath}/Count/ByStatus?{query.ToString()}");

                return JsonSerializer.Deserialize<int>(response, options);
            }
            return 0;
        }

        public async Task<VisitDto> GetWithForm(int id, string formKind)
        {
            var response = await GetRequest($"{_BasePath}/{id}/Forms/{formKind}");

            VisitDto? dto = JsonSerializer.Deserialize<VisitDto>(response, options);

            return dto;
        }

        public async Task PostWithForm(int id, string formKind, VisitDto dto)
        {
            string json = JsonSerializer.Serialize(dto);

            var response = await PostRequest($"{_BasePath}/{id}/Forms/{formKind}", json);
        }

    }
}

