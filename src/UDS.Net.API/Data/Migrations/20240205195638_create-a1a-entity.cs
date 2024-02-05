using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class createa1aentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A1as_VisitId",
                table: "tbl_A1as",
                column: "VisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A1as");
        }
    }
}
