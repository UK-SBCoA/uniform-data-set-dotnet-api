using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    [Owned]
    public class A3FamilyMember
    {

        public int? YOB { get; set; }

        public int? AGD { get; set; }

        [MaxLength(2)]
        public string? ETPR { get; set; }

        [MaxLength(2)]
        public string? ETSEC { get; set; }

        public int? MEVAL { get; set; }

        public int? AGO { get; set; }
    }
}

