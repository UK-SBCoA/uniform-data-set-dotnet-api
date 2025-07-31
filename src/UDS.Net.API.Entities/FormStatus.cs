using System;
using System.ComponentModel.DataAnnotations;


namespace UDS.Net.API.Entities
{
    /// <summary>
	/// SQL View
	/// </summary>
	public class FormStatus : Form
    {
        [MaxLength(3)]
        public string Kind { get; set; } = ""; // A1, A1A, A2, T1, etc.
    }
}

