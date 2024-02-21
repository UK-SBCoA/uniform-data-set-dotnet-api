using System;
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

            if (String.IsNullOrWhiteSpace(dto.Language))
                entity.Language = null;
            else
            {
                if (Enum.TryParse(dto.Language, true, out Language language))
                    entity.Language = language;
            }

            entity.IsIncluded = dto.IsIncluded;

            if (String.IsNullOrWhiteSpace(dto.ReasonCode))
                entity.ReasonCode = null;
            else
            {
                if (Enum.TryParse(dto.ReasonCode, true, out ReasonCode reasonCode))
                    entity.ReasonCode = reasonCode;
            }
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
                IsDeleted = dto.IsDeleted
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
                entity.ETHFRENCH = dto.ETHFRENCH;
                entity.ETHWHIOTH = dto.ETHWHIOTH;
                entity.ETHWHIOTHX = dto.ETHWHIOTHX;
                entity.ETHISPANIC = dto.ETHISPANIC;
                entity.ETHMEXICAN = dto.ETHMEXICAN;
                entity.ETHPUERTO = dto.ETHPUERTO;
                entity.ETHCUBAN = dto.ETHCUBAN;
                entity.ETHSALVA = dto.ETHSALVA;
                entity.ETHDOMIN = dto.ETHDOMIN;
                entity.ETHCOLOM = dto.ETHCOLOM;
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
                entity.ETHMOROCCO = dto.ETHMOROCCO;
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
                entity.FADMUT = dto.FADMUT;
                entity.FADMUTX = dto.FADMUTX;
                entity.FADMUSO = dto.FADMUSO;
                entity.FADMUSOX = dto.FADMUSOX;
                entity.FFTDMUT = dto.FFTDMUT;
                entity.FFTDMUTX = dto.FFTDMUTX;
                entity.FOTHMUT = dto.FOTHMUT;
                entity.FOTHMUTX = dto.FOTHMUTX;
                entity.MOMMOB = dto.MOMMOB;
                entity.MOMYOB = dto.MOMYOB;
                entity.MOMDAGE = dto.MOMDAGE;
                entity.MOMNEUR = dto.MOMNEUR;
                entity.MOMPRDX = dto.MOMPRDX;
                entity.MOMMOE = dto.MOMMOE;
                entity.MOMAGEO = dto.MOMAGEO;
                entity.DADMOB = dto.DADMOB;
                entity.DADYOB = dto.DADYOB;
                entity.DADDAGE = dto.DADDAGE;
                entity.DADNEUR = dto.DADNEUR;
                entity.DADPRDX = dto.DADPRDX;
                entity.DADMOE = dto.DADMOE;
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
                entity.MOB = dto.MOB;
                entity.YOB = dto.YOB;
                entity.AGD = dto.AGD;
                entity.NEU = dto.NEU;
                entity.PDX = dto.PDX;
                entity.MOE = dto.MOE;
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
                entity.RXNORMID1.RxNormId = null;
                entity.RXNORMID2.RxNormId = null;
                entity.RXNORMID3.RxNormId = null;
                entity.RXNORMID4.RxNormId = null;
                entity.RXNORMID5.RxNormId = null;
                entity.RXNORMID6.RxNormId = null;
                entity.RXNORMID7.RxNormId = null;
                entity.RXNORMID8.RxNormId = null;
                entity.RXNORMID9.RxNormId = null;
                entity.RXNORMID10.RxNormId = null;
                entity.RXNORMID11.RxNormId = null;
                entity.RXNORMID12.RxNormId = null;
                entity.RXNORMID13.RxNormId = null;
                entity.RXNORMID14.RxNormId = null;
                entity.RXNORMID15.RxNormId = null;
                entity.RXNORMID16.RxNormId = null;
                entity.RXNORMID17.RxNormId = null;
                entity.RXNORMID18.RxNormId = null;
                entity.RXNORMID19.RxNormId = null;
                entity.RXNORMID20.RxNormId = null;
                entity.RXNORMID21.RxNormId = null;
                entity.RXNORMID22.RxNormId = null;
                entity.RXNORMID23.RxNormId = null;
                entity.RXNORMID24.RxNormId = null;
                entity.RXNORMID25.RxNormId = null;
                entity.RXNORMID26.RxNormId = null;
                entity.RXNORMID27.RxNormId = null;
                entity.RXNORMID28.RxNormId = null;
                entity.RXNORMID29.RxNormId = null;
                entity.RXNORMID30.RxNormId = null;
                entity.RXNORMID31.RxNormId = null;
                entity.RXNORMID32.RxNormId = null;
                entity.RXNORMID33.RxNormId = null;
                entity.RXNORMID34.RxNormId = null;
                entity.RXNORMID35.RxNormId = null;
                entity.RXNORMID36.RxNormId = null;
                entity.RXNORMID37.RxNormId = null;
                entity.RXNORMID38.RxNormId = null;
                entity.RXNORMID39.RxNormId = null;
                entity.RXNORMID40.RxNormId = null;

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

                entity.CANCER = dto.CANCER;
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

                entity.OTHCOND = dto.OTHCOND;
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
                entity.DECIN = dto.DECIN;
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
                entity.BEVWELL = dto.BEVWELL;
                entity.BEAHALL = dto.BEAHALL;
                entity.BEAHSIMP = dto.BEAHSIMP;
                entity.BEAHCOMP = dto.BEAHCOMP;
                entity.BEDEL = dto.BEDEL;
                entity.BEAGGRS = dto.BEAGGRS;
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
                entity.OTHSUBUSE = dto.OTHSUBUSE;
                entity.OTHSUBUSEX = dto.OTHSUBUSEX;
                entity.PERCHAGE = dto.PERCHAGE;
                entity.BEREM = dto.BEREM;

                return true;
            }
            return false;
        }

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

        public static bool Update(this D1 entity, D1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.DXMETHOD = dto.DXMETHOD;
                entity.NORMCOG = dto.NORMCOG;
                entity.DEMENTED = dto.DEMENTED;
                entity.AMNDEM = dto.AMNDEM;
                entity.PCA = dto.PCA;
                entity.PPASYN = dto.PPASYN;
                entity.PPASYNT = dto.PPASYNT;
                entity.FTDSYN = dto.FTDSYN;
                entity.LBDSYN = dto.LBDSYN;
                entity.NAMNDEM = dto.NAMNDEM;
                entity.MCIAMEM = dto.MCIAMEM;
                entity.MCIAPLUS = dto.MCIAPLUS;
                entity.MCIAPLAN = dto.MCIAPLAN;
                entity.MCIAPATT = dto.MCIAPATT;
                entity.MCIAPEX = dto.MCIAPEX;
                entity.MCIAPVIS = dto.MCIAPVIS;
                entity.MCINON1 = dto.MCINON1;
                entity.MCIN1LAN = dto.MCIN1LAN;
                entity.MCIN1ATT = dto.MCIN1ATT;
                entity.MCIN1EX = dto.MCIN1EX;
                entity.MCIN1VIS = dto.MCIN1VIS;
                entity.MCINON2 = dto.MCINON2;
                entity.MCIN2LAN = dto.MCIN2LAN;
                entity.MCIN2ATT = dto.MCIN2ATT;
                entity.MCIN2EX = dto.MCIN2EX;
                entity.MCIN2VIS = dto.MCIN2VIS;
                entity.IMPNOMCI = dto.IMPNOMCI;
                entity.AMYLPET = dto.AMYLPET;
                entity.AMYLCSF = dto.AMYLCSF;
                entity.FDGAD = dto.FDGAD;
                entity.HIPPATR = dto.HIPPATR;
                entity.TAUPETAD = dto.TAUPETAD;
                entity.CSFTAU = dto.CSFTAU;
                entity.FDGFTLD = dto.FDGFTLD;
                entity.TPETFTLD = dto.TPETFTLD;
                entity.MRFTLD = dto.MRFTLD;
                entity.DATSCAN = dto.DATSCAN;
                entity.OTHBIOM = dto.OTHBIOM;
                entity.OTHBIOMX = dto.OTHBIOMX;
                entity.IMAGLINF = dto.IMAGLINF;
                entity.IMAGLAC = dto.IMAGLAC;
                entity.IMAGMACH = dto.IMAGMACH;
                entity.IMAGMICH = dto.IMAGMICH;
                entity.IMAGMWMH = dto.IMAGMWMH;
                entity.IMAGEWMH = dto.IMAGEWMH;
                entity.ADMUT = dto.ADMUT;
                entity.FTLDMUT = dto.FTLDMUT;
                entity.OTHMUT = dto.OTHMUT;
                entity.OTHMUTX = dto.OTHMUTX;
                entity.ALZDIS = dto.ALZDIS;
                entity.ALZDISIF = dto.ALZDISIF;
                entity.LBDIS = dto.LBDIS;
                entity.LBDIF = dto.LBDIF;
                entity.PARK = dto.PARK;
                entity.MSA = dto.MSA;
                entity.MSAIF = dto.MSAIF;
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
                entity.PREVSTK = dto.PREVSTK;
                entity.STROKDEC = dto.STROKDEC;
                entity.STKIMAG = dto.STKIMAG;
                entity.INFNETW = dto.INFNETW;
                entity.INFWMH = dto.INFWMH;
                entity.ESSTREM = dto.ESSTREM;
                entity.ESSTREIF = dto.ESSTREIF;
                entity.DOWNS = dto.DOWNS;
                entity.DOWNSIF = dto.DOWNSIF;
                entity.HUNT = dto.HUNT;
                entity.HUNTIF = dto.HUNTIF;
                entity.PRION = dto.PRION;
                entity.PRIONIF = dto.PRIONIF;
                entity.BRNINJ = dto.BRNINJ;
                entity.BRNINJIF = dto.BRNINJIF;
                entity.BRNINCTE = dto.BRNINCTE;
                entity.HYCEPH = dto.HYCEPH;
                entity.HYCEPHIF = dto.HYCEPHIF;
                entity.EPILEP = dto.EPILEP;
                entity.EPILEPIF = dto.EPILEPIF;
                entity.NEOP = dto.NEOP;
                entity.NEOPIF = dto.NEOPIF;
                entity.NEOPSTAT = dto.NEOPSTAT;
                entity.HIV = dto.HIV;
                entity.HIVIF = dto.HIVIF;
                entity.OTHCOG = dto.OTHCOG;
                entity.OTHCOGIF = dto.OTHCOGIF;
                entity.OTHCOGX = dto.OTHCOGX;
                entity.DEP = dto.DEP;
                entity.DEPIF = dto.DEPIF;
                entity.DEPTREAT = dto.DEPTREAT;
                entity.BIPOLDX = dto.BIPOLDX;
                entity.BIPOLDIF = dto.BIPOLDIF;
                entity.SCHIZOP = dto.SCHIZOP;
                entity.SCHIZOIF = dto.SCHIZOIF;
                entity.ANXIET = dto.ANXIET;
                entity.ANXIETIF = dto.ANXIETIF;
                entity.DELIR = dto.DELIR;
                entity.DELIRIF = dto.DELIRIF;
                entity.PTSDDX = dto.PTSDDX;
                entity.PTSDDXIF = dto.PTSDDXIF;
                entity.OTHPSY = dto.OTHPSY;
                entity.OTHPSYIF = dto.OTHPSYIF;
                entity.OTHPSYX = dto.OTHPSYX;
                entity.ALCDEM = dto.ALCDEM;
                entity.ALCDEMIF = dto.ALCDEMIF;
                entity.ALCABUSE = dto.ALCABUSE;
                entity.IMPSUB = dto.IMPSUB;
                entity.IMPSUBIF = dto.IMPSUBIF;
                entity.DYSILL = dto.DYSILL;
                entity.DYSILLIF = dto.DYSILLIF;
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

