﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    [Route("api/[controller]")]
    public class LookupsController : Controller, ILookupClient
    {
        private readonly ApiDbContext _context;

        public LookupsController(ApiDbContext context)
        {
            _context = context;
        }

        private IQueryable<DrugCodeLookup> GetDrugCodeQuery(string searchTerm = "")
        {
            var drugCodeQuery = _context.DrugCodesLookup
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string cleanedSearchTerm = searchTerm.Trim().ToLower();

                drugCodeQuery = drugCodeQuery
                    .Where(d => d.DrugName.StartsWith(cleanedSearchTerm) || d.BrandNames.Contains(cleanedSearchTerm));
            }

            return drugCodeQuery;
        }

        [HttpGet("DrugCodes", Name = "LookupDrugCodes")]
        public async Task<LookupDrugCodeDto> LookupDrugCodes(int pageSize = 10, int pageIndex = 1)
        {
            var query = GetDrugCodeQuery();
            var totalRecords = await query.CountAsync();

            var results = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .OrderBy(d => d.DrugName)
                .Select(d => d.ToDto())
                .ToListAsync();

            return new LookupDrugCodeDto
            {
                LookupType = "DrugCode",
                SearchTerm = "",
                PageSize = pageSize,
                PageIndex = pageSize,
                TotalResultsCount = totalRecords,
                Results = results,
                LookupParameters = new { },
                Error = new ErrorDto()
            };
        }

        /// <summary>
        /// Searches existing drug codes by drug name or brand name
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        [HttpGet("DrugCodes/Search", Name = "SearchDrugCodes")]
        public async Task<LookupDrugCodeDto> SearchDrugCodes(int pageSize = 10, int pageIndex = 1, string searchTerm = "")
        {
            var query = GetDrugCodeQuery(searchTerm);
            var totalRecords = await query.CountAsync();

            var results = await query.ToListAsync();

            return new LookupDrugCodeDto
            {
                LookupType = "DrugCode",
                SearchTerm = searchTerm,
                PageSize = pageSize,
                PageIndex = pageSize,
                TotalResultsCount = totalRecords,
                Results = results.Select(d => d.ToDto()).ToList(),
                LookupParameters = new { SearchTerm = searchTerm },
                Error = new ErrorDto()
            };
        }

        [HttpGet("DrugCodes/Find/{rxCUI}", Name = "FindDrugCodes")]
        public async Task<LookupDrugCodeDto> FindDrugCode(int rxCUI)
        {
            var drugCode = await _context.DrugCodesLookup
                .Where(d => d.RxNormId == rxCUI)
                .FirstOrDefaultAsync();

            if (drugCode != null)
            {
                return new LookupDrugCodeDto
                {
                    LookupType = "DrugCode",
                    SearchTerm = rxCUI.ToString(),
                    PageSize = 1,
                    PageIndex = 1,
                    TotalResultsCount = 1,
                    Results = new List<DrugCodeDto>
                    {
                        drugCode.ToDto()
                    },
                    LookupParameters = new { RxCUI = rxCUI },
                    Error = new ErrorDto()
                };
            }
            else
            {
                return new LookupDrugCodeDto
                {
                    LookupType = "DrugCode",
                    SearchTerm = rxCUI.ToString(),
                    PageSize = 1,
                    PageIndex = 1,
                    TotalResultsCount = 0,
                    Results = new List<DrugCodeDto>(),
                    LookupParameters = new { RxCUI = rxCUI },
                    Error = new ErrorDto()
                };
            }
        }

        [HttpPost("DrugCodes", Name = "AddDrugCode")]
        public async Task<DrugCodeDto> AddDrugCode([FromBody] DrugCodeDto dto)
        {
            bool exists = await _context.DrugCodesLookup.Where(d => d.RxNormId == dto.RxNormId).AnyAsync();
            if (!exists)
            {
                try
                {
                    _context.DrugCodesLookup.Add(dto.ToEntity());
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                }
            }

            return dto;
        }

        [HttpGet("Count", Name = "LookupsCount")]
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IEnumerable<LookupDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Task<LookupDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<LookupDto> Post(LookupDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<LookupDto> Put(int id, LookupDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("CountryCode", Name = "LookupCountryCode")]
        public async Task<LookupCountryCodeDto> LookupCountryCode(string? countryCode)
        {
            if (string.IsNullOrEmpty(countryCode))
            {
                return new LookupCountryCodeDto
                {
                    Error = new ErrorDto()
                };
            }

            var country = await _context.CountryCodesLookup.FirstOrDefaultAsync(c => c.Code == countryCode);
            if (country == null)
            {
                return new LookupCountryCodeDto
                {
                    Error = new ErrorDto()
                };
            }

            return new LookupCountryCodeDto
            {
                Id = country.Id,
                Code = country.Code,
                Country = country.Country,
                IsActive = country.IsActive,
                ReasonChangedCode = country.ReasonChangedCode

            };
        }

    }
}

