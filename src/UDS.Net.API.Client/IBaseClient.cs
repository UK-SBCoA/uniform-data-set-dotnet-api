using System.Collections.Generic;
using System.Threading.Tasks;

namespace UDS.Net.API.Client
{
    public interface IBaseClient<T>
    {
        Task<IEnumerable<T>> Get(int pageSize = 10, int pageIndex = 1);
        Task<int> Count();
        Task<T> Get(int id);
        Task Post(T dto);
        Task Put(int id, T dto);
        Task Delete(int id);
    }
}

