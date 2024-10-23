using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IPacketClient : IBaseClient<PacketDto>
    {
        Task<PacketDto> GetPacketWithForms(int id);

        Task<int> CountByStatusAndAssignee(string[] statuses, string assignedTo);

        Task<List<PacketDto>> GetPacketsByStatusAndAssignee(string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1);

        //Task<int> ErrorCountByForm(int visitId, string formKind, bool includeResolved = false);

        //Task<List<PacketSubmissionErrorDto>> GetErrorsByForm(int visitId, string formKind, bool includeResolved = false, int pageSize = 10, int pageIndex = 1);



        //Task<List<PacketSubmissionErrorDto>> GetPacketSubmissionErrorsByVisit(int visitId, int pageSize = 10, int pageIndex = 1);

        //Task PostPacketSubmissionError(int packetSubmissionId, PacketSubmissionErrorDto dto);

        //Task PutPacketSubmissionError(int packetSubmissionId, int id, PacketSubmissionErrorDto dto);
    }
}
