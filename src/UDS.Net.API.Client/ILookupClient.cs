﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UDS.Net.Dto;

namespace UDS.Net.API.Client
{
    public interface ILookupClient : IBaseClient<LookupDto>
    {
        Task<LookupDrugCodeDto> LookupDrugCodes(int pageSize = 10, int pageIndex = 1);

        Task<LookupDrugCodeDto> SearchDrugCodes(int pageSize = 10, int pageIndex = 1, string? searchTerm = "");

        Task<LookupDrugCodeDto> FindDrugCode(int rxCUI);

        Task<DrugCodeDto> AddDrugCode(DrugCodeDto dto);

        Task<LookupCountryCodeDto> LookupCountryCode(string countryCode);

    }
}

