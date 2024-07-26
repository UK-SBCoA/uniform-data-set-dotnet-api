using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IVisitClient : IBaseClient<VisitDto>
    {
        Task<VisitDto> GetWithForm(int id, string formKind);

        Task PostWithForm(int id, string formKind, VisitDto dto);
    }
}

