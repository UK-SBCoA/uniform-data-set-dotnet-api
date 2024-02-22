using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IFormClient : IBaseClient<FormDto>
    {
        Task<int> Count(string kind);

        Task<IEnumerable<FormDto>> Get(string kind, int pageSize = 10, int pageIndex = 1);

        Task<IEnumerable<FormDto>> GetSummaries(string kind, int pageSize = 10, int pageIndex = 1);
    }
}

