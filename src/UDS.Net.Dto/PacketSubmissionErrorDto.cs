namespace UDS.Net.Dto
{
    public class PacketSubmissionErrorDto : BaseDto
    {
        public int Id { get; set; }

        public int PacketSubmissionId { get; set; }

        public string FormKind { get; set; }

        public string Message { get; set; }

        public string AssignedTo { get; set; }

        public string Level { get; set; }

        public string ResolvedBy { get; set; }

        public string Location { get; set; }

        public string Value { get; set; }
    }
}

