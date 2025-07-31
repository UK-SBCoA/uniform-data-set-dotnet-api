namespace UDS.Net.API.Entities
{
    public enum PacketStatus
    {
        Pending, // since last form change, no attempts made to finalize
        Finalized, // finalized entire packet since last form change
        Submitted, // submitted at least once, pending error checks from the latest submission
        FailedErrorChecks, // submitted at least once and failed error checks
        PassedErrorChecks, // submitted at least once and passed error checks
        Frozen // data freeze
    }
}

