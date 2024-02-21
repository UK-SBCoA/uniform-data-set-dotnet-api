using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    [Owned]
    public class A4D
    {
        public int? RxNormId { get; set; }

        [ForeignKey("RxNormId")]
        public DrugCodeLookup DrugCode { get; set; } = default!;
    }
}

