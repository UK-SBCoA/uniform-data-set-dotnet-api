using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IVisitClient : IBaseClient<VisitDto>
    {
        Task<VisitDto> GetWithPacketSubmissions(int id, int pageSize = 10, int pageIndex = 1);

        Task<VisitDto> GetWithForm(int id, string formKind);

        Task PostWithForm(int id, string formKind, VisitDto dto);
    }
}

