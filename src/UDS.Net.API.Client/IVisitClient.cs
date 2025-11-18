using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IVisitClient : IBaseClient<VisitDto>
    {
        Task<List<VisitDto>> GetVisitsAtStatus(string[] statuses, int pageSize = 10, int pageIndex = 1);

        Task<int> GetCountOfVisitsAtStatus(string[] statuses);

        Task<List<VisitDto>> GetVisitsAtDateRangeAndStatus(string[] statuses, DateTime? startDate, DateTime? endDate, int pageSize = 10, int pageIndex = 1);

        Task<int> GetCountOfVisitsAtDateRangeAndStatus(string[] statuses, DateTime? startDate, DateTime? endDate);

        Task<VisitDto> GetWithForm(int id, string formKind);

        Task<VisitDto> GetByVisitNumber(int participantId, int visitNumber, string formKind);

        Task PostWithForm(int id, string formKind, VisitDto dto);
    }
}

