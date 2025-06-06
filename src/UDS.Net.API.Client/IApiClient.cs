﻿namespace UDS.Net.API.Client
{
    public interface IApiClient
    {
        IVisitClient VisitClient { get; }
        IParticipationClient ParticipationClient { get; }
        ILookupClient LookupClient { get; }
        IPacketClient PacketClient { get; }
        IMilestoneClient MilestoneClient { get; }
    }
}

