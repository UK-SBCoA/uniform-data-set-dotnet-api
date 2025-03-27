using System;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Data template https://files.alz.washington.edu/documentation/uds3-ivp-template.pdf
	/// This template is needed only for ASCII batch file submissions.
    /// </summary>
	[Keyless]
    public abstract class PacketFormHeader
    {
        public string PACKET { get; set; } = "I"; // I, I4, F Packet Code,packet,Yes,"I, I4","I, Initial Visit Packet | I4, Initial UDSv4 Visit Packet",String,,"ONLY use the ""I4"" packet code for participants who had previous UDS data and are completing UDSv4 for the first time. Use ""I"" if the participant is newly enrolled"
        public string FORMID { get; set; } = ""; // Entity table name without "tbl_" like "A1"
        public int FORMVER { get; set; } = 3; // Visit.Version
        public string ADCID { get; set; } = ""; // appsettings.json
        public string PTID { get; set; } = ""; // Participation.Id
        public string VISITMO { get; set; } = ""; // Visit.StartDateTime
        public string VISITDAY { get; set; } = ""; // Visit.StartDateTime
        public string VISITYR { get; set; } = ""; // Visit.StartDateTime
        public string VISITNUM { get; set; } = ""; // Visit.StartDateTime
        public string INITIALS { get; set; } = ""; // BaseEntity.ModifiedBy when BaseForm.Status changed to completed

    }
}

