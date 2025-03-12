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
        [Comment("Do you or someone in your household currently own a car?")]
        public int? OWNSCAR { get; set; }
        [Comment("Do you have consistent access to transportation?")]
        public int? TRSPACCESS { get; set; }
        [Comment("In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?")]
        public int? TRANSPROB { get; set; }
        [Comment("In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?")]
        public int? TRANSWORRY { get; set; }
        [Comment("In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?")]
        public int? TRSPMED { get; set; }
        [Comment("Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.")]
        public int? INCOMEYR { get; set; }
        [Comment("How satisfied are you with your current personal financial condition?")]
        public int? FINSATIS { get; set; }
        [Comment("How difficult is it for you to meet monthly payments on your bills?")]
        public int? BILLPAY { get; set; }
        [Comment("If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?")]
        public int? FINUPSET { get; set; }
        [Comment("At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?")]
        public int? EATLESS { get; set; }
        [Comment("In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?")]
        public int? EATLESSYR { get; set; }
        [Comment("At any time, have you ended up taking less medication than was prescribed for you because of the cost?")]
        public int? LESSMEDS { get; set; }
        [Comment("In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?")]
        public int? LESSMEDSYR { get; set; }
        [Comment("Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.")]
        public int? COMPCOMM { get; set; }
        [Comment("Thinking of the person who raised you, what was their highest level of education completed?")]
        public int? GUARDEDU { get; set; }
        [Comment("I experience a general sense of emptiness")]
        public int? EMPTINESS { get; set; }
        [Comment("I miss having people around")]
        public int? MISSPEOPLE { get; set; }
        [Comment("I feel like I don't have enough friends")]
        public int? FRIENDS { get; set; }
        [Comment("I often feel abandoned")]
        public int? ABANDONED { get; set; }
        [Comment("I miss having a really good friend")]
        public int? CLOSEFRND { get; set; }
        [Comment("If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? PARENTCOMM { get; set; }
        [Comment("If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? CHILDCOMM { get; set; }
        [Comment("How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?")]
        public int? FRIENDCOMM { get; set; }
        [Comment("How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?")]
        public int? PARTICIPATE { get; set; }
        [Comment("How safe do you feel in your home?")]
        public int? SAFEHOME { get; set; }
        [Comment("How safe do you feel in your community (or neighborhood)?")]
        public int? SAFECOMM { get; set; }
        [Comment("In the past year, how often did you delay seeking medical attention for a problem that was bothering you?")]
        public int? DELAYMED { get; set; }
        [Comment("In the past year, how often did you experience challenges in filling a prescription?")]
        public int? SCRIPTPROB { get; set; }
        [Comment("In the past year, how often did you miss a follow-up medical appointment that was scheduled?")]
        public int? MISSEDFUP { get; set; }
        [Comment("In the past year, how often did you follow a doctor's advice or treatment plan when it was given?")]
        public int? DOCADVICE { get; set; }
        [Comment("Overall, which of these describes your health insurance, access to healthcare services, and access to medications?")]
        public int? HEALTHACC { get; set; }
        [Comment("In your day-to-day life how often are you treated with less courtesy or respect than other people?")]
        public int? LESSCOURT { get; set; }
        [Comment("In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?")]
        public int? POORSERV { get; set; }
        [Comment("In your day-to-day life how often do people act as if they think you are not smart?")]
        public int? NOTSMART { get; set; }
        [Comment("In your day-to-day life how often do people act as if they are afraid of you?")]
        public int? ACTAFRAID { get; set; }
        [Comment("In your day-to-day life how often are you threatened or harassed?")]
        public int? THREATENED { get; set; }
        [Comment("How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?")]
        public int? POORMEDTRT { get; set; }
        [Comment("Main reason--Your Ancestry or National Origins")]
        public bool? EXPANCEST { get; set; }
        [Comment("Main reason--Your gender")]
        public bool? EXPGENDER { get; set; }
        [Comment("Main reason--Your race")]
        public bool? EXPRACE { get; set; }
        [Comment("Main reason--Your age")]
        public bool? EXPAGE { get; set; }
        [Comment("Main reason--Your religion")]
        public bool? EXPRELIG { get; set; }
        [Comment("Main reason--Your height")]
        public bool? EXPHEIGHT { get; set; }
        [Comment("Main reason--Your weight")]
        public bool? EXPWEIGHT { get; set; }
        [Comment("Main reason--Some other aspect of your physical appearance")]
        public bool? EXPAPPEAR { get; set; }
        [Comment("Main reason--Your sexual orientation")]
        public bool? EXPSEXORN { get; set; }
        [Comment("Main reason--Your education or income level")]
        public bool? EXPEDUCINC { get; set; }
        [Comment("Main reason--A physical disability")]
        public bool? EXPDISAB { get; set; }
        [Comment("Main reason--Your shade of skin color")]
        public bool? EXPSKIN { get; set; }
        [Comment("Main reason -- Other")]
        public bool? EXPOTHER { get; set; }
        [Comment("Main reason -- not applicable - I do not have these experiences in my day to day life")]
        public bool? EXPNOTAPP { get; set; }
        [Comment("Main reason--Prefer not to answer")]
        public bool? EXPNOANS { get; set; }
        [Comment("When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?")]
        public int? EXPSTRS { get; set; }
    }
}

