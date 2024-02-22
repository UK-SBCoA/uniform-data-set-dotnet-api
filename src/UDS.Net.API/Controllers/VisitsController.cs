using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    /// <summary>
    /// Agrees to VisitClient interface to always ensure client and api endpoints are in-sync. 
    /// </summary>
    [Route("api/[controller]")]
    public class VisitsController : Controller, IVisitClient
    {
        private readonly ApiDbContext _context;

        public VisitsController(ApiDbContext context)
        {
            _context = context;
        }

        private async Task<Visit> Get(int id, string formKind)
        {
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                var visit = await _context.Visits
                    .Include(v => v.FormStatuses)
                    .Where(v => v.Id == id)
                    .FirstOrDefaultAsync();

                // get details for form requested
                if (formKind == "A1") // participant demographics
                {
                    var a1 = await _context.A1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a1 != null)
                        visit.A1 = a1;
                }
                else if (formKind == "A1a") // social determinants
                {
                    var a1a = await _context.A1as
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a1a != null)
                        visit.A1a = a1a;
                }
                else if (formKind == "A2") // co-participant demogrpahics
                {
                    var a2 = await _context.A2s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a2 != null)
                        visit.A2 = a2;
                }
                else if (formKind == "A3") // family history
                {
                    var a3 = await _context.A3s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a3 != null)
                        visit.A3 = a3;
                }
                else if (formKind == "A4") // medications
                {
                    var a4 = await _context.A4s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a4 != null)
                        visit.A4 = a4;
                }
                else if (formKind == "A4a") // ADRD-specific treatment
                {
                    var a4a = await _context.A4as
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a4a != null)
                        visit.A4a = a4a;
                }
                else if (formKind == "A5D2") // health history and clinician-assessed medical conditions
                {
                    var a5d2 = await _context.A5D2s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a5d2 != null)
                        visit.A5D2 = a5d2;
                }
                else if (formKind == "B1") // evaluation form - physical
                {
                    var b1 = await _context.B1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b1 != null)
                        visit.B1 = b1;
                }
                else if (formKind == "B3") // updrs
                {
                    var b3 = await _context.B3s
                        .Where(b => b.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b3 != null)
                        visit.B3 = b3;
                }
                else if (formKind == "B4") // cdr plus ftld
                {
                    var b4 = await _context.B4s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b4 != null)
                        visit.B4 = b4;
                }
                else if (formKind == "B5") // npi-q
                {
                    var b5 = await _context.B5s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b5 != null)
                        visit.B5 = b5;
                }
                else if (formKind == "B6") // gds
                {
                    var b6 = await _context.B6s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b6 != null)
                        visit.B6 = b6;
                }
                else if (formKind == "B7") // faqs
                {
                    var b7 = await _context.B7s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b7 != null)
                        visit.B7 = b7;
                }
                else if (formKind == "B8") // neurological examination findings
                {
                    var b8 = await _context.B8s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b8 != null)
                        visit.B8 = b8;
                }
                else if (formKind == "B9") // symptoms
                {
                    var b9 = await _context.B9s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (b9 != null)
                        visit.B9 = b9;
                }
                else if (formKind == "C1") // neuro battery scores (mmse, etc.)
                {
                    var c1 = await _context.C1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (c1 != null)
                        visit.C1 = c1;
                }
                else if (formKind == "C2") // neuro battery scores (moca, etc.)
                {
                    var c2 = await _context.C2s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (c2 != null)
                        visit.C2 = c2;
                }
                else if (formKind == "D1") // clinician diagnosis
                {
                    var d1 = await _context.D1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (d1 != null)
                        visit.D1 = d1;
                }
                else if (formKind == "T1") // telephone inclusion
                {
                    var t1 = await _context.T1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (t1 != null)
                        visit.T1 = t1;
                }

                return visit;
            }

            return null;
        }

        [HttpGet]
        public async Task<IEnumerable<VisitDto>> Get(int pageSize = 10, int pageIndex = 1)
        {
            return await _context.Visits
                        .AsNoTracking()
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Select(v => v.ToDto())
                        .ToListAsync();
        }

        [HttpGet("Count", Name = "VisitsCount")]
        public async Task<int> Count()
        {
            return await _context.Visits.CountAsync();
        }

        [HttpGet("{id}")]
        public async Task<VisitDto> Get(int id)
        {
            var dto = await _context.Visits
                .Include(v => v.FormStatuses)
                .Where(v => v.Id == id)
                .Select(v => v.ToDto())
                .FirstOrDefaultAsync();

            return dto;
        }

        [HttpGet("{id}/Forms/{formKind}", Name = "GetWithForm")]
        public async Task<VisitDto> GetWithForm(int id, string formKind)
        {
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                var visit = await Get(id, formKind);

                return visit.ToDto(formKind);
            }
            throw new Exception("Must include a form id.");
        }

        [HttpPost]
        public async Task Post([FromBody] VisitDto dto)
        {
            var visit = new Visit
            {
                Kind = dto.Kind,
                Number = dto.Number,
                Version = dto.Version,
                StartDateTime = dto.StartDateTime,
                CreatedBy = dto.CreatedBy,
                CreatedAt = dto.CreatedAt,
                ModifiedBy = dto.ModifiedBy,
                IsDeleted = dto.IsDeleted,
                DeletedBy = dto.DeletedBy,
                ParticipationId = dto.ParticipationId
            };
            _context.Visits.Add(visit);
            await _context.SaveChangesAsync();
        }

        private string GetFormKind(VisitDto dto)
        {
            string formKind = "";
            if (dto.Forms != null && dto.Forms.Count() > 0)
            {
                foreach (var form in dto.Forms)
                {
                    if (form is A1Dto)
                        formKind = "A1";
                    else if (form is A1aDto)
                        formKind = "A1a";
                    else if (form is A2Dto)
                        formKind = "A2";
                    else if (form is A3Dto)
                        formKind = "A3";
                    else if (form is A4Dto)
                        formKind = "A4";
                    else if (form is A4aDto)
                        formKind = "A4a";
                    else if (form is A5D2Dto)
                        formKind = "A5D2";
                    else if (form is B1Dto)
                        formKind = "B1";
                    else if (form is B3Dto)
                        formKind = "B3";
                    else if (form is B4Dto)
                        formKind = "B4";
                    else if (form is B5Dto)
                        formKind = "B5";
                    else if (form is B6Dto)
                        formKind = "B6";
                    else if (form is B7Dto)
                        formKind = "B7";
                    else if (form is B8Dto)
                        formKind = "B8";
                    else if (form is B9Dto)
                        formKind = "B9";
                    else if (form is C1Dto)
                        formKind = "C1";
                    else if (form is C2Dto)
                        formKind = "C2";
                    else if (form is D1Dto)
                        formKind = "D1";
                    else if (form is T1Dto)
                        formKind = "T1";
                }
            }
            return formKind;
        }

        private void CreateOrUpdateFormInModel(Visit visit, FormDto formDto)
        {
            if (formDto is A1Dto)
            {
                if (visit.A1 == null)
                    visit.A1 = new A1();
                visit.A1.Update((A1Dto)formDto);
            }
            else if (formDto is A1aDto)
            {
                if (visit.A1a == null)
                    visit.A1a = new A1a();
                visit.A1a.Update((A1aDto)formDto);
            }
            else if (formDto is A2Dto)
            {
                if (visit.A2 == null)
                    visit.A2 = new A2();
                visit.A2.Update((A2Dto)formDto);
            }
            else if (formDto is A3Dto)
            {
                if (visit.A3 == null)
                    visit.A3 = new A3();
                visit.A3.Update((A3Dto)formDto);
            }
            else if (formDto is A4Dto)
            {
                if (visit.A4 == null)
                    visit.A4 = new A4();
                visit.A4.Update((A4Dto)formDto);
            }
            else if (formDto is A4aDto)
            {
                if (visit.A4a == null)
                    visit.A4a = new A4a();
                visit.A4a.Update((A4aDto)formDto);
            }
            else if (formDto is A5D2Dto)
            {
                if (visit.A5D2 == null)
                    visit.A5D2 = new A5D2();
                visit.A5D2.Update((A5D2Dto)formDto);
            }
            else if (formDto is B1Dto)
            {
                if (visit.B1 == null)
                    visit.B1 = new B1();
                visit.B1.Update((B1Dto)formDto);
            }
            else if (formDto is B3Dto)
            {
                if (visit.B3 == null)
                    visit.B3 = new B3();
                visit.B3.Update((B3Dto)formDto);
            }
            else if (formDto is B4Dto)
            {
                if (visit.B4 == null)
                    visit.B4 = new B4();
                visit.B4.Update((B4Dto)formDto);
            }
            else if (formDto is B5Dto)
            {
                if (visit.B5 == null)
                    visit.B5 = new B5();
                visit.B5.Update((B5Dto)formDto);
            }
            else if (formDto is B6Dto)
            {
                if (visit.B6 == null)
                    visit.B6 = new B6();
                visit.B6.Update((B6Dto)formDto);
            }
            else if (formDto is B7Dto)
            {
                if (visit.B7 == null)
                    visit.B7 = new B7();
                visit.B7.Update((B7Dto)formDto);
            }
            else if (formDto is B8Dto)
            {
                if (visit.B8 == null)
                    visit.B8 = new B8();
                visit.B8.Update((B8Dto)formDto);
            }
            else if (formDto is B9Dto)
            {
                if (visit.B9 == null)
                    visit.B9 = new B9();
                visit.B9.Update((B9Dto)formDto);
            }
            else if (formDto is C1Dto)
            {
                if (visit.C1 == null)
                    visit.C1 = new C1();
                visit.C1.Update((C1Dto)formDto);
            }
            else if (formDto is C2Dto)
            {
                if (visit.C2 == null)
                    visit.C2 = new C2();
                visit.C2.Update((C2Dto)formDto);
            }
            else if (formDto is D1Dto)
            {
                if (visit.D1 == null)
                    visit.D1 = new D1();
                visit.D1.Update((D1Dto)formDto);
            }
            else if (formDto is T1Dto)
            {
                if (visit.T1 == null)
                    visit.T1 = new T1();
                visit.T1.Update((T1Dto)formDto);
            }
        }

        [HttpPost("{id}/Forms/{formKind}", Name = "PostWithForm")]
        public async Task PostWithForm(int id, string formKind, [FromBody] VisitDto dto)
        {
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                // check to see if the dto has a full form
                string formKindInVisit = GetFormKind(dto);
                if (formKind.Trim() == formKindInVisit)
                {
                    Visit? visit = await Get(id, formKind);

                    if (visit != null)
                    {
                        var formDto = dto.Forms.Where(f => f.Kind == formKind).FirstOrDefault();

                        CreateOrUpdateFormInModel(visit, formDto);

                        _context.Visits.Update(visit);
                        await _context.SaveChangesAsync();
                    }
                    else
                        throw new Exception("Must create visit before creating form.");
                }
                else
                    throw new Exception("Form kind attempting to be created does not match form found in visit.");
            }
            else
                throw new Exception("Must include a form kind to create.");
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] VisitDto dto)
        {
            // check to see if the dto has a full form
            string formKind = GetFormKind(dto);

            Visit? visit;
            if (String.IsNullOrEmpty(formKind))
            {
                // there could be status updates for form bases
                visit = await _context.Visits
                    .Include(v => v.FormStatuses)
                    .Where(v => v.Id == id)
                    .FirstOrDefaultAsync();
            }
            else
            {
                visit = await Get(id, formKind);
            }

            if (visit != null)
            {
                visit.ParticipationId = dto.ParticipationId;
                visit.Number = dto.Number;
                visit.Kind = dto.Kind;
                visit.Version = dto.Version;
                visit.StartDateTime = dto.StartDateTime;
                visit.CreatedAt = dto.CreatedAt;
                visit.CreatedBy = dto.CreatedBy;
                visit.ModifiedBy = dto.ModifiedBy;
                visit.DeletedBy = dto.DeletedBy;
                visit.IsDeleted = dto.IsDeleted;


                if (!String.IsNullOrEmpty(formKind))
                {
                    var formDto = dto.Forms.Where(f => f.Kind == formKind).FirstOrDefault();

                    CreateOrUpdateFormInModel(visit, formDto);
                }

                _context.Visits.Update(visit);
                await _context.SaveChangesAsync();

                return;
            }

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var visit = await _context.Visits.FindAsync(id);

            if (visit == null)
                return;

            _context.Visits.Remove(visit);

            await _context.SaveChangesAsync();
        }

    }
}

