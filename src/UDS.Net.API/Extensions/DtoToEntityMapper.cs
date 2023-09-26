using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using UDS.Net.API.Entities;
using UDS.Net.Dto;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public static A4D ToEntity(this A4DDto dto)
        {
            var a4 = new A4D
            {
                DRUGID = dto.DRUGID
            };

            a4.SetBaseProperties(dto);

            return a4;
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

                entity.REASON = dto.REASON;
                entity.REFERSC = dto.REFERSC;
                entity.LEARNED = dto.LEARNED;
                entity.PRESTAT = dto.PRESTAT;
                entity.PRESPART = dto.PRESPART;
                entity.SOURCENW = dto.SOURCENW;
                entity.BIRTHMO = dto.BIRTHMO;
                entity.BIRTHYR = dto.BIRTHYR;
                entity.SEX = dto.SEX;
                entity.HISPANIC = dto.HISPANIC;
                entity.HISPOR = dto.HISPOR;
                entity.HISPORX = dto.HISPORX;
                entity.RACE = dto.RACE;
                entity.RACEX = dto.RACEX;
                entity.RACESEC = dto.RACESEC;
                entity.RACESECX = dto.RACESECX;
                entity.PRIMLANG = dto.PRIMLANG;
                entity.EDUC = dto.EDUC;
                entity.MARISTAT = dto.MARISTAT;
                entity.LIVSITUA = dto.LIVSITUA;
                entity.INDEPEND = dto.INDEPEND;
                entity.RESIDENC = dto.RESIDENC;
                entity.ZIP = dto.ZIP;
                entity.HANDED = dto.HANDED;

                return true;
            }
            return false;
        }

        public static bool Update(this A2 entity, A2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.INBIRMO = dto.INBIRMO;
                entity.INBIRYR = dto.INBIRYR;
                entity.INSEX = dto.INSEX;
                entity.INHISP = dto.INHISP;
                entity.INHISPOR = dto.INHISPOR;
                entity.INHISPOX = dto.INHISPOX;
                entity.INRACE = dto.INRACE;
                entity.INRACEX = dto.INRACEX;
                entity.INRASEC = dto.INRASEC;
                entity.INRASECX = dto.INRASECX;
                entity.INRATER = dto.INRATER;
                entity.INRATERX = dto.INRATERX;
                entity.INEDUC = dto.INEDUC;
                entity.INRELTO = dto.INRELTO;
                entity.INKNOWN = dto.INKNOWN;
                entity.INLIVWTH = dto.INLIVWTH;
                entity.INVISITS = dto.INVISITS;
                entity.INCALLS = dto.INCALLS;
                entity.INRELY = dto.INRELY;
                entity.NEWINF = dto.NEWINF;

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
            entity.MOB = dto.MOB;
            entity.YOB = dto.YOB;
            entity.AGD = dto.AGD;
            entity.NEU = dto.NEU;
            entity.PDX = dto.PDX;
            entity.MOE = dto.MOE;
            entity.AGO = dto.AGO;

            return true;
        }

        public static bool Update(this A4G entity, A4GDto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);
                entity.ANYMEDS = dto.ANYMEDS;
            }
            return false;
        }

        public static bool Update(this A4D entity, A4DDto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);
                entity.DRUGID = dto.DRUGID;
                return true;
            }
            return false;
        }

        public static bool Update(this A5 entity, A5Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.TOBAC30 = dto.TOBAC30;
                entity.TOBAC100 = dto.TOBAC100;
                entity.SMOKYRS = dto.SMOKYRS;
                entity.PACKSPER = dto.PACKSPER;
                entity.QUITSMOK = dto.QUITSMOK;
                entity.ALCOCCAS = dto.ALCOCCAS;
                entity.ALCFREQ = dto.ALCFREQ;
                entity.CVHATT = dto.CVHATT;
                entity.HATTMULT = dto.HATTMULT;
                entity.HATTYEAR = dto.HATTYEAR;
                entity.CVAFIB = dto.CVAFIB;
                entity.CVANGIO = dto.CVANGIO;
                entity.CVBYPASS = dto.CVBYPASS;
                entity.CVPACDEF = dto.CVPACDEF;
                entity.CVCHF = dto.CVCHF;
                entity.CVANGINA = dto.CVANGINA;
                entity.CVHVALVE = dto.CVHVALVE;
                entity.CVOTHR = dto.CVOTHR;
                entity.CVOTHRX = dto.CVOTHRX;
                entity.CBSTROKE = dto.CBSTROKE;
                entity.STROKMUL = dto.STROKMUL;
                entity.STROKYR = dto.STROKYR;
                entity.CBTIA = dto.CBTIA;
                entity.TIAMULT = dto.TIAMULT;
                entity.TIAYEAR = dto.TIAYEAR;
                entity.PD = dto.PD;
                entity.PDYR = dto.PDYR;
                entity.PDOTHR = dto.PDOTHR;
                entity.PDOTHRYR = dto.PDOTHRYR;
                entity.SEIZURES = dto.SEIZURES;
                entity.TBI = dto.TBI;
                entity.TBIBRIEF = dto.TBIBRIEF;
                entity.TBIEXTEN = dto.TBIEXTEN;
                entity.TBIWOLOS = dto.TBIWOLOS;
                entity.TBIYEAR = dto.TBIYEAR;
                entity.DIABETES = dto.DIABETES;
                entity.DIABTYPE = dto.DIABTYPE;
                entity.HYPERTEN = dto.HYPERTEN;
                entity.HYPERCHO = dto.HYPERCHO;
                entity.B12DEF = dto.B12DEF;
                entity.THYROID = dto.THYROID;
                entity.ARTHRIT = dto.ARTHRIT;
                entity.ARTHTYPE = dto.ARTHTYPE;
                entity.ARTHTYPX = dto.ARTHTYPX;
                entity.ARTHUPEX = dto.ARTHUPEX;
                entity.ARTHLOEX = dto.ARTHLOEX;
                entity.ARTHSPIN = dto.ARTHSPIN;
                entity.ARTHUNK = dto.ARTHUNK;
                entity.INCONTU = dto.INCONTU;
                entity.INCONTF = dto.INCONTF;
                entity.APNEA = dto.APNEA;
                entity.RBD = dto.RBD;
                entity.INSOMN = dto.INSOMN;
                entity.OTHSLEEP = dto.OTHSLEEP;
                entity.OTHSLEEX = dto.OTHSLEEX;
                entity.ALCOHOL = dto.ALCOHOL;
                entity.ABUSOTHR = dto.ABUSOTHR;
                entity.ABUSX = dto.ABUSX;
                entity.PTSD = dto.PTSD;
                entity.BIPOLAR = dto.BIPOLAR;
                entity.SCHIZ = dto.SCHIZ;
                entity.DEP2YRS = dto.DEP2YRS;
                entity.DEPOTHR = dto.DEPOTHR;
                entity.ANXIETY = dto.ANXIETY;
                entity.OCD = dto.OCD;
                entity.NPSYDEV = dto.NPSYDEV;
                entity.PSYCDIS = dto.PSYCDIS;
                entity.PSYCDISX = dto.PSYCDISX;

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
                entity.BPSYS = dto.BPSYS;
                entity.BPDIAS = dto.BPDIAS;
                entity.HRATE = dto.HRATE;
                entity.VISION = dto.VISION;
                entity.VISCORR = dto.VISCORR;
                entity.VISWCORR = dto.VISWCORR;
                entity.HEARING = dto.HEARING;
                entity.HEARAID = dto.HEARAID;
                entity.HEARWAID = dto.HEARWAID;

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

                entity.NORMEXAM = dto.NORMEXAM;
                entity.PARKSIGN = dto.PARKSIGN;
                entity.RESTTRL = dto.RESTTRL;
                entity.RESTTRR = dto.RESTTRR;
                entity.SLOWINGL = dto.SLOWINGL;
                entity.SLOWINGR = dto.SLOWINGR;
                entity.RIGIDL = dto.RIGIDL;
                entity.RIGIDR = dto.RIGIDR;
                entity.BRADY = dto.BRADY;
                entity.PARKGAIT = dto.PARKGAIT;
                entity.POSTINST = dto.POSTINST;
                entity.CVDSIGNS = dto.CVDSIGNS;
                entity.CORTDEF = dto.CORTDEF;
                entity.SIVDFIND = dto.SIVDFIND;
                entity.CVDMOTL = dto.CVDMOTL;
                entity.CVDMOTR = dto.CVDMOTR;
                entity.CORTVISL = dto.CORTVISL;
                entity.CORTVISR = dto.CORTVISR;
                entity.SOMATL = dto.SOMATL;
                entity.SOMATR = dto.SOMATR;
                entity.POSTCORT = dto.POSTCORT;
                entity.PSPCBS = dto.PSPCBS;
                entity.EYEPSP = dto.EYEPSP;
                entity.DYSPSP = dto.DYSPSP;
                entity.AXIALPSP = dto.AXIALPSP;
                entity.GAITPSP = dto.GAITPSP;
                entity.APRAXSP = dto.APRAXSP;
                entity.APRAXL = dto.APRAXL;
                entity.APRAXR = dto.APRAXR;
                entity.CORTSENL = dto.CORTSENL;
                entity.CORTSENR = dto.CORTSENR;
                entity.ATAXL = dto.ATAXL;
                entity.ATAXR = dto.ATAXR;
                entity.ALIENLML = dto.ALIENLML;
                entity.ALIENLMR = dto.ALIENLMR;
                entity.DYSTONL = dto.DYSTONL;
                entity.DYSTONR = dto.DYSTONR;
                entity.MYOCLLT = dto.MYOCLLT;
                entity.MYOCLRT = dto.MYOCLRT;
                entity.ALSFIND = dto.ALSFIND;
                entity.GAITNPH = dto.GAITNPH;
                entity.OTHNEUR = dto.OTHNEUR;
                entity.OTHNEURX = dto.OTHNEURX;

                return true;
            }
            return false;
        }

        public static bool Update(this B9 entity, B9Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.DECSUB = dto.DECSUB;
                entity.DECIN = dto.DECIN;
                entity.DECCLCOG = dto.DECCLCOG;
                entity.COGMEM = dto.COGMEM;
                entity.COGORI = dto.COGORI;
                entity.COGJUDG = dto.COGJUDG;
                entity.COGLANG = dto.COGLANG;
                entity.COGVIS = dto.COGVIS;
                entity.COGATTN = dto.COGATTN;
                entity.COGFLUC = dto.COGFLUC;
                entity.COGFLAGO = dto.COGFLAGO;
                entity.COGOTHR = dto.COGOTHR;
                entity.COGOTHRX = dto.COGOTHRX;
                entity.COGFPRED = dto.COGFPRED;
                entity.COGFPREX = dto.COGFPREX;
                entity.COGMODE = dto.COGMODE;
                entity.COGMODEX = dto.COGMODEX;
                entity.DECAGE = dto.DECAGE;
                entity.DECCLBE = dto.DECCLBE;
                entity.BEAPATHY = dto.BEAPATHY;
                entity.BEDEP = dto.BEDEP;
                entity.BEVHALL = dto.BEVHALL;
                entity.BEVWELL = dto.BEVWELL;
                entity.BEVHAGO = dto.BEVHAGO;
                entity.BEAHALL = dto.BEAHALL;
                entity.BEDEL = dto.BEDEL;
                entity.BEDISIN = dto.BEDISIN;
                entity.BEIRRIT = dto.BEIRRIT;
                entity.BEAGIT = dto.BEAGIT;
                entity.BEPERCH = dto.BEPERCH;
                entity.BEREM = dto.BEREM;
                entity.BEREMAGO = dto.BEREMAGO;
                entity.BEANX = dto.BEANX;
                entity.BEOTHR = dto.BEOTHR;
                entity.BEOTHRX = dto.BEOTHRX;
                entity.BEFPRED = dto.BEFPRED;
                entity.BEFPREDX = dto.BEFPREDX;
                entity.BEMODE = dto.BEMODE;
                entity.BEMODEX = dto.BEMODEX;
                entity.BEAGE = dto.BEAGE;
                entity.DECCLMOT = dto.DECCLMOT;
                entity.MOGAIT = dto.MOGAIT;
                entity.MOFALLS = dto.MOFALLS;
                entity.MOTREM = dto.MOTREM;
                entity.MOSLOW = dto.MOSLOW;
                entity.MOFRST = dto.MOFRST;
                entity.MOMODE = dto.MOMODE;
                entity.MOMODEX = dto.MOMODEX;
                entity.MOMOPARK = dto.MOMOPARK;
                entity.PARKAGE = dto.PARKAGE;
                entity.MOMOALS = dto.MOMOALS;
                entity.ALSAGE = dto.ALSAGE;
                entity.MOAGE = dto.MOAGE;
                entity.COURSE = dto.COURSE;
                entity.FRSTCHG = dto.FRSTCHG;
                entity.LBDEVAL = dto.LBDEVAL;
                entity.FTLDEVAL = dto.FTLDEVAL;

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

                entity.MODCOMM = dto.MODCOMM;
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
                entity.UDSBENTC = dto.UDSBENTC;
                entity.DIGFORCT = dto.DIGFORCT;
                entity.DIGFORSL = dto.DIGFORSL;
                entity.DIGBACCT = dto.DIGBACCT;
                entity.DIGBACLS = dto.DIGBACLS;
                entity.OTRAILA = dto.OTRAILA;
                entity.OTRLARR = dto.OTRLARR;
                entity.OTRLALI = dto.OTRLALI;
                entity.OTRAILB = dto.OTRAILB;
                entity.OTRLBRR = dto.OTRLBRR;
                entity.OTRLBLI = dto.OTRLBLI;
                entity.ANIMALS = dto.ANIMALS;
                entity.VEG = dto.VEG;
                entity.TRAILA = dto.TRAILA;
                entity.TRAILARR = dto.TRAILARR;
                entity.TRAILALI = dto.TRAILALI;
                entity.TRAILB = dto.TRAILB;
                entity.TRAILBRR = dto.TRAILBRR;
                entity.TRAILBLI = dto.TRAILBLI;
                entity.CRAFTDVR = dto.CRAFTDVR;
                entity.CRAFTDRE = dto.CRAFTDRE;
                entity.CRAFTDTI = dto.CRAFTDTI;
                entity.CRAFTCUE = dto.CRAFTCUE;
                entity.UDSBENTD = dto.UDSBENTD;
                entity.UDSBENRS = dto.UDSBENRS;
                entity.MINTTOTS = dto.MINTTOTS;
                entity.MINTTOTW = dto.MINTTOTW;
                entity.MINTSCNG = dto.MINTSCNG;
                entity.MINTSCNC = dto.MINTSCNC;
                entity.MINTPCNG = dto.MINTPCNG;
                entity.MINTPCNC = dto.MINTPCNC;
                entity.UDSVERFC = dto.UDSVERFC;
                entity.UDSVERFN = dto.UDSVERFN;
                entity.UDSVERNF = dto.UDSVERNF;
                entity.UDSVERLC = dto.UDSVERLC;
                entity.UDSVERLR = dto.UDSVERLR;
                entity.UDSVERLN = dto.UDSVERLN;
                entity.UDSVERTN = dto.UDSVERTN;
                entity.UDSVERTE = dto.UDSVERTE;
                entity.UDSVERTI = dto.UDSVERTI;
                entity.REYDREC = dto.REYDREC;
                entity.REYDINT = dto.REYDINT;
                entity.REYTCOR = dto.REYTCOR;
                entity.REYFPOS = dto.REYFPOS;
                entity.VNTTOTW = dto.VNTTOTW;
                entity.VNTPCNC = dto.VNTPCNC;
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

        public static bool Update(this D2 entity, D2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.SetBaseProperties(dto);

                entity.CANCER = dto.CANCER;
                entity.CANCSITE = dto.CANCSITE;
                entity.DIABET = dto.DIABET;
                entity.MYOINF = dto.MYOINF;
                entity.CONGHRT = dto.CONGHRT;
                entity.AFIBRILL = dto.AFIBRILL;
                entity.HYPERT = dto.HYPERT;
                entity.ANGINA = dto.ANGINA;
                entity.HYPCHOL = dto.HYPCHOL;
                entity.VB12DEF = dto.VB12DEF;
                entity.THYDIS = dto.THYDIS;
                entity.ARTH = dto.ARTH;
                entity.ARTYPE = dto.ARTYPE;
                entity.ARTYPEX = dto.ARTYPEX;
                entity.ARTUPEX = dto.ARTUPEX;
                entity.ARTLOEX = dto.ARTLOEX;
                entity.ARTSPIN = dto.ARTSPIN;
                entity.ARTUNKN = dto.ARTUNKN;
                entity.URINEINC = dto.URINEINC;
                entity.BOWLINC = dto.BOWLINC;
                entity.SLEEPAP = dto.SLEEPAP;
                entity.REMDIS = dto.REMDIS;
                entity.HYPOSOM = dto.HYPOSOM;
                entity.SLEEPOTH = dto.SLEEPOTH;
                entity.SLEEPOTX = dto.SLEEPOTX;
                entity.ANGIOCP = dto.ANGIOCP;
                entity.ANGIOPCI = dto.ANGIOPCI;
                entity.PACEMAKE = dto.PACEMAKE;
                entity.HVALVE = dto.HVALVE;
                entity.ANTIENC = dto.ANTIENC;
                entity.ANTIENCX = dto.ANTIENCX;
                entity.OTHCOND = dto.OTHCOND;
                entity.OTHCONDX = dto.OTHCONDX;

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

