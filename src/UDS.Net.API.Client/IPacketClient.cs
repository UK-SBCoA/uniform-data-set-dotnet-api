using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IPacketClient : IBaseClient<PacketDto>
    {
        Task<PacketDto> GetPacketWithForms(int id);

        Task<List<PacketDto>> GetPacketsWithForms(int[] ids);

        Task<int> CountByStatusAndAssignee(string[] statuses, string assignedTo);

        Task<List<PacketDto>> GetPacketsByStatusAndAssignee(string[] statuses, string assignedTo, int pageSize = 10, int pageIndex = 1);
    }
}