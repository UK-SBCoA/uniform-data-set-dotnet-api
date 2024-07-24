using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public class PacketSubmissionClient : AuthenticatedClient<PacketSubmissionDto>, IPacketSubmissionClient
    {
        const string BASEPATH = "PacketSubmissions";

        public PacketSubmissionClient(HttpClient httpClient) : base(httpClient, BASEPATH)
        {
        }

        public async Task<int> PacketSubmissionsCountByVisit(int visitId)
        {
            var response = await GetRequest($"{_BasePath}/Count/ByVisit/{visitId}");

            int count = JsonSerializer.Deserialize<int>(response, options);

            return count;
        }

        public async Task<int> PacketSubmissionsCountByStatus(string packetStatus)
        {
            var response = await GetRequest($"{_BasePath}/Count/ByStatus/{packetStatus}");

            int count = JsonSerializer.Deserialize<int>(response, options);

            return count;
        }

        public Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<PacketSubmissionDto>> GetPacketSubmissionsByStatus(string packetStatus, int pageSize = 10, int pageIndex = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> PacketSubmissionErrorsCount(bool includeResolved = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> PacketSubmissionsErrorsCountByVisit(int visitId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> PacketSubmissionsErrorsCountyByAssignee(string assignedTo)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1)
        {
            throw new System.NotImplementedException();
        }

        public async Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        {

            //string json = JsonSerializer.Serialize(dto);

            //var response = await PostRequest($"{_BasePath}/{id}/Forms/{formKind}", json);
            throw new System.NotImplementedException();
        }

        public async Task PutPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto)
        {
            throw new System.NotImplementedException();
        }

    }
}

