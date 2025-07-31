using System;

namespace UDS.Net.API.Entities
{
    // 1, Too cognitively impaired|2, Too physically impaired|3, Homebound or nursing home|4, Refused in-person visit|5, Other
    public enum RemoteReasonCode
    {
        TooCognitivelyImpaired = 1,
        TooPhysicallyImpaired = 2,
        HomeboundOrNursingHome = 3,
        RefusedInPseronVisit = 4,
        Other = 5
    }
}

