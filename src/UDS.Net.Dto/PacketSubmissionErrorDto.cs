namespace UDS.Net.Dto
{
    public class PacketSubmissionErrorDto : BaseDto
    {
        public int Id { get; set; }

        public string FormKind { get; set; }

        public string Message { get; set; }

        public string AssignedTo { get; set; }

        public string Level { get; set; }

        public string ResolvedBy { get; set; }
    }
}

