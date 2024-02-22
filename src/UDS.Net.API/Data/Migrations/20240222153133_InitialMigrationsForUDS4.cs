using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationsForUDS4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrugCodesLookup",
                columns: table => new
                {
                    RxNormId = table.Column<int>(type: "int", nullable: false),
                    DrugName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BrandNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsOverTheCounter = table.Column<bool>(type: "bit", nullable: false),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCodesLookup", x => x.RxNormId);
                });

            migrationBuilder.CreateTable(
                name: "Participation",
                columns: table => new
                {
                    ParticipationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegacyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participation", x => x.ParticipationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_M1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipationId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CHANGEMO = table.Column<int>(type: "int", nullable: true),
                    CHANGEDY = table.Column<int>(type: "int", nullable: true),
                    CHANGEYR = table.Column<int>(type: "int", nullable: true),
                    PROTOCOL = table.Column<int>(type: "int", nullable: true),
                    ACONSENT = table.Column<int>(type: "int", nullable: true),
                    RECOGIM = table.Column<int>(type: "int", nullable: true),
                    REPHYILL = table.Column<int>(type: "int", nullable: true),
                    REREFUSE = table.Column<int>(type: "int", nullable: true),
                    RENAVAIL = table.Column<int>(type: "int", nullable: true),
                    RENURSE = table.Column<int>(type: "int", nullable: true),
                    NURSEMO = table.Column<int>(type: "int", nullable: true),
                    NURSEDY = table.Column<int>(type: "int", nullable: true),
                    NURSEYR = table.Column<int>(type: "int", nullable: true),
                    REJOIN = table.Column<int>(type: "int", nullable: true),
                    FTLDDISC = table.Column<int>(type: "int", nullable: true),
                    FTLDREAS = table.Column<int>(type: "int", nullable: true),
                    FTLDREAX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DECEASED = table.Column<int>(type: "int", nullable: true),
                    DISCONT = table.Column<int>(type: "int", nullable: true),
                    DEATHMO = table.Column<int>(type: "int", nullable: true),
                    DEATHDY = table.Column<int>(type: "int", nullable: true),
                    DEATHYR = table.Column<int>(type: "int", nullable: true),
                    AUTOPSY = table.Column<int>(type: "int", nullable: true),
                    DISCMO = table.Column<int>(type: "int", nullable: true),
                    DISCDAY = table.Column<int>(type: "int", nullable: true),
                    DISCYR = table.Column<int>(type: "int", nullable: true),
                    DROPREAS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_M1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_M1s_Participation_ParticipationId",
                        column: x => x.ParticipationId,
                        principalTable: "Participation",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipationId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_tbl_Visits_Participation_ParticipationId",
                        column: x => x.ParticipationId,
                        principalTable: "Participation",
                        principalColumn: "ParticipationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A1as",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OWNSCAR = table.Column<int>(type: "int", nullable: true, comment: "1. Do you or someone in your household currently own a car?"),
                    TRSPACCESS = table.Column<int>(type: "int", nullable: true, comment: "2. Do you have consistent access to transportation?"),
                    TRANSPROB = table.Column<int>(type: "int", nullable: true, comment: "3. In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?"),
                    TRANSWORRY = table.Column<int>(type: "int", nullable: true, comment: "4. In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?"),
                    TRSPLONGER = table.Column<int>(type: "int", nullable: true, comment: "5. In the past 30 days, how often did it take you longer to get somewhere than it would have taken you if you had different transportation?"),
                    TRSPMED = table.Column<int>(type: "int", nullable: true, comment: "6. In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?"),
                    INCOMEYR = table.Column<int>(type: "int", nullable: true, comment: "7. Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth."),
                    FINSATIS = table.Column<int>(type: "int", nullable: true, comment: "8. How satisfied are you with your current personal financial condition?"),
                    BILLPAY = table.Column<int>(type: "int", nullable: true, comment: "9. How difficult is it for you to meet monthly payments on your bills?"),
                    FINUPSET = table.Column<int>(type: "int", nullable: true, comment: "10. If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?"),
                    EATLESS = table.Column<int>(type: "int", nullable: true, comment: "11. At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?"),
                    EATLESSYR = table.Column<int>(type: "int", nullable: true, comment: "12. In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?"),
                    LESSMEDS = table.Column<int>(type: "int", nullable: true, comment: "13. At any time, have you ended up taking less medication than was prescribed for you because of the cost?"),
                    LESSMEDSYR = table.Column<int>(type: "int", nullable: true, comment: "14. In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?"),
                    COMPCOMM = table.Column<int>(type: "int", nullable: true, comment: "15a. Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself."),
                    COMPUSA = table.Column<int>(type: "int", nullable: true, comment: "15b. Where would you place yourself on this ladder compared to others in the U.S.?"),
                    FAMCOMP = table.Column<int>(type: "int", nullable: true, comment: "15c. Thinking of your childhood, where would your family have been placed on this ladder compared to others in your community (or neighborhood)?"),
                    GUARDEDU = table.Column<int>(type: "int", nullable: true, comment: "16. Thinking of the person who raised you, what was their highest level of education completed?"),
                    GUARDREL = table.Column<int>(type: "int", nullable: true, comment: "16a. What was this person's relationship to you?"),
                    GUARDRELX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "16a1. Specify other relationship"),
                    GUARD2EDU = table.Column<int>(type: "int", nullable: true, comment: "17. If there was a second person who raised you (e.g., your mother, father, grandmother, etc.?), what was that person's highest level of education completed?"),
                    GUARD2REL = table.Column<int>(type: "int", nullable: true, comment: "17a. What was this second person's relationship to you (if applicable)?"),
                    GUARD2RELX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "17a1. Specify other relationship"),
                    EMPTINESS = table.Column<int>(type: "int", nullable: true, comment: "18. I experience a general sense of emptiness"),
                    MISSPEOPLE = table.Column<int>(type: "int", nullable: true, comment: "19. I miss having people around"),
                    FRIENDS = table.Column<int>(type: "int", nullable: true, comment: "20. I feel like I don't have enough friends"),
                    ABANDONED = table.Column<int>(type: "int", nullable: true, comment: "21. I often feel abandoned"),
                    CLOSEFRND = table.Column<int>(type: "int", nullable: true, comment: "22. I miss having a really good friend"),
                    PARENTCOMM = table.Column<int>(type: "int", nullable: true, comment: "23. If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?"),
                    CHILDCOMM = table.Column<int>(type: "int", nullable: true, comment: "24. If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?"),
                    FRIENDCOMM = table.Column<int>(type: "int", nullable: true, comment: "25. How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?"),
                    PARTICIPATE = table.Column<int>(type: "int", nullable: true, comment: "26. How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?"),
                    SAFEHOME = table.Column<int>(type: "int", nullable: true, comment: "27a. How safe do you feel in your home?"),
                    SAFECOMM = table.Column<int>(type: "int", nullable: true, comment: "27b. How safe do you feel in your community (or neighborhood)?"),
                    DELAYMED = table.Column<int>(type: "int", nullable: true, comment: "28. In the past year, how often did you delay seeking medical attention for a problem that was bothering you?"),
                    SCRIPTPROB = table.Column<int>(type: "int", nullable: true, comment: "29. In the past year, how often did you experience challenges in filling a prescription?"),
                    MISSEDFUP = table.Column<int>(type: "int", nullable: true, comment: "30. In the past year, how often did you miss a follow-up medical appointment that was scheduled?"),
                    DOCADVICE = table.Column<int>(type: "int", nullable: true, comment: "31. In the past year, how often did you follow a doctor's advice or treatment plan when it was given?"),
                    HEALTHACC = table.Column<int>(type: "int", nullable: true, comment: "32. Overall, which of these describes your health insurance, access to healthcare services, and access to medications?"),
                    LESSCOURT = table.Column<int>(type: "int", nullable: true, comment: "33. In your day-to-day life how often are you treated with less courtesy or respect than other people?"),
                    POORSERV = table.Column<int>(type: "int", nullable: true, comment: "34. In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?"),
                    NOTSMART = table.Column<int>(type: "int", nullable: true, comment: "35. In your day-to-day life how often do people act as if they think you are not smart?"),
                    ACTAFRAID = table.Column<int>(type: "int", nullable: true, comment: "36. In your day-to-day life how often do people act as if they are afraid of you?"),
                    THREATENED = table.Column<int>(type: "int", nullable: true, comment: "37. In your day-to-day life how often are you threatened or harassed?"),
                    POORMEDTRT = table.Column<int>(type: "int", nullable: true, comment: "38. How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?"),
                    EXPANCEST = table.Column<bool>(type: "bit", nullable: true, comment: "39a1. Main reason--Your Ancestry or National Origins"),
                    EXPGENDER = table.Column<bool>(type: "bit", nullable: true, comment: "39a2. Main reason--Your gender"),
                    EXPRACE = table.Column<bool>(type: "bit", nullable: true, comment: "39a3. Main reason--Your race"),
                    EXPAGE = table.Column<bool>(type: "bit", nullable: true, comment: "39a4. Main reason--Your age"),
                    EXPRELIG = table.Column<bool>(type: "bit", nullable: true, comment: "39a5. Main reason--Your religion"),
                    EXPHEIGHT = table.Column<bool>(type: "bit", nullable: true, comment: "39a6. Main reason--Your height"),
                    EXPWEIGHT = table.Column<bool>(type: "bit", nullable: true, comment: "39a7. Main reason--Your weight"),
                    EXPAPPEAR = table.Column<bool>(type: "bit", nullable: true, comment: "39a8. Main reason--Some other aspect of your physical appearance"),
                    EXPSEXORN = table.Column<bool>(type: "bit", nullable: true, comment: "39a9. Main reason--Your sexual orientation"),
                    EXPEDUCINC = table.Column<bool>(type: "bit", nullable: true, comment: "39a10. Main reason--Your education or income level"),
                    EXPDISAB = table.Column<bool>(type: "bit", nullable: true, comment: "39a11. Main reason--A physical disability"),
                    EXPSKIN = table.Column<bool>(type: "bit", nullable: true, comment: "39a12. Main reason--Your shade of skin color"),
                    EXPOTHER = table.Column<bool>(type: "bit", nullable: true, comment: "39a13. Main reason -- Other"),
                    EXPNOTAPP = table.Column<bool>(type: "bit", nullable: true, comment: "39a14. Main reason -- not applicable - I do not have these experiences in my day to day life"),
                    EXPNOANS = table.Column<bool>(type: "bit", nullable: true, comment: "39a15. Main reason--Prefer not to answer"),
                    EXPSTRS = table.Column<int>(type: "int", nullable: true, comment: "40. When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A1as", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A1as_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BIRTHMO = table.Column<int>(type: "int", nullable: true),
                    BIRTHYR = table.Column<int>(type: "int", nullable: true),
                    CHLDHDCTRY = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    RACEWHITE = table.Column<int>(type: "int", nullable: true),
                    ETHGERMAN = table.Column<int>(type: "int", nullable: true),
                    ETHIRISH = table.Column<int>(type: "int", nullable: true),
                    ETHENGLISH = table.Column<int>(type: "int", nullable: true),
                    ETHITALIAN = table.Column<int>(type: "int", nullable: true),
                    ETHPOLISH = table.Column<int>(type: "int", nullable: true),
                    ETHFRENCH = table.Column<int>(type: "int", nullable: true),
                    ETHWHIOTH = table.Column<int>(type: "int", nullable: true),
                    ETHWHIOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ETHISPANIC = table.Column<int>(type: "int", nullable: true),
                    ETHMEXICAN = table.Column<int>(type: "int", nullable: true),
                    ETHPUERTO = table.Column<int>(type: "int", nullable: true),
                    ETHCUBAN = table.Column<int>(type: "int", nullable: true),
                    ETHSALVA = table.Column<int>(type: "int", nullable: true),
                    ETHDOMIN = table.Column<int>(type: "int", nullable: true),
                    ETHCOLOM = table.Column<int>(type: "int", nullable: true),
                    ETHHISOTH = table.Column<int>(type: "int", nullable: true),
                    ETHHISOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACEBLACK = table.Column<int>(type: "int", nullable: true),
                    ETHAFAMER = table.Column<int>(type: "int", nullable: true),
                    ETHJAMAICA = table.Column<int>(type: "int", nullable: true),
                    ETHHAITIAN = table.Column<int>(type: "int", nullable: true),
                    ETHNIGERIA = table.Column<int>(type: "int", nullable: true),
                    ETHETHIOP = table.Column<int>(type: "int", nullable: true),
                    ETHSOMALI = table.Column<int>(type: "int", nullable: true),
                    ETHBLKOTH = table.Column<int>(type: "int", nullable: true),
                    ETHBLKOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACEASIAN = table.Column<int>(type: "int", nullable: true),
                    ETHCHINESE = table.Column<int>(type: "int", nullable: true),
                    ETHFILIP = table.Column<int>(type: "int", nullable: true),
                    ETHINDIA = table.Column<int>(type: "int", nullable: true),
                    ETHVIETNAM = table.Column<int>(type: "int", nullable: true),
                    ETHKOREAN = table.Column<int>(type: "int", nullable: true),
                    ETHJAPAN = table.Column<int>(type: "int", nullable: true),
                    ETHASNOTH = table.Column<int>(type: "int", nullable: true),
                    ETHASNOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACEAIAN = table.Column<int>(type: "int", nullable: true),
                    RACEAIANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACEMENA = table.Column<int>(type: "int", nullable: true),
                    ETHLEBANON = table.Column<int>(type: "int", nullable: true),
                    ETHIRAN = table.Column<int>(type: "int", nullable: true),
                    ETHEGYPT = table.Column<int>(type: "int", nullable: true),
                    ETHSYRIA = table.Column<int>(type: "int", nullable: true),
                    ETHMOROCCO = table.Column<int>(type: "int", nullable: true),
                    ETHISRAEL = table.Column<int>(type: "int", nullable: true),
                    ETHMENAOTH = table.Column<int>(type: "int", nullable: true),
                    ETHMENAOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACENHPI = table.Column<int>(type: "int", nullable: true),
                    ETHHAWAII = table.Column<int>(type: "int", nullable: true),
                    ETHSAMOAN = table.Column<int>(type: "int", nullable: true),
                    ETHCHAMOR = table.Column<int>(type: "int", nullable: true),
                    ETHTONGAN = table.Column<int>(type: "int", nullable: true),
                    ETHFIJIAN = table.Column<int>(type: "int", nullable: true),
                    ETHMARSHAL = table.Column<int>(type: "int", nullable: true),
                    ETHNHPIOTH = table.Column<int>(type: "int", nullable: true),
                    ETHNHPIOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RACEUNKN = table.Column<int>(type: "int", nullable: true),
                    GENMAN = table.Column<int>(type: "int", nullable: true),
                    GENWOMAN = table.Column<int>(type: "int", nullable: true),
                    GENTRMAN = table.Column<int>(type: "int", nullable: true),
                    GENTRWOMAN = table.Column<int>(type: "int", nullable: true),
                    GENNONBI = table.Column<int>(type: "int", nullable: true),
                    GENTWOSPIR = table.Column<int>(type: "int", nullable: true),
                    GENOTH = table.Column<int>(type: "int", nullable: true),
                    GENOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    GENDKN = table.Column<int>(type: "int", nullable: true),
                    GENNOANS = table.Column<int>(type: "int", nullable: true),
                    BIRTHSEX = table.Column<int>(type: "int", nullable: true),
                    INTERSEX = table.Column<int>(type: "int", nullable: true),
                    SEXORNGAY = table.Column<int>(type: "int", nullable: true),
                    SEXORNHET = table.Column<int>(type: "int", nullable: true),
                    SEXORNBI = table.Column<int>(type: "int", nullable: true),
                    SEXORNTWOS = table.Column<int>(type: "int", nullable: true),
                    SEXORNOTH = table.Column<int>(type: "int", nullable: true),
                    SEXORNOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    SEXORNDNK = table.Column<int>(type: "int", nullable: true),
                    SEXORNNOAN = table.Column<int>(type: "int", nullable: true),
                    PREDOMLAN = table.Column<int>(type: "int", nullable: true),
                    PREDOMLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDED = table.Column<int>(type: "int", nullable: true),
                    EDUC = table.Column<int>(type: "int", nullable: true),
                    LVLEDUC = table.Column<int>(type: "int", nullable: true),
                    MARISTAT = table.Column<int>(type: "int", nullable: true),
                    LIVSITUA = table.Column<int>(type: "int", nullable: true),
                    RESIDENC = table.Column<int>(type: "int", nullable: true),
                    ZIP = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SERVED = table.Column<int>(type: "int", nullable: true),
                    MEDVA = table.Column<int>(type: "int", nullable: true),
                    EXRTIME = table.Column<int>(type: "int", nullable: true),
                    MEMWORS = table.Column<int>(type: "int", nullable: true),
                    MEMTROUB = table.Column<int>(type: "int", nullable: true),
                    MEMTEN = table.Column<int>(type: "int", nullable: true),
                    ADISTATE = table.Column<int>(type: "int", nullable: true),
                    ADINAT = table.Column<int>(type: "int", nullable: true),
                    PRIOCC = table.Column<int>(type: "int", nullable: true),
                    SOURCENW = table.Column<int>(type: "int", nullable: true),
                    REFERSC = table.Column<int>(type: "int", nullable: true),
                    REFERSCX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFLEARNED = table.Column<int>(type: "int", nullable: true),
                    REFCTRSOCX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFCTRREGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFOTHWEBX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFOTHMEDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFOTHREGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    REFOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NEWINF = table.Column<int>(type: "int", nullable: true),
                    INRELTO = table.Column<int>(type: "int", nullable: true),
                    INKNOWN = table.Column<int>(type: "int", nullable: true),
                    INLIVWTH = table.Column<int>(type: "int", nullable: true),
                    INCNTMOD = table.Column<int>(type: "int", nullable: true),
                    INCNTMDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INCNTFRQ = table.Column<int>(type: "int", nullable: true),
                    INCNTTIM = table.Column<int>(type: "int", nullable: true),
                    INRELY = table.Column<int>(type: "int", nullable: true),
                    INMEMWORS = table.Column<int>(type: "int", nullable: true),
                    INMEMTROUB = table.Column<int>(type: "int", nullable: true),
                    INMEMTEN = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A3s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AFFFAMM = table.Column<int>(type: "int", nullable: true),
                    NWINFMUT = table.Column<int>(type: "int", nullable: true),
                    MOMYOB = table.Column<int>(type: "int", nullable: true),
                    MOMDAGE = table.Column<int>(type: "int", nullable: true),
                    MOMETPR = table.Column<int>(type: "int", nullable: true),
                    MOMETSEC = table.Column<int>(type: "int", nullable: true),
                    MOMMEVAL = table.Column<int>(type: "int", nullable: true),
                    MOMAGEO = table.Column<int>(type: "int", nullable: true),
                    DADYOB = table.Column<int>(type: "int", nullable: true),
                    DADDAGE = table.Column<int>(type: "int", nullable: true),
                    DADETPR = table.Column<int>(type: "int", nullable: true),
                    DADETSEC = table.Column<int>(type: "int", nullable: true),
                    DADMEVAL = table.Column<int>(type: "int", nullable: true),
                    DADAGEO = table.Column<int>(type: "int", nullable: true),
                    SIBS = table.Column<int>(type: "int", nullable: true),
                    NWINFSIB = table.Column<int>(type: "int", nullable: true),
                    SIB1_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB1_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB1_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB1_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB1_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB1_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB2_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB2_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB2_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB2_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB2_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB2_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB3_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB3_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB3_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB3_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB3_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB3_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB4_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB4_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB4_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB4_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB4_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB4_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB5_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB5_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB5_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB5_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB5_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB5_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB6_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB6_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB6_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB6_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB6_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB6_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB7_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB7_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB7_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB7_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB7_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB7_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB8_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB8_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB8_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB8_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB8_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB8_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB9_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB9_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB9_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB9_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB9_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB9_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB10_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB10_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB10_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB10_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB10_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB10_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB11_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB11_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB11_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB11_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB11_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB11_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB12_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB12_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB12_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB12_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB12_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB12_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB13_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB13_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB13_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB13_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB13_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB13_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB14_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB14_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB14_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB14_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB14_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB14_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB15_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB15_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB15_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB15_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB15_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB15_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB16_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB16_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB16_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB16_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB16_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB16_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB17_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB17_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB17_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB17_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB17_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB17_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB18_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB18_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB18_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB18_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB18_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB18_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB19_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB19_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB19_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB19_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB19_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB19_AGO = table.Column<int>(type: "int", nullable: true),
                    SIB20_YOB = table.Column<int>(type: "int", nullable: true),
                    SIB20_AGD = table.Column<int>(type: "int", nullable: true),
                    SIB20_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB20_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SIB20_MEVAL = table.Column<int>(type: "int", nullable: true),
                    SIB20_AGO = table.Column<int>(type: "int", nullable: true),
                    KIDS = table.Column<int>(type: "int", nullable: true),
                    NWINFKID = table.Column<int>(type: "int", nullable: true),
                    KID1_YOB = table.Column<int>(type: "int", nullable: true),
                    KID1_AGD = table.Column<int>(type: "int", nullable: true),
                    KID1_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID1_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID1_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID1_AGO = table.Column<int>(type: "int", nullable: true),
                    KID2_YOB = table.Column<int>(type: "int", nullable: true),
                    KID2_AGD = table.Column<int>(type: "int", nullable: true),
                    KID2_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID2_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID2_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID2_AGO = table.Column<int>(type: "int", nullable: true),
                    KID3_YOB = table.Column<int>(type: "int", nullable: true),
                    KID3_AGD = table.Column<int>(type: "int", nullable: true),
                    KID3_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID3_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID3_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID3_AGO = table.Column<int>(type: "int", nullable: true),
                    KID4_YOB = table.Column<int>(type: "int", nullable: true),
                    KID4_AGD = table.Column<int>(type: "int", nullable: true),
                    KID4_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID4_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID4_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID4_AGO = table.Column<int>(type: "int", nullable: true),
                    KID5_YOB = table.Column<int>(type: "int", nullable: true),
                    KID5_AGD = table.Column<int>(type: "int", nullable: true),
                    KID5_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID5_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID5_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID5_AGO = table.Column<int>(type: "int", nullable: true),
                    KID6_YOB = table.Column<int>(type: "int", nullable: true),
                    KID6_AGD = table.Column<int>(type: "int", nullable: true),
                    KID6_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID6_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID6_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID6_AGO = table.Column<int>(type: "int", nullable: true),
                    KID7_YOB = table.Column<int>(type: "int", nullable: true),
                    KID7_AGD = table.Column<int>(type: "int", nullable: true),
                    KID7_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID7_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID7_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID7_AGO = table.Column<int>(type: "int", nullable: true),
                    KID8_YOB = table.Column<int>(type: "int", nullable: true),
                    KID8_AGD = table.Column<int>(type: "int", nullable: true),
                    KID8_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID8_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID8_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID8_AGO = table.Column<int>(type: "int", nullable: true),
                    KID9_YOB = table.Column<int>(type: "int", nullable: true),
                    KID9_AGD = table.Column<int>(type: "int", nullable: true),
                    KID9_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID9_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID9_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID9_AGO = table.Column<int>(type: "int", nullable: true),
                    KID10_YOB = table.Column<int>(type: "int", nullable: true),
                    KID10_AGD = table.Column<int>(type: "int", nullable: true),
                    KID10_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID10_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID10_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID10_AGO = table.Column<int>(type: "int", nullable: true),
                    KID11_YOB = table.Column<int>(type: "int", nullable: true),
                    KID11_AGD = table.Column<int>(type: "int", nullable: true),
                    KID11_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID11_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID11_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID11_AGO = table.Column<int>(type: "int", nullable: true),
                    KID12_YOB = table.Column<int>(type: "int", nullable: true),
                    KID12_AGD = table.Column<int>(type: "int", nullable: true),
                    KID12_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID12_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID12_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID12_AGO = table.Column<int>(type: "int", nullable: true),
                    KID13_YOB = table.Column<int>(type: "int", nullable: true),
                    KID13_AGD = table.Column<int>(type: "int", nullable: true),
                    KID13_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID13_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID13_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID13_AGO = table.Column<int>(type: "int", nullable: true),
                    KID14_YOB = table.Column<int>(type: "int", nullable: true),
                    KID14_AGD = table.Column<int>(type: "int", nullable: true),
                    KID14_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID14_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID14_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID14_AGO = table.Column<int>(type: "int", nullable: true),
                    KID15_YOB = table.Column<int>(type: "int", nullable: true),
                    KID15_AGD = table.Column<int>(type: "int", nullable: true),
                    KID15_ETPR = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID15_ETSEC = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    KID15_MEVAL = table.Column<int>(type: "int", nullable: true),
                    KID15_AGO = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A3s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A3s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A4as",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRTBIOMARK = table.Column<int>(type: "int", nullable: true),
                    TARGETAB1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO1 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR1 = table.Column<int>(type: "int", nullable: true),
                    ENDMO1 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR1 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL1 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP1 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO2 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR2 = table.Column<int>(type: "int", nullable: true),
                    ENDMO2 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR2 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL2 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP2 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO3 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR3 = table.Column<int>(type: "int", nullable: true),
                    ENDMO3 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR3 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL3 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP3 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO4 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR4 = table.Column<int>(type: "int", nullable: true),
                    ENDMO4 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR4 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL4 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP4 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO5 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR5 = table.Column<int>(type: "int", nullable: true),
                    ENDMO5 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR5 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL5 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP5 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO6 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR6 = table.Column<int>(type: "int", nullable: true),
                    ENDMO6 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR6 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL6 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP6 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO7 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR7 = table.Column<int>(type: "int", nullable: true),
                    ENDMO7 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR7 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL7 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP7 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO8 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR8 = table.Column<int>(type: "int", nullable: true),
                    ENDMO8 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR8 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL8 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP8 = table.Column<int>(type: "int", nullable: true),
                    ADVEVENT = table.Column<int>(type: "int", nullable: true),
                    ARIAE = table.Column<bool>(type: "bit", nullable: true),
                    ARIAH = table.Column<bool>(type: "bit", nullable: true),
                    ADVERSEOTH = table.Column<bool>(type: "bit", nullable: true),
                    ADVERSEOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4as", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4as_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A4s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANYMEDS = table.Column<int>(type: "int", nullable: true),
                    RXNORMID1_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID2_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID3_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID4_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID5_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID6_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID7_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID8_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID9_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID10_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID11_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID12_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID13_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID14_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID15_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID16_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID17_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID18_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID19_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID20_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID21_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID22_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID23_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID24_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID25_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID26_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID27_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID28_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID29_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID30_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID31_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID32_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID33_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID34_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID35_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID36_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID37_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID38_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID39_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID40_RxNormId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID10_RxNormId",
                        column: x => x.RXNORMID10_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID11_RxNormId",
                        column: x => x.RXNORMID11_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID12_RxNormId",
                        column: x => x.RXNORMID12_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID13_RxNormId",
                        column: x => x.RXNORMID13_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID14_RxNormId",
                        column: x => x.RXNORMID14_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID15_RxNormId",
                        column: x => x.RXNORMID15_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID16_RxNormId",
                        column: x => x.RXNORMID16_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID17_RxNormId",
                        column: x => x.RXNORMID17_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID18_RxNormId",
                        column: x => x.RXNORMID18_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID19_RxNormId",
                        column: x => x.RXNORMID19_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID1_RxNormId",
                        column: x => x.RXNORMID1_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID20_RxNormId",
                        column: x => x.RXNORMID20_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID21_RxNormId",
                        column: x => x.RXNORMID21_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID22_RxNormId",
                        column: x => x.RXNORMID22_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID23_RxNormId",
                        column: x => x.RXNORMID23_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID24_RxNormId",
                        column: x => x.RXNORMID24_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID25_RxNormId",
                        column: x => x.RXNORMID25_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID26_RxNormId",
                        column: x => x.RXNORMID26_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID27_RxNormId",
                        column: x => x.RXNORMID27_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID28_RxNormId",
                        column: x => x.RXNORMID28_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID29_RxNormId",
                        column: x => x.RXNORMID29_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID2_RxNormId",
                        column: x => x.RXNORMID2_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID30_RxNormId",
                        column: x => x.RXNORMID30_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID31_RxNormId",
                        column: x => x.RXNORMID31_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID32_RxNormId",
                        column: x => x.RXNORMID32_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID33_RxNormId",
                        column: x => x.RXNORMID33_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID34_RxNormId",
                        column: x => x.RXNORMID34_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID35_RxNormId",
                        column: x => x.RXNORMID35_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID36_RxNormId",
                        column: x => x.RXNORMID36_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID37_RxNormId",
                        column: x => x.RXNORMID37_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID38_RxNormId",
                        column: x => x.RXNORMID38_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID39_RxNormId",
                        column: x => x.RXNORMID39_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID3_RxNormId",
                        column: x => x.RXNORMID3_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID40_RxNormId",
                        column: x => x.RXNORMID40_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID4_RxNormId",
                        column: x => x.RXNORMID4_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID5_RxNormId",
                        column: x => x.RXNORMID5_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID6_RxNormId",
                        column: x => x.RXNORMID6_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID7_RxNormId",
                        column: x => x.RXNORMID7_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID8_RxNormId",
                        column: x => x.RXNORMID8_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID9_RxNormId",
                        column: x => x.RXNORMID9_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A5D2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOBAC100 = table.Column<int>(type: "int", nullable: true, comment: "Has participant smoked more than 100 cigarettes in their life?"),
                    SMOKYRS = table.Column<int>(type: "int", nullable: true, comment: "Total years smoked"),
                    PACKSPER = table.Column<int>(type: "int", nullable: true, comment: "Average number of packs smoked per day"),
                    TOBAC30 = table.Column<int>(type: "int", nullable: true, comment: "Has participant smoked within the last 30 days?"),
                    QUITSMOK = table.Column<int>(type: "int", nullable: true, comment: "If the participant quit smoking, specify the age at which they last smoked (i.e., quit)"),
                    ALCFREQYR = table.Column<int>(type: "int", nullable: true, comment: "In the past 12 months, how often has the participant had a drink containing alcohol?"),
                    ALCDRINKS = table.Column<int>(type: "int", nullable: true, comment: "On a day when the participant drinks alcoholic beverages, how many standard drinks does the participant typically consume?"),
                    ALCBINGE = table.Column<int>(type: "int", nullable: true, comment: "In the past 12 months, how often did the participant have six or more drinks containing alcohol in one day?"),
                    SUBSTYEAR = table.Column<int>(type: "int", nullable: true, comment: "Participant used substances including prescription or recreational drugs that caused significant impairment in work, legal, driving, or social areas within the past 12 months"),
                    SUBSTPAST = table.Column<int>(type: "int", nullable: true, comment: "Participant used substances including prescription or recreational drugs that caused significant impairment in work, legal, driving, or social areas prior to 12 months ago"),
                    CANNABIS = table.Column<int>(type: "int", nullable: true, comment: "In the past 12 months, how often has the participant consumed cannabis (edibles, smoked, or vaporized)?"),
                    HRTATTACK = table.Column<int>(type: "int", nullable: true, comment: "Heart attack (heart artery blockage)"),
                    HRTATTMULT = table.Column<int>(type: "int", nullable: true, comment: "More than one heart attack?"),
                    HRTATTAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent heart attack"),
                    CARDARREST = table.Column<int>(type: "int", nullable: true, comment: "Cardiac arrest (heart stopped)"),
                    CARDARRAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent cardiac arrest"),
                    CVAFIB = table.Column<int>(type: "int", nullable: true, comment: "Atrial fibrillation"),
                    CVANGIO = table.Column<int>(type: "int", nullable: true, comment: "Coronary artery angioplasty / endarterectomy / stenting"),
                    CVBYPASS = table.Column<int>(type: "int", nullable: true, comment: "Coronary artery bypass procedure"),
                    BYPASSAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent coronary artery bypass surgery"),
                    CVPACDEF = table.Column<int>(type: "int", nullable: true, comment: "Pacemaker and/or defibrillator implantation"),
                    PACDEFAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at first pacemaker and/or defibrillator implantation"),
                    CVCHF = table.Column<int>(type: "int", nullable: true, comment: "Congestive heart failure (including pulmonary edema)"),
                    CVHVALVE = table.Column<int>(type: "int", nullable: true, comment: "Heart valve replacement or repair"),
                    VALVEAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent heart valve replacement or repair procedure"),
                    CVOTHR = table.Column<int>(type: "int", nullable: true, comment: "Other cardiovascular disease"),
                    CVOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other cardiovascular disease"),
                    CBSTROKE = table.Column<int>(type: "int", nullable: true, comment: "Stroke by history, not exam (imaging is not required)"),
                    STROKMUL = table.Column<int>(type: "int", nullable: true, comment: "More than one stroke?"),
                    STROKAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent stroke"),
                    STROKSTAT = table.Column<int>(type: "int", nullable: true, comment: "What is status of stroke symptoms?"),
                    ANGIOCP = table.Column<int>(type: "int", nullable: true, comment: "Carotid artery surgery or stenting?"),
                    CAROTIDAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent carotid artery surgery or stenting"),
                    CBTIA = table.Column<int>(type: "int", nullable: true, comment: "Transient ischemic attack (TIA)"),
                    TIAAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent TIA"),
                    PD = table.Column<int>(type: "int", nullable: true, comment: "Parkinson’s disease (PD)"),
                    PDAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at estimated PD symptom onset"),
                    PDOTHR = table.Column<int>(type: "int", nullable: true, comment: "Other parkinsonism disorder (e.g., DLB)"),
                    PDOTHRAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at parkinsonism disorder diagnosis"),
                    SEIZURES = table.Column<int>(type: "int", nullable: true, comment: "Epilepsy and/or history of seizures (excluding childhood febrile seizures)"),
                    SEIZNUM = table.Column<int>(type: "int", nullable: true, comment: "How many seizures has the participant had in the past 12 months?"),
                    SEIZAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at first seizure (excluding childhood febrile seizures)"),
                    HEADACHE = table.Column<int>(type: "int", nullable: true, comment: "Chronic headaches"),
                    MS = table.Column<int>(type: "int", nullable: true, comment: "Multiple sclerosis"),
                    HYDROCEPH = table.Column<int>(type: "int", nullable: true, comment: "Normal-pressure hydrocephalus"),
                    HEADIMP = table.Column<int>(type: "int", nullable: true, comment: "epetitive head impacts (e.g. from contact sports, intimate partner violence, or military duty), regardless of whether it caused symptoms."),
                    IMPAMFOOT = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: American football"),
                    IMPSOCCER = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Soccer"),
                    IMPHOCKEY = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Ice hockey"),
                    IMPBOXING = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Boxing or mixed martial arts"),
                    IMPSPORT = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Other contact sport"),
                    IMPIPV = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Intimate partner violence"),
                    IMPMILIT = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Military service"),
                    IMPASSAULT = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Physical assault"),
                    IMPOTHER = table.Column<bool>(type: "bit", nullable: true, comment: "Source of exposure for repeated hits to the head: Other cause"),
                    IMPOTHERX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other source of exposure for repeated hits to the head"),
                    IMPYEARS = table.Column<int>(type: "int", nullable: true, comment: "The total length of time in years that the participant was exposed to repeated hits to the head (e.g. playing American football for 7 years)"),
                    HEADINJURY = table.Column<int>(type: "int", nullable: true, comment: "Head injury (e.g. in a vehicle accident, being hit by an object...)"),
                    HEADINJUNC = table.Column<int>(type: "int", nullable: true, comment: "After a head injury, what was the longest period of time that the participant was unconscious?"),
                    HEADINJCON = table.Column<int>(type: "int", nullable: true, comment: "After a head injury, what was the longest period..."),
                    HEADINJNUM = table.Column<int>(type: "int", nullable: true, comment: "Total number of head injuries"),
                    FIRSTTBI = table.Column<int>(type: "int", nullable: true, comment: "Age of first head injury"),
                    LASTTBI = table.Column<int>(type: "int", nullable: true, comment: "Age of most recent head injury"),
                    DIABETES = table.Column<int>(type: "int", nullable: true, comment: "Diabetes"),
                    DIABTYPE = table.Column<int>(type: "int", nullable: true, comment: "Diabetes type"),
                    DIABINS = table.Column<bool>(type: "bit", nullable: true, comment: "Diabetes treated with: Insulin"),
                    DIABMEDS = table.Column<bool>(type: "bit", nullable: true, comment: "Diabetes treated with: Oral medications"),
                    DIABDIET = table.Column<bool>(type: "bit", nullable: true, comment: "Diabetes treated with: Diet"),
                    DIABUNK = table.Column<bool>(type: "bit", nullable: true, comment: "Diabetes treated with: Unknown"),
                    DIABAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at diabetes diagnosis"),
                    HYPERTEN = table.Column<int>(type: "int", nullable: true, comment: "Hypertension (or taking medication for hypertension)"),
                    HYPERTAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at hypertension diagnosis"),
                    HYPERCHO = table.Column<int>(type: "int", nullable: true, comment: "Hypercholesterolemia (or taking medication for high cholesterol)"),
                    HYPERCHAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at hypercholesterolemia diagnosis"),
                    B12DEF = table.Column<int>(type: "int", nullable: true, comment: "B12 deficiency"),
                    THYROID = table.Column<int>(type: "int", nullable: true, comment: "Thyroid disease"),
                    ARTHRIT = table.Column<int>(type: "int", nullable: true, comment: "Arthritis"),
                    ARTHRRHEUM = table.Column<bool>(type: "bit", nullable: true, comment: "Type of arthritis: Rheumatoid"),
                    ARTHROSTEO = table.Column<bool>(type: "bit", nullable: true, comment: "Type of arthritis: Osteoarthritis"),
                    ARTHROTHR = table.Column<bool>(type: "bit", nullable: true, comment: "Type of arthritis: Other"),
                    ARTHTYPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other type of arthritis"),
                    ARTHTYPUNK = table.Column<bool>(type: "bit", nullable: true, comment: "Type of arthritis: Unknown"),
                    ARTHUPEX = table.Column<bool>(type: "bit", nullable: true, comment: "Upper extremity affected by arthritis"),
                    ARTHLOEX = table.Column<bool>(type: "bit", nullable: true, comment: "Lower extremity affected by arthritis"),
                    ARTHSPIN = table.Column<bool>(type: "bit", nullable: true, comment: "Spine affected by arthritis"),
                    ARTHUNK = table.Column<bool>(type: "bit", nullable: true, comment: "Region affected by arthritis unknown"),
                    INCONTU = table.Column<int>(type: "int", nullable: true, comment: "Incontinence—urinary (occurring at least weekly)"),
                    INCONTF = table.Column<int>(type: "int", nullable: true, comment: "Incontinence—bowel (occurring at least weekly)"),
                    APNEA = table.Column<int>(type: "int", nullable: true, comment: "Sleep apnea"),
                    CPAP = table.Column<int>(type: "int", nullable: true, comment: "Typical use of breathing machine (e.g. CPAP) at night over the past 12 months"),
                    APNEAORAL = table.Column<int>(type: "int", nullable: true, comment: "Typical use of an oral device for sleep apnea at night over the past 12 months?"),
                    RBD = table.Column<int>(type: "int", nullable: true, comment: "REM sleep behavior disorder"),
                    INSOMN = table.Column<int>(type: "int", nullable: true, comment: "Hyposomnia/Insomnia (occurring at least weekly or requiring medication)"),
                    OTHSLEEP = table.Column<int>(type: "int", nullable: true, comment: "Other sleep disorder"),
                    OTHSLEEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other sleep disorder"),
                    CANCER = table.Column<int>(type: "int", nullable: true, comment: "Cancer, primary or metastatic (Report all known diagnoses. Exclude non-melanoma skin cancer.)"),
                    CANCERPRIM = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer: Primary/non-metastatic"),
                    CANCERMETA = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer: Metastatic"),
                    CANCMETBR = table.Column<bool>(type: "bit", nullable: true, comment: "Type of metastatic cancer: Metatstic to brain"),
                    CANCMETOTH = table.Column<bool>(type: "bit", nullable: true, comment: "Type of metastatic cancer: Metastatic to sites other than brain"),
                    CANCERUNK = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer: Unknown"),
                    CANCBLOOD = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Blood"),
                    CANCBREAST = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Breast"),
                    CANCCOLON = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Colon"),
                    CANCLUNG = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Lung"),
                    CANCPROST = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Prostate"),
                    CANCOTHER = table.Column<bool>(type: "bit", nullable: true, comment: "Primary site of cancer: Other"),
                    CANCOTHERX = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Specify other primary site of cancer"),
                    CANCRAD = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Radiation"),
                    CANCRESECT = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Surgical resection"),
                    CANCIMMUNO = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Immunotherapy"),
                    CANCBONE = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Bone marrow transplant"),
                    CANCCHEMO = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Chemotherapy"),
                    CANCHORM = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Hormone therapy"),
                    CANCTROTH = table.Column<bool>(type: "bit", nullable: true, comment: "Type of cancer treatment: Other"),
                    CANCTROTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other type of cancer treatment"),
                    CANCERAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at most recent cancer diagnosis"),
                    COVID19 = table.Column<int>(type: "int", nullable: true, comment: "COVID-19 infection"),
                    COVIDHOSP = table.Column<int>(type: "int", nullable: true, comment: "COVID-19 infection requiring hospitalization?"),
                    PULMONARY = table.Column<int>(type: "int", nullable: true, comment: "Asthma/COPD/pulmonary disease"),
                    KIDNEY = table.Column<int>(type: "int", nullable: true, comment: "Chronic kidney disease"),
                    KIDNEYAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at chronic kidney disease diagnosis"),
                    LIVER = table.Column<int>(type: "int", nullable: true, comment: "Liver disease"),
                    LIVERAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at liver disease diagnosis"),
                    PVD = table.Column<int>(type: "int", nullable: true, comment: "Peripheral vascular disease"),
                    PVDAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at peripheral vascular disease diagnosis"),
                    HIVDIAG = table.Column<int>(type: "int", nullable: true, comment: "Human Immunodeficiency Virus"),
                    HIVAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at HIV diagnosis"),
                    OTHCOND = table.Column<int>(type: "int", nullable: true, comment: "Other medical conditions or procedures"),
                    OTHCONDX = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Specify other medical conditions or procedures"),
                    MAJORDEP = table.Column<int>(type: "int", nullable: true, comment: "Major depressive disorder (DSM-5-TR criteria)"),
                    OTHERDEP = table.Column<int>(type: "int", nullable: true, comment: "Other specified depressive disorder (DSm-5-TR criteria)"),
                    DEPRTREAT = table.Column<bool>(type: "bit", nullable: true, comment: "Choose if treated or untreated"),
                    BIPOLAR = table.Column<int>(type: "int", nullable: true, comment: "Bipolar disorder(DSM - 5 - TR criteria)"),
                    SCHIZ = table.Column<int>(type: "int", nullable: true, comment: "Schizophrenia or other psychosis disorder (DSM-5-TR criteria)"),
                    ANXIETY = table.Column<int>(type: "int", nullable: true, comment: "Anxiety disorder (DSM-5-TR criteria)"),
                    GENERALANX = table.Column<int>(type: "int", nullable: true, comment: "Generalized Anxiety Disorder"),
                    PANICDIS = table.Column<int>(type: "int", nullable: true, comment: "Panic Disorder"),
                    OCD = table.Column<int>(type: "int", nullable: true, comment: "Obsessive-compulsive disorder (OCD)"),
                    OTHANXDIS = table.Column<int>(type: "int", nullable: true, comment: "Other anxiety disorder"),
                    OTHANXDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other anxiety disorder"),
                    PTSD = table.Column<int>(type: "int", nullable: true, comment: "Post-traumatic stress disorder (PTSD) (DSM-5-TR criteria)"),
                    NPSYDEV = table.Column<int>(type: "int", nullable: true, comment: "Developmental neuropsychiatric disorders"),
                    PSYCDIS = table.Column<int>(type: "int", nullable: true, comment: "Other psychiatric disorders"),
                    PSYCDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other psychiatric disorders"),
                    MENARCHE = table.Column<int>(type: "int", nullable: true, comment: "How old was the participant when they had their first menstrual period?"),
                    NOMENSAGE = table.Column<int>(type: "int", nullable: true, comment: "How old was the participant when they had their last menstrual period?"),
                    NOMENSNAT = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to natural menopause"),
                    NOMENSHYST = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to hysterectomy (surgical removal of uterus)"),
                    NOMENSSURG = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to surgical removal of both ovaries"),
                    NOMENSCHEM = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to chemotherapy for cancer or another condition"),
                    NOMENSRAD = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to radiation treatment or other damage/injury to reproductive organs"),
                    NOMENSHORM = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to hormonal supplements (e.g. the Pill, injections, Mirena, HRT)"),
                    NOMENSESTR = table.Column<bool>(type: "bit", nullable: true, comment: "Participant has stopped having menstrual periods due to anti-estrogen medication"),
                    NOMENSUNK = table.Column<bool>(type: "bit", nullable: true, comment: "Unsure of reason participant has stopped having menstrual periods"),
                    NOMENSOTH = table.Column<bool>(type: "bit", nullable: true, comment: "Other reason participant has stopped having menstrual periods"),
                    NOMENSOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other reason participant has stopped having menstrual periods"),
                    HRT = table.Column<int>(type: "int", nullable: true, comment: "Has the participant taken female hormone replacement pills or patches (e.g. estrogen)?"),
                    HRTYEARS = table.Column<int>(type: "int", nullable: true, comment: "Total number of years participant has taken female hormone replacement pills"),
                    HRTSTRTAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at first use of female hormone replacement pills"),
                    HRTENDAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at last use of female hormone replacement pills"),
                    BCPILLS = table.Column<int>(type: "int", nullable: true, comment: "Has the participant ever taken birth control pills?"),
                    BCPILLSYR = table.Column<int>(type: "int", nullable: true, comment: "Total number of years participant has taken birth control pills"),
                    BCSTARTAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at first use of birth control pills"),
                    BCENDAGE = table.Column<int>(type: "int", nullable: true, comment: "Age at last use of birth control pills"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A5D2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A5D2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEIGHT = table.Column<decimal>(type: "decimal(3,1)", nullable: true, comment: "Participant height (inches)"),
                    WEIGHT = table.Column<int>(type: "int", nullable: true, comment: "Participant weight (lbs.)"),
                    WAIST1 = table.Column<int>(type: "int", nullable: true, comment: "Waist circumference measurements (inches): Measurement 1"),
                    WAIST2 = table.Column<int>(type: "int", nullable: true, comment: "Waist circumference measurements (inches): Measurement 2"),
                    HIP1 = table.Column<int>(type: "int", nullable: true, comment: "Hip circumference measurements (inches): Measurement 1"),
                    HIP2 = table.Column<int>(type: "int", nullable: true, comment: "Hip circumference measurements (inches): Measurement 2"),
                    BPSYSL1 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Left arm: Systolic Reading 1"),
                    BPDIASL1 = table.Column<int>(type: "int", nullable: true, comment: " Participant blood pressure - Left arm: Diastolic Reading 1"),
                    BPSYSL2 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Left arm: Systolic Reading 2"),
                    BPDIASL2 = table.Column<int>(type: "int", nullable: true, comment: " Participant blood pressure - Left arm: Diastolic Reading 2"),
                    BPSYSR1 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Right arm: Systolic Reading 1"),
                    BPDIASR1 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Right arm: Diastolic Reading 1"),
                    BPSYSR2 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Right arm: Systolic Reading 2"),
                    BPDIASR2 = table.Column<int>(type: "int", nullable: true, comment: "Participant blood pressure - Right arm: Diastolic Reading 2"),
                    HRATE = table.Column<int>(type: "int", nullable: true, comment: "Participant resting heart rate (pulse)"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B3s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PDNORMAL = table.Column<bool>(type: "bit", nullable: true),
                    SPEECH = table.Column<int>(type: "int", nullable: true),
                    SPEECHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FACEXP = table.Column<int>(type: "int", nullable: true),
                    FACEXPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTFAC = table.Column<int>(type: "int", nullable: true),
                    TRESTFAX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTRHD = table.Column<int>(type: "int", nullable: true),
                    TRESTRHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTLHD = table.Column<int>(type: "int", nullable: true),
                    TRESTLHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTRFT = table.Column<int>(type: "int", nullable: true),
                    TRESTRFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTLFT = table.Column<int>(type: "int", nullable: true),
                    TRESTLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRACTRHD = table.Column<int>(type: "int", nullable: true),
                    TRACTRHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRACTLHD = table.Column<int>(type: "int", nullable: true),
                    TRACTLHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDNECK = table.Column<int>(type: "int", nullable: true),
                    RIGDNEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDUPRT = table.Column<int>(type: "int", nullable: true),
                    RIGDUPRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDUPLF = table.Column<int>(type: "int", nullable: true),
                    RIGDUPLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDLORT = table.Column<int>(type: "int", nullable: true),
                    RIGDLORX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDLOLF = table.Column<int>(type: "int", nullable: true),
                    RIGDLOLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TAPSRT = table.Column<int>(type: "int", nullable: true),
                    TAPSRTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TAPSLF = table.Column<int>(type: "int", nullable: true),
                    TAPSLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDMOVR = table.Column<int>(type: "int", nullable: true),
                    HANDMVRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDMOVL = table.Column<int>(type: "int", nullable: true),
                    HANDMVLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDALTR = table.Column<int>(type: "int", nullable: true),
                    HANDATRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDALTL = table.Column<int>(type: "int", nullable: true),
                    HANDATLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LEGRT = table.Column<int>(type: "int", nullable: true),
                    LEGRTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LEGLF = table.Column<int>(type: "int", nullable: true),
                    LEGLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARISING = table.Column<int>(type: "int", nullable: true),
                    ARISINGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    POSTURE = table.Column<int>(type: "int", nullable: true),
                    POSTUREX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    GAIT = table.Column<int>(type: "int", nullable: true),
                    GAITX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    POSSTAB = table.Column<int>(type: "int", nullable: true),
                    POSSTABX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BRADYKIN = table.Column<int>(type: "int", nullable: true),
                    BRADYKIX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TOTALUPDRS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B3s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B3s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B4s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MEMORY = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    ORIENT = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    JUDGMENT = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    COMMUN = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    HOMEHOBB = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    PERSCARE = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CDRSUM = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    CDRGLOB = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    COMPORT = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CDRLANG = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B4s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B4s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B5s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NPIQINF = table.Column<int>(type: "int", nullable: true),
                    NPIQINFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DEL = table.Column<int>(type: "int", nullable: true),
                    DELSEV = table.Column<int>(type: "int", nullable: true),
                    HALL = table.Column<int>(type: "int", nullable: true),
                    HALLSEV = table.Column<int>(type: "int", nullable: true),
                    AGIT = table.Column<int>(type: "int", nullable: true),
                    AGITSEV = table.Column<int>(type: "int", nullable: true),
                    DEPD = table.Column<int>(type: "int", nullable: true),
                    DEPDSEV = table.Column<int>(type: "int", nullable: true),
                    ANX = table.Column<int>(type: "int", nullable: true),
                    ANXSEV = table.Column<int>(type: "int", nullable: true),
                    ELAT = table.Column<int>(type: "int", nullable: true),
                    ELATSEV = table.Column<int>(type: "int", nullable: true),
                    APA = table.Column<int>(type: "int", nullable: true),
                    APASEV = table.Column<int>(type: "int", nullable: true),
                    DISN = table.Column<int>(type: "int", nullable: true),
                    DISNSEV = table.Column<int>(type: "int", nullable: true),
                    IRR = table.Column<int>(type: "int", nullable: true),
                    IRRSEV = table.Column<int>(type: "int", nullable: true),
                    MOT = table.Column<int>(type: "int", nullable: true),
                    MOTSEV = table.Column<int>(type: "int", nullable: true),
                    NITE = table.Column<int>(type: "int", nullable: true),
                    NITESEV = table.Column<int>(type: "int", nullable: true),
                    APP = table.Column<int>(type: "int", nullable: true),
                    APPSEV = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B5s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B5s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B6s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOGDS = table.Column<int>(type: "int", nullable: true),
                    SATIS = table.Column<int>(type: "int", nullable: true),
                    DROPACT = table.Column<int>(type: "int", nullable: true),
                    EMPTY = table.Column<int>(type: "int", nullable: true),
                    BORED = table.Column<int>(type: "int", nullable: true),
                    SPIRITS = table.Column<int>(type: "int", nullable: true),
                    AFRAID = table.Column<int>(type: "int", nullable: true),
                    HAPPY = table.Column<int>(type: "int", nullable: true),
                    HELPLESS = table.Column<int>(type: "int", nullable: true),
                    STAYHOME = table.Column<int>(type: "int", nullable: true),
                    MEMPROB = table.Column<int>(type: "int", nullable: true),
                    WONDRFUL = table.Column<int>(type: "int", nullable: true),
                    WRTHLESS = table.Column<int>(type: "int", nullable: true),
                    ENERGY = table.Column<int>(type: "int", nullable: true),
                    HOPELESS = table.Column<int>(type: "int", nullable: true),
                    BETTER = table.Column<int>(type: "int", nullable: true),
                    GDS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B6s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B6s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B7s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BILLS = table.Column<int>(type: "int", nullable: true),
                    TAXES = table.Column<int>(type: "int", nullable: true),
                    SHOPPING = table.Column<int>(type: "int", nullable: true),
                    GAMES = table.Column<int>(type: "int", nullable: true),
                    STOVE = table.Column<int>(type: "int", nullable: true),
                    MEALPREP = table.Column<int>(type: "int", nullable: true),
                    EVENTS = table.Column<int>(type: "int", nullable: true),
                    PAYATTN = table.Column<int>(type: "int", nullable: true),
                    REMDATES = table.Column<int>(type: "int", nullable: true),
                    TRAVEL = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B7s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B7s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B8s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NEUREXAM = table.Column<int>(type: "int", nullable: true),
                    NORMNREXAM = table.Column<bool>(type: "bit", nullable: true),
                    PARKSIGN = table.Column<int>(type: "int", nullable: true),
                    SLOWINGFM = table.Column<int>(type: "int", nullable: true),
                    TREMREST = table.Column<int>(type: "int", nullable: true),
                    TREMPOST = table.Column<int>(type: "int", nullable: true),
                    TREMKINE = table.Column<int>(type: "int", nullable: true),
                    RIGIDARM = table.Column<int>(type: "int", nullable: true),
                    RIGIDLEG = table.Column<int>(type: "int", nullable: true),
                    DYSTARM = table.Column<int>(type: "int", nullable: true),
                    DYSTLEG = table.Column<int>(type: "int", nullable: true),
                    CHOREA = table.Column<int>(type: "int", nullable: true),
                    AMPMOTOR = table.Column<int>(type: "int", nullable: true),
                    AXIALRIG = table.Column<int>(type: "int", nullable: true),
                    POSTINST = table.Column<int>(type: "int", nullable: true),
                    MASKING = table.Column<int>(type: "int", nullable: true),
                    STOOPED = table.Column<int>(type: "int", nullable: true),
                    OTHERSIGN = table.Column<int>(type: "int", nullable: true),
                    LIMBAPRAX = table.Column<int>(type: "int", nullable: true),
                    UMNDIST = table.Column<int>(type: "int", nullable: true),
                    LMNDIST = table.Column<int>(type: "int", nullable: true),
                    VFIELDCUT = table.Column<int>(type: "int", nullable: true),
                    LIMBATAX = table.Column<int>(type: "int", nullable: true),
                    MYOCLON = table.Column<int>(type: "int", nullable: true),
                    UNISOMATO = table.Column<int>(type: "int", nullable: true),
                    APHASIA = table.Column<int>(type: "int", nullable: true),
                    ALIENLIMB = table.Column<int>(type: "int", nullable: true),
                    HSPATNEG = table.Column<int>(type: "int", nullable: true),
                    PSPOAGNO = table.Column<int>(type: "int", nullable: true),
                    SMTAGNO = table.Column<int>(type: "int", nullable: true),
                    OPTICATAX = table.Column<int>(type: "int", nullable: true),
                    APRAXGAZE = table.Column<int>(type: "int", nullable: true),
                    VHGAZEPAL = table.Column<int>(type: "int", nullable: true),
                    DYSARTH = table.Column<int>(type: "int", nullable: true),
                    APRAXSP = table.Column<int>(type: "int", nullable: true),
                    GAITABN = table.Column<int>(type: "int", nullable: true),
                    GAITFIND = table.Column<int>(type: "int", nullable: true),
                    GAITOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B8s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B8s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_B9s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DECCOG = table.Column<int>(type: "int", nullable: true, comment: "Does the participant report a decline in any cognitive domain (relative to stable baseline prior to onset of current syndrome)?"),
                    DECMOT = table.Column<int>(type: "int", nullable: true, comment: "Does the participant report a decline in any motor domain (relative to stable baseline prior to onset of current syndrome)?"),
                    PSYCHSYM = table.Column<int>(type: "int", nullable: true, comment: "Does the participant report the development of any significant neuropsychiatric/behavioral symptoms (relative to stable baseline prior to onset of current syndrome)?"),
                    DECCOGIN = table.Column<int>(type: "int", nullable: true, comment: "Does the co-participant report a decline in any cognitive domain (relative to stable baseline prior to onset of current syndrome)?"),
                    DECMOTIN = table.Column<int>(type: "int", nullable: true, comment: "Does the co-participant report a change in any motor domain (relative to stable baseline prior to onset of current syndrome)?"),
                    PSYCHSYMIN = table.Column<int>(type: "int", nullable: true, comment: "Does the co-participant report the development of any significant neuropsychiatric/behavioral symptoms (relative to stable baseline prior to onset of current syndrome)?"),
                    DECCLIN = table.Column<bool>(type: "bit", nullable: true, comment: "Does the participant have any neuropsychiatric/behavioral symptoms or declines in any cognitive or motor domain?"),
                    DECCLCOG = table.Column<bool>(type: "bit", nullable: true, comment: "Based on the clinician’s judgment, is the participant currently experiencing meaningful impairment in cognition?"),
                    COGMEM = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in memory."),
                    COGORI = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in orientation."),
                    COGJUDG = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in executive function (judgment, planning, and problem-solving)"),
                    COGLANG = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in language"),
                    COGVIS = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in visuospatial function"),
                    COGATTN = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently is meaningfully impaired in attention/concentration"),
                    COGFLUC = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has fluctuating cognition"),
                    COGOTHR = table.Column<int>(type: "int", nullable: true, comment: "Other cognitive impairment"),
                    COGOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other cognitive domains"),
                    COGAGE = table.Column<int>(type: "int", nullable: true, comment: "If any of the cognitive-related behavioral symptoms in 9a-9h are present, at what age did they begin?"),
                    COGMODE = table.Column<int>(type: "int", nullable: true, comment: "Indicate the mode of onset for the most prominent cognitive problem that is causing the participant's complaints and/or affecting the participant's function."),
                    COGMODEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other mode of onset of cognitive symptoms"),
                    DECCLBE = table.Column<int>(type: "int", nullable: true, comment: "Based on the clinician’s judgment, is the participant currently experiencing any kind of behavioral symptoms?"),
                    BEAPATHY = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Apathy, withdrawal"),
                    BEDEP = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Depressed mood"),
                    BEANX = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Anxiety"),
                    BEEUPH = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior - Euphoria"),
                    BEIRRIT = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Irritability"),
                    BEAGIT = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Agitation"),
                    BEHAGE = table.Column<int>(type: "int", nullable: true, comment: "If any of the mood-related behavioral symptoms in 12a-12f are present, at what age did they begin?"),
                    BEVHALL = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Psychosis — Visual hallucinations"),
                    BEVPATT = table.Column<int>(type: "int", nullable: true, comment: "IF YES, do their hallucinations include patterns that are not definite objects, such as pixelation of flat uniform surfaces?"),
                    BEVWELL = table.Column<int>(type: "int", nullable: true, comment: "IF YES, do their hallucinations include well formed and detailed images of objects or people, either as independent images or as part of other objects?"),
                    BEAHALL = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Psychosis — Auditory hallucinations"),
                    BEAHSIMP = table.Column<int>(type: "int", nullable: true, comment: "IF YES, do the auditory hallucinations include simple sounds like knocks or other simple sounds?"),
                    BEAHCOMP = table.Column<int>(type: "int", nullable: true, comment: "IF YES, do the auditory hallucinations include complex sounds like voices speaking words, or music?"),
                    BEDEL = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Psychosis — Abnormal, false, or delusional beliefs"),
                    BEAGGRS = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Aggression"),
                    PSYCHAGE = table.Column<int>(type: "int", nullable: true, comment: "If any of the psychosis and impulse control-related behavioral symptoms in 12h-12k are present, at what age did they begin?"),
                    BEDISIN = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Disinhibition"),
                    BEPERCH = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Personality change"),
                    BEEMPATH = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Loss of empathy"),
                    BEOBCOM = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Obsessions/compulsions"),
                    BEANGER = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — Explosive anger"),
                    BESUBAB = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior - Substance use"),
                    ALCUSE = table.Column<bool>(type: "bit", nullable: true, comment: "Alcohol use"),
                    SEDUSE = table.Column<bool>(type: "bit", nullable: true, comment: "Sedative/hypnotic use"),
                    OPIATEUSE = table.Column<bool>(type: "bit", nullable: true, comment: "Opiate use"),
                    COCAINEUSE = table.Column<bool>(type: "bit", nullable: true, comment: "Cocaine use"),
                    OTHSUBUSE = table.Column<bool>(type: "bit", nullable: true, comment: "Other substance use"),
                    OTHSUBUSEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Specify other substance use"),
                    PERCHAGE = table.Column<int>(type: "int", nullable: true, comment: "If any of the personality-related behavioral symptoms in 12m-12r are present, at what age did they begin?"),
                    BEREM = table.Column<int>(type: "int", nullable: true, comment: "Participant currently manifests meaningful change in behavior — REM sleep behavior disorder"),
                    BEREMAGO = table.Column<int>(type: "int", nullable: true, comment: "IF YES, at what age did the dream enactment behavior begin?"),
                    BEREMCONF = table.Column<int>(type: "int", nullable: true, comment: "Was REM sleep behavior disorder confirmed by polysomnography?"),
                    BEOTHR = table.Column<int>(type: "int", nullable: true, comment: "Other behavioral symptom"),
                    BEOTHRX = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Participant currently manifests meaningful change in behavior - Other, specify"),
                    BEMODE = table.Column<int>(type: "int", nullable: true, comment: "Overall mode of onset for behavioral symptoms"),
                    BEMODEX = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Other mode of onset - specify"),
                    DECCLMOT = table.Column<bool>(type: "bit", nullable: true, comment: "Based on the clinician’s judgment, is the participant currently experiencing any motor symptoms?"),
                    MOGAIT = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Gait disorder"),
                    MOFALLS = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Falls"),
                    MOSLOW = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Slowness"),
                    MOTREM = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Tremor"),
                    MOLIMB = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Limb weakness"),
                    MOFACE = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Change in facial expression"),
                    MOSPEECH = table.Column<int>(type: "int", nullable: true, comment: "Indicate whether the participant currently has meaningful changes in motor function — Change in speech"),
                    MOTORAGE = table.Column<int>(type: "int", nullable: true, comment: "If changes in motor function are present in 15a-15g, at what age did they begin?"),
                    MOMODE = table.Column<int>(type: "int", nullable: true, comment: "Indicate the mode of onset for the most prominent motor problem that is causing the participant's complaints and/or affecting the participant's function."),
                    MOMODEX = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Indicate mode of onset for the most prominent motor problem that is causing the participant's complains and or affecting the participant's function - Other, specify"),
                    MOMOPARK = table.Column<int>(type: "int", nullable: true, comment: "Were changes in motor function suggestive of parkinsonism?"),
                    MOMOALS = table.Column<int>(type: "int", nullable: true, comment: "Were changes in motor function suggestive of amyotrophic lateral sclerosis?"),
                    COURSE = table.Column<int>(type: "int", nullable: true, comment: "Overall course of decline of cognitive / behavorial / motor syndrome"),
                    FRSTCHG = table.Column<int>(type: "int", nullable: true, comment: "Indicate the predominant domain that was first recognized as changed in the participant"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B9s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B9s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_C1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MMSECOMP = table.Column<int>(type: "int", nullable: true),
                    MMSEREAS = table.Column<int>(type: "int", nullable: true),
                    MMSELOC = table.Column<int>(type: "int", nullable: true),
                    MMSELAN = table.Column<int>(type: "int", nullable: true),
                    MMSELANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MMSEVIS = table.Column<int>(type: "int", nullable: true),
                    MMSEHEAR = table.Column<int>(type: "int", nullable: true),
                    MMSEORDA = table.Column<int>(type: "int", nullable: true),
                    MMSEORLO = table.Column<int>(type: "int", nullable: true),
                    PENTAGON = table.Column<int>(type: "int", nullable: true),
                    MMSE = table.Column<int>(type: "int", nullable: true),
                    NPSYCLOC = table.Column<int>(type: "int", nullable: true),
                    NPSYLAN = table.Column<int>(type: "int", nullable: true),
                    NPSYLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LOGIMO = table.Column<int>(type: "int", nullable: true),
                    LOGIDAY = table.Column<int>(type: "int", nullable: true),
                    LOGIYR = table.Column<int>(type: "int", nullable: true),
                    LOGIPREV = table.Column<int>(type: "int", nullable: true),
                    LOGIMEM = table.Column<int>(type: "int", nullable: true),
                    UDSBENTC = table.Column<int>(type: "int", nullable: true),
                    DIGIF = table.Column<int>(type: "int", nullable: true),
                    DIGIFLEN = table.Column<int>(type: "int", nullable: true),
                    DIGIB = table.Column<int>(type: "int", nullable: true),
                    DIGIBLEN = table.Column<int>(type: "int", nullable: true),
                    ANIMALS = table.Column<int>(type: "int", nullable: true),
                    VEG = table.Column<int>(type: "int", nullable: true),
                    TRAILA = table.Column<int>(type: "int", nullable: true),
                    TRAILARR = table.Column<int>(type: "int", nullable: true),
                    TRAILALI = table.Column<int>(type: "int", nullable: true),
                    TRAILB = table.Column<int>(type: "int", nullable: true),
                    TRAILBRR = table.Column<int>(type: "int", nullable: true),
                    TRAILBLI = table.Column<int>(type: "int", nullable: true),
                    MEMUNITS = table.Column<int>(type: "int", nullable: true),
                    MEMTIME = table.Column<int>(type: "int", nullable: true),
                    UDSBENTD = table.Column<int>(type: "int", nullable: true),
                    UDSBENRS = table.Column<int>(type: "int", nullable: true),
                    BOSTON = table.Column<int>(type: "int", nullable: true),
                    UDSVERFC = table.Column<int>(type: "int", nullable: true),
                    UDSVERFN = table.Column<int>(type: "int", nullable: true),
                    UDSVERNF = table.Column<int>(type: "int", nullable: true),
                    UDSVERLC = table.Column<int>(type: "int", nullable: true),
                    UDSVERLR = table.Column<int>(type: "int", nullable: true),
                    UDSVERLN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTE = table.Column<int>(type: "int", nullable: true),
                    UDSVERTI = table.Column<int>(type: "int", nullable: true),
                    COGSTAT = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_C1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_C1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_C2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MOCACOMP = table.Column<int>(type: "int", nullable: true),
                    MOCAREAS = table.Column<int>(type: "int", nullable: true),
                    MOCALOC = table.Column<int>(type: "int", nullable: true),
                    MOCALAN = table.Column<int>(type: "int", nullable: true),
                    MOCALANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MOCAVIS = table.Column<int>(type: "int", nullable: true),
                    MOCAHEAR = table.Column<int>(type: "int", nullable: true),
                    MOCATOTS = table.Column<int>(type: "int", nullable: true),
                    MOCATRAI = table.Column<int>(type: "int", nullable: true),
                    MOCACUBE = table.Column<int>(type: "int", nullable: true),
                    MOCACLOC = table.Column<int>(type: "int", nullable: true),
                    MOCACLON = table.Column<int>(type: "int", nullable: true),
                    MOCACLOH = table.Column<int>(type: "int", nullable: true),
                    MOCANAMI = table.Column<int>(type: "int", nullable: true),
                    MOCAREGI = table.Column<int>(type: "int", nullable: true),
                    MOCADIGI = table.Column<int>(type: "int", nullable: true),
                    MOCALETT = table.Column<int>(type: "int", nullable: true),
                    MOCASER7 = table.Column<int>(type: "int", nullable: true),
                    MOCAREPE = table.Column<int>(type: "int", nullable: true),
                    MOCAFLUE = table.Column<int>(type: "int", nullable: true),
                    MOCAABST = table.Column<int>(type: "int", nullable: true),
                    MOCARECN = table.Column<int>(type: "int", nullable: true),
                    MOCARECC = table.Column<int>(type: "int", nullable: true),
                    MOCARECR = table.Column<int>(type: "int", nullable: true),
                    MOCAORDT = table.Column<int>(type: "int", nullable: true),
                    MOCAORMO = table.Column<int>(type: "int", nullable: true),
                    MOCAORYR = table.Column<int>(type: "int", nullable: true),
                    MOCAORDY = table.Column<int>(type: "int", nullable: true),
                    MOCAORPL = table.Column<int>(type: "int", nullable: true),
                    MOCAORCT = table.Column<int>(type: "int", nullable: true),
                    NPSYCLOC = table.Column<int>(type: "int", nullable: true),
                    NPSYLAN = table.Column<int>(type: "int", nullable: true),
                    NPSYLANX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CRAFTVRS = table.Column<int>(type: "int", nullable: true),
                    CRAFTURS = table.Column<int>(type: "int", nullable: true),
                    UDSBENTC = table.Column<int>(type: "int", nullable: true),
                    DIGFORCT = table.Column<int>(type: "int", nullable: true),
                    DIGFORSL = table.Column<int>(type: "int", nullable: true),
                    DIGBACCT = table.Column<int>(type: "int", nullable: true),
                    DIGBACLS = table.Column<int>(type: "int", nullable: true),
                    ANIMALS = table.Column<int>(type: "int", nullable: true),
                    VEG = table.Column<int>(type: "int", nullable: true),
                    TRAILA = table.Column<int>(type: "int", nullable: true),
                    TRAILARR = table.Column<int>(type: "int", nullable: true),
                    TRAILALI = table.Column<int>(type: "int", nullable: true),
                    TRAILB = table.Column<int>(type: "int", nullable: true),
                    TRAILBRR = table.Column<int>(type: "int", nullable: true),
                    TRAILBLI = table.Column<int>(type: "int", nullable: true),
                    UDSBENTD = table.Column<int>(type: "int", nullable: true),
                    UDSBENRS = table.Column<int>(type: "int", nullable: true),
                    CRAFTDVR = table.Column<int>(type: "int", nullable: true),
                    CRAFTDRE = table.Column<int>(type: "int", nullable: true),
                    CRAFTDTI = table.Column<int>(type: "int", nullable: true),
                    CRAFTCUE = table.Column<int>(type: "int", nullable: true),
                    UDSVERFC = table.Column<int>(type: "int", nullable: true),
                    UDSVERFN = table.Column<int>(type: "int", nullable: true),
                    UDSVERNF = table.Column<int>(type: "int", nullable: true),
                    UDSVERLC = table.Column<int>(type: "int", nullable: true),
                    UDSVERLR = table.Column<int>(type: "int", nullable: true),
                    UDSVERLN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTN = table.Column<int>(type: "int", nullable: true),
                    UDSVERTE = table.Column<int>(type: "int", nullable: true),
                    UDSVERTI = table.Column<int>(type: "int", nullable: true),
                    VERBALTEST = table.Column<int>(type: "int", nullable: true),
                    REY1REC = table.Column<int>(type: "int", nullable: true),
                    REY1INT = table.Column<int>(type: "int", nullable: true),
                    REY2REC = table.Column<int>(type: "int", nullable: true),
                    REY2INT = table.Column<int>(type: "int", nullable: true),
                    REY3REC = table.Column<int>(type: "int", nullable: true),
                    REY3INT = table.Column<int>(type: "int", nullable: true),
                    REY4REC = table.Column<int>(type: "int", nullable: true),
                    REY4INT = table.Column<int>(type: "int", nullable: true),
                    REY5REC = table.Column<int>(type: "int", nullable: true),
                    REY5INT = table.Column<int>(type: "int", nullable: true),
                    REYBREC = table.Column<int>(type: "int", nullable: true),
                    REYBINT = table.Column<int>(type: "int", nullable: true),
                    REY6REC = table.Column<int>(type: "int", nullable: true),
                    REY6INT = table.Column<int>(type: "int", nullable: true),
                    REYDREC = table.Column<int>(type: "int", nullable: true),
                    REYDINT = table.Column<int>(type: "int", nullable: true),
                    REYDTI = table.Column<int>(type: "int", nullable: true),
                    REYMETHOD = table.Column<int>(type: "int", nullable: true),
                    REYTCOR = table.Column<int>(type: "int", nullable: true),
                    REYFPOS = table.Column<int>(type: "int", nullable: true),
                    CERAD1REC = table.Column<int>(type: "int", nullable: true),
                    CERAD1READ = table.Column<int>(type: "int", nullable: true),
                    CERAD1INT = table.Column<int>(type: "int", nullable: true),
                    CERAD2REC = table.Column<int>(type: "int", nullable: true),
                    CERAD2READ = table.Column<int>(type: "int", nullable: true),
                    CERAD2INT = table.Column<int>(type: "int", nullable: true),
                    CERAD3REC = table.Column<int>(type: "int", nullable: true),
                    CERAD3READ = table.Column<int>(type: "int", nullable: true),
                    CERAD3INT = table.Column<int>(type: "int", nullable: true),
                    CERADDTI = table.Column<int>(type: "int", nullable: true),
                    CERADJ6REC = table.Column<int>(type: "int", nullable: true),
                    CERADJ6INT = table.Column<int>(type: "int", nullable: true),
                    CERADJ7YES = table.Column<int>(type: "int", nullable: true),
                    CERADJ7NO = table.Column<int>(type: "int", nullable: true),
                    MINTTOTS = table.Column<int>(type: "int", nullable: true),
                    MINTTOTW = table.Column<int>(type: "int", nullable: true),
                    MINTSCNG = table.Column<int>(type: "int", nullable: true),
                    MINTSCNC = table.Column<int>(type: "int", nullable: true),
                    MINTPCNG = table.Column<int>(type: "int", nullable: true),
                    MINTPCNC = table.Column<int>(type: "int", nullable: true),
                    COGSTAT = table.Column<int>(type: "int", nullable: true),
                    RESPVAL = table.Column<int>(type: "int", nullable: true),
                    RESPHEAR = table.Column<int>(type: "int", nullable: true),
                    RESPDIST = table.Column<int>(type: "int", nullable: true),
                    RESPINTR = table.Column<int>(type: "int", nullable: true),
                    RESPDISN = table.Column<int>(type: "int", nullable: true),
                    RESPFATG = table.Column<int>(type: "int", nullable: true),
                    RESPEMOT = table.Column<int>(type: "int", nullable: true),
                    RESPASST = table.Column<int>(type: "int", nullable: true),
                    RESPOTH = table.Column<int>(type: "int", nullable: true),
                    RESPOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_C2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_C2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_D1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DXMETHOD = table.Column<int>(type: "int", nullable: true),
                    NORMCOG = table.Column<int>(type: "int", nullable: true),
                    DEMENTED = table.Column<int>(type: "int", nullable: true),
                    AMNDEM = table.Column<int>(type: "int", nullable: true),
                    PCA = table.Column<int>(type: "int", nullable: true),
                    PPASYN = table.Column<int>(type: "int", nullable: true),
                    PPASYNT = table.Column<int>(type: "int", nullable: true),
                    FTDSYN = table.Column<int>(type: "int", nullable: true),
                    LBDSYN = table.Column<int>(type: "int", nullable: true),
                    NAMNDEM = table.Column<int>(type: "int", nullable: true),
                    MCIAMEM = table.Column<int>(type: "int", nullable: true),
                    MCIAPLUS = table.Column<int>(type: "int", nullable: true),
                    MCIAPLAN = table.Column<int>(type: "int", nullable: true),
                    MCIAPATT = table.Column<int>(type: "int", nullable: true),
                    MCIAPEX = table.Column<int>(type: "int", nullable: true),
                    MCIAPVIS = table.Column<int>(type: "int", nullable: true),
                    MCINON1 = table.Column<int>(type: "int", nullable: true),
                    MCIN1LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN1ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN1EX = table.Column<int>(type: "int", nullable: true),
                    MCIN1VIS = table.Column<int>(type: "int", nullable: true),
                    MCINON2 = table.Column<int>(type: "int", nullable: true),
                    MCIN2LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN2ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN2EX = table.Column<int>(type: "int", nullable: true),
                    MCIN2VIS = table.Column<int>(type: "int", nullable: true),
                    IMPNOMCI = table.Column<int>(type: "int", nullable: true),
                    AMYLPET = table.Column<int>(type: "int", nullable: true),
                    AMYLCSF = table.Column<int>(type: "int", nullable: true),
                    FDGAD = table.Column<int>(type: "int", nullable: true),
                    HIPPATR = table.Column<int>(type: "int", nullable: true),
                    TAUPETAD = table.Column<int>(type: "int", nullable: true),
                    CSFTAU = table.Column<int>(type: "int", nullable: true),
                    FDGFTLD = table.Column<int>(type: "int", nullable: true),
                    TPETFTLD = table.Column<int>(type: "int", nullable: true),
                    MRFTLD = table.Column<int>(type: "int", nullable: true),
                    DATSCAN = table.Column<int>(type: "int", nullable: true),
                    OTHBIOM = table.Column<int>(type: "int", nullable: true),
                    OTHBIOMX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IMAGLINF = table.Column<int>(type: "int", nullable: true),
                    IMAGLAC = table.Column<int>(type: "int", nullable: true),
                    IMAGMACH = table.Column<int>(type: "int", nullable: true),
                    IMAGMICH = table.Column<int>(type: "int", nullable: true),
                    IMAGMWMH = table.Column<int>(type: "int", nullable: true),
                    IMAGEWMH = table.Column<int>(type: "int", nullable: true),
                    ADMUT = table.Column<int>(type: "int", nullable: true),
                    FTLDMUT = table.Column<int>(type: "int", nullable: true),
                    OTHMUT = table.Column<int>(type: "int", nullable: true),
                    OTHMUTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALZDIS = table.Column<int>(type: "int", nullable: true),
                    ALZDISIF = table.Column<int>(type: "int", nullable: true),
                    LBDIS = table.Column<int>(type: "int", nullable: true),
                    LBDIF = table.Column<int>(type: "int", nullable: true),
                    PARK = table.Column<int>(type: "int", nullable: true),
                    MSA = table.Column<int>(type: "int", nullable: true),
                    MSAIF = table.Column<int>(type: "int", nullable: true),
                    PSP = table.Column<int>(type: "int", nullable: true),
                    PSPIF = table.Column<int>(type: "int", nullable: true),
                    CORT = table.Column<int>(type: "int", nullable: true),
                    CORTIF = table.Column<int>(type: "int", nullable: true),
                    FTLDMO = table.Column<int>(type: "int", nullable: true),
                    FTLDMOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDNOS = table.Column<int>(type: "int", nullable: true),
                    FTLDNOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBT = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CVD = table.Column<int>(type: "int", nullable: true),
                    CVDIF = table.Column<int>(type: "int", nullable: true),
                    PREVSTK = table.Column<int>(type: "int", nullable: true),
                    STROKDEC = table.Column<int>(type: "int", nullable: true),
                    STKIMAG = table.Column<int>(type: "int", nullable: true),
                    INFNETW = table.Column<int>(type: "int", nullable: true),
                    INFWMH = table.Column<int>(type: "int", nullable: true),
                    ESSTREM = table.Column<int>(type: "int", nullable: true),
                    ESSTREIF = table.Column<int>(type: "int", nullable: true),
                    DOWNS = table.Column<int>(type: "int", nullable: true),
                    DOWNSIF = table.Column<int>(type: "int", nullable: true),
                    HUNT = table.Column<int>(type: "int", nullable: true),
                    HUNTIF = table.Column<int>(type: "int", nullable: true),
                    PRION = table.Column<int>(type: "int", nullable: true),
                    PRIONIF = table.Column<int>(type: "int", nullable: true),
                    BRNINJ = table.Column<int>(type: "int", nullable: true),
                    BRNINJIF = table.Column<int>(type: "int", nullable: true),
                    BRNINCTE = table.Column<int>(type: "int", nullable: true),
                    HYCEPH = table.Column<int>(type: "int", nullable: true),
                    HYCEPHIF = table.Column<int>(type: "int", nullable: true),
                    EPILEP = table.Column<int>(type: "int", nullable: true),
                    EPILEPIF = table.Column<int>(type: "int", nullable: true),
                    NEOP = table.Column<int>(type: "int", nullable: true),
                    NEOPIF = table.Column<int>(type: "int", nullable: true),
                    NEOPSTAT = table.Column<int>(type: "int", nullable: true),
                    HIV = table.Column<int>(type: "int", nullable: true),
                    HIVIF = table.Column<int>(type: "int", nullable: true),
                    OTHCOG = table.Column<int>(type: "int", nullable: true),
                    OTHCOGIF = table.Column<int>(type: "int", nullable: true),
                    OTHCOGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DEP = table.Column<int>(type: "int", nullable: true),
                    DEPIF = table.Column<int>(type: "int", nullable: true),
                    DEPTREAT = table.Column<int>(type: "int", nullable: true),
                    BIPOLDX = table.Column<int>(type: "int", nullable: true),
                    BIPOLDIF = table.Column<int>(type: "int", nullable: true),
                    SCHIZOP = table.Column<int>(type: "int", nullable: true),
                    SCHIZOIF = table.Column<int>(type: "int", nullable: true),
                    ANXIET = table.Column<int>(type: "int", nullable: true),
                    ANXIETIF = table.Column<int>(type: "int", nullable: true),
                    DELIR = table.Column<int>(type: "int", nullable: true),
                    DELIRIF = table.Column<int>(type: "int", nullable: true),
                    PTSDDX = table.Column<int>(type: "int", nullable: true),
                    PTSDDXIF = table.Column<int>(type: "int", nullable: true),
                    OTHPSY = table.Column<int>(type: "int", nullable: true),
                    OTHPSYIF = table.Column<int>(type: "int", nullable: true),
                    OTHPSYX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALCDEM = table.Column<int>(type: "int", nullable: true),
                    ALCDEMIF = table.Column<int>(type: "int", nullable: true),
                    ALCABUSE = table.Column<int>(type: "int", nullable: true),
                    IMPSUB = table.Column<int>(type: "int", nullable: true),
                    IMPSUBIF = table.Column<int>(type: "int", nullable: true),
                    DYSILL = table.Column<int>(type: "int", nullable: true),
                    DYSILLIF = table.Column<int>(type: "int", nullable: true),
                    MEDS = table.Column<int>(type: "int", nullable: true),
                    MEDSIF = table.Column<int>(type: "int", nullable: true),
                    COGOTH = table.Column<int>(type: "int", nullable: true),
                    COGOTHIF = table.Column<int>(type: "int", nullable: true),
                    COGOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTH2 = table.Column<int>(type: "int", nullable: true),
                    COGOTH2F = table.Column<int>(type: "int", nullable: true),
                    COGOTH2X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTH3 = table.Column<int>(type: "int", nullable: true),
                    COGOTH3F = table.Column<int>(type: "int", nullable: true),
                    COGOTH3X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_T1s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TELCOG = table.Column<int>(type: "int", nullable: true),
                    TELILL = table.Column<int>(type: "int", nullable: true),
                    TELHOME = table.Column<int>(type: "int", nullable: true),
                    TELREFU = table.Column<int>(type: "int", nullable: true),
                    TELCOV = table.Column<int>(type: "int", nullable: true),
                    TELOTHR = table.Column<int>(type: "int", nullable: true),
                    TELOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TELMOD = table.Column<int>(type: "int", nullable: true),
                    TELINPER = table.Column<int>(type: "int", nullable: true),
                    TELMILE = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_T1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_T1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A1as_VisitId",
                table: "tbl_A1as",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A1s_VisitId",
                table: "tbl_A1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A2s_VisitId",
                table: "tbl_A2s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A3s_VisitId",
                table: "tbl_A3s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID1_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID1_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID10_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID10_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID11_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID11_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID12_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID12_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID13_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID13_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID14_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID14_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID15_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID15_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID16_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID16_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID17_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID17_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID18_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID18_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID19_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID19_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID2_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID2_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID20_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID20_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID21_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID21_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID22_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID22_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID23_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID23_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID24_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID24_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID25_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID25_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID26_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID26_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID27_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID27_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID28_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID28_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID29_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID29_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID3_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID3_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID30_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID30_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID31_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID31_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID32_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID32_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID33_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID33_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID34_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID34_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID35_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID35_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID36_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID36_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID37_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID37_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID38_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID38_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID39_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID39_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID4_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID4_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID40_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID40_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID5_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID5_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID6_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID6_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID7_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID7_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID8_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID8_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID9_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID9_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_VisitId",
                table: "tbl_A4s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A5D2s_VisitId",
                table: "tbl_A5D2s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B1s_VisitId",
                table: "tbl_B1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B3s_VisitId",
                table: "tbl_B3s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B4s_VisitId",
                table: "tbl_B4s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B5s_VisitId",
                table: "tbl_B5s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B6s_VisitId",
                table: "tbl_B6s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B7s_VisitId",
                table: "tbl_B7s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B8s_VisitId",
                table: "tbl_B8s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B9s_VisitId",
                table: "tbl_B9s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_C1s_VisitId",
                table: "tbl_C1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_C2s_VisitId",
                table: "tbl_C2s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1s_VisitId",
                table: "tbl_D1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_M1s_ParticipationId",
                table: "tbl_M1s",
                column: "ParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_T1s_VisitId",
                table: "tbl_T1s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visits_ParticipationId_Number",
                table: "tbl_Visits",
                columns: new[] { "ParticipationId", "Number" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A1as");

            migrationBuilder.DropTable(
                name: "tbl_A1s");

            migrationBuilder.DropTable(
                name: "tbl_A2s");

            migrationBuilder.DropTable(
                name: "tbl_A3s");

            migrationBuilder.DropTable(
                name: "tbl_A4as");

            migrationBuilder.DropTable(
                name: "tbl_A4s");

            migrationBuilder.DropTable(
                name: "tbl_A5D2s");

            migrationBuilder.DropTable(
                name: "tbl_B1s");

            migrationBuilder.DropTable(
                name: "tbl_B3s");

            migrationBuilder.DropTable(
                name: "tbl_B4s");

            migrationBuilder.DropTable(
                name: "tbl_B5s");

            migrationBuilder.DropTable(
                name: "tbl_B6s");

            migrationBuilder.DropTable(
                name: "tbl_B7s");

            migrationBuilder.DropTable(
                name: "tbl_B8s");

            migrationBuilder.DropTable(
                name: "tbl_B9s");

            migrationBuilder.DropTable(
                name: "tbl_C1s");

            migrationBuilder.DropTable(
                name: "tbl_C2s");

            migrationBuilder.DropTable(
                name: "tbl_D1s");

            migrationBuilder.DropTable(
                name: "tbl_M1s");

            migrationBuilder.DropTable(
                name: "tbl_T1s");

            migrationBuilder.DropTable(
                name: "DrugCodesLookup");

            migrationBuilder.DropTable(
                name: "tbl_Visits");

            migrationBuilder.DropTable(
                name: "Participation");
        }
    }
}
