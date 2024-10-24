using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class PacketClient : AuthenticatedClient<PacketDto>, IPacketClient
    {
        const string BASEPATH = "Packets";

        public PacketClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<PacketDto> GetPacketWithForms(int id)
        {
            var response = await GetRequest($"{_BasePath}/{id}/IncludeForms");

            PacketDto dto = JsonSerializer.Deserialize<PacketDto>(response, options);

            return dto;
        }

        public async Task<int> CountByStatusAndAssignee(string[] statuses, string assignedTo)
        {
            if (statuses != null && statuses.Length > 0)
            {
                NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

                foreach (var status in statuses)
                {
                    query.Add("statuses", status);
                }

                if (string.IsNullOrWhiteSpace(assignedTo))
                {
                    var response = await GetRequest($"{_BasePath}/Count/ByStatus?{query.ToString()}");

                    return JsonSerializer.Deserialize<int>(response, options);
                }
                else
                {
                    var response = await GetRequest($"{_BasePath}/Count/ByStatus?{query.ToString()}&assignedTo={assignedTo}");

                    return JsonSerializer.Deserialize<int>(response, options);
                }
            }
            return 0;
        }

        public async Task<List<PacketDto>> GetPacketsByStatusAndAssignee(string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            List<PacketDto> dto = new List<PacketDto>();

            if (statuses != null && statuses.Length > 0)
            {
                NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

                foreach (var status in statuses)
                {
                    query.Add("statuses", status);
                }

                if (string.IsNullOrWhiteSpace(assignedTo))
                {
                    var response = await GetRequest($"{_BasePath}/ByStatus?{query.ToString()}&pageSize={pageSize}&pageIndex={pageIndex}");

                    dto = JsonSerializer.Deserialize<List<PacketDto>>(response, options);
                }
                else
                {
                    var response = await GetRequest($"{_BasePath}/ByStatus?{query.ToString()}&assignedTo={assignedTo}&pageSize={pageSize}&pageIndex={pageIndex}");

                    dto = JsonSerializer.Deserialize<List<PacketDto>>(response, options);
                }
            }

            return dto;
        }
    }
}

