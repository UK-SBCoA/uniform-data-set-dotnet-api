using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Vital Signs and Anthropometrics
    /// </summary>
    [Table("tbl_B1s")]
    public class B1 : Form
    {
        // Height range 36.0 to 87.9, 88.8
        [Comment("Participant height (inches)")]
        [Column(TypeName = "decimal(3,1)")]
        public double? HEIGHT { get; set; }
        [Comment("Participant weight (lbs.)")]
        public int? WEIGHT { get; set; }
        [Comment("Waist circumference measurements (inches): Measurement 1")]
        public int? WAIST1 { get; set; }
        [Comment("Waist circumference measurements (inches): Measurement 2")]
        public int? WAIST2 { get; set; }
        [Comment("Hip circumference measurements (inches): Measurement 1")]
        public int? HIP1 { get; set; }
        [Comment("Hip circumference measurements (inches): Measurement 2")]
        public int? HIP2 { get; set; }
        [Comment("Participant blood pressure - Left arm: Systolic Reading 1")]
        public int? BPSYSL1 { get; set; }
        [Comment(" Participant blood pressure - Left arm: Diastolic Reading 1")]
        public int? BPDIASL1 { get; set; }
        [Comment("Participant blood pressure - Left arm: Systolic Reading 2")]
        public int? BPSYSL2 { get; set; }
        [Comment(" Participant blood pressure - Left arm: Diastolic Reading 2")]
        public int? BPDIASL2 { get; set; }
        [Comment("Participant blood pressure - Right arm: Systolic Reading 1")]
        public int? BPSYSR1 { get; set; }
        [Comment("Participant blood pressure - Right arm: Diastolic Reading 1")]
        public int? BPDIASR1 { get; set; }
        [Comment("Participant blood pressure - Right arm: Systolic Reading 2")]
        public int? BPSYSR2 { get; set; }
        [Comment("Participant blood pressure - Right arm: Diastolic Reading 2")]
        public int? BPDIASR2 { get; set; }
        [Comment("Participant resting heart rate (pulse)")]
        public int? HRATE { get; set; }

    }
}

