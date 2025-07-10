using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// This can return any combination of drug lists (popular, OTC, or custom)
        /// 
        /* 
            +-------------+---------------------------+------------------+------------------------------+
            |  Include?   |       OTC = null          |      false       |             true             |
            +-------------+---------------------------+------------------+------------------------------+
            | Popular =   |                           |                  |                              |
            | null        | all                       | anything not OTC | OTC, no regard to popularity |
            | false       | anything not popular      | custom           | only OTC                     |
            | true        | popular, no regard to OTC | only popular     | only popular and OTC         |
            +-------------+---------------------------+------------------+------------------------------+
        */
        /// </summary>
        [HttpGet("DrugCodes", Name = "LookupDrugCodes")]
        public async Task<LookupDrugCodeDto> LookupDrugCodes(int pageSize = 10, int pageIndex = 1, bool? includePopular = null, bool? includeOverTheCounter = null)
        {
            var query = _context.DrugCodesLookup.AsQueryable();

            if (includePopular.HasValue || includeOverTheCounter.HasValue)
            {
                if (includePopular.HasValue)
                {
                    if (includeOverTheCounter.HasValue)
                    {
                        // consider both
                        query = query.Where(d => d.IsPopular == includePopular.Value && d.IsOverTheCounter == includeOverTheCounter.Value);
                    }
                    else
                    {
                        // includeOverTheCounter not defined, only consider is popular
                        query = query.Where(d => d.IsPopular == includePopular.Value);
                    }
                }
                else if (includeOverTheCounter.HasValue)
                {
                    // includePopular not defined, only consider over the counter
                    query = query.Where(d => d.IsOverTheCounter == includeOverTheCounter.Value);
                }
            }
            else
            {
                // no filter
            }

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
                LookupParameters = new { PageSize = pageSize, PageIndex = pageIndex, IncludePopular = includePopular, IncludeOverTheCounter = includeOverTheCounter },
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

        [HttpGet("DrugCodes/Find", Name = "FindDrugCodes")]
        public async Task<LookupDrugCodeDto> FindDrugCodes([FromQuery] int[] rxCUIs)
        {
            if (rxCUIs != null && rxCUIs.Count() > 0)
            {
                var drugCodes = await _context.DrugCodesLookup
                    .Where(d => EF.Constant(rxCUIs).Contains(d.RxNormId))
                    .ToListAsync();

                if (drugCodes != null)
                {
                    return new LookupDrugCodeDto
                    {
                        LookupType = "DrugCode",
                        SearchTerm = string.Join(", ", rxCUIs),
                        PageSize = 1,
                        PageIndex = 1,
                        TotalResultsCount = 1,
                        Results = drugCodes.ToDto(),
                        LookupParameters = new { RxCUI = rxCUIs },
                        Error = new ErrorDto()
                    };
                }
            }
            return new LookupDrugCodeDto
            {
                LookupType = "DrugCode",
                SearchTerm = "",
                PageSize = 1,
                PageIndex = 1,
                TotalResultsCount = 0,
                Results = new List<DrugCodeDto>(),
                LookupParameters = new { RxCUI = rxCUIs },
                Error = new ErrorDto()
            };
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

