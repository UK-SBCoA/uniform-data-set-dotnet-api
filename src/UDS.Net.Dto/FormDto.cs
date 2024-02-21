using System;
using System.Text.Json.Serialization;

namespace UDS.Net.Dto
{
    [JsonDerivedType(typeof(FormDto), "FormDto")]
    [JsonDerivedType(typeof(A1Dto), "A1Dto")]
    [JsonDerivedType(typeof(A1aDto), "A1aDto")]
    [JsonDerivedType(typeof(A2Dto), "A2Dto")]
    [JsonDerivedType(typeof(A3Dto), "A3Dto")]
    [JsonDerivedType(typeof(A4Dto), "A4Dto")]
    [JsonDerivedType(typeof(A4aDto), "A4aDto")]
    [JsonDerivedType(typeof(A5D2Dto), "A5D2Dto")]
    [JsonDerivedType(typeof(B1Dto), "B1Dto")]
    [JsonDerivedType(typeof(B3Dto), "B3Dto")]
    [JsonDerivedType(typeof(B4Dto), "B4Dto")]
    [JsonDerivedType(typeof(B5Dto), "B5Dto")]
    [JsonDerivedType(typeof(B6Dto), "B6Dto")]
    [JsonDerivedType(typeof(B7Dto), "B7Dto")]
    [JsonDerivedType(typeof(B8Dto), "B8Dto")]
    [JsonDerivedType(typeof(B9Dto), "B9Dto")]
    [JsonDerivedType(typeof(C1Dto), "C1Dto")]
    [JsonDerivedType(typeof(C2Dto), "C2Dto")]
    [JsonDerivedType(typeof(D1Dto), "D1Dto")]
    [JsonDerivedType(typeof(T1Dto), "T1Dto")]
    public class FormDto : BaseDto
    {
        public int VisitId { get; set; }

        public string Kind { get; set; }

        public string Status { get; set; }

        public string Language { get; set; }

        public bool? IsIncluded { get; set; }

        public string ReasonCode { get; set; }
    }
}

