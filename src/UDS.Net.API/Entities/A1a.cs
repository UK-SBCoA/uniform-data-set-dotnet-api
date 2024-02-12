using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// A1a data templates https://github.com/naccdata/uniform-data-set/tree/main/forms/uds/a1a
    /// Form A1a: Social Determinants of Health
    /// </summary>
    [Table("tbl_A1as")]
    public class A1a : Form
    {
        [Comment("1. Do you or someone in your household currently own a car?")]
        public int? OWNSCAR { get; set; }
        [Comment("2. Do you have consistent access to transportation?")]
        public int? TRSPACCESS { get; set; }
        [Comment("3. In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?")]
        public int? TRANSPROB { get; set; }
        [Comment("4. In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?")]
        public int? TRANSWORRY { get; set; }
        [Comment("5. In the past 30 days, how often did it take you longer to get somewhere than it would have taken you if you had different transportation?")]
        public int? TRSPLONGER { get; set; }
        [Comment("6. In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?")]
        public int? TRSPMED { get; set; }
        [Comment("7. Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.")]
        public int? INCOMEYR { get; set; }
        [Comment("8. How satisfied are you with your current personal financial condition?")]
        public int? FINSATIS { get; set; }
        [Comment("9. How difficult is it for you to meet monthly payments on your bills?")]
        public int? BILLPAY { get; set; }
        [Comment("10. If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?")]
        public int? FINUPSET { get; set; }
        [Comment("11. At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?")]
        public int? EATLESS { get; set; }
        [Comment("12. In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?")]
        public int? EATLESSYR { get; set; }
        [Comment("13. At any time, have you ended up taking less medication than was prescribed for you because of the cost?")]
        public int? LESSMEDS { get; set; }
        [Comment("14. In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?")]
        public int? LESSMEDSYR { get; set; }
        [Comment("15a. Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.")]
        public int? COMPCOMM { get; set; }
        [Comment("15b. Where would you place yourself on this ladder compared to others in the U.S.?")]
        public int? COMPUSA { get; set; }
        [Comment("15c. Thinking of your childhood, where would your family have been placed on this ladder compared to others in your community (or neighborhood)?")]
        public int? FAMCOMP { get; set; }
        [Comment("16. Thinking of the person who raised you, what was their highest level of education completed?")]
        public int? GUARDEDU { get; set; }
        [Comment("16a. What was this person's relationship to you?")]
        public int? GUARDREL { get; set; }
        [Comment("16a1. Specify other relationship")]
        [MaxLength(60)]
        public string? GUARDRELX { get; set; }
        [Comment("17. If there was a second person who raised you (e.g., your mother, father, grandmother, etc.?), what was that person's highest level of education completed?")]
        public int? GUARD2EDU { get; set; }
        [Comment("17a. What was this second person's relationship to you (if applicable)?")]
        public int? GUARD2REL { get; set; }
        [MaxLength(60)]
        [Comment("17a1. Specify other relationship")]
        public string? GUARD2RELX { get; set; }
        [Comment("18. I experience a general sense of emptiness")]
        public int? EMPTINESS { get; set; }
        [Comment("19. I miss having people around")]
        public int? MISSPEOPLE { get; set; }
        [Comment("20. I feel like I don't have enough friends")]
        public int? FRIENDS { get; set; }
        [Comment("21. I often feel abandoned")]
        public int? ABANDONED { get; set; }
        [Comment("22. I miss having a really good friend")]
        public int? CLOSEFRND { get; set; }
        [Comment("23. If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? PARENTCOMM { get; set; }
        [Comment("24. If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? CHILDCOMM { get; set; }
        [Comment("25. How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? FRIENDCOMM { get; set; }
        [Comment("26. How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?")]
        public int? PARTICIPATE { get; set; }
        [Comment("27a. How safe do you feel in your home?")]
        public int? SAFEHOME { get; set; }
        [Comment("27b. How safe do you feel in your community (or neighborhood)?")]
        public int? SAFECOMM { get; set; }
        [Comment("28. In the past year, how often did you delay seeking medical attention for a problem that was bothering you?")]
        public int? DELAYMED { get; set; }
        [Comment("29. In the past year, how often did you experience challenges in filling a prescription?")]
        public int? SCRIPTPROB { get; set; }
        [Comment("30. In the past year, how often did you miss a follow-up medical appointment that was scheduled?")]
        public int? MISSEDFUP { get; set; }
        [Comment("31. In the past year, how often did you follow a doctor's advice or treatment plan when it was given?")]
        public int? DOCADVICE { get; set; }
        [Comment("32. Overall, which of these describes your health insurance, access to healthcare services, and access to medications?")]
        public int? HEALTHACC { get; set; }
        [Comment("33. In your day-to-day life how often are you treated with less courtesy or respect than other people?")]
        public int? LESSCOURT { get; set; }
        [Comment("34. In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?")]
        public int? POORSERV { get; set; }
        [Comment("35. In your day-to-day life how often do people act as if they think you are not smart?")]
        public int? NOTSMART { get; set; }
        [Comment("36. In your day-to-day life how often do people act as if they are afraid of you?")]
        public int? ACTAFRAID { get; set; }
        [Comment("37. In your day-to-day life how often are you threatened or harassed?")]
        public int? THREATENED { get; set; }
        [Comment("38. How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?")]
        public int? POORMEDTRT { get; set; }
        [Comment("39a1. Main reason--Your Ancestry or National Origins")]
        public bool? EXPANCEST { get; set; }
        [Comment("39a2. Main reason--Your gender")]
        public bool? EXPGENDER { get; set; }
        [Comment("39a3. Main reason--Your race")]
        public bool? EXPRACE { get; set; }
        [Comment("39a4. Main reason--Your age")]
        public bool? EXPAGE { get; set; }
        [Comment("39a5. Main reason--Your religion")]
        public bool? EXPRELIG { get; set; }
        [Comment("39a6. Main reason--Your height")]
        public bool? EXPHEIGHT { get; set; }
        [Comment("39a7. Main reason--Your weight")]
        public bool? EXPWEIGHT { get; set; }
        [Comment("39a8. Main reason--Some other aspect of your physical appearance")]
        public bool? EXPAPPEAR { get; set; }
        [Comment("39a9. Main reason--Your sexual orientation")]
        public bool? EXPSEXORN { get; set; }
        [Comment("39a10. Main reason--Your education or income level")]
        public bool? EXPEDUCINC { get; set; }
        [Comment("39a11. Main reason--A physical disability")]
        public bool? EXPDISAB { get; set; }
        [Comment("39a12. Main reason--Your shade of skin color")]
        public bool? EXPSKIN { get; set; }
        [Comment("39a13. Main reason -- Other")]
        public bool? EXPOTHER { get; set; }
        [Comment("39a14. Main reason -- not applicable - I do not have these experiences in my day to day life")]
        public bool? EXPNOTAPP { get; set; }
        [Comment("39a15. Main reason--Prefer not to answer")]
        public bool? EXPNOANS { get; set; }
        [Comment("40. When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?")]
        public int? EXPSTRS { get; set; }
    }
}

