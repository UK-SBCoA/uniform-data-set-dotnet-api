using System.Net.NetworkInformation;
using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class DtoToEntityMapper
    {
        private static void SetBaseProperties(this Form entity, FormDto dto)
        {
            entity.CreatedAt = dto.CreatedAt;
            entity.CreatedBy = dto.CreatedBy;
            entity.ModifiedBy = dto.ModifiedBy;
            entity.DeletedBy = dto.DeletedBy;
            entity.IsDeleted = dto.IsDeleted;
            entity.Status = dto.Status;

            if (dto.INITIALS == null)
                entity.INITIALS = string.Empty; // INITIALS can't be null, so use empty string
            else
                entity.INITIALS = dto.INITIALS;

            if (dto.FRMDATE > DateTime.MinValue)
                entity.FRMDATE = dto.FRMDATE;
            else
                entity.FRMDATE = dto.CreatedAt;

            if (String.IsNullOrWhiteSpace(dto.LANG))
                entity.LANG = null;
            else
            {
                if (Enum.TryParse(dto.LANG, true, out Language language))
                    entity.LANG = language;
            }

            if (String.IsNullOrWhiteSpace(dto.MODE))
                entity.MODE = null;
            else
            {
                if (Enum.TryParse(dto.MODE, true, out FormMode mode))
                    entity.MODE = mode;
            }

            if (String.IsNullOrWhiteSpace(dto.RMREAS))
                entity.RMREAS = null;
            else
            {
                if (Enum.TryParse(dto.RMREAS, true, out RemoteReasonCode code))
                    entity.RMREAS = code;
            }

            if (String.IsNullOrWhiteSpace(dto.RMMODE))
                entity.RMMODE = null;
            else
            {
                if (Enum.TryParse(dto.RMMODE, true, out RemoteMode remoteMode))
                    entity.RMMODE = remoteMode;
            }

            if (String.IsNullOrWhiteSpace(dto.NOT))
                entity.NOT = null;
            else
            {
                if (Enum.TryParse(dto.NOT, true, out NotIncludedReasonCode reasonCode))
                    entity.NOT = reasonCode;
            }
        }

        public static Visit Convert(this VisitDto dto)
        {
            var visit = new Visit
            {
                PACKET = dto.PACKET,
                VISITNUM = dto.VISITNUM,
                FORMVER = dto.FORMVER,
                VISIT_DATE = dto.VISIT_DATE,
                INITIALS = dto.INITIALS,
                CreatedBy = dto.CreatedBy,
                CreatedAt = dto.CreatedAt,
                ModifiedBy = dto.ModifiedBy,
                IsDeleted = dto.IsDeleted,
                DeletedBy = dto.DeletedBy,
                ParticipationId = dto.ParticipationId
            };

            if (!string.IsNullOrWhiteSpace(dto.Status))
            {
                if (Enum.TryParse(dto.Status, true, out PacketStatus status))
                    visit.Status = status;
            }

            return visit;
        }

        public static bool Update(this Visit entity, VisitDto dto)
        {
            if (entity != null)
            {
                // Only some properties are allowed to be updated
                if (!string.IsNullOrWhiteSpace(dto.Status))
                {
                    if (Enum.TryParse(dto.Status, true, out PacketStatus status))
                        entity.Status = status;
                }

                entity.VISIT_DATE = dto.VISIT_DATE;
                entity.INITIALS = dto.INITIALS;
                entity.ModifiedBy = dto.ModifiedBy;
                entity.DeletedBy = dto.DeletedBy;
                entity.IsDeleted = dto.IsDeleted;
                return true;
            }
            return false;
        }

        public static PacketSubmission Convert(this PacketSubmissionDto dto)
        {
            return new PacketSubmission
            {
                Id = dto.Id,
                VisitId = dto.VisitId,
                SubmissionDate = dto.SubmissionDate,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                ModifiedBy = dto.ModifiedBy,
                IsDeleted = dto.IsDeleted,
                DeletedBy = dto.DeletedBy,
                PacketSubmissionErrors = dto.PacketSubmissionErrors.Select(e => e.Convert()).ToList()
            };
        }

        public static PacketSubmissionError Convert(this PacketSubmissionErrorDto dto)
        {
            var entity = new PacketSubmissionError
            {
                Id = dto.Id,
                PacketSubmissionId = dto.PacketSubmissionId,
                FormKind = dto.FormKind,
                Message = dto.Message,
                AssignedTo = dto.AssignedTo,
                ResolvedBy = dto.ResolvedBy,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                ModifiedBy = dto.ModifiedBy,
                IsDeleted = dto.IsDeleted,
                DeletedBy = dto.DeletedBy
            };

            if (!string.IsNullOrWhiteSpace(dto.Level))
            {
                if (Enum.TryParse(dto.Level, true, out PacketSubmissionErrorLevel level))
                    entity.Level = level;
            }

            return entity;
        }

        public static M1 ToEntity(this M1Dto dto)
        {
            return new M1
            {
                ParticipationId = dto.ParticipationId,
                FormId = dto.FormId,
                Status = dto.Status,
                CHANGEMO = dto.CHANGEMO,
                CHANGEDY = dto.CHANGEDY,
                CHANGEYR = dto.CHANGEYR,
                PROTOCOL = dto.PROTOCOL,
                ACONSENT = dto.ACONSENT,
                RECOGIM = dto.RECOGIM,
                REPHYILL = dto.REPHYILL,
                REREFUSE = dto.REREFUSE,
                RENAVAIL = dto.RENAVAIL,
                RENURSE = dto.RENURSE,
                NURSEMO = dto.NURSEMO,
                NURSEDY = dto.NURSEDY,
                NURSEYR = dto.NURSEYR,
                REJOIN = dto.REJOIN,
                FTLDDISC = dto.FTLDDISC,
                FTLDREAS = dto.FTLDREAS,
                FTLDREAX = dto.FTLDREAX,
                DECEASED = dto.DECEASED,
                DISCONT = dto.DISCONT,
                DEATHMO = dto.DEATHMO,
                DEATHDY = dto.DEATHDY,
                DEATHYR = dto.DEATHYR,
                AUTOPSY = dto.AUTOPSY,
                DISCMO = dto.DISCMO,
                DISCDAY = dto.DISCDAY,
                DISCYR = dto.DISCYR,
                DROPREAS = dto.DROPREAS,
                CreatedAt = dto.CreatedAt,
                CreatedBy = dto.CreatedBy,
                ModifiedBy = dto.ModifiedBy,
                DeletedBy = dto.DeletedBy,
                IsDeleted = dto.IsDeleted,
                MILESTONETYPE = dto.MILESTONETYPE
            };
        }

        public static bool Update(this A1 entity, A1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.BIRTHMO = dto.BIRTHMO;
                entity.BIRTHYR = dto.BIRTHYR;
                entity.CHLDHDCTRY = dto.CHLDHDCTRY;
                entity.RACEWHITE = dto.RACEWHITE;
                entity.ETHGERMAN = dto.ETHGERMAN;
                entity.ETHIRISH = dto.ETHIRISH;
                entity.ETHENGLISH = dto.ETHENGLISH;
                entity.ETHITALIAN = dto.ETHITALIAN;
                entity.ETHPOLISH = dto.ETHPOLISH;
                entity.ETHSCOTT = dto.ETHSCOTT;
                entity.ETHWHIOTH = dto.ETHWHIOTH;
                entity.ETHWHIOTHX = dto.ETHWHIOTHX;
                entity.ETHISPANIC = dto.ETHISPANIC;
                entity.ETHMEXICAN = dto.ETHMEXICAN;
                entity.ETHPUERTO = dto.ETHPUERTO;
                entity.ETHCUBAN = dto.ETHCUBAN;
                entity.ETHSALVA = dto.ETHSALVA;
                entity.ETHDOMIN = dto.ETHDOMIN;
                entity.ETHGUATEM = dto.ETHGUATEM;
                entity.ETHHISOTH = dto.ETHHISOTH;
                entity.ETHHISOTHX = dto.ETHHISOTHX;
                entity.RACEBLACK = dto.RACEBLACK;
                entity.ETHAFAMER = dto.ETHAFAMER;
                entity.ETHJAMAICA = dto.ETHJAMAICA;
                entity.ETHHAITIAN = dto.ETHHAITIAN;
                entity.ETHNIGERIA = dto.ETHNIGERIA;
                entity.ETHETHIOP = dto.ETHETHIOP;
                entity.ETHSOMALI = dto.ETHSOMALI;
                entity.ETHBLKOTH = dto.ETHBLKOTH;
                entity.ETHBLKOTHX = dto.ETHBLKOTHX;
                entity.RACEASIAN = dto.RACEASIAN;
                entity.ETHCHINESE = dto.ETHCHINESE;
                entity.ETHFILIP = dto.ETHFILIP;
                entity.ETHINDIA = dto.ETHINDIA;
                entity.ETHVIETNAM = dto.ETHVIETNAM;
                entity.ETHKOREAN = dto.ETHKOREAN;
                entity.ETHJAPAN = dto.ETHJAPAN;
                entity.ETHASNOTH = dto.ETHASNOTH;
                entity.ETHASNOTHX = dto.ETHASNOTHX;
                entity.RACEAIAN = dto.RACEAIAN;
                entity.RACEAIANX = dto.RACEAIANX;
                entity.RACEMENA = dto.RACEMENA;
                entity.ETHLEBANON = dto.ETHLEBANON;
                entity.ETHIRAN = dto.ETHIRAN;
                entity.ETHEGYPT = dto.ETHEGYPT;
                entity.ETHSYRIA = dto.ETHSYRIA;
                entity.ETHIRAQI = dto.ETHIRAQI;
                entity.ETHISRAEL = dto.ETHISRAEL;
                entity.ETHMENAOTH = dto.ETHMENAOTH;
                entity.ETHMENAOTX = dto.ETHMENAOTX;
                entity.RACENHPI = dto.RACENHPI;
                entity.ETHHAWAII = dto.ETHHAWAII;
                entity.ETHSAMOAN = dto.ETHSAMOAN;
                entity.ETHCHAMOR = dto.ETHCHAMOR;
                entity.ETHTONGAN = dto.ETHTONGAN;
                entity.ETHFIJIAN = dto.ETHFIJIAN;
                entity.ETHMARSHAL = dto.ETHMARSHAL;
                entity.ETHNHPIOTH = dto.ETHNHPIOTH;
                entity.ETHNHPIOTX = dto.ETHNHPIOTX;
                entity.RACEUNKN = dto.RACEUNKN;
                entity.GENMAN = dto.GENMAN;
                entity.GENWOMAN = dto.GENWOMAN;
                entity.GENTRMAN = dto.GENTRMAN;
                entity.GENTRWOMAN = dto.GENTRWOMAN;
                entity.GENNONBI = dto.GENNONBI;
                entity.GENTWOSPIR = dto.GENTWOSPIR;
                entity.GENOTH = dto.GENOTH;
                entity.GENOTHX = dto.GENOTHX;
                entity.GENDKN = dto.GENDKN;
                entity.GENNOANS = dto.GENNOANS;
                entity.BIRTHSEX = dto.BIRTHSEX;
                entity.INTERSEX = dto.INTERSEX;
                entity.SEXORNGAY = dto.SEXORNGAY;
                entity.SEXORNHET = dto.SEXORNHET;
                entity.SEXORNBI = dto.SEXORNBI;
                entity.SEXORNTWOS = dto.SEXORNTWOS;
                entity.SEXORNOTH = dto.SEXORNOTH;
                entity.SEXORNOTHX = dto.SEXORNOTHX;
                entity.SEXORNDNK = dto.SEXORNDNK;
                entity.SEXORNNOAN = dto.SEXORNNOAN;
                entity.PREDOMLAN = dto.PREDOMLAN;
                entity.PREDOMLANX = dto.PREDOMLANX;
                entity.HANDED = dto.HANDED;
                entity.EDUC = dto.EDUC;
                entity.LVLEDUC = dto.LVLEDUC;
                entity.MARISTAT = dto.MARISTAT;
                entity.LIVSITUA = dto.LIVSITUA;
                entity.RESIDENC = dto.RESIDENC;
                entity.ZIP = dto.ZIP;
                entity.SERVED = dto.SERVED;
                entity.MEDVA = dto.MEDVA;
                entity.EXRTIME = dto.EXRTIME;
                entity.MEMWORS = dto.MEMWORS;
                entity.MEMTROUB = dto.MEMTROUB;
                entity.MEMTEN = dto.MEMTEN;
                entity.ADISTATE = dto.ADISTATE;
                entity.ADINAT = dto.ADINAT;
                entity.PRIOCC = dto.PRIOCC;
                entity.SOURCENW = dto.SOURCENW;
                entity.REFERSC = dto.REFERSC;
                entity.REFERSCX = dto.REFERSCX;
                entity.REFLEARNED = dto.REFLEARNED;
                entity.REFCTRSOCX = dto.REFCTRSOCX;
                entity.REFCTRREGX = dto.REFCTRREGX;
                entity.REFOTHWEBX = dto.REFOTHWEBX;
                entity.REFOTHMEDX = dto.REFOTHMEDX;
                entity.REFOTHREGX = dto.REFOTHREGX;
                entity.REFOTHX = dto.REFOTHX;

                return true;
            }
            return false;
        }

        public static bool Update(this A1a entity, A1aDto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.OWNSCAR = dto.OWNSCAR;
                entity.TRSPACCESS = dto.TRSPACCESS;
                entity.TRANSPROB = dto.TRANSPROB;
                entity.TRANSWORRY = dto.TRANSWORRY;
                entity.TRSPLONGER = dto.TRSPLONGER;
                entity.TRSPMED = dto.TRSPMED;
                entity.INCOMEYR = dto.INCOMEYR;
                entity.FINSATIS = dto.FINSATIS;
                entity.BILLPAY = dto.BILLPAY;
                entity.FINUPSET = dto.FINUPSET;
                entity.EATLESS = dto.EATLESS;
                entity.EATLESSYR = dto.EATLESSYR;
                entity.LESSMEDS = dto.LESSMEDS;
                entity.LESSMEDSYR = dto.LESSMEDSYR;
                entity.COMPCOMM = dto.COMPCOMM;
                entity.COMPUSA = dto.COMPUSA;
                entity.FAMCOMP = dto.FAMCOMP;
                entity.GUARDEDU = dto.GUARDEDU;
                entity.GUARDREL = dto.GUARDREL;
                entity.GUARDRELX = dto.GUARDRELX;
                entity.GUARD2EDU = dto.GUARD2EDU;
                entity.GUARD2REL = dto.GUARD2REL;
                entity.GUARD2RELX = dto.GUARD2RELX;
                entity.EMPTINESS = dto.EMPTINESS;
                entity.MISSPEOPLE = dto.MISSPEOPLE;
                entity.FRIENDS = dto.FRIENDS;
                entity.ABANDONED = dto.ABANDONED;
                entity.CLOSEFRND = dto.CLOSEFRND;
                entity.PARENTCOMM = dto.PARENTCOMM;
                entity.CHILDCOMM = dto.CHILDCOMM;
                entity.FRIENDCOMM = dto.FRIENDCOMM;
                entity.PARTICIPATE = dto.PARTICIPATE;
                entity.SAFEHOME = dto.SAFEHOME;
                entity.SAFECOMM = dto.SAFECOMM;
                entity.DELAYMED = dto.DELAYMED;
                entity.SCRIPTPROB = dto.SCRIPTPROB;
                entity.MISSEDFUP = dto.MISSEDFUP;
                entity.DOCADVICE = dto.DOCADVICE;
                entity.HEALTHACC = dto.HEALTHACC;
                entity.LESSCOURT = dto.LESSCOURT;
                entity.POORSERV = dto.POORSERV;
                entity.NOTSMART = dto.NOTSMART;
                entity.ACTAFRAID = dto.ACTAFRAID;
                entity.THREATENED = dto.THREATENED;
                entity.POORMEDTRT = dto.POORMEDTRT;
                entity.EXPANCEST = dto.EXPANCEST;
                entity.EXPGENDER = dto.EXPGENDER;
                entity.EXPRACE = dto.EXPRACE;
                entity.EXPAGE = dto.EXPAGE;
                entity.EXPRELIG = dto.EXPRELIG;
                entity.EXPHEIGHT = dto.EXPHEIGHT;
                entity.EXPWEIGHT = dto.EXPWEIGHT;
                entity.EXPAPPEAR = dto.EXPAPPEAR;
                entity.EXPSEXORN = dto.EXPSEXORN;
                entity.EXPEDUCINC = dto.EXPEDUCINC;
                entity.EXPDISAB = dto.EXPDISAB;
                entity.EXPSKIN = dto.EXPSKIN;
                entity.EXPOTHER = dto.EXPOTHER;
                entity.EXPNOTAPP = dto.EXPNOTAPP;
                entity.EXPNOANS = dto.EXPNOANS;
                entity.EXPSTRS = dto.EXPSTRS;

                return true;
            }
            return false;
        }

        public static bool Update(this A2 entity, A2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.NEWINF = dto.NEWINF;
                entity.INRELTO = dto.INRELTO;
                entity.INKNOWN = dto.INKNOWN;
                entity.INLIVWTH = dto.INLIVWTH;
                entity.INCNTMOD = dto.INCNTMOD;
                entity.INCNTMDX = dto.INCNTMDX;
                entity.INCNTFRQ = dto.INCNTFRQ;
                entity.INCNTTIM = dto.INCNTTIM;
                entity.INRELY = dto.INRELY;
                entity.INMEMWORS = dto.INMEMWORS;
                entity.INMEMTROUB = dto.INMEMTROUB;
                entity.INMEMTEN = dto.INMEMTEN;


                return true;
            }
            return false;
        }

        public static bool Update(this A3 entity, A3Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.AFFFAMM = dto.AFFFAMM;
                entity.NWINFMUT = dto.NWINFMUT;
                entity.MOMYOB = dto.MOMYOB;
                entity.MOMDAGE = dto.MOMDAGE;
                entity.MOMETPR = dto.MOMETPR;
                entity.MOMETSEC = dto.MOMETSEC;
                entity.MOMMEVAL = dto.MOMMEVAL;
                entity.MOMAGEO = dto.MOMAGEO;
                entity.DADYOB = dto.DADYOB;
                entity.DADDAGE = dto.DADDAGE;
                entity.DADETPR = dto.DADETPR;
                entity.DADETSEC = dto.DADETSEC;
                entity.DADMEVAL = dto.DADMEVAL;
                entity.DADAGEO = dto.DADAGEO;
                entity.SIBS = dto.SIBS;
                entity.NWINFSIB = dto.NWINFSIB;
                entity.SIB1.Update(dto.SIB1);
                entity.SIB2.Update(dto.SIB2);
                entity.SIB3.Update(dto.SIB3);
                entity.SIB4.Update(dto.SIB4);
                entity.SIB5.Update(dto.SIB5);
                entity.SIB6.Update(dto.SIB6);
                entity.SIB7.Update(dto.SIB7);
                entity.SIB8.Update(dto.SIB8);
                entity.SIB9.Update(dto.SIB9);
                entity.SIB10.Update(dto.SIB10);
                entity.SIB11.Update(dto.SIB11);
                entity.SIB12.Update(dto.SIB12);
                entity.SIB13.Update(dto.SIB13);
                entity.SIB14.Update(dto.SIB14);
                entity.SIB15.Update(dto.SIB15);
                entity.SIB16.Update(dto.SIB16);
                entity.SIB17.Update(dto.SIB17);
                entity.SIB18.Update(dto.SIB18);
                entity.SIB19.Update(dto.SIB19);
                entity.SIB20.Update(dto.SIB20);
                entity.KIDS = dto.KIDS;
                entity.NWINFKID = dto.NWINFKID;
                entity.KID1.Update(dto.KID1);
                entity.KID2.Update(dto.KID2);
                entity.KID3.Update(dto.KID3);
                entity.KID4.Update(dto.KID4);
                entity.KID5.Update(dto.KID5);
                entity.KID6.Update(dto.KID6);
                entity.KID7.Update(dto.KID7);
                entity.KID8.Update(dto.KID8);
                entity.KID9.Update(dto.KID9);
                entity.KID10.Update(dto.KID10);
                entity.KID11.Update(dto.KID11);
                entity.KID12.Update(dto.KID12);
                entity.KID13.Update(dto.KID13);
                entity.KID14.Update(dto.KID14);
                entity.KID15.Update(dto.KID15);
            }
            return false;
        }

        public static bool Update(this A3FamilyMember entity, A3FamilyMemberDto dto)
        {
            if (dto != null)
            {
                entity.YOB = dto.YOB;
                entity.AGD = dto.AGD;
                entity.ETPR = dto.ETPR;
                entity.ETSEC = dto.ETSEC;
                entity.MEVAL = dto.MEVAL;
                entity.AGO = dto.AGO;
            }

            return true;
        }

        public static bool Update(this A4 entity, A4Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);
                entity.ANYMEDS = dto.ANYMEDS;

                // reset entity
                entity.RXNORMID1 = new A4D();
                entity.RXNORMID2 = new A4D();
                entity.RXNORMID3 = new A4D();
                entity.RXNORMID4 = new A4D();
                entity.RXNORMID5 = new A4D();
                entity.RXNORMID6 = new A4D();
                entity.RXNORMID7 = new A4D();
                entity.RXNORMID8 = new A4D();
                entity.RXNORMID9 = new A4D();
                entity.RXNORMID10 = new A4D();
                entity.RXNORMID11 = new A4D();
                entity.RXNORMID12 = new A4D();
                entity.RXNORMID13 = new A4D();
                entity.RXNORMID14 = new A4D();
                entity.RXNORMID15 = new A4D();
                entity.RXNORMID16 = new A4D();
                entity.RXNORMID17 = new A4D();
                entity.RXNORMID18 = new A4D();
                entity.RXNORMID19 = new A4D();
                entity.RXNORMID20 = new A4D();
                entity.RXNORMID21 = new A4D();
                entity.RXNORMID22 = new A4D();
                entity.RXNORMID23 = new A4D();
                entity.RXNORMID24 = new A4D();
                entity.RXNORMID25 = new A4D();
                entity.RXNORMID26 = new A4D();
                entity.RXNORMID27 = new A4D();
                entity.RXNORMID28 = new A4D();
                entity.RXNORMID29 = new A4D();
                entity.RXNORMID30 = new A4D();
                entity.RXNORMID31 = new A4D();
                entity.RXNORMID32 = new A4D();
                entity.RXNORMID33 = new A4D();
                entity.RXNORMID34 = new A4D();
                entity.RXNORMID35 = new A4D();
                entity.RXNORMID36 = new A4D();
                entity.RXNORMID37 = new A4D();
                entity.RXNORMID38 = new A4D();
                entity.RXNORMID39 = new A4D();
                entity.RXNORMID40 = new A4D();

                const int MAXINUMRECORDCOUNT = 40; // dto allows an infinite list, but we can only persist and send 40 to NACC
                if (dto.ANYMEDS.HasValue && dto.ANYMEDS.Value == 1)
                {
                    for (int i = 0; i < dto.A4DetailsDtos.Count && i < MAXINUMRECORDCOUNT; i++)
                    {
                        var details = entity.GetType().GetProperty("RXNORMID" + (i + 1))?.GetValue(entity);

                        details.GetType().GetProperty("RxNormId").SetValue(details, dto.A4DetailsDtos[i]);
                    }
                }
            }
            return false;
        }

        public static bool Update(this A4a entity, A4aDto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);
                entity.TRTBIOMARK = dto.TRTBIOMARK;
                entity.ADVEVENT = dto.ADVEVENT;
                entity.ARIAE = dto.ARIAE;
                entity.ARIAH = dto.ARIAH;
                entity.ADVERSEOTH = dto.ADVERSEOTH;
                entity.ADVERSEOTX = dto.ADVERSEOTX;

                entity.Treatment1.Update(dto.Treatment1);
                entity.Treatment2.Update(dto.Treatment2);
                entity.Treatment3.Update(dto.Treatment3);
                entity.Treatment4.Update(dto.Treatment4);
                entity.Treatment5.Update(dto.Treatment5);
                entity.Treatment6.Update(dto.Treatment6);
                entity.Treatment7.Update(dto.Treatment7);
                entity.Treatment8.Update(dto.Treatment8);
            }
            return false;
        }

        public static bool Update(this A4aTreatment entity, A4aTreatmentDto dto)
        {
            if (dto != null)
            {
                entity.TARGETAB = dto.TARGETAB;
                entity.TARGETTAU = dto.TARGETTAU;
                entity.TARGETINF = dto.TARGETINF;
                entity.TARGETSYN = dto.TARGETSYN;
                entity.TARGETOTH = dto.TARGETOTH;
                entity.TARGETOTX = dto.TARGETOTX;
                entity.TRTTRIAL = dto.TRTTRIAL;
                entity.NCTNUM = dto.NCTNUM;
                entity.STARTMO = dto.STARTMO;
                entity.STARTYEAR = dto.STARTYEAR;
                entity.ENDMO = dto.ENDMO;
                entity.ENDYEAR = dto.ENDYEAR;
                entity.CARETRIAL = dto.CARETRIAL;
                entity.TRIALGRP = dto.TRIALGRP;
            }
            return true;
        }

        public static bool Update(this A5D2 entity, A5D2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.TOBAC100 = dto.TOBAC100;
                entity.SMOKYRS = dto.SMOKYRS;
                entity.PACKSPER = dto.PACKSPER;
                entity.TOBAC30 = dto.TOBAC30;
                entity.QUITSMOK = dto.QUITSMOK;
                entity.ALCFREQYR = dto.ALCFREQYR;
                entity.ALCDRINKS = dto.ALCDRINKS;
                entity.ALCBINGE = dto.ALCBINGE;
                entity.SUBSTYEAR = dto.SUBSTYEAR;
                entity.SUBSTPAST = dto.SUBSTPAST;
                entity.CANNABIS = dto.CANNABIS;
                entity.HRTATTACK = dto.HRTATTACK;
                entity.HRTATTMULT = dto.HRTATTMULT;
                entity.HRTATTAGE = dto.HRTATTAGE;
                entity.CARDARREST = dto.CARDARREST;
                entity.CARDARRAGE = dto.CARDARRAGE;
                entity.CVAFIB = dto.CVAFIB;
                entity.CVANGIO = dto.CVANGIO;
                entity.CVBYPASS = dto.CVBYPASS;
                entity.BYPASSAGE = dto.BYPASSAGE;
                entity.CVPACDEF = dto.CVPACDEF;
                entity.PACDEFAGE = dto.PACDEFAGE;
                entity.CVCHF = dto.CVCHF;
                entity.CVHVALVE = dto.CVHVALVE;
                entity.VALVEAGE = dto.VALVEAGE;
                entity.CVOTHR = dto.CVOTHR;
                entity.CVOTHRX = dto.CVOTHRX;
                entity.CBSTROKE = dto.CBSTROKE;
                entity.STROKMUL = dto.STROKMUL;
                entity.STROKAGE = dto.STROKAGE;
                entity.STROKSTAT = dto.STROKSTAT;
                entity.ANGIOCP = dto.ANGIOCP;
                entity.CAROTIDAGE = dto.CAROTIDAGE;
                entity.CBTIA = dto.CBTIA;
                entity.TIAAGE = dto.TIAAGE;
                entity.PD = dto.PD;
                entity.PDAGE = dto.PDAGE;
                entity.PDOTHR = dto.PDOTHR;
                entity.PDOTHRAGE = dto.PDOTHRAGE;
                entity.SEIZURES = dto.SEIZURES;
                entity.SEIZNUM = dto.SEIZNUM;
                entity.SEIZAGE = dto.SEIZAGE;
                entity.HEADACHE = dto.HEADACHE;
                entity.MS = dto.MS;
                entity.HYDROCEPH = dto.HYDROCEPH;
                entity.HEADIMP = dto.HEADIMP;
                entity.IMPAMFOOT = dto.IMPAMFOOT;
                entity.IMPSOCCER = dto.IMPSOCCER;
                entity.IMPHOCKEY = dto.IMPHOCKEY;
                entity.IMPBOXING = dto.IMPBOXING;
                entity.IMPSPORT = dto.IMPSPORT;
                entity.IMPIPV = dto.IMPIPV;
                entity.IMPMILIT = dto.IMPMILIT;
                entity.IMPASSAULT = dto.IMPASSAULT;
                entity.IMPOTHER = dto.IMPOTHER;
                entity.IMPOTHERX = dto.IMPOTHERX;
                entity.IMPYEARS = dto.IMPYEARS;
                entity.HEADINJURY = dto.HEADINJURY;
                entity.HEADINJUNC = dto.HEADINJUNC;
                entity.HEADINJCON = dto.HEADINJCON;
                entity.HEADINJNUM = dto.HEADINJNUM;
                entity.FIRSTTBI = dto.FIRSTTBI;
                entity.LASTTBI = dto.LASTTBI;
                entity.DIABETES = dto.DIABETES;
                entity.DIABTYPE = dto.DIABTYPE;
                entity.DIABINS = dto.DIABINS;
                entity.DIABMEDS = dto.DIABMEDS;
                entity.DIABGLP1 = dto.DIABGLP1;
                entity.DIABRECACT = dto.DIABRECACT;
                entity.DIABDIET = dto.DIABDIET;
                entity.DIABUNK = dto.DIABUNK;
                entity.DIABAGE = dto.DIABAGE;
                entity.HYPERTEN = dto.HYPERTEN;
                entity.HYPERTAGE = dto.HYPERTAGE;
                entity.HYPERCHO = dto.HYPERCHO;
                entity.HYPERCHAGE = dto.HYPERCHAGE;
                entity.B12DEF = dto.B12DEF;
                entity.THYROID = dto.THYROID;
                entity.ARTHRIT = dto.ARTHRIT;
                entity.ARTHRRHEUM = dto.ARTHRRHEUM;
                entity.ARTHROSTEO = dto.ARTHROSTEO;
                entity.ARTHROTHR = dto.ARTHROTHR;
                entity.ARTHTYPX = dto.ARTHTYPX;
                entity.ARTHTYPUNK = dto.ARTHTYPUNK;
                entity.ARTHUPEX = dto.ARTHUPEX;
                entity.ARTHLOEX = dto.ARTHLOEX;
                entity.ARTHSPIN = dto.ARTHSPIN;
                entity.ARTHUNK = dto.ARTHUNK;
                entity.INCONTU = dto.INCONTU;
                entity.INCONTF = dto.INCONTF;
                entity.APNEA = dto.APNEA;
                entity.CPAP = dto.CPAP;
                entity.APNEAORAL = dto.APNEAORAL;
                entity.RBD = dto.RBD;
                entity.INSOMN = dto.INSOMN;
                entity.OTHSLEEP = dto.OTHSLEEP;
                entity.OTHSLEEX = dto.OTHSLEEX;
                entity.CANCERACTV = dto.CANCERACTV;
                entity.CANCERPRIM = dto.CANCERPRIM;
                entity.CANCERMETA = dto.CANCERMETA;
                entity.CANCMETBR = dto.CANCMETBR;
                entity.CANCMETOTH = dto.CANCMETOTH;
                entity.CANCERUNK = dto.CANCERUNK;
                entity.CANCBLOOD = dto.CANCBLOOD;
                entity.CANCBREAST = dto.CANCBREAST;
                entity.CANCCOLON = dto.CANCCOLON;
                entity.CANCLUNG = dto.CANCLUNG;
                entity.CANCPROST = dto.CANCPROST;
                entity.CANCOTHER = dto.CANCOTHER;
                entity.CANCOTHERX = dto.CANCOTHERX;
                entity.CANCRAD = dto.CANCRAD;
                entity.CANCRESECT = dto.CANCRESECT;
                entity.CANCIMMUNO = dto.CANCIMMUNO;
                entity.CANCBONE = dto.CANCBONE;
                entity.CANCCHEMO = dto.CANCCHEMO;
                entity.CANCHORM = dto.CANCHORM;
                entity.CANCTROTH = dto.CANCTROTH;
                entity.CANCTROTHX = dto.CANCTROTHX;
                entity.CANCERAGE = dto.CANCERAGE;
                entity.COVID19 = dto.COVID19;
                entity.COVIDHOSP = dto.COVIDHOSP;
                entity.PULMONARY = dto.PULMONARY;
                entity.KIDNEY = dto.KIDNEY;
                entity.KIDNEYAGE = dto.KIDNEYAGE;
                entity.LIVER = dto.LIVER;
                entity.LIVERAGE = dto.LIVERAGE;
                entity.PVD = dto.PVD;
                entity.PVDAGE = dto.PVDAGE;
                entity.HIVDIAG = dto.HIVDIAG;
                entity.HIVAGE = dto.HIVAGE;
                entity.OTHERCOND = dto.OTHERCOND;
                entity.OTHCONDX = dto.OTHCONDX;
                entity.MAJORDEP = dto.MAJORDEP;
                entity.OTHERDEP = dto.OTHERDEP;
                entity.DEPRTREAT = dto.DEPRTREAT;
                entity.BIPOLAR = dto.BIPOLAR;
                entity.SCHIZ = dto.SCHIZ;
                entity.ANXIETY = dto.ANXIETY;
                entity.GENERALANX = dto.GENERALANX;
                entity.PANICDIS = dto.PANICDIS;
                entity.OCD = dto.OCD;
                entity.OTHANXDIS = dto.OTHANXDIS;
                entity.OTHANXDISX = dto.OTHANXDISX;
                entity.PTSD = dto.PTSD;
                entity.NPSYDEV = dto.NPSYDEV;
                entity.PSYCDIS = dto.PSYCDIS;
                entity.PSYCDISX = dto.PSYCDISX;
                entity.MENARCHE = dto.MENARCHE;
                entity.NOMENSAGE = dto.NOMENSAGE;
                entity.NOMENSNAT = dto.NOMENSNAT;
                entity.NOMENSHYST = dto.NOMENSHYST;
                entity.NOMENSSURG = dto.NOMENSSURG;
                entity.NOMENSCHEM = dto.NOMENSCHEM;
                entity.NOMENSRAD = dto.NOMENSRAD;
                entity.NOMENSHORM = dto.NOMENSHORM;
                entity.NOMENSESTR = dto.NOMENSESTR;
                entity.NOMENSUNK = dto.NOMENSUNK;
                entity.NOMENSOTH = dto.NOMENSOTH;
                entity.NOMENSOTHX = dto.NOMENSOTHX;
                entity.HRT = dto.HRT;
                entity.HRTYEARS = dto.HRTYEARS;
                entity.HRTSTRTAGE = dto.HRTSTRTAGE;
                entity.HRTENDAGE = dto.HRTENDAGE;
                entity.BCPILLS = dto.BCPILLS;
                entity.BCPILLSYR = dto.BCPILLSYR;
                entity.BCSTARTAGE = dto.BCSTARTAGE;
                entity.BCENDAGE = dto.BCENDAGE;

                return true;
            }

            return false;
        }

        public static bool Update(this B1 entity, B1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.HEIGHT = dto.HEIGHT;
                entity.WEIGHT = dto.WEIGHT;
                entity.WAIST1 = dto.WAIST1;
                entity.WAIST2 = dto.WAIST2;
                entity.HIP1 = dto.HIP1;
                entity.HIP2 = dto.HIP2;
                entity.BPSYSL1 = dto.BPSYSL1;
                entity.BPDIASL1 = dto.BPDIASL1;
                entity.BPSYSL2 = dto.BPSYSL2;
                entity.BPDIASL2 = dto.BPDIASL2;
                entity.BPSYSR1 = dto.BPSYSR1;
                entity.BPDIASR1 = dto.BPDIASR1;
                entity.BPSYSR2 = dto.BPSYSR2;
                entity.BPDIASR2 = dto.BPDIASR2;
                entity.HRATE = dto.HRATE;

                return true;
            }
            return false;
        }

        public static bool Update(this B3 entity, B3Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.PDNORMAL = dto.PDNORMAL;
                entity.SPEECH = dto.SPEECH;
                entity.SPEECHX = dto.SPEECHX;
                entity.FACEXP = dto.FACEXP;
                entity.FACEXPX = dto.FACEXPX;
                entity.TRESTFAC = dto.TRESTFAC;
                entity.TRESTFAX = dto.TRESTFAX;
                entity.TRESTRHD = dto.TRESTRHD;
                entity.TRESTRHX = dto.TRESTRHX;
                entity.TRESTLHD = dto.TRESTLHD;
                entity.TRESTLHX = dto.TRESTLHX;
                entity.TRESTRFT = dto.TRESTRFT;
                entity.TRESTRFX = dto.TRESTRFX;
                entity.TRESTLFT = dto.TRESTLFT;
                entity.TRESTLFX = dto.TRESTLFX;
                entity.TRACTRHD = dto.TRACTRHD;
                entity.TRACTRHX = dto.TRACTRHX;
                entity.TRACTLHD = dto.TRACTLHD;
                entity.TRACTLHX = dto.TRACTLHX;
                entity.RIGDNECK = dto.RIGDNECK;
                entity.RIGDNEX = dto.RIGDNEX;
                entity.RIGDUPRT = dto.RIGDUPRT;
                entity.RIGDUPRX = dto.RIGDUPRX;
                entity.RIGDUPLF = dto.RIGDUPLF;
                entity.RIGDUPLX = dto.RIGDUPLX;
                entity.RIGDLORT = dto.RIGDLORT;
                entity.RIGDLORX = dto.RIGDLORX;
                entity.RIGDLOLF = dto.RIGDLOLF;
                entity.RIGDLOLX = dto.RIGDLOLX;
                entity.TAPSRT = dto.TAPSRT;
                entity.TAPSRTX = dto.TAPSRTX;
                entity.TAPSLF = dto.TAPSLF;
                entity.TAPSLFX = dto.TAPSLFX;
                entity.HANDMOVR = dto.HANDMOVR;
                entity.HANDMVRX = dto.HANDMVRX;
                entity.HANDMOVL = dto.HANDMOVL;
                entity.HANDMVLX = dto.HANDMVLX;
                entity.HANDALTR = dto.HANDALTR;
                entity.HANDATRX = dto.HANDATRX;
                entity.HANDALTL = dto.HANDALTL;
                entity.HANDATLX = dto.HANDATLX;
                entity.LEGRT = dto.LEGRT;
                entity.LEGRTX = dto.LEGRTX;
                entity.LEGLF = dto.LEGLF;
                entity.LEGLFX = dto.LEGLFX;
                entity.ARISING = dto.ARISING;
                entity.ARISINGX = dto.ARISINGX;
                entity.POSTURE = dto.POSTURE;
                entity.POSTUREX = dto.POSTUREX;
                entity.GAIT = dto.GAIT;
                entity.GAITX = dto.GAITX;
                entity.POSSTAB = dto.POSSTAB;
                entity.POSSTABX = dto.POSSTABX;
                entity.BRADYKIN = dto.BRADYKIN;
                entity.BRADYKIX = dto.BRADYKIX;
                entity.TOTALUPDRS = dto.TOTALUPDRS;

                return true;
            }
            return false;
        }

        public static bool Update(this B4 entity, B4Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.MEMORY = dto.MEMORY;
                entity.ORIENT = dto.ORIENT;
                entity.JUDGMENT = dto.JUDGMENT;
                entity.COMMUN = dto.COMMUN;
                entity.HOMEHOBB = dto.HOMEHOBB;
                entity.PERSCARE = dto.PERSCARE;
                entity.CDRSUM = dto.CDRSUM;
                entity.CDRGLOB = dto.CDRGLOB;
                entity.COMPORT = dto.COMPORT;
                entity.CDRLANG = dto.CDRLANG;

                return true;
            }
            return false;
        }

        public static bool Update(this B5 entity, B5Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.NPIQINF = dto.NPIQINF;
                entity.NPIQINFX = dto.NPIQINFX;
                entity.DEL = dto.DEL;
                entity.DELSEV = dto.DELSEV;
                entity.HALL = dto.HALL;
                entity.HALLSEV = dto.HALLSEV;
                entity.AGIT = dto.AGIT;
                entity.AGITSEV = dto.AGITSEV;
                entity.DEPD = dto.DEPD;
                entity.DEPDSEV = dto.DEPDSEV;
                entity.ANX = dto.ANX;
                entity.ANXSEV = dto.ANXSEV;
                entity.ELAT = dto.ELAT;
                entity.ELATSEV = dto.ELATSEV;
                entity.APA = dto.APA;
                entity.APASEV = dto.APASEV;
                entity.DISN = dto.DISN;
                entity.DISNSEV = dto.DISNSEV;
                entity.IRR = dto.IRR;
                entity.IRRSEV = dto.IRRSEV;
                entity.MOT = dto.MOT;
                entity.MOTSEV = dto.MOTSEV;
                entity.NITE = dto.NITE;
                entity.NITESEV = dto.NITESEV;
                entity.APP = dto.APP;
                entity.APPSEV = dto.APPSEV;

                return true;
            }
            return false;
        }

        public static bool Update(this B6 entity, B6Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.NOGDS = dto.NOGDS;
                entity.SATIS = dto.SATIS;
                entity.DROPACT = dto.DROPACT;
                entity.EMPTY = dto.EMPTY;
                entity.BORED = dto.BORED;
                entity.SPIRITS = dto.SPIRITS;
                entity.AFRAID = dto.AFRAID;
                entity.HAPPY = dto.HAPPY;
                entity.HELPLESS = dto.HELPLESS;
                entity.STAYHOME = dto.STAYHOME;
                entity.MEMPROB = dto.MEMPROB;
                entity.WONDRFUL = dto.WONDRFUL;
                entity.WRTHLESS = dto.WRTHLESS;
                entity.ENERGY = dto.ENERGY;
                entity.HOPELESS = dto.HOPELESS;
                entity.BETTER = dto.BETTER;
                entity.GDS = dto.GDS;

                return true;
            }
            return false;
        }

        public static bool Update(this B7 entity, B7Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.BILLS = dto.BILLS;
                entity.TAXES = dto.TAXES;
                entity.SHOPPING = dto.SHOPPING;
                entity.GAMES = dto.GAMES;
                entity.STOVE = dto.STOVE;
                entity.MEALPREP = dto.MEALPREP;
                entity.EVENTS = dto.EVENTS;
                entity.PAYATTN = dto.PAYATTN;
                entity.REMDATES = dto.REMDATES;
                entity.TRAVEL = dto.TRAVEL;

                return true;
            }
            return false;
        }

        public static bool Update(this B8 entity, B8Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.NEUREXAM = dto.NEUREXAM;
                entity.NORMNREXAM = dto.NORMNREXAM;
                entity.PARKSIGN = dto.PARKSIGN;
                entity.SLOWINGFM = dto.SLOWINGFM;
                entity.TREMREST = dto.TREMREST;
                entity.TREMPOST = dto.TREMPOST;
                entity.TREMKINE = dto.TREMKINE;
                entity.RIGIDARM = dto.RIGIDARM;
                entity.RIGIDLEG = dto.RIGIDLEG;
                entity.DYSTARM = dto.DYSTARM;
                entity.DYSTLEG = dto.DYSTLEG;
                entity.CHOREA = dto.CHOREA;
                entity.AMPMOTOR = dto.AMPMOTOR;
                entity.AXIALRIG = dto.AXIALRIG;
                entity.POSTINST = dto.POSTINST;
                entity.MASKING = dto.MASKING;
                entity.STOOPED = dto.STOOPED;
                entity.OTHERSIGN = dto.OTHERSIGN;
                entity.LIMBAPRAX = dto.LIMBAPRAX;
                entity.UMNDIST = dto.UMNDIST;
                entity.LMNDIST = dto.LMNDIST;
                entity.VFIELDCUT = dto.VFIELDCUT;
                entity.LIMBATAX = dto.LIMBATAX;
                entity.MYOCLON = dto.MYOCLON;
                entity.UNISOMATO = dto.UNISOMATO;
                entity.APHASIA = dto.APHASIA;
                entity.ALIENLIMB = dto.ALIENLIMB;
                entity.HSPATNEG = dto.HSPATNEG;
                entity.PSPOAGNO = dto.PSPOAGNO;
                entity.SMTAGNO = dto.SMTAGNO;
                entity.OPTICATAX = dto.OPTICATAX;
                entity.APRAXGAZE = dto.APRAXGAZE;
                entity.VHGAZEPAL = dto.VHGAZEPAL;
                entity.DYSARTH = dto.DYSARTH;
                entity.APRAXSP = dto.APRAXSP;
                entity.GAITABN = dto.GAITABN;
                entity.GAITFIND = dto.GAITFIND;
                entity.GAITOTHRX = dto.GAITOTHRX;

                return true;
            }
            return false;
        }

        public static bool Update(this B9 entity, B9Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.DECCOG = dto.DECCOG;
                entity.DECMOT = dto.DECMOT;
                entity.PSYCHSYM = dto.PSYCHSYM;
                entity.DECCOGIN = dto.DECCOGIN;
                entity.DECMOTIN = dto.DECMOTIN;
                entity.PSYCHSYMIN = dto.PSYCHSYMIN;
                entity.DECCLIN = dto.DECCLIN;
                entity.DECCLCOG = dto.DECCLCOG;
                entity.COGMEM = dto.COGMEM;
                entity.COGORI = dto.COGORI;
                entity.COGJUDG = dto.COGJUDG;
                entity.COGLANG = dto.COGLANG;
                entity.COGVIS = dto.COGVIS;
                entity.COGATTN = dto.COGATTN;
                entity.COGFLUC = dto.COGFLUC;
                entity.COGOTHR = dto.COGOTHR;
                entity.COGOTHRX = dto.COGOTHRX;
                entity.COGAGE = dto.COGAGE;
                entity.COGMODE = dto.COGMODE;
                entity.COGMODEX = dto.COGMODEX;
                entity.DECCLBE = dto.DECCLBE;
                entity.BEAPATHY = dto.BEAPATHY;
                entity.BEDEP = dto.BEDEP;
                entity.BEANX = dto.BEANX;
                entity.BEEUPH = dto.BEEUPH;
                entity.BEIRRIT = dto.BEIRRIT;
                entity.BEAGIT = dto.BEAGIT;
                entity.BEHAGE = dto.BEHAGE;
                entity.BEVHALL = dto.BEVHALL;
                entity.BEVPATT = dto.BEVPATT;
                entity.BEVWELL = dto.BEVWELL;
                entity.BEAHALL = dto.BEAHALL;
                entity.BEAHSIMP = dto.BEAHSIMP;
                entity.BEAHCOMP = dto.BEAHCOMP;
                entity.BEDEL = dto.BEDEL;
                entity.BEAGGRS = dto.BEAGGRS;
                entity.PSYCHAGE = dto.PSYCHAGE;
                entity.BEDISIN = dto.BEDISIN;
                entity.BEPERCH = dto.BEPERCH;
                entity.BEEMPATH = dto.BEEMPATH;
                entity.BEOBCOM = dto.BEOBCOM;
                entity.BEANGER = dto.BEANGER;
                entity.BESUBAB = dto.BESUBAB;
                entity.ALCUSE = dto.ALCUSE;
                entity.SEDUSE = dto.SEDUSE;
                entity.OPIATEUSE = dto.OPIATEUSE;
                entity.COCAINEUSE = dto.COCAINEUSE;
                entity.CANNABUSE = dto.CANNABUSE;
                entity.OTHSUBUSE = dto.OTHSUBUSE;
                entity.OTHSUBUSEX = dto.OTHSUBUSEX;
                entity.PERCHAGE = dto.PERCHAGE;
                entity.BEREM = dto.BEREM;
                entity.BEREMAGO = dto.BEREMAGO;
                entity.BEREMCONF = dto.BEREMCONF;
                entity.BEOTHR = dto.BEOTHR;
                entity.BEOTHRX = dto.BEOTHRX;
                entity.BEMODE = dto.BEMODE;
                entity.BEMODEX = dto.BEMODEX;
                entity.DECCLMOT = dto.DECCLMOT;
                entity.MOGAIT = dto.MOGAIT;
                entity.MOFALLS = dto.MOFALLS;
                entity.MOSLOW = dto.MOSLOW;
                entity.MOTREM = dto.MOTREM;
                entity.MOLIMB = dto.MOLIMB;
                entity.MOFACE = dto.MOFACE;
                entity.MOSPEECH = dto.MOSPEECH;
                entity.MOTORAGE = dto.MOTORAGE;
                entity.MOMODE = dto.MOMODE;
                entity.MOMODEX = dto.MOMODEX;
                entity.MOMOPARK = dto.MOMOPARK;
                entity.MOMOALS = dto.MOMOALS;
                entity.COURSE = dto.COURSE;
                entity.FRSTCHG = dto.FRSTCHG;

                return true;
            }
            return false;
        }

        [Obsolete]
        public static bool Update(this C1 entity, C1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.MMSECOMP = dto.MMSECOMP;
                entity.MMSEREAS = dto.MMSEREAS;
                entity.MMSELOC = dto.MMSELOC;
                entity.MMSELAN = dto.MMSELAN;
                entity.MMSELANX = dto.MMSELANX;
                entity.MMSEVIS = dto.MMSEVIS;
                entity.MMSEHEAR = dto.MMSEHEAR;
                entity.MMSEORDA = dto.MMSEORDA;
                entity.MMSEORLO = dto.MMSEORLO;
                entity.PENTAGON = dto.PENTAGON;
                entity.MMSE = dto.MMSE;
                entity.NPSYCLOC = dto.NPSYCLOC;
                entity.NPSYLAN = dto.NPSYLAN;
                entity.NPSYLANX = dto.NPSYLANX;
                entity.LOGIMO = dto.LOGIMO;
                entity.LOGIDAY = dto.LOGIDAY;
                entity.LOGIYR = dto.LOGIYR;
                entity.LOGIPREV = dto.LOGIPREV;
                entity.LOGIMEM = dto.LOGIMEM;
                entity.UDSBENTC = dto.UDSBENTC;
                entity.DIGIF = dto.DIGIF;
                entity.DIGIFLEN = dto.DIGIFLEN;
                entity.DIGIB = dto.DIGIB;
                entity.DIGIBLEN = dto.DIGIBLEN;
                entity.ANIMALS = dto.ANIMALS;
                entity.VEG = dto.VEG;
                entity.TRAILA = dto.TRAILA;
                entity.TRAILARR = dto.TRAILARR;
                entity.TRAILALI = dto.TRAILALI;
                entity.TRAILB = dto.TRAILB;
                entity.TRAILBRR = dto.TRAILBRR;
                entity.TRAILBLI = dto.TRAILBLI;
                entity.MEMUNITS = dto.MEMUNITS;
                entity.MEMTIME = dto.MEMTIME;
                entity.UDSBENTD = dto.UDSBENTD;
                entity.UDSBENRS = dto.UDSBENRS;
                entity.BOSTON = dto.BOSTON;
                entity.UDSVERFC = dto.UDSVERFC;
                entity.UDSVERFN = dto.UDSVERFN;
                entity.UDSVERNF = dto.UDSVERNF;
                entity.UDSVERLC = dto.UDSVERLC;
                entity.UDSVERLR = dto.UDSVERLR;
                entity.UDSVERLN = dto.UDSVERLN;
                entity.UDSVERTN = dto.UDSVERTN;
                entity.UDSVERTE = dto.UDSVERTE;
                entity.UDSVERTI = dto.UDSVERTI;
                entity.COGSTAT = dto.COGSTAT;

                return true;
            }
            return false;
        }

        public static bool Update(this C2 entity, C2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.MOCACOMP = dto.MOCACOMP;
                entity.MOCAREAS = dto.MOCAREAS;
                entity.MOCALOC = dto.MOCALOC;
                entity.MOCALAN = dto.MOCALAN;
                entity.MOCALANX = dto.MOCALANX;
                entity.MOCAVIS = dto.MOCAVIS;
                entity.MOCAHEAR = dto.MOCAHEAR;
                entity.MOCATOTS = dto.MOCATOTS;
                entity.MOCATRAI = dto.MOCATRAI;
                entity.MOCACUBE = dto.MOCACUBE;
                entity.MOCACLOC = dto.MOCACLOC;
                entity.MOCACLON = dto.MOCACLON;
                entity.MOCACLOH = dto.MOCACLOH;
                entity.MOCANAMI = dto.MOCANAMI;
                entity.MOCAREGI = dto.MOCAREGI;
                entity.MOCADIGI = dto.MOCADIGI;
                entity.MOCALETT = dto.MOCALETT;
                entity.MOCASER7 = dto.MOCASER7;
                entity.MOCAREPE = dto.MOCAREPE;
                entity.MOCAFLUE = dto.MOCAFLUE;
                entity.MOCAABST = dto.MOCAABST;
                entity.MOCARECN = dto.MOCARECN;
                entity.MOCARECC = dto.MOCARECC;
                entity.MOCARECR = dto.MOCARECR;
                entity.MOCAORDT = dto.MOCAORDT;
                entity.MOCAORMO = dto.MOCAORMO;
                entity.MOCAORYR = dto.MOCAORYR;
                entity.MOCAORDY = dto.MOCAORDY;
                entity.MOCAORPL = dto.MOCAORPL;
                entity.MOCAORCT = dto.MOCAORCT;
                entity.NPSYCLOC = dto.NPSYCLOC;
                entity.NPSYLAN = dto.NPSYLAN;
                entity.NPSYLANX = dto.NPSYLANX;
                entity.CRAFTVRS = dto.CRAFTVRS;
                entity.CRAFTURS = dto.CRAFTURS;
                entity.UDSBENTC = dto.UDSBENTC;
                entity.DIGFORCT = dto.DIGFORCT;
                entity.DIGFORSL = dto.DIGFORSL;
                entity.DIGBACCT = dto.DIGBACCT;
                entity.DIGBACLS = dto.DIGBACLS;
                entity.ANIMALS = dto.ANIMALS;
                entity.VEG = dto.VEG;
                entity.TRAILA = dto.TRAILA;
                entity.TRAILARR = dto.TRAILARR;
                entity.TRAILALI = dto.TRAILALI;
                entity.TRAILB = dto.TRAILB;
                entity.TRAILBRR = dto.TRAILBRR;
                entity.TRAILBLI = dto.TRAILBLI;
                entity.UDSBENTD = dto.UDSBENTD;
                entity.UDSBENRS = dto.UDSBENRS;
                entity.CRAFTDVR = dto.CRAFTDVR;
                entity.CRAFTDRE = dto.CRAFTDRE;
                entity.CRAFTDTI = dto.CRAFTDTI;
                entity.CRAFTCUE = dto.CRAFTCUE;
                entity.UDSVERFC = dto.UDSVERFC;
                entity.UDSVERFN = dto.UDSVERFN;
                entity.UDSVERNF = dto.UDSVERNF;
                entity.UDSVERLC = dto.UDSVERLC;
                entity.UDSVERLR = dto.UDSVERLR;
                entity.UDSVERLN = dto.UDSVERLN;
                entity.UDSVERTN = dto.UDSVERTN;
                entity.UDSVERTE = dto.UDSVERTE;
                entity.UDSVERTI = dto.UDSVERTI;
                entity.VERBALTEST = dto.VERBALTEST;
                entity.REY1REC = dto.REY1REC;
                entity.REY1INT = dto.REY1INT;
                entity.REY2REC = dto.REY2REC;
                entity.REY2INT = dto.REY2INT;
                entity.REY3REC = dto.REY3REC;
                entity.REY3INT = dto.REY3INT;
                entity.REY4REC = dto.REY4REC;
                entity.REY4INT = dto.REY4INT;
                entity.REY5REC = dto.REY5REC;
                entity.REY5INT = dto.REY5INT;
                entity.REYBINT = dto.REYBINT;
                entity.REYBREC = dto.REYBREC;
                entity.REY6REC = dto.REY6REC;
                entity.REY6INT = dto.REY6INT;
                entity.REYDREC = dto.REYDREC;
                entity.REYDINT = dto.REYDINT;
                entity.REYDTI = dto.REYDTI;
                entity.REYMETHOD = dto.REYMETHOD;
                entity.REYTCOR = dto.REYTCOR;
                entity.REYFPOS = dto.REYFPOS;
                entity.CERAD1REC = dto.CERAD1REC;
                entity.CERAD1READ = dto.CERAD1READ;
                entity.CERAD1INT = dto.CERAD1INT;
                entity.CERAD2REC = dto.CERAD2REC;
                entity.CERAD2READ = dto.CERAD2READ;
                entity.CERAD2INT = dto.CERAD2INT;
                entity.CERAD3REC = dto.CERAD3REC;
                entity.CERAD3READ = dto.CERAD3READ;
                entity.CERAD3INT = dto.CERAD3INT;
                entity.CERADDTI = dto.CERADDTI;
                entity.CERADJ6REC = dto.CERADJ6REC;
                entity.CERADJ6INT = dto.CERADJ6INT;
                entity.CERADJ7YES = dto.CERADJ7YES;
                entity.CERADJ7NO = dto.CERADJ7NO;
                entity.MINTTOTS = dto.MINTTOTS;
                entity.MINTTOTW = dto.MINTTOTW;
                entity.MINTSCNG = dto.MINTSCNG;
                entity.MINTSCNC = dto.MINTSCNC;
                entity.MINTPCNG = dto.MINTPCNG;
                entity.MINTPCNC = dto.MINTPCNC;
                entity.COGSTAT = dto.COGSTAT;
                entity.RESPVAL = dto.RESPVAL;
                entity.RESPHEAR = dto.RESPHEAR;
                entity.RESPDIST = dto.RESPDIST;
                entity.RESPINTR = dto.RESPINTR;
                entity.RESPDISN = dto.RESPDISN;
                entity.RESPFATG = dto.RESPFATG;
                entity.RESPEMOT = dto.RESPEMOT;
                entity.RESPASST = dto.RESPASST;
                entity.RESPOTH = dto.RESPOTH;
                entity.RESPOTHX = dto.RESPOTHX;

                return true;
            }
            return false;
        }

        public static bool Update(this D1a entity, D1aDto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.DXMETHOD = dto.DXMETHOD;
                entity.NORMCOG = dto.NORMCOG;
                entity.SCD = dto.SCD;
                entity.SCDDXCONF = dto.SCDDXCONF;
                entity.DEMENTED = dto.DEMENTED;
                entity.MCICRITCLN = dto.MCICRITCLN;
                entity.MCICRITIMP = dto.MCICRITIMP;
                entity.MCICRITFUN = dto.MCICRITFUN;
                entity.MCI = dto.MCI;
                entity.IMPNOMCIFU = dto.IMPNOMCIFU;
                entity.IMPNOMCICG = dto.IMPNOMCICG;
                entity.IMPNOMCLCD = dto.IMPNOMCLCD;
                entity.IMPNOMCIO = dto.IMPNOMCIO;
                entity.IMPNOMCIOX = dto.IMPNOMCIOX;
                entity.IMPNOMCI = dto.IMPNOMCI;
                entity.CDOMMEM = dto.CDOMMEM;
                entity.CDOMLANG = dto.CDOMLANG;
                entity.CDOMATTN = dto.CDOMATTN;
                entity.CDOMEXEC = dto.CDOMEXEC;
                entity.CDOMVISU = dto.CDOMVISU;
                entity.CDOMBEH = dto.CDOMBEH;
                entity.CDOMAPRAX = dto.CDOMAPRAX;
                entity.MBI = dto.MBI;
                entity.BDOMMOT = dto.BDOMMOT;
                entity.BDOMAFREG = dto.BDOMAFREG;
                entity.BDOMIMP = dto.BDOMIMP;
                entity.BDOMSOCIAL = dto.BDOMSOCIAL;
                entity.BDOMTHTS = dto.BDOMTHTS;
                entity.PREDOMSYN = dto.PREDOMSYN;
                entity.AMNDEM = dto.AMNDEM;
                entity.DYEXECSYN = dto.DYEXECSYN;
                entity.PCA = dto.PCA;
                entity.PPASYN = dto.PPASYN;
                entity.PPASYNT = dto.PPASYNT;
                entity.FTDSYN = dto.FTDSYN;
                entity.LBDSYN = dto.LBDSYN;
                entity.LBDSYNT = dto.LBDSYNT;
                entity.NAMNDEM = dto.NAMNDEM;
                entity.PSPSYN = dto.PSPSYN;
                entity.PSPSYNT = dto.PSPSYNT;
                entity.CTESYN = dto.CTESYN;
                entity.CBSSYN = dto.CBSSYN;
                entity.MSASYN = dto.MSASYN;
                entity.MSASYNT = dto.MSASYNT;
                entity.OTHSYN = dto.OTHSYN;
                entity.OTHSYNX = dto.OTHSYNX;
                entity.SYNINFCLIN = dto.SYNINFCLIN;
                entity.SYNINFCTST = dto.SYNINFCTST;
                entity.SYNINFBIOM = dto.SYNINFBIOM;
                entity.MAJDEPDX = dto.MAJDEPDX;
                entity.MAJDEPDIF = dto.MAJDEPDIF;
                entity.OTHDEPDX = dto.OTHDEPDX;
                entity.OTHDEPDIF = dto.OTHDEPDIF;
                entity.BIPOLDX = dto.BIPOLDX;
                entity.BIPOLDIF = dto.BIPOLDIF;
                entity.SCHIZOP = dto.SCHIZOP;
                entity.SCHIZOIF = dto.SCHIZOIF;
                entity.ANXIET = dto.ANXIET;
                entity.ANXIETIF = dto.ANXIETIF;
                entity.GENANX = dto.GENANX;
                entity.PANICDISDX = dto.PANICDISDX;
                entity.OCDDX = dto.OCDDX;
                entity.OTHANXD = dto.OTHANXD;
                entity.OTHANXDX = dto.OTHANXDX;
                entity.PTSDDX = dto.PTSDDX;
                entity.PTSDDXIF = dto.PTSDDXIF;
                entity.NDEVDIS = dto.NDEVDIS;
                entity.NDEVDISIF = dto.NDEVDISIF;
                entity.DELIR = dto.DELIR;
                entity.DELIRIF = dto.DELIRIF;
                entity.OTHPSY = dto.OTHPSY;
                entity.OTHPSYIF = dto.OTHPSYIF;
                entity.OTHPSYX = dto.OTHPSYX;
                entity.TBIDX = dto.TBIDX;
                entity.TBIDXIF = dto.TBIDXIF;
                entity.EPILEP = dto.EPILEP;
                entity.EPILEPIF = dto.EPILEPIF;
                entity.HYCEPH = dto.HYCEPH;
                entity.HYCEPHIF = dto.HYCEPHIF;
                entity.NEOP = dto.NEOP;
                entity.NEOPIF = dto.NEOPIF;
                entity.NEOPSTAT = dto.NEOPSTAT;
                entity.HIV = dto.HIV;
                entity.HIVIF = dto.HIVIF;
                entity.POSTC19 = dto.POSTC19;
                entity.POSTC19IF = dto.POSTC19IF;
                entity.APNEADX = dto.APNEADX;
                entity.APNEADXIF = dto.APNEADXIF;
                entity.OTHCOGILL = dto.OTHCOGILL;
                entity.OTHCILLIF = dto.OTHCILLIF;
                entity.OTHCOGILLX = dto.OTHCOGILLX;
                entity.ALCDEM = dto.ALCDEM;
                entity.ALCDEMIF = dto.ALCDEMIF;
                entity.IMPSUB = dto.IMPSUB;
                entity.IMPSUBIF = dto.IMPSUBIF;
                entity.MEDS = dto.MEDS;
                entity.MEDSIF = dto.MEDSIF;
                entity.COGOTH = dto.COGOTH;
                entity.COGOTHIF = dto.COGOTHIF;
                entity.COGOTHX = dto.COGOTHX;
                entity.COGOTH2 = dto.COGOTH2;
                entity.COGOTH2F = dto.COGOTH2F;
                entity.COGOTH2X = dto.COGOTH2X;
                entity.COGOTH3 = dto.COGOTH3;
                entity.COGOTH3F = dto.COGOTH3F;
                entity.COGOTH3X = dto.COGOTH3X;

                return true;
            }

            return false;

        }

        public static bool Update(this D1b entity, D1bDto dto)
        {

            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.BIOMARKDX = dto.BIOMARKDX;
                entity.FLUIDBIOM = dto.FLUIDBIOM;
                entity.BLOODAD = dto.BLOODAD;
                entity.BLOODFTLD = dto.BLOODFTLD;
                entity.BLOODLBD = dto.BLOODLBD;
                entity.BLOODOTH = dto.BLOODOTH;
                entity.BLOODOTHX = dto.BLOODOTHX;
                entity.CSFAD = dto.CSFAD;
                entity.CSFFTLD = dto.CSFFTLD;
                entity.CSFLBD = dto.CSFLBD;
                entity.CSFOTH = dto.CSFOTH;
                entity.CSFOTHX = dto.CSFOTHX;
                entity.IMAGINGDX = dto.IMAGINGDX;
                entity.PETDX = dto.PETDX;
                entity.AMYLPET = dto.AMYLPET;
                entity.TAUPET = dto.TAUPET;
                entity.FDGPETDX = dto.FDGPETDX;
                entity.FDGAD = dto.FDGAD;
                entity.FDGFTLD = dto.FDGFTLD;
                entity.FDGLBD = dto.FDGLBD;
                entity.FDGOTH = dto.FDGOTH;
                entity.FDGOTHX = dto.FDGOTHX;
                entity.DATSCANDX = dto.DATSCANDX;
                entity.TRACOTHDX = dto.TRACOTHDX;
                entity.TRACOTHDXX = dto.TRACOTHDXX;
                entity.TRACERAD = dto.TRACERAD;
                entity.TRACERFTLD = dto.TRACERFTLD;
                entity.TRACERLBD = dto.TRACERLBD;
                entity.TRACEROTH = dto.TRACEROTH;
                entity.TRACEROTHX = dto.TRACEROTHX;
                entity.STRUCTDX = dto.STRUCTDX;
                entity.STRUCTAD = dto.STRUCTAD;
                entity.STRUCTFTLD = dto.STRUCTFTLD;
                entity.STRUCTCVD = dto.STRUCTCVD;
                entity.IMAGLINF = dto.IMAGLINF;
                entity.IMAGLAC = dto.IMAGLAC;
                entity.IMAGMACH = dto.IMAGMACH;
                entity.IMAGMICH = dto.IMAGMICH;
                entity.IMAGMWMH = dto.IMAGMWMH;
                entity.IMAGEWMH = dto.IMAGEWMH;
                entity.OTHBIOM1 = dto.OTHBIOM1;
                entity.OTHBIOMX1 = dto.OTHBIOMX1;
                entity.BIOMAD1 = dto.BIOMAD1;
                entity.BIOMFTLD1 = dto.BIOMFTLD1;
                entity.BIOMLBD1 = dto.BIOMLBD1;
                entity.BIOMOTH1 = dto.BIOMOTH1;
                entity.BIOMOTHX1 = dto.BIOMOTHX1;
                entity.OTHBIOM2 = dto.OTHBIOM2;
                entity.OTHBIOMX2 = dto.OTHBIOMX2;
                entity.BIOMAD2 = dto.BIOMAD2;
                entity.BIOMFTLD2 = dto.BIOMFTLD2;
                entity.BIOMLBD2 = dto.BIOMLBD2;
                entity.BIOMOTH2 = dto.BIOMOTH2;
                entity.BIOMOTHX2 = dto.BIOMOTHX2;
                entity.OTHBIOM3 = dto.OTHBIOM3;
                entity.OTHBIOMX3 = dto.OTHBIOMX3;
                entity.BIOMAD3 = dto.BIOMAD3;
                entity.BIOMFTLD3 = dto.BIOMFTLD3;
                entity.BIOMLBD3 = dto.BIOMLBD3;
                entity.BIOMOTH3 = dto.BIOMOTH3;
                entity.BIOMOTHX3 = dto.BIOMOTHX3;
                entity.AUTDOMMUT = dto.AUTDOMMUT;
                entity.ALZDIS = dto.ALZDIS;
                entity.ALZDISIF = dto.ALZDISIF;
                entity.LBDIS = dto.LBDIS;
                entity.LBDIF = dto.LBDIF;
                entity.FTLD = dto.FTLD;
                entity.FTLDIF = dto.FTLDIF;
                entity.PSP = dto.PSP;
                entity.PSPIF = dto.PSPIF;
                entity.CORT = dto.CORT;
                entity.CORTIF = dto.CORTIF;
                entity.FTLDMO = dto.FTLDMO;
                entity.FTLDMOIF = dto.FTLDMOIF;
                entity.FTLDNOS = dto.FTLDNOS;
                entity.FTLDNOIF = dto.FTLDNOIF;
                entity.FTLDSUBT = dto.FTLDSUBT;
                entity.FTLDSUBX = dto.FTLDSUBX;
                entity.CVD = dto.CVD;
                entity.CVDIF = dto.CVDIF;
                entity.MSA = dto.MSA;
                entity.MSAIF = dto.MSAIF;
                entity.CTE = dto.CTE;
                entity.CTEIF = dto.CTEIF;
                entity.DOWNS = dto.DOWNS;
                entity.DOWNSIF = dto.DOWNSIF;
                entity.HUNT = dto.HUNT;
                entity.HUNTIF = dto.HUNTIF;
                entity.PRION = dto.PRION;
                entity.PRIONIF = dto.PRIONIF;
                entity.CAA = dto.CAA;
                entity.CAAIF = dto.CAAIF;
                entity.LATE = dto.LATE;
                entity.LATEIF = dto.LATEIF;
                entity.OTHCOG = dto.OTHCOG;
                entity.OTHCOGIF = dto.OTHCOGIF;
                entity.OTHCOGX = dto.OTHCOGX;


                return true;
            }

            return false;


        }

        [Obsolete]
        public static bool Update(this T1 entity, T1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.TELCOG = dto.TELCOG;
                entity.TELILL = dto.TELILL;
                entity.TELHOME = dto.TELHOME;
                entity.TELREFU = dto.TELREFU;
                entity.TELCOV = dto.TELCOV;
                entity.TELOTHR = dto.TELOTHR;
                entity.TELOTHRX = dto.TELOTHRX;
                entity.TELMOD = dto.TELMOD;
                entity.TELINPER = dto.TELINPER;
                entity.TELMILE = dto.TELMILE;

                return true;
            }
            return false;
        }
    }
}

