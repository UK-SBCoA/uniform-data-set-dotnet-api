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


        //public async Task<int> PacketSubmissionsCountByVisit(int visitId)
        //{
        //    var response = await GetRequest($"{_BasePath}/Count/ByVisit/{visitId}");

        //    int count = JsonSerializer.Deserialize<int>(response, options);

        //    return count;
        //}


        //public async Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        //{
        //    var response = await GetRequest($"{_BasePath}/ByVisit/{visitId}?pageSize={pageSize}&pageIndex={pageIndex}");

        //    List<PacketSubmissionDto> dto = JsonSerializer.Deserialize<List<PacketSubmissionDto>>(response, options);

        //    return dto;
        //}


        //public async Task<int> PacketSubmissionErrorsCount(bool includeResolved = false)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors/Count?includeResolved={includeResolved}");

        //    int count = JsonSerializer.Deserialize<int>(response, options);

        //    return count;
        //}

        //public async Task<int> PacketSubmissionsErrorsCountByVisit(int visitId)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors/Count/ByVisit/{visitId}");

        //    int count = JsonSerializer.Deserialize<int>(response, options);

        //    return count;
        //}

        //public async Task<int> PacketSubmissionsErrorsCountByAssignee(string assignedTo)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors/Count/ByAssignee/{assignedTo}");

        //    int count = JsonSerializer.Deserialize<int>(response, options);

        //    return count;
        //}

        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors?includeResolved={includeResolved}&pageSize={pageSize}&pageIndex={pageIndex}");

        //    List<PacketSubmissionErrorDto> dto = JsonSerializer.Deserialize<List<PacketSubmissionErrorDto>>(response, options);

        //    return dto;
        //}

        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors/ByVisit/{visitId}?pageSize={pageSize}&pageIndex={pageIndex}");

        //    List<PacketSubmissionErrorDto> dto = JsonSerializer.Deserialize<List<PacketSubmissionErrorDto>>(response, options);

        //    return dto;
        //}

        //public async Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1)
        //{
        //    var response = await GetRequest($"{_BasePath}/Errors/ByAssignee/{assignedTo}?pageSize={pageSize}&pageIndex={pageIndex}");

        //    List<PacketSubmissionErrorDto> dto = JsonSerializer.Deserialize<List<PacketSubmissionErrorDto>>(response, options);

        //    return dto;
        //}

        //public async Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        //{
        //    string json = JsonSerializer.Serialize(dto);

        //    var response = await PostRequest($"{_BasePath}/{packetSubmissionId}/Errors", json);
        //}

        //public async Task PutPacketSubmissionError(int packetSubmissionId, int id, PacketSubmissionErrorDto dto)
        //{
        //    string json = JsonSerializer.Serialize(dto);

        //    var response = await PutRequest($"{_BasePath}/{packetSubmissionId}/Errors/{id}", json);
        //}
    }
}

