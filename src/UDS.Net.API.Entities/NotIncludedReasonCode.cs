using System;
namespace UDS.Net.API.Entities
{
    // A2: 94, No co-participant|95, Physical problem|96, Cognitive/behavioral problem|97, Other|98, Verbal refusal
    // B1, B3: 94, Remote visit|95, Physical problem|96, Cognitive/behavioral problem|97, Other|98, Verbal refusal
    public enum NotIncludedReasonCode
    {
        NoCoParticipantOrRemoteVisit = 94, // only allowed for A2, B1, B3
        PhysicalProblem = 95,
        CognitiveBehavioralProblem = 96,
        Other = 97,
        VerbalRefusal = 98
    }
}

