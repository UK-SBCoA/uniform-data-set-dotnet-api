using System.Collections.Generic;
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
            var response = await GetRequest($"{_BasePath}/Count/ByStatus/{statuses}");

            int count = JsonSerializer.Deserialize<int>(response, options);

            return count;
        }

        public async Task<List<PacketDto>> GetPacketsByStatusAndAssignee(string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            var response = await GetRequest($"{_BasePath}/ByStatus/{statuses}?pageSize={pageSize}&pageIndex={pageIndex}");

            List<PacketDto> dto = JsonSerializer.Deserialize<List<PacketDto>>(response, options);

            return dto;
        }
    }
}

