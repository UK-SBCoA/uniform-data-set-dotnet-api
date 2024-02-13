using System;
using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class EntityToDtoMapper
    {
        private static VisitDto ConvertVisitToDto(Visit visit)
        {
            var dto = new VisitDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted,
                Number = visit.Number,
                Kind = visit.Kind,
                Version = visit.Version,
                StartDateTime = visit.StartDateTime,
                Forms = new List<FormDto>()
            };

            return dto;
        }

        public static VisitDto ToDto(this Visit visit)
        {
            var dto = ConvertVisitToDto(visit);

            if (visit.FormStatuses != null)
            {
                // since we aren't returning any specific details of any form, return the summary and status of all
                foreach (var formStatus in visit.FormStatuses.OrderBy(f => f.Kind).ToList()) // TODO Instead of ordering alphabetically by kind, include a DisplayWeight property and make it configurable (maybe even grouping)
                {
                    dto.Forms.Add(new FormDto
                    {
                        Id = formStatus.Id,
                        VisitId = formStatus.VisitId,
                        Status = formStatus.Status,
                        Kind = formStatus.Kind,
                        IsDeleted = formStatus.IsDeleted,
                        DeletedBy = formStatus.DeletedBy,
                        CreatedBy = formStatus.CreatedBy,
                        CreatedAt = formStatus.CreatedAt,
                        IsIncluded = formStatus.IsIncluded,
                        Language = formStatus.Language.HasValue ? ((int)formStatus.Language).ToString() : "",
                        ModifiedBy = formStatus.ModifiedBy,
                        ReasonCode = formStatus.ReasonCode.HasValue ? ((int)formStatus.ReasonCode).ToString() : ""
                    });
                }
            }

            return dto;
        }

        public static VisitDto ToDto(this Visit visit, string formKind)
        {
            var dto = ConvertVisitToDto(visit);

            // Attach form based on kind
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                foreach (var form in visit.FormStatuses)
                {
                    FormDto formDto = new FormDto();

                    if (form.Kind == formKind)
                    {
                        if (formKind == "A1" && visit.A1 != null)
                            formDto = visit.A1.ToFullDto();

                        if (formKind == "A1a" && visit.A1a != null)
                            formDto = visit.A1a.ToFullDto();

                        if (formKind == "A2" && visit.A2 != null)
                            formDto = visit.A2.ToFullDto();

                        if (formKind == "A3" && visit.A3 != null)
                            formDto = visit.A3.ToFullDto();

                        if (formKind == "A4")
                        {
                            if (visit.A4G != null && visit.A4Ds != null)
                                formDto = visit.A4G.ToFullDto(visit.A4Ds);
                        }

                        if (formKind == "A5" && visit.A5 != null)
                            formDto = visit.A5.ToFullDto();

                        if (formKind == "B1" && visit.B1 != null)
                            formDto = visit.B1.ToFullDto();

                        if (formKind == "B4" && visit.B4 != null)
                            formDto = visit.B4.ToFullDto();

                        if (formKind == "B5" && visit.B5 != null)
                            formDto = visit.B5.ToFullDto();

                        if (formKind == "B6" && visit.B6 != null)
                            formDto = visit.B6.ToFullDto();

                        if (formKind == "B7" && visit.B7 != null)
                            formDto = visit.B7.ToFullDto();

                        if (formKind == "B8" && visit.B8 != null)
                            formDto = visit.B8.ToFullDto();

                        if (formKind == "B9" && visit.B9 != null)
                            formDto = visit.B9.ToFullDto();

                        if (formKind == "C1" && visit.C1 != null)
                            formDto = visit.C1.ToFullDto();

                        if (formKind == "C2" && visit.C2 != null)
                            formDto = visit.C2.ToFullDto();

                        if (formKind == "D1" && visit.D1 != null)
                            formDto = visit.D1.ToFullDto();

                        if (formKind == "D2" && visit.D2 != null)
                            formDto = visit.D2.ToFullDto();

                        if (formKind == "T1" && visit.T1 != null)
                            formDto = visit.T1.ToFullDto();
                    }
                    else
                    {
                        formDto = new FormDto
                        {
                            Id = form.Id,
                            VisitId = form.VisitId,
                            Kind = form.Kind,
                            Status = form.Status,
                            CreatedAt = form.CreatedAt,
                            CreatedBy = form.CreatedBy,
                            ModifiedBy = form.ModifiedBy,
                            DeletedBy = form.DeletedBy,
                            IsDeleted = form.IsDeleted,
                            IsIncluded = form.IsIncluded,
                            Language = form.Language.HasValue ? ((int)form.Language).ToString() : "",
                            ReasonCode = form.ReasonCode.HasValue ? ((int)form.ReasonCode).ToString() : ""
                        };
                    }
                    dto.Forms.Add(formDto);
                }

            }

            return dto;
        }

        private static void SetBaseFormProperties(this FormDto dto, Form form)
        {
            if (form != null)
            {
                dto.Kind = form.GetType().Name;

                if (form.GetType().Name == "A4G") // workaround for form name
                    dto.Kind = "A4";

                dto.Id = form.Id;
                dto.CreatedAt = form.CreatedAt;
                dto.CreatedBy = form.CreatedBy;
                dto.ModifiedBy = form.ModifiedBy;
                dto.DeletedBy = form.DeletedBy;
                dto.IsDeleted = form.IsDeleted;
                dto.VisitId = form.VisitId;
                dto.Status = form.Status;
                dto.Language = form.Language.HasValue ? ((int)form.Language).ToString() : "";
                dto.IsIncluded = form.IsIncluded;
                dto.ReasonCode = form.ReasonCode.HasValue ? ((int)form.ReasonCode).ToString() : "";
            }
        }

        public static A1Dto ToFullDto(this A1 a1)
        {
            A1Dto dto = new A1Dto
            {
                BIRTHMO = a1.BIRTHMO,
                BIRTHYR = a1.BIRTHYR,
                CHLDHDCTRY = a1.CHLDHDCTRY,
                RACEWHITE = a1.RACEWHITE,
                ETHGERMAN = a1.ETHGERMAN,
                ETHIRISH = a1.ETHIRISH,
                ETHENGLISH = a1.ETHENGLISH,
                ETHITALIAN = a1.ETHITALIAN,
                ETHPOLISH = a1.ETHPOLISH,
                ETHFRENCH = a1.ETHFRENCH,
                ETHWHIOTH = a1.ETHWHIOTH,
                ETHWHIOTHX = a1.ETHWHIOTHX,
                ETHISPANIC = a1.ETHISPANIC,
                ETHMEXICAN = a1.ETHMEXICAN,
                ETHPUERTO = a1.ETHPUERTO,
                ETHCUBAN = a1.ETHCUBAN,
                ETHSALVA = a1.ETHSALVA,
                ETHDOMIN = a1.ETHDOMIN,
                ETHCOLOM = a1.ETHCOLOM,
                ETHHISOTH = a1.ETHHISOTH,
                ETHHISOTHX = a1.ETHHISOTHX,
                RACEBLACK = a1.RACEBLACK,
                ETHAFAMER = a1.ETHAFAMER,
                ETHJAMAICA = a1.ETHJAMAICA,
                ETHHAITIAN = a1.ETHHAITIAN,
                ETHNIGERIA = a1.ETHNIGERIA,
                ETHETHIOP = a1.ETHETHIOP,
                ETHSOMALI = a1.ETHSOMALI,
                ETHBLKOTH = a1.ETHBLKOTH,
                ETHBLKOTHX = a1.ETHBLKOTHX,
                RACEASIAN = a1.RACEASIAN,
                ETHCHINESE = a1.ETHCHINESE,
                ETHFILIP = a1.ETHFILIP,
                ETHINDIA = a1.ETHINDIA,
                ETHVIETNAM = a1.ETHVIETNAM,
                ETHKOREAN = a1.ETHKOREAN,
                ETHJAPAN = a1.ETHJAPAN,
                ETHASNOTH = a1.ETHASNOTH,
                ETHASNOTHX = a1.ETHASNOTHX,
                RACEAIAN = a1.RACEAIAN,
                RACEAIANX = a1.RACEAIANX,
                RACEMENA = a1.RACEMENA,
                ETHLEBANON = a1.ETHLEBANON,
                ETHIRAN = a1.ETHIRAN,
                ETHEGYPT = a1.ETHEGYPT,
                ETHSYRIA = a1.ETHSYRIA,
                ETHMOROCCO = a1.ETHMOROCCO,
                ETHISRAEL = a1.ETHISRAEL,
                ETHMENAOTH = a1.ETHMENAOTH,
                ETHMENAOTX = a1.ETHMENAOTX,
                RACENHPI = a1.RACENHPI,
                ETHHAWAII = a1.ETHHAWAII,
                ETHSAMOAN = a1.ETHSAMOAN,
                ETHCHAMOR = a1.ETHCHAMOR,
                ETHTONGAN = a1.ETHTONGAN,
                ETHFIJIAN = a1.ETHFIJIAN,
                ETHMARSHAL = a1.ETHMARSHAL,
                ETHNHPIOTH = a1.ETHNHPIOTH,
                ETHNHPIOTX = a1.ETHNHPIOTX,
                RACEUNKN = a1.RACEUNKN,
                GENMAN = a1.GENMAN,
                GENWOMAN = a1.GENWOMAN,
                GENTRMAN = a1.GENTRMAN,
                GENTRWOMAN = a1.GENTRWOMAN,
                GENNONBI = a1.GENNONBI,
                GENTWOSPIR = a1.GENTWOSPIR,
                GENOTH = a1.GENOTH,
                GENOTHX = a1.GENOTHX,
                GENDKN = a1.GENDKN,
                GENNOANS = a1.GENNOANS,
                BIRTHSEX = a1.BIRTHSEX,
                INTERSEX = a1.INTERSEX,
                SEXORNGAY = a1.SEXORNGAY,
                SEXORNHET = a1.SEXORNHET,
                SEXORNBI = a1.SEXORNBI,
                SEXORNTWOS = a1.SEXORNTWOS,
                SEXORNOTH = a1.SEXORNOTH,
                SEXORNOTHX = a1.SEXORNOTHX,
                SEXORNDNK = a1.SEXORNDNK,
                SEXORNNOAN = a1.SEXORNNOAN,
                PREDOMLAN = a1.PREDOMLAN,
                PREDOMLANX = a1.PREDOMLANX,
                HANDED = a1.HANDED,
                EDUC = a1.EDUC,
                LVLEDUC = a1.LVLEDUC,
                MARISTAT = a1.MARISTAT,
                LIVSITUA = a1.LIVSITUA,
                RESIDENC = a1.RESIDENC,
                ZIP = a1.ZIP,
                SERVED = a1.SERVED,
                MEDVA = a1.MEDVA,
                EXRTIME = a1.EXRTIME,
                MEMWORS = a1.MEMWORS,
                MEMTROUB = a1.MEMTROUB,
                MEMTEN = a1.MEMTEN,
                ADISTATE = a1.ADISTATE,
                ADINAT = a1.ADINAT,
                PRIOCC = a1.PRIOCC,
                SOURCENW = a1.SOURCENW,
                REFERSC = a1.REFERSC,
                REFERSCX = a1.REFERSCX,
                REFLEARNED = a1.REFLEARNED,
                REFCTRSOCX = a1.REFCTRSOCX,
                REFCTRREGX = a1.REFCTRREGX,
                REFOTHWEBX = a1.REFOTHWEBX,
                REFOTHMEDX = a1.REFOTHMEDX,
                REFOTHREGX = a1.REFOTHREGX,
                REFOTHX = a1.REFOTHX
            };
            dto.SetBaseFormProperties(a1);

            return dto;
        }

        public static A1aDto ToFullDto(this A1a a1a)
        {
            A1aDto dto = new A1aDto
            {
                OWNSCAR = a1a.OWNSCAR,
                TRSPACCESS = a1a.TRSPACCESS,
                TRANSPROB = a1a.TRANSPROB,
                TRANSWORRY = a1a.TRANSWORRY,
                TRSPLONGER = a1a.TRSPLONGER,
                TRSPMED = a1a.TRSPMED,
                INCOMEYR = a1a.INCOMEYR,
                FINSATIS = a1a.FINSATIS,
                BILLPAY = a1a.BILLPAY,
                FINUPSET = a1a.FINUPSET,
                EATLESS = a1a.EATLESS,
                EATLESSYR = a1a.EATLESSYR,
                LESSMEDS = a1a.LESSMEDS,
                LESSMEDSYR = a1a.LESSMEDSYR,
                COMPCOMM = a1a.COMPCOMM,
                COMPUSA = a1a.COMPUSA,
                FAMCOMP = a1a.FAMCOMP,
                GUARDEDU = a1a.GUARDEDU,
                GUARDREL = a1a.GUARDREL,
                GUARDRELX = a1a.GUARDRELX,
                GUARD2EDU = a1a.GUARD2EDU,
                GUARD2REL = a1a.GUARD2REL,
                GUARD2RELX = a1a.GUARD2RELX,
                EMPTINESS = a1a.EMPTINESS,
                MISSPEOPLE = a1a.MISSPEOPLE,
                FRIENDS = a1a.FRIENDS,
                ABANDONED = a1a.ABANDONED,
                CLOSEFRND = a1a.CLOSEFRND,
                PARENTCOMM = a1a.PARENTCOMM,
                CHILDCOMM = a1a.CHILDCOMM,
                FRIENDCOMM = a1a.FRIENDCOMM,
                PARTICIPATE = a1a.PARTICIPATE,
                SAFEHOME = a1a.SAFEHOME,
                SAFECOMM = a1a.SAFECOMM,
                DELAYMED = a1a.DELAYMED,
                SCRIPTPROB = a1a.SCRIPTPROB,
                MISSEDFUP = a1a.MISSEDFUP,
                DOCADVICE = a1a.DOCADVICE,
                HEALTHACC = a1a.HEALTHACC,
                LESSCOURT = a1a.LESSCOURT,
                POORSERV = a1a.POORSERV,
                NOTSMART = a1a.NOTSMART,
                ACTAFRAID = a1a.ACTAFRAID,
                THREATENED = a1a.THREATENED,
                POORMEDTRT = a1a.POORMEDTRT,
                EXPANCEST = a1a.EXPANCEST,
                EXPGENDER = a1a.EXPGENDER,
                EXPRACE = a1a.EXPRACE,
                EXPAGE = a1a.EXPAGE,
                EXPRELIG = a1a.EXPRELIG,
                EXPHEIGHT = a1a.EXPHEIGHT,
                EXPWEIGHT = a1a.EXPWEIGHT,
                EXPAPPEAR = a1a.EXPAPPEAR,
                EXPSEXORN = a1a.EXPSEXORN,
                EXPEDUCINC = a1a.EXPEDUCINC,
                EXPDISAB = a1a.EXPDISAB,
                EXPSKIN = a1a.EXPSKIN,
                EXPOTHER = a1a.EXPOTHER,
                EXPNOTAPP = a1a.EXPNOTAPP,
                EXPNOANS = a1a.EXPNOANS,
                EXPSTRS = a1a.EXPSTRS
            };
            dto.SetBaseFormProperties(a1a);

            return dto;
        }

        public static A2Dto ToFullDto(this A2 a2)
        {
            A2Dto dto = new A2Dto
            {
                NEWINF = a2.NEWINF,
                INRELTO = a2.INRELTO,
                INKNOWN = a2.INKNOWN,
                INLIVWTH = a2.INLIVWTH,
                INCNTMOD = a2.INCNTMOD,
                INCNTMDX = a2.INCNTMDX,
                INCNTFRQ = a2.INCNTFRQ,
                INCNTTIM = a2.INCNTTIM,
                INRELY = a2.INRELY,
                INMEMWORS = a2.INMEMWORS,
                INMEMTROUB = a2.INMEMTROUB,
                INMEMTEN = a2.INMEMTEN

            };
            dto.SetBaseFormProperties(a2);
            return dto;
        }

        public static A3Dto ToFullDto(this A3 a3)
        {
            A3Dto dto = new A3Dto
            {
                AFFFAMM = a3.AFFFAMM,
                NWINFMUT = a3.NWINFMUT,
                FADMUT = a3.FADMUT,
                FADMUTX = a3.FADMUTX,
                FADMUSO = a3.FADMUSO,
                FADMUSOX = a3.FADMUSOX,
                FFTDMUT = a3.FFTDMUT,
                FFTDMUTX = a3.FFTDMUTX,
                FOTHMUT = a3.FOTHMUT,
                FOTHMUTX = a3.FOTHMUTX,
                MOMMOB = a3.MOMMOB,
                MOMYOB = a3.MOMYOB,
                MOMDAGE = a3.MOMDAGE,
                MOMNEUR = a3.MOMNEUR,
                MOMPRDX = a3.MOMPRDX,
                MOMMOE = a3.MOMMOE,
                MOMAGEO = a3.MOMAGEO,
                DADMOB = a3.DADMOB,
                DADYOB = a3.DADYOB,
                DADDAGE = a3.DADDAGE,
                DADNEUR = a3.DADNEUR,
                DADPRDX = a3.DADPRDX,
                DADMOE = a3.DADMOE,
                DADAGEO = a3.DADAGEO,
                SIBS = a3.SIBS,
                NWINFSIB = a3.NWINFSIB,
                SIB1 = a3.SIB1.ToFullDto(a3.Id),
                SIB2 = a3.SIB2.ToFullDto(a3.Id),
                SIB3 = a3.SIB3.ToFullDto(a3.Id),
                SIB4 = a3.SIB4.ToFullDto(a3.Id),
                SIB5 = a3.SIB5.ToFullDto(a3.Id),
                SIB6 = a3.SIB6.ToFullDto(a3.Id),
                SIB7 = a3.SIB7.ToFullDto(a3.Id),
                SIB8 = a3.SIB8.ToFullDto(a3.Id),
                SIB9 = a3.SIB9.ToFullDto(a3.Id),
                SIB10 = a3.SIB10.ToFullDto(a3.Id),
                SIB11 = a3.SIB11.ToFullDto(a3.Id),
                SIB12 = a3.SIB12.ToFullDto(a3.Id),
                SIB13 = a3.SIB13.ToFullDto(a3.Id),
                SIB14 = a3.SIB14.ToFullDto(a3.Id),
                SIB15 = a3.SIB15.ToFullDto(a3.Id),
                SIB16 = a3.SIB16.ToFullDto(a3.Id),
                SIB17 = a3.SIB17.ToFullDto(a3.Id),
                SIB18 = a3.SIB18.ToFullDto(a3.Id),
                SIB19 = a3.SIB19.ToFullDto(a3.Id),
                SIB20 = a3.SIB20.ToFullDto(a3.Id),
                KIDS = a3.KIDS,
                NWINFKID = a3.NWINFKID,
                KID1 = a3.KID1.ToFullDto(a3.Id),
                KID2 = a3.KID2.ToFullDto(a3.Id),
                KID3 = a3.KID3.ToFullDto(a3.Id),
                KID4 = a3.KID4.ToFullDto(a3.Id),
                KID5 = a3.KID5.ToFullDto(a3.Id),
                KID6 = a3.KID6.ToFullDto(a3.Id),
                KID7 = a3.KID7.ToFullDto(a3.Id),
                KID8 = a3.KID8.ToFullDto(a3.Id),
                KID9 = a3.KID9.ToFullDto(a3.Id),
                KID10 = a3.KID10.ToFullDto(a3.Id),
                KID11 = a3.KID11.ToFullDto(a3.Id),
                KID12 = a3.KID12.ToFullDto(a3.Id),
                KID13 = a3.KID13.ToFullDto(a3.Id),
                KID14 = a3.KID14.ToFullDto(a3.Id),
                KID15 = a3.KID15.ToFullDto(a3.Id)
            };
            dto.SetBaseFormProperties(a3);

            return dto;
        }

        public static A3FamilyMemberDto ToFullDto(this A3FamilyMember a3FamilyMember, int formId)
        {
            if (a3FamilyMember != null)
            {
                return new A3FamilyMemberDto
                {
                    FormId = formId,
                    MOB = a3FamilyMember.MOB,
                    YOB = a3FamilyMember.YOB,
                    AGD = a3FamilyMember.AGD,
                    NEU = a3FamilyMember.NEU,
                    PDX = a3FamilyMember.PDX,
                    MOE = a3FamilyMember.MOE,
                    AGO = a3FamilyMember.AGO
                };
            }
            else
                return new A3FamilyMemberDto();
        }

        public static A4GDto ToFullDto(this A4G a4G, IEnumerable<A4D> a4Ds)
        {
            A4GDto dto = new A4GDto
            {
                ANYMEDS = a4G.ANYMEDS,
                A4Dtos = a4Ds.Select(a => a.ToFullDto()).ToList()
            };
            dto.SetBaseFormProperties(a4G);
            return dto;
        }

        public static A4DDto ToFullDto(this A4D a4D)
        {
            var drugCodeDto = new DrugCodeDto();
            if (a4D.DrugCode != null)
            {
                drugCodeDto.DrugId = a4D.DrugCode.DrugId;
                drugCodeDto.DrugName = a4D.DrugCode.DrugName;
                drugCodeDto.BrandName = a4D.DrugCode.BrandName;
                drugCodeDto.IsOverTheCounter = a4D.DrugCode.IsOverTheCounter;
                drugCodeDto.IsPopular = a4D.DrugCode.IsPopular;
            }

            A4DDto dto = new A4DDto
            {
                DRUGID = a4D.DRUGID,
                DrugCodeLookup = drugCodeDto
            };
            dto.SetBaseFormProperties(a4D);
            return dto;
        }

        public static A5Dto ToFullDto(this A5 a5)
        {
            A5Dto dto = new A5Dto
            {
                TOBAC30 = a5.TOBAC30,
                TOBAC100 = a5.TOBAC100,
                SMOKYRS = a5.SMOKYRS,
                PACKSPER = a5.PACKSPER,
                QUITSMOK = a5.QUITSMOK,
                ALCOCCAS = a5.ALCOCCAS,
                ALCFREQ = a5.ALCFREQ,
                CVHATT = a5.CVHATT,
                HATTMULT = a5.HATTMULT,
                HATTYEAR = a5.HATTYEAR,
                CVAFIB = a5.CVAFIB,
                CVANGIO = a5.CVANGIO,
                CVBYPASS = a5.CVBYPASS,
                CVPACDEF = a5.CVPACDEF,
                CVCHF = a5.CVCHF,
                CVANGINA = a5.CVANGINA,
                CVHVALVE = a5.CVHVALVE,
                CVOTHR = a5.CVOTHR,
                CVOTHRX = a5.CVOTHRX,
                CBSTROKE = a5.CBSTROKE,
                STROKMUL = a5.STROKMUL,
                STROKYR = a5.STROKYR,
                CBTIA = a5.CBTIA,
                TIAMULT = a5.TIAMULT,
                TIAYEAR = a5.TIAYEAR,
                PD = a5.PD,
                PDYR = a5.PDYR,
                PDOTHR = a5.PDOTHR,
                PDOTHRYR = a5.PDOTHRYR,
                SEIZURES = a5.SEIZURES,
                TBI = a5.TBI,
                TBIBRIEF = a5.TBIBRIEF,
                TBIEXTEN = a5.TBIEXTEN,
                TBIWOLOS = a5.TBIWOLOS,
                TBIYEAR = a5.TBIYEAR,
                DIABETES = a5.DIABETES,
                DIABTYPE = a5.DIABTYPE,
                HYPERTEN = a5.HYPERTEN,
                HYPERCHO = a5.HYPERCHO,
                B12DEF = a5.B12DEF,
                THYROID = a5.THYROID,
                ARTHRIT = a5.ARTHRIT,
                ARTHTYPE = a5.ARTHTYPE,
                ARTHTYPX = a5.ARTHTYPX,
                ARTHUPEX = a5.ARTHUPEX,
                ARTHLOEX = a5.ARTHLOEX,
                ARTHSPIN = a5.ARTHSPIN,
                ARTHUNK = a5.ARTHUNK,
                INCONTU = a5.INCONTU,
                INCONTF = a5.INCONTF,
                APNEA = a5.APNEA,
                RBD = a5.RBD,
                INSOMN = a5.INSOMN,
                OTHSLEEP = a5.OTHSLEEP,
                OTHSLEEX = a5.OTHSLEEX,
                ALCOHOL = a5.ALCOHOL,
                ABUSOTHR = a5.ABUSOTHR,
                ABUSX = a5.ABUSX,
                PTSD = a5.PTSD,
                BIPOLAR = a5.BIPOLAR,
                SCHIZ = a5.SCHIZ,
                DEP2YRS = a5.DEP2YRS,
                DEPOTHR = a5.DEPOTHR,
                ANXIETY = a5.ANXIETY,
                OCD = a5.OCD,
                NPSYDEV = a5.NPSYDEV,
                PSYCDIS = a5.PSYCDIS,
                PSYCDISX = a5.PSYCDISX
            };
            dto.SetBaseFormProperties(a5);
            return dto;
        }

        public static B1Dto ToFullDto(this B1 b1)
        {
            B1Dto dto = new B1Dto
            {
                HEIGHT = b1.HEIGHT,
                WEIGHT = b1.WEIGHT,
                BPSYS = b1.BPSYS,
                BPDIAS = b1.BPDIAS,
                HRATE = b1.HRATE,
                VISION = b1.VISION,
                VISCORR = b1.VISCORR,
                VISWCORR = b1.VISWCORR,
                HEARING = b1.HEARING,
                HEARAID = b1.HEARAID,
                HEARWAID = b1.HEARWAID
            };
            dto.SetBaseFormProperties(b1);
            return dto;
        }

        public static B4Dto ToFullDto(this B4 b4)
        {
            B4Dto dto = new B4Dto
            {
                MEMORY = b4.MEMORY,
                ORIENT = b4.ORIENT,
                JUDGMENT = b4.JUDGMENT,
                COMMUN = b4.COMMUN,
                HOMEHOBB = b4.HOMEHOBB,
                PERSCARE = b4.PERSCARE,
                CDRSUM = b4.CDRSUM,
                CDRGLOB = b4.CDRGLOB,
                COMPORT = b4.COMPORT,
                CDRLANG = b4.CDRLANG
            };
            dto.SetBaseFormProperties(b4);
            return dto;
        }

        public static B5Dto ToFullDto(this B5 b5)
        {
            B5Dto dto = new B5Dto
            {
                NPIQINF = b5.NPIQINF,
                NPIQINFX = b5.NPIQINFX,
                DEL = b5.DEL,
                DELSEV = b5.DELSEV,
                HALL = b5.HALL,
                HALLSEV = b5.HALLSEV,
                AGIT = b5.AGIT,
                AGITSEV = b5.AGITSEV,
                DEPD = b5.DEPD,
                DEPDSEV = b5.DEPDSEV,
                ANX = b5.ANX,
                ANXSEV = b5.ANXSEV,
                ELAT = b5.ELAT,
                ELATSEV = b5.ELATSEV,
                APA = b5.APA,
                APASEV = b5.APASEV,
                DISN = b5.DISN,
                DISNSEV = b5.DISNSEV,
                IRR = b5.IRR,
                IRRSEV = b5.IRRSEV,
                MOT = b5.MOT,
                MOTSEV = b5.MOTSEV,
                NITE = b5.NITE,
                NITESEV = b5.NITESEV,
                APP = b5.APP,
                APPSEV = b5.APPSEV
            };
            dto.SetBaseFormProperties(b5);
            return dto;
        }

        public static B6Dto ToFullDto(this B6 b6)
        {
            B6Dto dto = new B6Dto
            {
                NOGDS = b6.NOGDS,
                SATIS = b6.SATIS,
                DROPACT = b6.DROPACT,
                EMPTY = b6.EMPTY,
                BORED = b6.BORED,
                SPIRITS = b6.SPIRITS,
                AFRAID = b6.AFRAID,
                HAPPY = b6.HAPPY,
                HELPLESS = b6.HELPLESS,
                STAYHOME = b6.STAYHOME,
                MEMPROB = b6.MEMPROB,
                WONDRFUL = b6.WONDRFUL,
                WRTHLESS = b6.WRTHLESS,
                ENERGY = b6.ENERGY,
                HOPELESS = b6.HOPELESS,
                BETTER = b6.BETTER,
                GDS = b6.GDS
            };
            dto.SetBaseFormProperties(b6);
            return dto;
        }

        public static B7Dto ToFullDto(this B7 b7)
        {
            B7Dto dto = new B7Dto
            {
                BILLS = b7.BILLS,
                TAXES = b7.TAXES,
                SHOPPING = b7.SHOPPING,
                GAMES = b7.GAMES,
                STOVE = b7.STOVE,
                MEALPREP = b7.MEALPREP,
                EVENTS = b7.EVENTS,
                PAYATTN = b7.PAYATTN,
                REMDATES = b7.REMDATES,
                TRAVEL = b7.TRAVEL
            };
            dto.SetBaseFormProperties(b7);
            return dto;
        }

        public static B8Dto ToFullDto(this B8 b8)
        {
            B8Dto dto = new B8Dto
            {
                NORMEXAM = b8.NORMEXAM,
                PARKSIGN = b8.PARKSIGN,
                RESTTRL = b8.RESTTRL,
                RESTTRR = b8.RESTTRR,
                SLOWINGL = b8.SLOWINGL,
                SLOWINGR = b8.SLOWINGR,
                RIGIDL = b8.RIGIDL,
                RIGIDR = b8.RIGIDR,
                BRADY = b8.BRADY,
                PARKGAIT = b8.PARKGAIT,
                POSTINST = b8.POSTINST,
                CVDSIGNS = b8.CVDSIGNS,
                CORTDEF = b8.CORTDEF,
                SIVDFIND = b8.SIVDFIND,
                CVDMOTL = b8.CVDMOTL,
                CVDMOTR = b8.CVDMOTR,
                CORTVISL = b8.CORTVISL,
                CORTVISR = b8.CORTVISR,
                SOMATL = b8.SOMATL,
                SOMATR = b8.SOMATR,
                POSTCORT = b8.POSTCORT,
                PSPCBS = b8.PSPCBS,
                EYEPSP = b8.EYEPSP,
                DYSPSP = b8.DYSPSP,
                AXIALPSP = b8.AXIALPSP,
                GAITPSP = b8.GAITPSP,
                APRAXSP = b8.APRAXSP,
                APRAXL = b8.APRAXL,
                APRAXR = b8.APRAXR,
                CORTSENL = b8.CORTSENL,
                CORTSENR = b8.CORTSENR,
                ATAXL = b8.ATAXL,
                ATAXR = b8.ATAXR,
                ALIENLML = b8.ALIENLML,
                ALIENLMR = b8.ALIENLMR,
                DYSTONL = b8.DYSTONL,
                DYSTONR = b8.DYSTONR,
                MYOCLLT = b8.MYOCLLT,
                MYOCLRT = b8.MYOCLRT,
                ALSFIND = b8.ALSFIND,
                GAITNPH = b8.GAITNPH,
                OTHNEUR = b8.OTHNEUR,
                OTHNEURX = b8.OTHNEURX
            };
            dto.SetBaseFormProperties(b8);
            return dto;
        }

        public static B9Dto ToFullDto(this B9 b9)
        {
            B9Dto dto = new B9Dto
            {
                DECSUB = b9.DECSUB,
                DECIN = b9.DECIN,
                DECCLCOG = b9.DECCLCOG,
                COGMEM = b9.COGMEM,
                COGORI = b9.COGORI,
                COGJUDG = b9.COGJUDG,
                COGLANG = b9.COGLANG,
                COGVIS = b9.COGVIS,
                COGATTN = b9.COGATTN,
                COGFLUC = b9.COGFLUC,
                COGFLAGO = b9.COGFLAGO,
                COGOTHR = b9.COGOTHR,
                COGOTHRX = b9.COGOTHRX,
                COGFPRED = b9.COGFPRED,
                COGFPREX = b9.COGFPREX,
                COGMODE = b9.COGMODE,
                COGMODEX = b9.COGMODEX,
                DECAGE = b9.DECAGE,
                DECCLBE = b9.DECCLBE,
                BEAPATHY = b9.BEAPATHY,
                BEDEP = b9.BEDEP,
                BEVHALL = b9.BEVHALL,
                BEVWELL = b9.BEVWELL,
                BEVHAGO = b9.BEVHAGO,
                BEAHALL = b9.BEAHALL,
                BEDEL = b9.BEDEL,
                BEDISIN = b9.BEDISIN,
                BEIRRIT = b9.BEIRRIT,
                BEAGIT = b9.BEAGIT,
                BEPERCH = b9.BEPERCH,
                BEREM = b9.BEREM,
                BEREMAGO = b9.BEREMAGO,
                BEANX = b9.BEANX,
                BEOTHR = b9.BEOTHR,
                BEOTHRX = b9.BEOTHRX,
                BEFPRED = b9.BEFPRED,
                BEFPREDX = b9.BEFPREDX,
                BEMODE = b9.BEMODE,
                BEMODEX = b9.BEMODEX,
                BEAGE = b9.BEAGE,
                DECCLMOT = b9.DECCLMOT,
                MOGAIT = b9.MOGAIT,
                MOFALLS = b9.MOFALLS,
                MOTREM = b9.MOTREM,
                MOSLOW = b9.MOSLOW,
                MOFRST = b9.MOFRST,
                MOMODE = b9.MOMODE,
                MOMODEX = b9.MOMODEX,
                MOMOPARK = b9.MOMOPARK,
                PARKAGE = b9.PARKAGE,
                MOMOALS = b9.MOMOALS,
                ALSAGE = b9.ALSAGE,
                MOAGE = b9.MOAGE,
                COURSE = b9.COURSE,
                FRSTCHG = b9.FRSTCHG,
                LBDEVAL = b9.LBDEVAL,
                FTLDEVAL = b9.FTLDEVAL
            };
            dto.SetBaseFormProperties(b9);
            return dto;
        }

        public static C1Dto ToFullDto(this C1 c1)
        {
            C1Dto dto = new C1Dto
            {
                MMSECOMP = c1.MMSECOMP,
                MMSEREAS = c1.MMSEREAS,
                MMSELOC = c1.MMSELOC,
                MMSELAN = c1.MMSELAN,
                MMSELANX = c1.MMSELANX,
                MMSEVIS = c1.MMSEVIS,
                MMSEHEAR = c1.MMSEHEAR,
                MMSEORDA = c1.MMSEORDA,
                MMSEORLO = c1.MMSEORLO,
                PENTAGON = c1.PENTAGON,
                MMSE = c1.MMSE,
                NPSYCLOC = c1.NPSYCLOC,
                NPSYLAN = c1.NPSYLAN,
                NPSYLANX = c1.NPSYLANX,
                LOGIMO = c1.LOGIMO,
                LOGIDAY = c1.LOGIDAY,
                LOGIYR = c1.LOGIYR,
                LOGIPREV = c1.LOGIPREV,
                LOGIMEM = c1.LOGIMEM,
                UDSBENTC = c1.UDSBENTC,
                DIGIF = c1.DIGIF,
                DIGIFLEN = c1.DIGIFLEN,
                DIGIB = c1.DIGIB,
                DIGIBLEN = c1.DIGIBLEN,
                ANIMALS = c1.ANIMALS,
                VEG = c1.VEG,
                TRAILA = c1.TRAILA,
                TRAILARR = c1.TRAILARR,
                TRAILALI = c1.TRAILALI,
                TRAILB = c1.TRAILB,
                TRAILBRR = c1.TRAILBRR,
                TRAILBLI = c1.TRAILBLI,
                MEMUNITS = c1.MEMUNITS,
                MEMTIME = c1.MEMTIME,
                UDSBENTD = c1.UDSBENTD,
                UDSBENRS = c1.UDSBENRS,
                BOSTON = c1.BOSTON,
                UDSVERFC = c1.UDSVERFC,
                UDSVERFN = c1.UDSVERFN,
                UDSVERNF = c1.UDSVERNF,
                UDSVERLC = c1.UDSVERLC,
                UDSVERLR = c1.UDSVERLR,
                UDSVERLN = c1.UDSVERLN,
                UDSVERTN = c1.UDSVERTN,
                UDSVERTE = c1.UDSVERTE,
                UDSVERTI = c1.UDSVERTI,
                COGSTAT = c1.COGSTAT
            };
            dto.SetBaseFormProperties(c1);
            return dto;
        }

        public static C2Dto ToFullDto(this C2 c2)
        {
            C2Dto dto = new C2Dto
            {
                MODCOMM = c2.MODCOMM,
                MOCACOMP = c2.MOCACOMP,
                MOCAREAS = c2.MOCAREAS,
                MOCALOC = c2.MOCALOC,
                MOCALAN = c2.MOCALAN,
                MOCALANX = c2.MOCALANX,
                MOCAVIS = c2.MOCAVIS,
                MOCAHEAR = c2.MOCAHEAR,
                MOCATOTS = c2.MOCATOTS,
                MOCATRAI = c2.MOCATRAI,
                MOCACUBE = c2.MOCACUBE,
                MOCACLOC = c2.MOCACLOC,
                MOCACLON = c2.MOCACLON,
                MOCACLOH = c2.MOCACLOH,
                MOCANAMI = c2.MOCANAMI,
                MOCAREGI = c2.MOCAREGI,
                MOCADIGI = c2.MOCADIGI,
                MOCALETT = c2.MOCALETT,
                MOCASER7 = c2.MOCASER7,
                MOCAREPE = c2.MOCAREPE,
                MOCAFLUE = c2.MOCAFLUE,
                MOCAABST = c2.MOCAABST,
                MOCARECN = c2.MOCARECN,
                MOCARECC = c2.MOCARECC,
                MOCARECR = c2.MOCARECR,
                MOCAORDT = c2.MOCAORDT,
                MOCAORMO = c2.MOCAORMO,
                MOCAORYR = c2.MOCAORYR,
                MOCAORDY = c2.MOCAORDY,
                MOCAORPL = c2.MOCAORPL,
                MOCAORCT = c2.MOCAORCT,
                NPSYCLOC = c2.NPSYCLOC,
                NPSYLAN = c2.NPSYLAN,
                NPSYLANX = c2.NPSYLANX,
                CRAFTVRS = c2.CRAFTVRS,
                CRAFTURS = c2.CRAFTURS,
                REY1REC = c2.REY1REC,
                REY1INT = c2.REY1INT,
                REY2REC = c2.REY2REC,
                REY2INT = c2.REY2INT,
                REY3REC = c2.REY3REC,
                REY3INT = c2.REY3INT,
                REY4REC = c2.REY4REC,
                REY4INT = c2.REY4INT,
                REY5REC = c2.REY5REC,
                REY5INT = c2.REY5INT,
                REY6REC = c2.REY6REC,
                REY6INT = c2.REY6INT,
                UDSBENTC = c2.UDSBENTC,
                DIGFORCT = c2.DIGFORCT,
                DIGFORSL = c2.DIGFORSL,
                DIGBACCT = c2.DIGBACCT,
                DIGBACLS = c2.DIGBACLS,
                OTRAILA = c2.OTRAILA,
                OTRLARR = c2.OTRLARR,
                OTRLALI = c2.OTRLALI,
                OTRAILB = -c2.OTRAILB,
                OTRLBRR = c2.OTRLBRR,
                OTRLBLI = c2.OTRLBLI,
                ANIMALS = c2.ANIMALS,
                VEG = c2.VEG,
                TRAILA = c2.TRAILA,
                TRAILARR = c2.TRAILARR,
                TRAILALI = c2.TRAILALI,
                TRAILB = c2.TRAILB,
                TRAILBRR = c2.TRAILBRR,
                TRAILBLI = c2.TRAILBLI,
                CRAFTDVR = c2.CRAFTDVR,
                CRAFTDRE = c2.CRAFTDRE,
                CRAFTDTI = c2.CRAFTDTI,
                CRAFTCUE = c2.CRAFTCUE,
                UDSBENTD = c2.UDSBENTD,
                UDSBENRS = c2.UDSBENRS,
                MINTTOTS = c2.MINTTOTS,
                MINTTOTW = c2.MINTTOTW,
                MINTSCNG = c2.MINTSCNG,
                MINTSCNC = c2.MINTSCNC,
                MINTPCNG = c2.MINTPCNG,
                MINTPCNC = c2.MINTPCNC,
                UDSVERFC = c2.UDSVERFC,
                UDSVERFN = c2.UDSVERFN,
                UDSVERNF = c2.UDSVERNF,
                UDSVERLC = c2.UDSVERLC,
                UDSVERLR = c2.UDSVERLR,
                UDSVERLN = c2.UDSVERLN,
                UDSVERTN = c2.UDSVERTN,
                UDSVERTE = c2.UDSVERTE,
                UDSVERTI = c2.UDSVERTI,
                REYDREC = c2.REYDREC,
                REYDINT = c2.REYDINT,
                REYTCOR = c2.REYTCOR,
                REYFPOS = c2.REYFPOS,
                VNTTOTW = c2.VNTTOTW,
                VNTPCNC = c2.VNTPCNC,
                COGSTAT = c2.COGSTAT,
                RESPVAL = c2.RESPVAL,
                RESPHEAR = c2.RESPHEAR,
                RESPDIST = c2.RESPDIST,
                RESPINTR = c2.RESPINTR,
                RESPDISN = c2.RESPDISN,
                RESPFATG = c2.RESPFATG,
                RESPEMOT = c2.RESPEMOT,
                RESPASST = c2.RESPASST,
                RESPOTH = c2.RESPOTH,
                RESPOTHX = c2.RESPOTHX,
            };
            dto.SetBaseFormProperties(c2);
            return dto;
        }

        public static D1Dto ToFullDto(this D1 d1)
        {
            D1Dto dto = new D1Dto
            {
                DXMETHOD = d1.DXMETHOD,
                NORMCOG = d1.NORMCOG,
                DEMENTED = d1.DEMENTED,
                AMNDEM = d1.AMNDEM,
                PCA = d1.PCA,
                PPASYN = d1.PPASYN,
                PPASYNT = d1.PPASYNT,
                FTDSYN = d1.FTDSYN,
                LBDSYN = d1.LBDSYN,
                NAMNDEM = d1.NAMNDEM,
                MCIAMEM = d1.MCIAMEM,
                MCIAPLUS = d1.MCIAPLUS,
                MCIAPLAN = d1.MCIAPLAN,
                MCIAPATT = d1.MCIAPATT,
                MCIAPEX = d1.MCIAPEX,
                MCIAPVIS = d1.MCIAPVIS,
                MCINON1 = d1.MCINON1,
                MCIN1LAN = d1.MCIN1LAN,
                MCIN1ATT = d1.MCIN1ATT,
                MCIN1EX = d1.MCIN1EX,
                MCIN1VIS = d1.MCIN1VIS,
                MCINON2 = d1.MCINON2,
                MCIN2LAN = d1.MCIN2LAN,
                MCIN2ATT = d1.MCIN2ATT,
                MCIN2EX = d1.MCIN2EX,
                MCIN2VIS = d1.MCIN2VIS,
                IMPNOMCI = d1.IMPNOMCI,
                AMYLPET = d1.AMYLPET,
                AMYLCSF = d1.AMYLCSF,
                FDGAD = d1.FDGAD,
                HIPPATR = d1.HIPPATR,
                TAUPETAD = d1.TAUPETAD,
                CSFTAU = d1.CSFTAU,
                FDGFTLD = d1.FDGFTLD,
                TPETFTLD = d1.TPETFTLD,
                MRFTLD = d1.MRFTLD,
                DATSCAN = d1.DATSCAN,
                OTHBIOM = d1.OTHBIOM,
                OTHBIOMX = d1.OTHBIOMX,
                IMAGLINF = d1.IMAGLINF,
                IMAGLAC = d1.IMAGLAC,
                IMAGMACH = d1.IMAGMACH,
                IMAGMICH = d1.IMAGMICH,
                IMAGMWMH = d1.IMAGMWMH,
                IMAGEWMH = d1.IMAGEWMH,
                ADMUT = d1.ADMUT,
                FTLDMUT = d1.FTLDMUT,
                OTHMUT = d1.OTHMUT,
                OTHMUTX = d1.OTHMUTX,
                ALZDIS = d1.ALZDIS,
                ALZDISIF = d1.ALZDISIF,
                LBDIS = d1.LBDIS,
                LBDIF = d1.LBDIF,
                PARK = d1.PARK,
                MSA = d1.MSA,
                MSAIF = d1.MSAIF,
                PSP = d1.PSP,
                PSPIF = d1.PSPIF,
                CORT = d1.CORT,
                CORTIF = d1.CORTIF,
                FTLDMO = d1.FTLDMO,
                FTLDMOIF = d1.FTLDMOIF,
                FTLDNOS = d1.FTLDNOS,
                FTLDNOIF = d1.FTLDNOIF,
                FTLDSUBT = d1.FTLDSUBT,
                FTLDSUBX = d1.FTLDSUBX,
                CVD = d1.CVD,
                CVDIF = d1.CVDIF,
                PREVSTK = d1.PREVSTK,
                STROKDEC = d1.STROKDEC,
                STKIMAG = d1.STKIMAG,
                INFNETW = d1.INFNETW,
                INFWMH = d1.INFWMH,
                ESSTREM = d1.ESSTREM,
                ESSTREIF = d1.ESSTREIF,
                DOWNS = d1.DOWNS,
                DOWNSIF = d1.DOWNSIF,
                HUNT = d1.HUNT,
                HUNTIF = d1.HUNTIF,
                PRION = d1.PRION,
                PRIONIF = d1.PRIONIF,
                BRNINJ = d1.BRNINJ,
                BRNINJIF = d1.BRNINJIF,
                BRNINCTE = d1.BRNINCTE,
                HYCEPH = d1.HYCEPH,
                HYCEPHIF = d1.HYCEPHIF,
                EPILEP = d1.EPILEP,
                EPILEPIF = d1.EPILEPIF,
                NEOP = d1.NEOP,
                NEOPIF = d1.NEOPIF,
                NEOPSTAT = d1.NEOPSTAT,
                HIV = d1.HIV,
                HIVIF = d1.HIVIF,
                OTHCOG = d1.OTHCOG,
                OTHCOGIF = d1.OTHCOGIF,
                OTHCOGX = d1.OTHCOGX,
                DEP = d1.DEP,
                DEPIF = d1.DEPIF,
                DEPTREAT = d1.DEPTREAT,
                BIPOLDX = d1.BIPOLDX,
                BIPOLDIF = d1.BIPOLDIF,
                SCHIZOP = d1.SCHIZOP,
                SCHIZOIF = d1.SCHIZOIF,
                ANXIET = d1.ANXIET,
                ANXIETIF = d1.ANXIETIF,
                DELIR = d1.DELIR,
                DELIRIF = d1.DELIRIF,
                PTSDDX = d1.PTSDDX,
                PTSDDXIF = d1.PTSDDXIF,
                OTHPSY = d1.OTHPSY,
                OTHPSYIF = d1.OTHPSYIF,
                OTHPSYX = d1.OTHPSYX,
                ALCDEM = d1.ALCDEM,
                ALCDEMIF = d1.ALCDEMIF,
                ALCABUSE = d1.ALCABUSE,
                IMPSUB = d1.IMPSUB,
                IMPSUBIF = d1.IMPSUBIF,
                DYSILL = d1.DYSILL,
                DYSILLIF = d1.DYSILLIF,
                MEDS = d1.MEDS,
                MEDSIF = d1.MEDSIF,
                COGOTH = d1.COGOTH,
                COGOTHIF = d1.COGOTHIF,
                COGOTHX = d1.COGOTHX,
                COGOTH2 = d1.COGOTH2,
                COGOTH2F = d1.COGOTH2F,
                COGOTH2X = d1.COGOTH2X,
                COGOTH3 = d1.COGOTH3,
                COGOTH3F = d1.COGOTH3F,
                COGOTH3X = d1.COGOTH3X
            };
            dto.SetBaseFormProperties(d1);
            return dto;
        }

        public static D2Dto ToFullDto(this D2 d2)
        {
            D2Dto dto = new D2Dto
            {
                CANCER = d2.CANCER,
                CANCSITE = d2.CANCSITE,
                DIABET = d2.DIABET,
                MYOINF = d2.MYOINF,
                CONGHRT = d2.CONGHRT,
                AFIBRILL = d2.AFIBRILL,
                HYPERT = d2.HYPERT,
                ANGINA = d2.ANGINA,
                HYPCHOL = d2.HYPCHOL,
                VB12DEF = d2.VB12DEF,
                THYDIS = d2.THYDIS,
                ARTH = d2.ARTH,
                ARTYPE = d2.ARTYPE,
                ARTYPEX = d2.ARTYPEX,
                ARTUPEX = d2.ARTUPEX,
                ARTLOEX = d2.ARTLOEX,
                ARTSPIN = d2.ARTSPIN,
                ARTUNKN = d2.ARTUNKN,
                URINEINC = d2.URINEINC,
                BOWLINC = d2.BOWLINC,
                SLEEPAP = d2.SLEEPAP,
                REMDIS = d2.REMDIS,
                HYPOSOM = d2.HYPOSOM,
                SLEEPOTH = d2.SLEEPOTH,
                SLEEPOTX = d2.SLEEPOTX,
                ANGIOCP = d2.ANGIOCP,
                ANGIOPCI = d2.ANGIOPCI,
                PACEMAKE = d2.PACEMAKE,
                HVALVE = d2.HVALVE,
                ANTIENC = d2.ANTIENC,
                ANTIENCX = d2.ANTIENCX,
                OTHCOND = d2.OTHCOND,
                OTHCONDX = d2.OTHCONDX
            };
            dto.SetBaseFormProperties(d2);
            return dto;
        }

        public static T1Dto ToFullDto(this T1 t1)
        {
            T1Dto dto = new T1Dto
            {
                TELCOG = t1.TELCOG,
                TELILL = t1.TELILL,
                TELHOME = t1.TELHOME,
                TELREFU = t1.TELREFU,
                TELCOV = t1.TELCOV,
                TELOTHR = t1.TELOTHR,
                TELOTHRX = t1.TELOTHRX,
                TELMOD = t1.TELMOD,
                TELINPER = t1.TELINPER,
                TELMILE = t1.TELMILE
            };
            dto.SetBaseFormProperties(t1);
            return dto;
        }

        public static M1Dto ToDto(this M1 m1)
        {
            M1Dto dto = new M1Dto
            {
                ParticipationId = m1.ParticipationId,
                FormId = m1.FormId,
                Status = m1.Status,
                CHANGEMO = m1.CHANGEMO,
                CHANGEDY = m1.CHANGEDY,
                CHANGEYR = m1.CHANGEYR,
                PROTOCOL = m1.PROTOCOL,
                ACONSENT = m1.ACONSENT,
                RECOGIM = m1.RECOGIM,
                REPHYILL = m1.REPHYILL,
                REREFUSE = m1.REREFUSE,
                RENAVAIL = m1.RENAVAIL,
                RENURSE = m1.RENURSE,
                NURSEMO = m1.NURSEMO,
                NURSEDY = m1.NURSEDY,
                NURSEYR = m1.NURSEYR,
                REJOIN = m1.REJOIN,
                FTLDDISC = m1.FTLDDISC,
                FTLDREAS = m1.FTLDREAS,
                FTLDREAX = m1.FTLDREAX,
                DECEASED = m1.DECEASED,
                DISCONT = m1.DISCONT,
                DEATHMO = m1.DEATHMO,
                DEATHDY = m1.DEATHDY,
                DEATHYR = m1.DEATHYR,
                AUTOPSY = m1.AUTOPSY,
                DISCMO = m1.DISCMO,
                DISCDAY = m1.DISCDAY,
                DISCYR = m1.DISCYR,
                DROPREAS = m1.DROPREAS,
                CreatedAt = m1.CreatedAt,
                CreatedBy = m1.CreatedBy,
                ModifiedBy = m1.ModifiedBy,
                DeletedBy = m1.DeletedBy,
                IsDeleted = m1.IsDeleted
            };
            return dto;
        }

        public static ParticipationDto ToDto(this Participation participation)
        {
            var dto = new ParticipationDto()
            {
                Id = participation.Id,
                LegacyId = participation.LegacyId,
                CreatedAt = participation.CreatedAt,
                CreatedBy = participation.CreatedBy,
                ModifiedBy = participation.ModifiedBy,
                DeletedBy = participation.DeletedBy,
                IsDeleted = participation.IsDeleted,
                Visits = participation.Visits.Select(v => v.ToDto()).ToList(),
                VisitCount = participation.Visits != null ? participation.Visits.Count() : 0,
                LastVisitNumber = participation.Visits != null ? (participation.Visits.Any() ? participation.Visits.OrderByDescending(v => v.Number).Select(v => v.Number).First() : 0) : 0
            };

            return dto;
        }

        public static DrugCodeDto ToDto(this DrugCodeLookup drugCode)
        {
            return new DrugCodeDto
            {
                DrugId = drugCode.DrugId,
                DrugName = drugCode.DrugName,
                BrandName = drugCode.BrandName,
                IsOverTheCounter = drugCode.IsOverTheCounter,
                IsPopular = drugCode.IsPopular
            };
        }
    }
}

