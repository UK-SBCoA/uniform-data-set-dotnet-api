using System;
namespace UDS.Net.API.Entities
{
    // 1, In-person|2, Remote|3, Not completed
    public enum FormMode
    {
        InPerson = 1,
        Remote = 2, // Not possible for B1
        NotCompleted = 3 // optional for some forms
    }
}

