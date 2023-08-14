using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IParticipationClient : IBaseClient<ParticipationDto>
    {
        Task<List<M1Dto>> GetMilestones(int id);

        Task PostMilestone(int id, M1Dto dto);

        Task PutMilestone(int id, int formId, M1Dto dto);

        Task<ParticipationDto> GetByLegacyId(string LegacyId);
    }
}

