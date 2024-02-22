using System;
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
    public class FormsController : Controller, IFormClient
    {
        private readonly ApiDbContext _context;

        public FormsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("{kind}/Count", Name = "FormsCountByKind")]
        public async Task<int> Count(string kind)
        {
            switch (kind)
            {
                case "A1":
                    return await _context.A1s.CountAsync();
                case "A1a":
                    return await _context.A1as.CountAsync();
                case "A2":
                    return await _context.A2s.CountAsync();
                case "A3":
                    return await _context.A3s.CountAsync();
                case "A4":
                    return await _context.A4s.CountAsync();
                case "A4a":
                    return await _context.A4as.CountAsync();
                case "A5D2":
                    return await _context.A5D2s.CountAsync();
                case "B1":
                    return await _context.B1s.CountAsync();
                case "B3":
                    return await _context.B3s.CountAsync();
                case "B4":
                    return await _context.B4s.CountAsync();
                case "B5":
                    return await _context.B5s.CountAsync();
                case "B6":
                    return await _context.B6s.CountAsync();
                case "B7":
                    return await _context.B7s.CountAsync();
                case "B8":
                    return await _context.B8s.CountAsync();
                case "C1":
                    return await _context.C1s.CountAsync();
                case "C2":
                    return await _context.C2s.CountAsync();
                case "D1":
                    return await _context.D1s.CountAsync();
                default:
                    break;
            }
            return 0;
        }

        [HttpGet("{kind}/Full", Name = "FormsByKind")]
        public async Task<IEnumerable<FormDto>> Get(string kind, int pageSize = 10, int pageIndex = 1)
        {
            switch (kind)
            {
                case "A1":
                    return await _context.A1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A1a":
                    return await _context.A1as
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A2":
                    return await _context.A2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A3":
                    return await _context.A3s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A4":
                    return await _context.A4s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A4a":
                    return await _context.A4as
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "A5D2":
                    return await _context.A5D2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B1":
                    return await _context.B1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B3":
                    return await _context.B3s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B4":
                    return await _context.B4s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B5":
                    return await _context.B5s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B6":
                    return await _context.B6s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B7":
                    return await _context.B7s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "B8":
                    return await _context.B8s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "C1":
                    return await _context.C1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "C2":
                    return await _context.C2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                case "D1":
                    return await _context.D1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToFullDto())
                        .ToListAsync();
                default:
                    break;
            }
            return new List<FormDto>();
        }

        [HttpGet("{kind}/Summary", Name = "FormSummariesByKind")]
        public async Task<IEnumerable<FormDto>> GetSummaries(string kind, int pageSize = 10, int pageIndex = 1)
        {
            switch (kind)
            {
                case "A1":
                    return await _context.A1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A1a":
                    return await _context.A1as
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A2":
                    return await _context.A2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A3":
                    return await _context.A3s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A4":
                    return await _context.A4s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A4a":
                    return await _context.A4as
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "A5D2":
                    return await _context.A5D2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B1":
                    return await _context.B1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B3":
                    return await _context.B3s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B4":
                    return await _context.B4s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B5":
                    return await _context.B5s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B6":
                    return await _context.B6s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B7":
                    return await _context.B7s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "B8":
                    return await _context.B8s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "C1":
                    return await _context.C1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "C2":
                    return await _context.C2s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                case "D1":
                    return await _context.D1s
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(a => a.ToSummaryDto(kind))
                        .ToListAsync();
                default:
                    break;
            }
            return new List<FormDto>();
        }


        #region Will not implement

        [Obsolete]
        [HttpGet]
        public Task<IEnumerable<FormDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        [HttpGet("Count", Name = "FormsCount")]
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        [HttpGet("{id}")]
        public Task<FormDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        [HttpPost]
        public Task Post(FormDto dto)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        [HttpPut("{id}")]
        public Task Put(int id, FormDto dto)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}

