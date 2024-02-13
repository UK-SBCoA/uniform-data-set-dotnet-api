using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// IVP data template https://github.com/naccdata/uniform-data-set/blob/main/forms/uds/a1/form_a1_ivp_questions_and%20vars.csv
    /// </summary>
    [Table("tbl_A1s")]
    public class A1 : Form
    {
        public int? BIRTHMO { get; set; }
        public int? BIRTHYR { get; set; }
        [MaxLength(3)]
        public string? CHLDHDCTRY { get; set; }
        public int? RACEWHITE { get; set; }
        public int? ETHGERMAN { get; set; }
        public int? ETHIRISH { get; set; }
        public int? ETHENGLISH { get; set; }
        public int? ETHITALIAN { get; set; }
        public int? ETHPOLISH { get; set; }
        public int? ETHFRENCH { get; set; }
        public int? ETHWHIOTH { get; set; }
        [MaxLength(60)]
        public string? ETHWHIOTHX { get; set; }
        public int? ETHISPANIC { get; set; }
        public int? ETHMEXICAN { get; set; }
        public int? ETHPUERTO { get; set; }
        public int? ETHCUBAN { get; set; }
        public int? ETHSALVA { get; set; }
        public int? ETHDOMIN { get; set; }
        public int? ETHCOLOM { get; set; }
        public int? ETHHISOTH { get; set; }
        [MaxLength(60)]
        public string? ETHHISOTHX { get; set; }
        public int? RACEBLACK { get; set; }
        public int? ETHAFAMER { get; set; }
        public int? ETHJAMAICA { get; set; }
        public int? ETHHAITIAN { get; set; }
        public int? ETHNIGERIA { get; set; }
        public int? ETHETHIOP { get; set; }
        public int? ETHSOMALI { get; set; }
        public int? ETHBLKOTH { get; set; }
        [MaxLength(60)]
        public string? ETHBLKOTHX { get; set; }
        public int? RACEASIAN { get; set; }
        public int? ETHCHINESE { get; set; }
        public int? ETHFILIP { get; set; }
        public int? ETHINDIA { get; set; }
        public int? ETHVIETNAM { get; set; }
        public int? ETHKOREAN { get; set; }
        public int? ETHJAPAN { get; set; }
        public int? ETHASNOTH { get; set; }
        [MaxLength(60)]
        public string? ETHASNOTHX { get; set; }
        public int? RACEAIAN { get; set; }
        [MaxLength(60)]
        public string? RACEAIANX { get; set; }
        public int? RACEMENA { get; set; }
        public int? ETHLEBANON { get; set; }
        public int? ETHIRAN { get; set; }
        public int? ETHEGYPT { get; set; }
        public int? ETHSYRIA { get; set; }
        public int? ETHMOROCCO { get; set; }
        public int? ETHISRAEL { get; set; }
        public int? ETHMENAOTH { get; set; }
        [MaxLength(60)]
        public string? ETHMENAOTX { get; set; }
        public int? RACENHPI { get; set; }
        public int? ETHHAWAII { get; set; }
        public int? ETHSAMOAN { get; set; }
        public int? ETHCHAMOR { get; set; }
        public int? ETHTONGAN { get; set; }
        public int? ETHFIJIAN { get; set; }
        public int? ETHMARSHAL { get; set; }
        public int? ETHNHPIOTH { get; set; }
        [MaxLength(60)]
        public string? ETHNHPIOTX { get; set; }
        public int? RACEUNKN { get; set; }
        public int? GENMAN { get; set; }
        public int? GENWOMAN { get; set; }
        public int? GENTRMAN { get; set; }
        public int? GENTRWOMAN { get; set; }
        public int? GENNONBI { get; set; }
        public int? GENTWOSPIR { get; set; }
        public int? GENOTH { get; set; }
        [MaxLength(60)]
        public string? GENOTHX { get; set; }
        public int? GENDKN { get; set; }
        public int? GENNOANS { get; set; }
        public int? BIRTHSEX { get; set; }
        public int? INTERSEX { get; set; }
        public int? SEXORNGAY { get; set; }
        public int? SEXORNHET { get; set; }
        public int? SEXORNBI { get; set; }
        public int? SEXORNTWOS { get; set; }
        public int? SEXORNOTH { get; set; }
        [MaxLength(60)]
        public string? SEXORNOTHX { get; set; }
        public int? SEXORNDNK { get; set; }
        public int? SEXORNNOAN { get; set; }
        public int? PREDOMLAN { get; set; }
        [MaxLength(60)]
        public string? PREDOMLANX { get; set; }
        public int? HANDED { get; set; }
        public int? EDUC { get; set; }
        public int? LVLEDUC { get; set; }
        public int? MARISTAT { get; set; }
        public int? LIVSITUA { get; set; }
        public int? RESIDENC { get; set; }
        [MaxLength(3)]
        public string? ZIP { get; set; } = default!;
        public int? SERVED { get; set; }
        public int? MEDVA { get; set; }
        public int? EXRTIME { get; set; }
        public int? MEMWORS { get; set; }
        public int? MEMTROUB { get; set; }
        public int? MEMTEN { get; set; }
        public int? ADISTATE { get; set; }
        public int? ADINAT { get; set; }
        public int? PRIOCC { get; set; }
        public int? SOURCENW { get; set; }
        public int? REFERSC { get; set; }
        [MaxLength(60)]
        public string? REFERSCX { get; set; }
        public int? REFLEARNED { get; set; }
        [MaxLength(60)]
        public string? REFCTRSOCX { get; set; }
        [MaxLength(60)]
        public string? REFCTRREGX { get; set; }
        [MaxLength(60)]
        public string? REFOTHWEBX { get; set; }
        [MaxLength(60)]
        public string? REFOTHMEDX { get; set; }
        [MaxLength(60)]
        public string? REFOTHREGX { get; set; }
        [MaxLength(60)]
        public string? REFOTHX { get; set; }

    }
}
