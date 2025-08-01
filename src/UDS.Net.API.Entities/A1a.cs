using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// A1a data templates https://github.com/naccdata/uniform-data-set/tree/main/forms/uds/a1a
    /// Form A1a: Social Determinants of Health
    /// </summary>
    [Table("tbl_A1as")]
    public class A1a : Form
    {
        public int? OWNSCAR { get; set; }
        public int? TRSPACCESS { get; set; }
        public int? TRANSPROB { get; set; }
        public int? TRANSWORRY { get; set; }
        public int? TRSPMED { get; set; }
        public int? INCOMEYR { get; set; }
        public int? FINSATIS { get; set; }
        public int? BILLPAY { get; set; }
        public int? FINUPSET { get; set; }
        public int? EATLESS { get; set; }
        public int? EATLESSYR { get; set; }
        public int? LESSMEDS { get; set; }
        public int? LESSMEDSYR { get; set; }
        public int? COMPCOMM { get; set; }
        public int? GUARDEDU { get; set; }
        public int? EMPTINESS { get; set; }
        public int? MISSPEOPLE { get; set; }
        public int? FRIENDS { get; set; }
        public int? ABANDONED { get; set; }
        public int? CLOSEFRND { get; set; }
        public int? PARENTCOMM { get; set; }
        public int? CHILDCOMM { get; set; }
        public int? FRIENDCOMM { get; set; }
        public int? PARTICIPATE { get; set; }
        public int? SAFEHOME { get; set; }
        public int? SAFECOMM { get; set; }
        public int? DELAYMED { get; set; }
        public int? SCRIPTPROB { get; set; }
        public int? MISSEDFUP { get; set; }
        public int? DOCADVICE { get; set; }
        public int? HEALTHACC { get; set; }
        public int? LESSCOURT { get; set; }
        public int? POORSERV { get; set; }
        public int? NOTSMART { get; set; }
        public int? ACTAFRAID { get; set; }
        public int? THREATENED { get; set; }
        public int? POORMEDTRT { get; set; }
        public bool? EXPANCEST { get; set; }
        public bool? EXPGENDER { get; set; }
        public bool? EXPRACE { get; set; }
        public bool? EXPAGE { get; set; }
        public bool? EXPRELIG { get; set; }
        public bool? EXPHEIGHT { get; set; }
        public bool? EXPWEIGHT { get; set; }
        public bool? EXPAPPEAR { get; set; }
        public bool? EXPSEXORN { get; set; }
        public bool? EXPEDUCINC { get; set; }
        public bool? EXPDISAB { get; set; }
        public bool? EXPSKIN { get; set; }
        public bool? EXPOTHER { get; set; }
        public bool? EXPNOTAPP { get; set; }
        public bool? EXPNOANS { get; set; }
        public int? EXPSTRS { get; set; }
    }
}

