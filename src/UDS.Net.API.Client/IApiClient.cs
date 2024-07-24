namespace UDS.Net.API.Client
{
    public interface IApiClient
    {
        IVisitClient VisitClient { get; }
        IParticipationClient ParticipationClient { get; }
        ILookupClient LookupClient { get; }
        IPacketSubmissionClient PacketSubmissionClient { get; }
    }
}

