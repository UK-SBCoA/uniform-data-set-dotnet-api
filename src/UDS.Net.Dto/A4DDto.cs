using System;
namespace UDS.Net.Dto
{
    public class A4DDto : FormDto
    {
        public string DRUGID { get; set; }

        public DrugCodeDto DrugCodeLookup { get; set; }
    }
}

