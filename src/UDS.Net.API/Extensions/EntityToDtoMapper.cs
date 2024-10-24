using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class EntityToDtoMapper
    {
        private static VisitDto ConvertVisitToDto(Visit visit)
        {
            return new VisitDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted,
                VISITNUM = visit.VISITNUM,
                PACKET = visit.PACKET,
                FORMVER = visit.FORMVER,
                VISIT_DATE = visit.VISIT_DATE,
                INITIALS = visit.INITIALS,
                Status = visit.Status.ToString()
            };
        }

        public static PacketDto ToPacketDto(this Visit visit)
        {
            PacketDto dto = new PacketDto()
            {
                Id = visit.Id,
                ParticipationId = visit.ParticipationId,
                CreatedAt = visit.CreatedAt,
                CreatedBy = visit.CreatedBy,
                ModifiedBy = visit.ModifiedBy,
                DeletedBy = visit.DeletedBy,
                IsDeleted = visit.IsDeleted,
                VISITNUM = visit.VISITNUM,
                PACKET = visit.PACKET,
                FORMVER = visit.FORMVER,
                VISIT_DATE = visit.VISIT_DATE,
                INITIALS = visit.INITIALS,
                Status = visit.Status.ToString()
            };

            if (visit.PacketSubmissions != null && visit.PacketSubmissions.Count() > 0)
            {
                dto.PacketSubmissionCount = visit.PacketSubmissions.Count();
                dto.PacketSubmissions = visit.PacketSubmissions.ToDto();
                int? unresolvedErrorsCount = null;
                foreach (var submission in dto.PacketSubmissions)
                {
                    int? unresolvedCountPerSubmission = submission.PacketSubmissionErrors.Where(e => String.IsNullOrWhiteSpace(e.ResolvedBy)).Count();
                    unresolvedErrorsCount += unresolvedCountPerSubmission;
                }
                dto.TotalUnresolvedErrorCount = unresolvedErrorsCount;
            }

            return dto;
        }

        public static VisitDto ToDto(this Visit visit)
        {
            var dto = ConvertVisitToDto(visit);

            if (visit.FormStatuses != null)
            {
                // since we aren't returning any specific details of any form, return the summary and status of all
                foreach (var formStatus in visit.FormStatuses.OrderBy(f => f.Kind).ToList())
                {
                    var formDto = formStatus.ToSummaryDto(formStatus.Kind);

                    dto.Forms.Add(formDto);
                }
            }

            if (visit.PacketSubmissions != null)
            {
                int? unresolvedErrorsCount = null;
                var unresolvedErrors = new List<PacketSubmissionErrorDto>();
                foreach (var submission in visit.PacketSubmissions)
                {
                    if (submission != null && submission.ErrorCount.HasValue && submission.PacketSubmissionErrors != null)
                    {
                        foreach (var error in submission.PacketSubmissionErrors)
                        {
                            if (error != null && String.IsNullOrWhiteSpace(error.ResolvedBy))
                            {
                                unresolvedErrorsCount += 1;
                                unresolvedErrors.Add(error.ToDto());
                                if (dto.Forms != null)
                                {
                                    // if there are forms, also update the number of unresolved errors and errors list per form
                                    var formDto = dto.Forms.Where(f => f.Kind == error.FormKind).FirstOrDefault();
                                    if (formDto != null)
                                    {
                                        formDto.UnresolvedErrorCount += 1;
                                        formDto.UnresolvedErrors.Add(error.ToDto());
                                    }
                                }
                            }
                        }
                    }
                }
                dto.TotalUnresolvedErrorCount = unresolvedErrorsCount;
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

                        if (formKind == "A4" && visit.A4 != null)
                            formDto = visit.A4.ToFullDto();

                        if (formKind == "A4a" && visit.A4a != null)
                            formDto = visit.A4a.ToFullDto();

                        if (formKind == "A5D2" && visit.A5D2 != null)
                            formDto = visit.A5D2.ToFullDto();

                        if (formKind == "B1" && visit.B1 != null)
                            formDto = visit.B1.ToFullDto();

                        if (formKind == "B3" && visit.B3 != null)
                            formDto = visit.B3.ToFullDto();

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

                        if (formKind == "D1a" && visit.D1a != null)
                            formDto = visit.D1a.ToFullDto();

                        if (formKind == "D1b" && visit.D1b != null)
                            formDto = visit.D1b.ToFullDto();

                        if (formKind == "T1" && visit.T1 != null)
                            formDto = visit.T1.ToFullDto();
                    }
                    else
                    {
                        formDto = form.ToSummaryDto(form.Kind);
                    }
                    dto.Forms.Add(formDto);
                }

            }

            return dto;
        }

        private static void SetBaseFormProperties(this FormDto dto, Form form, string? formKind = "")
        {
            if (form != null)
            {
                dto.Id = form.Id;
                dto.VisitId = form.VisitId;
                if (String.IsNullOrWhiteSpace(formKind))
                    dto.Kind = form.GetType().Name;
                else
                    dto.Kind = formKind;
                dto.CreatedAt = form.CreatedAt;
                dto.CreatedBy = form.CreatedBy;
                dto.ModifiedBy = form.ModifiedBy;
                dto.IsDeleted = form.IsDeleted;
                dto.DeletedBy = form.DeletedBy;
                dto.Status = form.Status;
                dto.FRMDATE = form.FRMDATE;
                dto.INITIALS = form.INITIALS;
                dto.LANG = form.LANG.HasValue ? ((int)form.LANG).ToString() : "";
                dto.MODE = form.MODE.HasValue ? ((int)form.MODE).ToString() : "";
                dto.RMREAS = form.RMREAS.HasValue ? ((int)form.RMREAS).ToString() : "";
                dto.RMMODE = form.RMMODE.HasValue ? ((int)form.RMMODE).ToString() : "";
                dto.NOT = form.NOT.HasValue ? ((int)form.NOT).ToString() : "";
            }
        }

        public static FormDto ToSummaryDto(this Form form, string formKind)
        {
            var dto = new FormDto();
            dto.SetBaseFormProperties(form, formKind);
            return dto;
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
                ETHSCOTT = a1.ETHSCOTT,
                ETHWHIOTH = a1.ETHWHIOTH,
                ETHWHIOTHX = a1.ETHWHIOTHX,
                ETHISPANIC = a1.ETHISPANIC,
                ETHMEXICAN = a1.ETHMEXICAN,
                ETHPUERTO = a1.ETHPUERTO,
                ETHCUBAN = a1.ETHCUBAN,
                ETHSALVA = a1.ETHSALVA,
                ETHDOMIN = a1.ETHDOMIN,
                ETHGUATEM = a1.ETHGUATEM,
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
                ETHIRAQI = a1.ETHIRAQI,
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
                MOMYOB = a3.MOMYOB,
                MOMDAGE = a3.MOMDAGE,
                MOMETPR = a3.MOMETPR,
                MOMETSEC = a3.MOMETSEC,
                MOMMEVAL = a3.MOMMEVAL,
                MOMAGEO = a3.MOMAGEO,
                DADYOB = a3.DADYOB,
                DADDAGE = a3.DADDAGE,
                DADETPR = a3.DADETPR,
                DADETSEC = a3.DADETSEC,
                DADMEVAL = a3.DADMEVAL,
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
                    YOB = a3FamilyMember.YOB,
                    AGD = a3FamilyMember.AGD,
                    ETPR = a3FamilyMember.ETPR,
                    ETSEC = a3FamilyMember.ETSEC,
                    MEVAL = a3FamilyMember.MEVAL,
                    AGO = a3FamilyMember.AGO
                };
            }
            else
                return new A3FamilyMemberDto();
        }

        public static A4Dto ToFullDto(this A4 a4)
        {
            A4Dto dto = new A4Dto
            {
                ANYMEDS = a4.ANYMEDS
            };

            if (a4.RXNORMID1.ToFullDto(out int rxNormId1))
                dto.A4DetailsDtos.Add(rxNormId1);
            if (a4.RXNORMID2.ToFullDto(out int rxNormId2))
                dto.A4DetailsDtos.Add(rxNormId2);
            if (a4.RXNORMID3.ToFullDto(out int rxNormId3))
                dto.A4DetailsDtos.Add(rxNormId3);
            if (a4.RXNORMID4.ToFullDto(out int rxNormId4))
                dto.A4DetailsDtos.Add(rxNormId4);
            if (a4.RXNORMID5.ToFullDto(out int rxNormId5))
                dto.A4DetailsDtos.Add(rxNormId5);
            if (a4.RXNORMID6.ToFullDto(out int rxNormId6))
                dto.A4DetailsDtos.Add(rxNormId6);
            if (a4.RXNORMID7.ToFullDto(out int rxNormId7))
                dto.A4DetailsDtos.Add(rxNormId7);
            if (a4.RXNORMID8.ToFullDto(out int rxNormId8))
                dto.A4DetailsDtos.Add(rxNormId8);
            if (a4.RXNORMID9.ToFullDto(out int rxNormId9))
                dto.A4DetailsDtos.Add(rxNormId9);
            if (a4.RXNORMID10.ToFullDto(out int rxNormId10))
                dto.A4DetailsDtos.Add(rxNormId10);
            if (a4.RXNORMID11.ToFullDto(out int rxNormId11))
                dto.A4DetailsDtos.Add(rxNormId11);
            if (a4.RXNORMID12.ToFullDto(out int rxNormId12))
                dto.A4DetailsDtos.Add(rxNormId12);
            if (a4.RXNORMID13.ToFullDto(out int rxNormId13))
                dto.A4DetailsDtos.Add(rxNormId13);
            if (a4.RXNORMID14.ToFullDto(out int rxNormId14))
                dto.A4DetailsDtos.Add(rxNormId14);
            if (a4.RXNORMID15.ToFullDto(out int rxNormId15))
                dto.A4DetailsDtos.Add(rxNormId15);
            if (a4.RXNORMID16.ToFullDto(out int rxNormId16))
                dto.A4DetailsDtos.Add(rxNormId16);
            if (a4.RXNORMID17.ToFullDto(out int rxNormId17))
                dto.A4DetailsDtos.Add(rxNormId17);
            if (a4.RXNORMID18.ToFullDto(out int rxNormId18))
                dto.A4DetailsDtos.Add(rxNormId18);
            if (a4.RXNORMID19.ToFullDto(out int rxNormId19))
                dto.A4DetailsDtos.Add(rxNormId19);
            if (a4.RXNORMID20.ToFullDto(out int rxNormId20))
                dto.A4DetailsDtos.Add(rxNormId20);
            if (a4.RXNORMID21.ToFullDto(out int rxNormId21))
                dto.A4DetailsDtos.Add(rxNormId21);
            if (a4.RXNORMID22.ToFullDto(out int rxNormId22))
                dto.A4DetailsDtos.Add(rxNormId22);
            if (a4.RXNORMID23.ToFullDto(out int rxNormId23))
                dto.A4DetailsDtos.Add(rxNormId23);
            if (a4.RXNORMID24.ToFullDto(out int rxNormId24))
                dto.A4DetailsDtos.Add(rxNormId24);
            if (a4.RXNORMID25.ToFullDto(out int rxNormId25))
                dto.A4DetailsDtos.Add(rxNormId25);
            if (a4.RXNORMID26.ToFullDto(out int rxNormId26))
                dto.A4DetailsDtos.Add(rxNormId26);
            if (a4.RXNORMID27.ToFullDto(out int rxNormId27))
                dto.A4DetailsDtos.Add(rxNormId27);
            if (a4.RXNORMID28.ToFullDto(out int rxNormId28))
                dto.A4DetailsDtos.Add(rxNormId28);
            if (a4.RXNORMID29.ToFullDto(out int rxNormId29))
                dto.A4DetailsDtos.Add(rxNormId29);
            if (a4.RXNORMID30.ToFullDto(out int rxNormId30))
                dto.A4DetailsDtos.Add(rxNormId30);
            if (a4.RXNORMID31.ToFullDto(out int rxNormId31))
                dto.A4DetailsDtos.Add(rxNormId31);
            if (a4.RXNORMID32.ToFullDto(out int rxNormId32))
                dto.A4DetailsDtos.Add(rxNormId32);
            if (a4.RXNORMID33.ToFullDto(out int rxNormId33))
                dto.A4DetailsDtos.Add(rxNormId33);
            if (a4.RXNORMID34.ToFullDto(out int rxNormId34))
                dto.A4DetailsDtos.Add(rxNormId34);
            if (a4.RXNORMID35.ToFullDto(out int rxNormId35))
                dto.A4DetailsDtos.Add(rxNormId35);
            if (a4.RXNORMID36.ToFullDto(out int rxNormId36))
                dto.A4DetailsDtos.Add(rxNormId36);
            if (a4.RXNORMID37.ToFullDto(out int rxNormId37))
                dto.A4DetailsDtos.Add(rxNormId37);
            if (a4.RXNORMID38.ToFullDto(out int rxNormId38))
                dto.A4DetailsDtos.Add(rxNormId38);
            if (a4.RXNORMID39.ToFullDto(out int rxNormId39))
                dto.A4DetailsDtos.Add(rxNormId39);
            if (a4.RXNORMID40.ToFullDto(out int rxNormId40))
                dto.A4DetailsDtos.Add(rxNormId40);

            dto.SetBaseFormProperties(a4);
            return dto;
        }

        public static bool ToFullDto(this A4D a4d, out int rxNormId)
        {
            if (a4d != null && a4d.RxNormId.HasValue)
            {
                rxNormId = a4d.RxNormId.Value;
                return true;
            }
            rxNormId = 0;
            return false;
        }

        public static A4aDto ToFullDto(this A4a a4a)
        {
            A4aDto dto = new A4aDto
            {
                TRTBIOMARK = a4a.TRTBIOMARK,
                Treatment1 = a4a.Treatment1.ToFullDto(a4a.Id),
                Treatment2 = a4a.Treatment2.ToFullDto(a4a.Id),
                Treatment3 = a4a.Treatment3.ToFullDto(a4a.Id),
                Treatment4 = a4a.Treatment4.ToFullDto(a4a.Id),
                Treatment5 = a4a.Treatment5.ToFullDto(a4a.Id),
                Treatment6 = a4a.Treatment6.ToFullDto(a4a.Id),
                Treatment7 = a4a.Treatment7.ToFullDto(a4a.Id),
                Treatment8 = a4a.Treatment8.ToFullDto(a4a.Id),
                ADVEVENT = a4a.ADVEVENT,
                ARIAE = a4a.ARIAE,
                ARIAH = a4a.ARIAH,
                ADVERSEOTH = a4a.ADVERSEOTH,
                ADVERSEOTX = a4a.ADVERSEOTX
            };
            dto.SetBaseFormProperties(a4a);

            return dto;
        }

        public static A4aTreatmentDto ToFullDto(this A4aTreatment treatment, int formId)
        {
            if (treatment != null)
            {
                return new A4aTreatmentDto
                {
                    FormId = formId,
                    TARGETAB = treatment.TARGETAB,
                    TARGETTAU = treatment.TARGETTAU,
                    TARGETINF = treatment.TARGETINF,
                    TARGETSYN = treatment.TARGETSYN,
                    TARGETOTH = treatment.TARGETOTH,
                    TARGETOTX = treatment.TARGETOTX,
                    TRTTRIAL = treatment.TRTTRIAL,
                    NCTNUM = treatment.NCTNUM,
                    STARTMO = treatment.STARTMO,
                    STARTYEAR = treatment.STARTYEAR,
                    ENDMO = treatment.ENDMO,
                    ENDYEAR = treatment.ENDYEAR,
                    CARETRIAL = treatment.CARETRIAL,
                    TRIALGRP = treatment.TRIALGRP
                };
            }
            else
                return new A4aTreatmentDto();
        }

        public static A5D2Dto ToFullDto(this A5D2 a5)
        {
            A5D2Dto dto = new A5D2Dto
            {
                TOBAC100 = a5.TOBAC100,
                SMOKYRS = a5.SMOKYRS,
                PACKSPER = a5.PACKSPER,
                TOBAC30 = a5.TOBAC30,
                QUITSMOK = a5.QUITSMOK,
                ALCFREQYR = a5.ALCFREQYR,
                ALCDRINKS = a5.ALCDRINKS,
                ALCBINGE = a5.ALCBINGE,
                SUBSTYEAR = a5.SUBSTYEAR,
                SUBSTPAST = a5.SUBSTPAST,
                CANNABIS = a5.CANNABIS,
                HRTATTACK = a5.HRTATTACK,
                HRTATTMULT = a5.HRTATTMULT,
                HRTATTAGE = a5.HRTATTAGE,
                CARDARREST = a5.CARDARREST,
                CARDARRAGE = a5.CARDARRAGE,
                CVAFIB = a5.CVAFIB,
                CVANGIO = a5.CVANGIO,
                CVBYPASS = a5.CVBYPASS,
                BYPASSAGE = a5.BYPASSAGE,
                CVPACDEF = a5.CVPACDEF,
                PACDEFAGE = a5.PACDEFAGE,
                CVCHF = a5.CVCHF,
                CVHVALVE = a5.CVHVALVE,
                VALVEAGE = a5.VALVEAGE,
                CVOTHR = a5.CVOTHR,
                CVOTHRX = a5.CVOTHRX,
                CBSTROKE = a5.CBSTROKE,
                STROKMUL = a5.STROKMUL,
                STROKAGE = a5.STROKAGE,
                STROKSTAT = a5.STROKSTAT,
                ANGIOCP = a5.ANGIOCP,
                CAROTIDAGE = a5.CAROTIDAGE,
                CBTIA = a5.CBTIA,
                TIAAGE = a5.TIAAGE,
                PD = a5.PD,
                PDAGE = a5.PDAGE,
                PDOTHR = a5.PDOTHR,
                PDOTHRAGE = a5.PDOTHRAGE,
                SEIZURES = a5.SEIZURES,
                SEIZNUM = a5.SEIZNUM,
                SEIZAGE = a5.SEIZAGE,
                HEADACHE = a5.HEADACHE,
                MS = a5.MS,
                HYDROCEPH = a5.HYDROCEPH,
                HEADIMP = a5.HEADIMP,
                IMPAMFOOT = a5.IMPAMFOOT,
                IMPSOCCER = a5.IMPSOCCER,
                IMPHOCKEY = a5.IMPHOCKEY,
                IMPBOXING = a5.IMPBOXING,
                IMPSPORT = a5.IMPSPORT,
                IMPIPV = a5.IMPIPV,
                IMPMILIT = a5.IMPMILIT,
                IMPASSAULT = a5.IMPASSAULT,
                IMPOTHER = a5.IMPOTHER,
                IMPOTHERX = a5.IMPOTHERX,
                IMPYEARS = a5.IMPYEARS,
                HEADINJURY = a5.HEADINJURY,
                HEADINJUNC = a5.HEADINJUNC,
                HEADINJCON = a5.HEADINJCON,
                HEADINJNUM = a5.HEADINJNUM,
                FIRSTTBI = a5.FIRSTTBI,
                LASTTBI = a5.LASTTBI,
                DIABETES = a5.DIABETES,
                DIABTYPE = a5.DIABTYPE,
                DIABINS = a5.DIABINS,
                DIABMEDS = a5.DIABMEDS,
                DIABGLP1 = a5.DIABGLP1,
                DIABRECACT = a5.DIABRECACT,
                DIABDIET = a5.DIABDIET,
                DIABUNK = a5.DIABUNK,
                DIABAGE = a5.DIABAGE,
                HYPERTEN = a5.HYPERTEN,
                HYPERTAGE = a5.HYPERTAGE,
                HYPERCHO = a5.HYPERCHO,
                HYPERCHAGE = a5.HYPERCHAGE,
                B12DEF = a5.B12DEF,
                THYROID = a5.THYROID,
                ARTHRIT = a5.ARTHRIT,
                ARTHRRHEUM = a5.ARTHRRHEUM,
                ARTHROSTEO = a5.ARTHROSTEO,
                ARTHROTHR = a5.ARTHROTHR,
                ARTHTYPX = a5.ARTHTYPX,
                ARTHTYPUNK = a5.ARTHTYPUNK,
                ARTHUPEX = a5.ARTHUPEX,
                ARTHLOEX = a5.ARTHLOEX,
                ARTHSPIN = a5.ARTHSPIN,
                ARTHUNK = a5.ARTHUNK,
                INCONTU = a5.INCONTU,
                INCONTF = a5.INCONTF,
                APNEA = a5.APNEA,
                CPAP = a5.CPAP,
                APNEAORAL = a5.APNEAORAL,
                RBD = a5.RBD,
                INSOMN = a5.INSOMN,
                OTHSLEEP = a5.OTHSLEEP,
                OTHSLEEX = a5.OTHSLEEX,
                CANCERACTV = a5.CANCERACTV,
                CANCERPRIM = a5.CANCERPRIM,
                CANCERMETA = a5.CANCERMETA,
                CANCMETBR = a5.CANCMETBR,
                CANCMETOTH = a5.CANCMETOTH,
                CANCERUNK = a5.CANCERUNK,
                CANCBLOOD = a5.CANCBLOOD,
                CANCBREAST = a5.CANCBREAST,
                CANCCOLON = a5.CANCCOLON,
                CANCLUNG = a5.CANCLUNG,
                CANCPROST = a5.CANCPROST,
                CANCOTHER = a5.CANCOTHER,
                CANCOTHERX = a5.CANCOTHERX,
                CANCRAD = a5.CANCRAD,
                CANCRESECT = a5.CANCRESECT,
                CANCIMMUNO = a5.CANCIMMUNO,
                CANCBONE = a5.CANCBONE,
                CANCCHEMO = a5.CANCCHEMO,
                CANCHORM = a5.CANCHORM,
                CANCTROTH = a5.CANCTROTH,
                CANCTROTHX = a5.CANCTROTHX,
                CANCERAGE = a5.CANCERAGE,
                COVID19 = a5.COVID19,
                COVIDHOSP = a5.COVIDHOSP,
                PULMONARY = a5.PULMONARY,
                KIDNEY = a5.KIDNEY,
                KIDNEYAGE = a5.KIDNEYAGE,
                LIVER = a5.LIVER,
                LIVERAGE = a5.LIVERAGE,
                PVD = a5.PVD,
                PVDAGE = a5.PVDAGE,
                HIVDIAG = a5.HIVDIAG,
                HIVAGE = a5.HIVAGE,
                OTHERCOND = a5.OTHERCOND,
                OTHCONDX = a5.OTHCONDX,
                MAJORDEP = a5.MAJORDEP,
                OTHERDEP = a5.OTHERDEP,
                DEPRTREAT = a5.DEPRTREAT,
                BIPOLAR = a5.BIPOLAR,
                SCHIZ = a5.SCHIZ,
                ANXIETY = a5.ANXIETY,
                GENERALANX = a5.GENERALANX,
                PANICDIS = a5.PANICDIS,
                OCD = a5.OCD,
                OTHANXDIS = a5.OTHANXDIS,
                OTHANXDISX = a5.OTHANXDISX,
                PTSD = a5.PTSD,
                NPSYDEV = a5.NPSYDEV,
                PSYCDIS = a5.PSYCDIS,
                PSYCDISX = a5.PSYCDISX,
                MENARCHE = a5.MENARCHE,
                NOMENSAGE = a5.NOMENSAGE,
                NOMENSNAT = a5.NOMENSNAT,
                NOMENSHYST = a5.NOMENSHYST,
                NOMENSSURG = a5.NOMENSSURG,
                NOMENSCHEM = a5.NOMENSCHEM,
                NOMENSRAD = a5.NOMENSRAD,
                NOMENSHORM = a5.NOMENSHORM,
                NOMENSESTR = a5.NOMENSESTR,
                NOMENSUNK = a5.NOMENSUNK,
                NOMENSOTH = a5.NOMENSOTH,
                NOMENSOTHX = a5.NOMENSOTHX,
                HRT = a5.HRT,
                HRTYEARS = a5.HRTYEARS,
                HRTSTRTAGE = a5.HRTSTRTAGE,
                HRTENDAGE = a5.HRTENDAGE,
                BCPILLS = a5.BCPILLS,
                BCPILLSYR = a5.BCPILLSYR,
                BCSTARTAGE = a5.BCSTARTAGE,
                BCENDAGE = a5.BCENDAGE
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
                WAIST1 = b1.WAIST1,
                WAIST2 = b1.WAIST2,
                HIP1 = b1.HIP1,
                HIP2 = b1.HIP2,
                BPSYSL1 = b1.BPSYSL1,
                BPDIASL1 = b1.BPDIASL1,
                BPSYSL2 = b1.BPSYSL2,
                BPDIASL2 = b1.BPDIASL2,
                BPSYSR1 = b1.BPSYSR1,
                BPDIASR1 = b1.BPDIASR1,
                BPSYSR2 = b1.BPSYSR2,
                BPDIASR2 = b1.BPDIASR2,
                HRATE = b1.HRATE
            };
            dto.SetBaseFormProperties(b1);
            return dto;
        }

        public static B3Dto ToFullDto(this B3 b3)
        {
            B3Dto dto = new B3Dto
            {
                PDNORMAL = b3.PDNORMAL,
                SPEECH = b3.SPEECH,
                SPEECHX = b3.SPEECHX,
                FACEXP = b3.FACEXP,
                FACEXPX = b3.FACEXPX,
                TRESTFAC = b3.TRESTFAC,
                TRESTFAX = b3.TRESTFAX,
                TRESTRHD = b3.TRESTRHD,
                TRESTRHX = b3.TRESTRHX,
                TRESTLHD = b3.TRESTLHD,
                TRESTLHX = b3.TRESTLHX,
                TRESTRFT = b3.TRESTRFT,
                TRESTRFX = b3.TRESTRFX,
                TRESTLFT = b3.TRESTLFT,
                TRESTLFX = b3.TRESTLFX,
                TRACTRHD = b3.TRACTRHD,
                TRACTRHX = b3.TRACTRHX,
                TRACTLHD = b3.TRACTLHD,
                TRACTLHX = b3.TRACTLHX,
                RIGDNECK = b3.RIGDNECK,
                RIGDNEX = b3.RIGDNEX,
                RIGDUPRT = b3.RIGDUPRT,
                RIGDUPRX = b3.RIGDUPRX,
                RIGDUPLF = b3.RIGDUPLF,
                RIGDUPLX = b3.RIGDUPLX,
                RIGDLORT = b3.RIGDLORT,
                RIGDLORX = b3.RIGDLORX,
                RIGDLOLF = b3.RIGDLOLF,
                RIGDLOLX = b3.RIGDLOLX,
                TAPSRT = b3.TAPSRT,
                TAPSRTX = b3.TAPSRTX,
                TAPSLF = b3.TAPSLF,
                TAPSLFX = b3.TAPSLFX,
                HANDMOVR = b3.HANDMOVR,
                HANDMVRX = b3.HANDMVRX,
                HANDMOVL = b3.HANDMOVL,
                HANDMVLX = b3.HANDMVLX,
                HANDALTR = b3.HANDALTR,
                HANDATRX = b3.HANDATRX,
                HANDALTL = b3.HANDALTL,
                HANDATLX = b3.HANDATLX,
                LEGRT = b3.LEGRT,
                LEGRTX = b3.LEGRTX,
                LEGLF = b3.LEGLF,
                LEGLFX = b3.LEGLFX,
                ARISING = b3.ARISING,
                ARISINGX = b3.ARISINGX,
                POSTURE = b3.POSTURE,
                POSTUREX = b3.POSTUREX,
                GAIT = b3.GAIT,
                GAITX = b3.GAITX,
                POSSTAB = b3.POSSTAB,
                POSSTABX = b3.POSSTABX,
                BRADYKIN = b3.BRADYKIN,
                BRADYKIX = b3.BRADYKIX,
                TOTALUPDRS = b3.TOTALUPDRS
            };
            dto.SetBaseFormProperties(b3);
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
                NEUREXAM = b8.NEUREXAM,
                NORMNREXAM = b8.NORMNREXAM,
                PARKSIGN = b8.PARKSIGN,
                SLOWINGFM = b8.SLOWINGFM,
                TREMREST = b8.TREMREST,
                TREMPOST = b8.TREMPOST,
                TREMKINE = b8.TREMKINE,
                RIGIDARM = b8.RIGIDARM,
                RIGIDLEG = b8.RIGIDLEG,
                DYSTARM = b8.DYSTARM,
                DYSTLEG = b8.DYSTLEG,
                CHOREA = b8.CHOREA,
                AMPMOTOR = b8.AMPMOTOR,
                AXIALRIG = b8.AXIALRIG,
                POSTINST = b8.POSTINST,
                MASKING = b8.MASKING,
                STOOPED = b8.STOOPED,
                OTHERSIGN = b8.OTHERSIGN,
                LIMBAPRAX = b8.LIMBAPRAX,
                UMNDIST = b8.UMNDIST,
                LMNDIST = b8.LMNDIST,
                VFIELDCUT = b8.VFIELDCUT,
                LIMBATAX = b8.LIMBATAX,
                MYOCLON = b8.MYOCLON,
                UNISOMATO = b8.UNISOMATO,
                APHASIA = b8.APHASIA,
                ALIENLIMB = b8.ALIENLIMB,
                HSPATNEG = b8.HSPATNEG,
                PSPOAGNO = b8.PSPOAGNO,
                SMTAGNO = b8.SMTAGNO,
                OPTICATAX = b8.OPTICATAX,
                APRAXGAZE = b8.APRAXGAZE,
                VHGAZEPAL = b8.VHGAZEPAL,
                DYSARTH = b8.DYSARTH,
                APRAXSP = b8.APRAXSP,
                GAITABN = b8.GAITABN,
                GAITFIND = b8.GAITFIND,
                GAITOTHRX = b8.GAITOTHRX
            };
            dto.SetBaseFormProperties(b8);
            return dto;
        }

        public static B9Dto ToFullDto(this B9 b9)
        {
            B9Dto dto = new B9Dto
            {
                DECCOG = b9.DECCOG,
                DECMOT = b9.DECMOT,
                PSYCHSYM = b9.PSYCHSYM,
                DECCOGIN = b9.DECCOGIN,
                DECMOTIN = b9.DECMOTIN,
                PSYCHSYMIN = b9.PSYCHSYMIN,
                DECCLIN = b9.DECCLIN,
                DECCLCOG = b9.DECCLCOG,
                COGMEM = b9.COGMEM,
                COGORI = b9.COGORI,
                COGJUDG = b9.COGJUDG,
                COGLANG = b9.COGLANG,
                COGVIS = b9.COGVIS,
                COGATTN = b9.COGATTN,
                COGFLUC = b9.COGFLUC,
                COGOTHR = b9.COGOTHR,
                COGOTHRX = b9.COGOTHRX,
                COGAGE = b9.COGAGE,
                COGMODE = b9.COGMODE,
                COGMODEX = b9.COGMODEX,
                DECCLBE = b9.DECCLBE,
                BEAPATHY = b9.BEAPATHY,
                BEDEP = b9.BEDEP,
                BEANX = b9.BEANX,
                BEEUPH = b9.BEEUPH,
                BEIRRIT = b9.BEIRRIT,
                BEAGIT = b9.BEAGIT,
                BEHAGE = b9.BEHAGE,
                BEVHALL = b9.BEVHALL,
                BEVPATT = b9.BEVPATT,
                BEVWELL = b9.BEVWELL,
                BEAHALL = b9.BEAHALL,
                BEAHSIMP = b9.BEAHSIMP,
                BEAHCOMP = b9.BEAHCOMP,
                BEDEL = b9.BEDEL,
                BEAGGRS = b9.BEAGGRS,
                PSYCHAGE = b9.PSYCHAGE,
                BEDISIN = b9.BEDISIN,
                BEPERCH = b9.BEPERCH,
                BEEMPATH = b9.BEEMPATH,
                BEOBCOM = b9.BEOBCOM,
                BEANGER = b9.BEANGER,
                BESUBAB = b9.BESUBAB,
                ALCUSE = b9.ALCUSE,
                SEDUSE = b9.SEDUSE,
                OPIATEUSE = b9.OPIATEUSE,
                COCAINEUSE = b9.COCAINEUSE,
                CANNABUSE = b9.CANNABUSE,
                OTHSUBUSE = b9.OTHSUBUSE,
                OTHSUBUSEX = b9.OTHSUBUSEX,
                PERCHAGE = b9.PERCHAGE,
                BEREM = b9.BEREM,
                BEREMAGO = b9.BEREMAGO,
                BEREMCONF = b9.BEREMCONF,
                BEOTHR = b9.BEOTHR,
                BEOTHRX = b9.BEOTHRX,
                BEMODE = b9.BEMODE,
                BEMODEX = b9.BEMODEX,
                DECCLMOT = b9.DECCLMOT,
                MOGAIT = b9.MOGAIT,
                MOFALLS = b9.MOFALLS,
                MOSLOW = b9.MOSLOW,
                MOTREM = b9.MOTREM,
                MOLIMB = b9.MOLIMB,
                MOFACE = b9.MOFACE,
                MOSPEECH = b9.MOSPEECH,
                MOTORAGE = b9.MOTORAGE,
                MOMODE = b9.MOMODE,
                MOMODEX = b9.MOMODEX,
                MOMOPARK = b9.MOMOPARK,
                MOMOALS = b9.MOMOALS,
                COURSE = b9.COURSE,
                FRSTCHG = b9.FRSTCHG
            };
            dto.SetBaseFormProperties(b9);
            return dto;
        }

        [Obsolete]
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
                UDSBENTC = c2.UDSBENTC,
                DIGFORCT = c2.DIGFORCT,
                DIGFORSL = c2.DIGFORSL,
                DIGBACCT = c2.DIGBACCT,
                DIGBACLS = c2.DIGBACLS,
                ANIMALS = c2.ANIMALS,
                VEG = c2.VEG,
                TRAILA = c2.TRAILA,
                TRAILARR = c2.TRAILARR,
                TRAILALI = c2.TRAILALI,
                TRAILB = c2.TRAILB,
                TRAILBRR = c2.TRAILBRR,
                TRAILBLI = c2.TRAILBLI,
                UDSBENTD = c2.UDSBENTD,
                UDSBENRS = c2.UDSBENRS,
                CRAFTDVR = c2.CRAFTDVR,
                CRAFTDRE = c2.CRAFTDRE,
                CRAFTDTI = c2.CRAFTDTI,
                CRAFTCUE = c2.CRAFTCUE,
                UDSVERFC = c2.UDSVERFC,
                UDSVERFN = c2.UDSVERFN,
                UDSVERNF = c2.UDSVERNF,
                UDSVERLC = c2.UDSVERLC,
                UDSVERLR = c2.UDSVERLR,
                UDSVERLN = c2.UDSVERLN,
                UDSVERTN = c2.UDSVERTN,
                UDSVERTE = c2.UDSVERTE,
                UDSVERTI = c2.UDSVERTI,
                VERBALTEST = c2.VERBALTEST,
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
                REYBINT = c2.REYBINT,
                REYBREC = c2.REYBREC,
                REY6REC = c2.REY6REC,
                REY6INT = c2.REY6INT,
                REYDREC = c2.REYDREC,
                REYDINT = c2.REYDINT,
                REYDTI = c2.REYDTI,
                REYMETHOD = c2.REYMETHOD,
                REYTCOR = c2.REYTCOR,
                REYFPOS = c2.REYFPOS,
                CERAD1REC = c2.CERAD1REC,
                CERAD1READ = c2.CERAD1READ,
                CERAD1INT = c2.CERAD1INT,
                CERAD2REC = c2.CERAD2REC,
                CERAD2READ = c2.CERAD2READ,
                CERAD2INT = c2.CERAD2INT,
                CERAD3REC = c2.CERAD3REC,
                CERAD3READ = c2.CERAD3READ,
                CERAD3INT = c2.CERAD3INT,
                CERADDTI = c2.CERADDTI,
                CERADJ6REC = c2.CERADJ6REC,
                CERADJ6INT = c2.CERADJ6INT,
                CERADJ7YES = c2.CERADJ7YES,
                CERADJ7NO = c2.CERADJ7NO,
                MINTTOTS = c2.MINTTOTS,
                MINTTOTW = c2.MINTTOTW,
                MINTSCNG = c2.MINTSCNG,
                MINTSCNC = c2.MINTSCNC,
                MINTPCNG = c2.MINTPCNG,
                MINTPCNC = c2.MINTPCNC,
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
                RESPOTHX = c2.RESPOTHX
            };
            dto.SetBaseFormProperties(c2);
            return dto;
        }

        public static D1aDto ToFullDto(this D1a d1a)
        {
            D1aDto dto = new D1aDto
            {
                DXMETHOD = d1a.DXMETHOD,
                NORMCOG = d1a.NORMCOG,
                SCD = d1a.SCD,
                SCDDXCONF = d1a.SCDDXCONF,
                DEMENTED = d1a.DEMENTED,
                MCICRITCLN = d1a.MCICRITCLN,
                MCICRITIMP = d1a.MCICRITIMP,
                MCICRITFUN = d1a.MCICRITFUN,
                MCI = d1a.MCI,
                IMPNOMCIFU = d1a.IMPNOMCIFU,
                IMPNOMCICG = d1a.IMPNOMCICG,
                IMPNOMCLCD = d1a.IMPNOMCLCD,
                IMPNOMCIO = d1a.IMPNOMCIO,
                IMPNOMCIOX = d1a.IMPNOMCIOX,
                IMPNOMCI = d1a.IMPNOMCI,
                CDOMMEM = d1a.CDOMMEM,
                CDOMLANG = d1a.CDOMLANG,
                CDOMATTN = d1a.CDOMATTN,
                CDOMEXEC = d1a.CDOMEXEC,
                CDOMVISU = d1a.CDOMVISU,
                CDOMBEH = d1a.CDOMBEH,
                CDOMAPRAX = d1a.CDOMAPRAX,
                MBI = d1a.MBI,
                BDOMMOT = d1a.BDOMMOT,
                BDOMAFREG = d1a.BDOMAFREG,
                BDOMIMP = d1a.BDOMIMP,
                BDOMSOCIAL = d1a.BDOMSOCIAL,
                BDOMTHTS = d1a.BDOMTHTS,
                PREDOMSYN = d1a.PREDOMSYN,
                AMNDEM = d1a.AMNDEM,
                DYEXECSYN = d1a.DYEXECSYN,
                PCA = d1a.PCA,
                PPASYN = d1a.PPASYN,
                PPASYNT = d1a.PPASYNT,
                FTDSYN = d1a.FTDSYN,
                LBDSYN = d1a.LBDSYN,
                LBDSYNT = d1a.LBDSYNT,
                NAMNDEM = d1a.NAMNDEM,
                PSPSYN = d1a.PSPSYN,
                PSPSYNT = d1a.PSPSYNT,
                CTESYN = d1a.CTESYN,
                CBSSYN = d1a.CBSSYN,
                MSASYN = d1a.MSASYN,
                MSASYNT = d1a.MSASYNT,
                OTHSYN = d1a.OTHSYN,
                OTHSYNX = d1a.OTHSYNX,
                SYNINFCLIN = d1a.SYNINFCLIN,
                SYNINFCTST = d1a.SYNINFCTST,
                SYNINFBIOM = d1a.SYNINFBIOM,
                MAJDEPDX = d1a.MAJDEPDX,
                MAJDEPDIF = d1a.MAJDEPDIF,
                OTHDEPDX = d1a.OTHDEPDX,
                OTHDEPDIF = d1a.OTHDEPDIF,
                BIPOLDX = d1a.BIPOLDX,
                BIPOLDIF = d1a.BIPOLDIF,
                SCHIZOP = d1a.SCHIZOP,
                SCHIZOIF = d1a.SCHIZOIF,
                ANXIET = d1a.ANXIET,
                ANXIETIF = d1a.ANXIETIF,
                GENANX = d1a.GENANX,
                PANICDISDX = d1a.PANICDISDX,
                OCDDX = d1a.OCDDX,
                OTHANXD = d1a.OTHANXD,
                OTHANXDX = d1a.OTHANXDX,
                PTSDDX = d1a.PTSDDX,
                PTSDDXIF = d1a.PTSDDXIF,
                NDEVDIS = d1a.NDEVDIS,
                NDEVDISIF = d1a.NDEVDISIF,
                DELIR = d1a.DELIR,
                DELIRIF = d1a.DELIRIF,
                OTHPSY = d1a.OTHPSY,
                OTHPSYIF = d1a.OTHPSYIF,
                OTHPSYX = d1a.OTHPSYX,
                TBIDX = d1a.TBIDX,
                TBIDXIF = d1a.TBIDXIF,
                EPILEP = d1a.EPILEP,
                EPILEPIF = d1a.EPILEPIF,
                HYCEPH = d1a.HYCEPH,
                HYCEPHIF = d1a.HYCEPHIF,
                NEOP = d1a.NEOP,
                NEOPIF = d1a.NEOPIF,
                NEOPSTAT = d1a.NEOPSTAT,
                HIV = d1a.HIV,
                HIVIF = d1a.HIVIF,
                POSTC19 = d1a.POSTC19,
                POSTC19IF = d1a.POSTC19IF,
                APNEADX = d1a.APNEADX,
                APNEADXIF = d1a.APNEADXIF,
                OTHCOGILL = d1a.OTHCOGILL,
                OTHCILLIF = d1a.OTHCILLIF,
                OTHCOGILLX = d1a.OTHCOGILLX,
                ALCDEM = d1a.ALCDEM,
                ALCDEMIF = d1a.ALCDEMIF,
                IMPSUB = d1a.IMPSUB,
                IMPSUBIF = d1a.IMPSUBIF,
                MEDS = d1a.MEDS,
                MEDSIF = d1a.MEDSIF,
                COGOTH = d1a.COGOTH,
                COGOTHIF = d1a.COGOTHIF,
                COGOTHX = d1a.COGOTHX,
                COGOTH2 = d1a.COGOTH2,
                COGOTH2F = d1a.COGOTH2F,
                COGOTH2X = d1a.COGOTH2X,
                COGOTH3 = d1a.COGOTH3,
                COGOTH3F = d1a.COGOTH3F,
                COGOTH3X = d1a.COGOTH3X,

            };
            dto.SetBaseFormProperties(d1a);
            return dto;

        }

        public static D1bDto ToFullDto(this D1b d1b)
        {
            D1bDto dto = new D1bDto
            {
                BIOMARKDX = d1b.BIOMARKDX,
                FLUIDBIOM = d1b.FLUIDBIOM,
                BLOODAD = d1b.BLOODAD,
                BLOODFTLD = d1b.BLOODFTLD,
                BLOODLBD = d1b.BLOODLBD,
                BLOODOTH = d1b.BLOODOTH,
                BLOODOTHX = d1b.BLOODOTHX,
                CSFAD = d1b.CSFAD,
                CSFFTLD = d1b.CSFFTLD,
                CSFLBD = d1b.CSFLBD,
                CSFOTH = d1b.CSFOTH,
                CSFOTHX = d1b.CSFOTHX,
                IMAGINGDX = d1b.IMAGINGDX,
                PETDX = d1b.PETDX,
                AMYLPET = d1b.AMYLPET,
                TAUPET = d1b.TAUPET,
                FDGPETDX = d1b.FDGPETDX,
                FDGAD = d1b.FDGAD,
                FDGFTLD = d1b.FDGFTLD,
                FDGLBD = d1b.FDGLBD,
                FDGOTH = d1b.FDGOTH,
                FDGOTHX = d1b.FDGOTHX,
                DATSCANDX = d1b.DATSCANDX,
                TRACOTHDX = d1b.TRACOTHDX,
                TRACOTHDXX = d1b.TRACOTHDXX,
                TRACERAD = d1b.TRACERAD,
                TRACERFTLD = d1b.TRACERFTLD,
                TRACERLBD = d1b.TRACERLBD,
                TRACEROTH = d1b.TRACEROTH,
                TRACEROTHX = d1b.TRACEROTHX,
                STRUCTDX = d1b.STRUCTDX,
                STRUCTAD = d1b.STRUCTAD,
                STRUCTFTLD = d1b.STRUCTFTLD,
                STRUCTCVD = d1b.STRUCTCVD,
                IMAGLINF = d1b.IMAGLINF,
                IMAGLAC = d1b.IMAGLAC,
                IMAGMACH = d1b.IMAGMACH,
                IMAGMICH = d1b.IMAGMICH,
                IMAGMWMH = d1b.IMAGMWMH,
                IMAGEWMH = d1b.IMAGEWMH,
                OTHBIOM1 = d1b.OTHBIOM1,
                OTHBIOMX1 = d1b.OTHBIOMX1,
                BIOMAD1 = d1b.BIOMAD1,
                BIOMFTLD1 = d1b.BIOMFTLD1,
                BIOMLBD1 = d1b.BIOMLBD1,
                BIOMOTH1 = d1b.BIOMOTH1,
                BIOMOTHX1 = d1b.BIOMOTHX1,
                OTHBIOM2 = d1b.OTHBIOM2,
                OTHBIOMX2 = d1b.OTHBIOMX2,
                BIOMAD2 = d1b.BIOMAD2,
                BIOMFTLD2 = d1b.BIOMFTLD2,
                BIOMLBD2 = d1b.BIOMLBD2,
                BIOMOTH2 = d1b.BIOMOTH2,
                BIOMOTHX2 = d1b.BIOMOTHX2,
                OTHBIOM3 = d1b.OTHBIOM3,
                OTHBIOMX3 = d1b.OTHBIOMX3,
                BIOMAD3 = d1b.BIOMAD3,
                BIOMFTLD3 = d1b.BIOMFTLD3,
                BIOMLBD3 = d1b.BIOMLBD3,
                BIOMOTH3 = d1b.BIOMOTH3,
                BIOMOTHX3 = d1b.BIOMOTHX3,
                AUTDOMMUT = d1b.AUTDOMMUT,
                ALZDIS = d1b.ALZDIS,
                ALZDISIF = d1b.ALZDISIF,
                LBDIS = d1b.LBDIS,
                LBDIF = d1b.LBDIF,
                FTLD = d1b.FTLD,
                FTLDIF = d1b.FTLDIF,
                PSP = d1b.PSP,
                PSPIF = d1b.PSPIF,
                CORT = d1b.CORT,
                CORTIF = d1b.CORTIF,
                FTLDMO = d1b.FTLDMO,
                FTLDMOIF = d1b.FTLDMOIF,
                FTLDNOS = d1b.FTLDNOS,
                FTLDNOIF = d1b.FTLDNOIF,
                FTLDSUBT = d1b.FTLDSUBT,
                FTLDSUBX = d1b.FTLDSUBX,
                CVD = d1b.CVD,
                CVDIF = d1b.CVDIF,
                MSA = d1b.MSA,
                MSAIF = d1b.MSAIF,
                CTE = d1b.CTE,
                CTEIF = d1b.CTEIF,
                DOWNS = d1b.DOWNS,
                DOWNSIF = d1b.DOWNSIF,
                HUNT = d1b.HUNT,
                HUNTIF = d1b.HUNTIF,
                PRION = d1b.PRION,
                PRIONIF = d1b.PRIONIF,
                CAA = d1b.CAA,
                CAAIF = d1b.CAAIF,
                LATE = d1b.LATE,
                LATEIF = d1b.LATEIF,
                OTHCOG = d1b.OTHCOG,
                OTHCOGIF = d1b.OTHCOGIF,
                OTHCOGX = d1b.OTHCOGX,

            };
            dto.SetBaseFormProperties(d1b);
            return dto;
        }

        [Obsolete]
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
                IsDeleted = m1.IsDeleted,
                MILESTONETYPE = m1.MILESTONETYPE
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
                LastVisitNumber = participation.Visits != null ? (participation.Visits.Any() ? participation.Visits.OrderByDescending(v => v.VISITNUM).Select(v => v.VISITNUM).First() : 0) : 0
            };

            return dto;
        }

        public static DrugCodeDto ToDto(this DrugCodeLookup drugCode)
        {
            return new DrugCodeDto
            {
                RxNormId = drugCode.RxNormId,
                DrugName = drugCode.DrugName,
                BrandName = drugCode.BrandNames,
                IsOverTheCounter = drugCode.IsOverTheCounter,
                IsPopular = drugCode.IsPopular
            };
        }

        public static List<PacketSubmissionDto> ToDto(this List<PacketSubmission> packetSubmissions)
        {
            List<PacketSubmissionDto> dto = new List<PacketSubmissionDto>();

            if (packetSubmissions != null && packetSubmissions.Count() > 0)
            {
                dto = packetSubmissions.Select(p => p.ToDto()).ToList();
            }

            return dto;
        }

        public static PacketSubmissionDto ToDto(this PacketSubmission packetSubmission)
        {
            var dto = new PacketSubmissionDto
            {
                Id = packetSubmission.Id,
                VisitId = packetSubmission.VisitId,
                SubmissionDate = packetSubmission.SubmissionDate,
                CreatedAt = packetSubmission.CreatedAt,
                CreatedBy = packetSubmission.CreatedBy,
                ModifiedBy = packetSubmission.ModifiedBy,
                IsDeleted = packetSubmission.IsDeleted,
                DeletedBy = packetSubmission.DeletedBy
            };

            if (packetSubmission.PacketSubmissionErrors != null && packetSubmission.PacketSubmissionErrors.Count() > 0)
            {
                dto.ErrorCount = packetSubmission.ErrorCount;
                dto.PacketSubmissionErrors = packetSubmission.PacketSubmissionErrors.ToDto();
            }

            return dto;
        }

        public static List<PacketSubmissionErrorDto> ToDto(this List<PacketSubmissionError> packetSubmissionErrors)
        {
            List<PacketSubmissionErrorDto> dto = new List<PacketSubmissionErrorDto>();

            if (packetSubmissionErrors != null && packetSubmissionErrors.Count() > 0)
            {
                dto = packetSubmissionErrors.Select(e => e.ToDto()).ToList();
            }

            return dto;
        }

        public static PacketSubmissionErrorDto ToDto(this PacketSubmissionError packetSubmissionError)
        {
            return new PacketSubmissionErrorDto()
            {
                Id = packetSubmissionError.Id,
                PacketSubmissionId = packetSubmissionError.PacketSubmissionId,
                FormKind = packetSubmissionError.FormKind,
                Level = packetSubmissionError.Level.ToString(),
                Message = packetSubmissionError.Message,
                AssignedTo = packetSubmissionError.AssignedTo,
                ResolvedBy = packetSubmissionError.ResolvedBy,
                CreatedAt = packetSubmissionError.CreatedAt,
                CreatedBy = packetSubmissionError.CreatedBy,
                ModifiedBy = packetSubmissionError.ModifiedBy,
                IsDeleted = packetSubmissionError.IsDeleted,
                DeletedBy = packetSubmissionError.DeletedBy
            };
        }
    }
}

