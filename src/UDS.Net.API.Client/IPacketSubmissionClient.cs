using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IPacketSubmissionClient : IBaseClient<PacketSubmissionDto>
    {
        Task<PacketSubmissionDto> GetPacketSubmissionWithForms(int id);

        Task<int> PacketSubmissionsCountByVisit(int visitId);

        Task<int> PacketSubmissionsCountByStatus(string packetStatus);

        Task<List<PacketSubmissionDto>> GetPacketSubmissionsByVisit(int visitId, int pageSize = 10, int pageIndex = 1);

        Task<List<PacketSubmissionDto>> GetPacketSubmissionsByStatus(string packetStatus, int pageSize = 10, int pageIndex = 1);

        Task<int> PacketSubmissionErrorsCount(bool includeResolved = false);

        Task<int> PacketSubmissionsErrorsCountByVisit(int visitId);

        Task<int> PacketSubmissionsErrorsCountByAssignee(string assignedTo);

        Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrors(bool includeResolved = false, int pageSize = 10, int pageIndex = 1);

        Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1);

        Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByAssignee(string assignedTo, int pageSize = 10, int pageIndex = 1);

        Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto);

        Task PutPacketSubmissionError(int packetSubmissionId, int id, PacketSubmissionErrorDto dto);
    }
}
