using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface IParticipationClient : IBaseClient<ParticipationDto>
    {

        Task<ParticipationDto> GetByLegacyId(string LegacyId);
    }
}

