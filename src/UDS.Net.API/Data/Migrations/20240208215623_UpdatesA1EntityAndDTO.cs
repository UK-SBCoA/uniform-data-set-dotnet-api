using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesA1EntityAndDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SEX",
                table: "tbl_A1s",
                newName: "SEXORNTWOS");

            migrationBuilder.RenameColumn(
                name: "REASON",
                table: "tbl_A1s",
                newName: "SEXORNOTH");

            migrationBuilder.RenameColumn(
                name: "RACEX",
                table: "tbl_A1s",
                newName: "SEXORNOTHX");

            migrationBuilder.RenameColumn(
                name: "RACETERX",
                table: "tbl_A1s",
                newName: "REFOTHX");

            migrationBuilder.RenameColumn(
                name: "RACETER",
                table: "tbl_A1s",
                newName: "SEXORNNOAN");

            migrationBuilder.RenameColumn(
                name: "RACESECX",
                table: "tbl_A1s",
                newName: "REFOTHWEBX");

            migrationBuilder.RenameColumn(
                name: "RACESEC",
                table: "tbl_A1s",
                newName: "SEXORNHET");

            migrationBuilder.RenameColumn(
                name: "RACE",
                table: "tbl_A1s",
                newName: "SEXORNGAY");

            migrationBuilder.RenameColumn(
                name: "PRIMLANX",
                table: "tbl_A1s",
                newName: "REFOTHREGX");

            migrationBuilder.RenameColumn(
                name: "PRIMLANG",
                table: "tbl_A1s",
                newName: "SEXORNDNK");

            migrationBuilder.RenameColumn(
                name: "PRESTAT",
                table: "tbl_A1s",
                newName: "SEXORNBI");

            migrationBuilder.RenameColumn(
                name: "PRESPART",
                table: "tbl_A1s",
                newName: "SERVED");

            migrationBuilder.RenameColumn(
                name: "LEARNED",
                table: "tbl_A1s",
                newName: "REFLEARNED");

            migrationBuilder.RenameColumn(
                name: "INDEPEND",
                table: "tbl_A1s",
                newName: "RACEWHITE");

            migrationBuilder.RenameColumn(
                name: "HISPORX",
                table: "tbl_A1s",
                newName: "REFOTHMEDX");

            migrationBuilder.RenameColumn(
                name: "HISPOR",
                table: "tbl_A1s",
                newName: "RACEUNKN");

            migrationBuilder.RenameColumn(
                name: "HISPANIC",
                table: "tbl_A1s",
                newName: "RACENHPI");

            migrationBuilder.AddColumn<int>(
                name: "ADINAT",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ADISTATE",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BIRTHSEX",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHLDHDCTRY",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHAFAMER",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHASNOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHASNOTHX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHBLKOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHBLKOTHX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHCHAMOR",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHCHINESE",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHCOLOM",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHCUBAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHDOMIN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHEGYPT",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHENGLISH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHETHIOP",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHFIJIAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHFILIP",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHFRENCH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHGERMAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHHAITIAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHHAWAII",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHHISOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHHISOTHX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHINDIA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHIRAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHIRISH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHISPANIC",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHISRAEL",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHITALIAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHJAMAICA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHJAPAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHKOREAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHLEBANON",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHMARSHAL",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHMENAOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHMENAOTX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHMEXICAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHMOROCCO",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHNHPIOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHNHPIOTX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHNIGERIA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHPOLISH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHPUERTO",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHSALVA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHSAMOAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHSOMALI",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHSYRIA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHTONGAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHVIETNAM",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ETHWHIOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ETHWHIOTHX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EXRTIME",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENDKN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENMAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENNOANS",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENNONBI",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENOTH",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GENOTHX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENTRMAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENTRWOMAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENTWOSPIR",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GENWOMAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "INTERSEX",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LVLEDUC",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MEDVA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MEMTEN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MEMTROUB",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MEMWORS",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PREDOMLAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PREDOMLANX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PRIOCC",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RACEAIAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RACEAIANX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RACEASIAN",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RACEBLACK",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RACEMENA",
                table: "tbl_A1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REFCTRREGX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REFCTRSOCX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REFERSCX",
                table: "tbl_A1s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADINAT",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ADISTATE",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "BIRTHSEX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "CHLDHDCTRY",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHAFAMER",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHASNOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHASNOTHX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHBLKOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHBLKOTHX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHCHAMOR",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHCHINESE",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHCOLOM",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHCUBAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHDOMIN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHEGYPT",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHENGLISH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHETHIOP",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHFIJIAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHFILIP",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHFRENCH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHGERMAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHHAITIAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHHAWAII",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHHISOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHHISOTHX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHINDIA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHIRAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHIRISH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHISPANIC",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHISRAEL",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHITALIAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHJAMAICA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHJAPAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHKOREAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHLEBANON",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHMARSHAL",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHMENAOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHMENAOTX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHMEXICAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHMOROCCO",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHNHPIOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHNHPIOTX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHNIGERIA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHPOLISH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHPUERTO",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHSALVA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHSAMOAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHSOMALI",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHSYRIA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHTONGAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHVIETNAM",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHWHIOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ETHWHIOTHX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "EXRTIME",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENDKN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENMAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENNOANS",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENNONBI",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENOTH",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENOTHX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENTRMAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENTRWOMAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENTWOSPIR",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "GENWOMAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "INTERSEX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "LVLEDUC",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "MEDVA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "MEMTEN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "MEMTROUB",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "MEMWORS",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "PREDOMLAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "PREDOMLANX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "PRIOCC",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "RACEAIAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "RACEAIANX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "RACEASIAN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "RACEBLACK",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "RACEMENA",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "REFCTRREGX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "REFCTRSOCX",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "REFERSCX",
                table: "tbl_A1s");

            migrationBuilder.RenameColumn(
                name: "SEXORNTWOS",
                table: "tbl_A1s",
                newName: "SEX");

            migrationBuilder.RenameColumn(
                name: "SEXORNOTHX",
                table: "tbl_A1s",
                newName: "RACEX");

            migrationBuilder.RenameColumn(
                name: "SEXORNOTH",
                table: "tbl_A1s",
                newName: "REASON");

            migrationBuilder.RenameColumn(
                name: "SEXORNNOAN",
                table: "tbl_A1s",
                newName: "RACETER");

            migrationBuilder.RenameColumn(
                name: "SEXORNHET",
                table: "tbl_A1s",
                newName: "RACESEC");

            migrationBuilder.RenameColumn(
                name: "SEXORNGAY",
                table: "tbl_A1s",
                newName: "RACE");

            migrationBuilder.RenameColumn(
                name: "SEXORNDNK",
                table: "tbl_A1s",
                newName: "PRIMLANG");

            migrationBuilder.RenameColumn(
                name: "SEXORNBI",
                table: "tbl_A1s",
                newName: "PRESTAT");

            migrationBuilder.RenameColumn(
                name: "SERVED",
                table: "tbl_A1s",
                newName: "PRESPART");

            migrationBuilder.RenameColumn(
                name: "REFOTHX",
                table: "tbl_A1s",
                newName: "RACETERX");

            migrationBuilder.RenameColumn(
                name: "REFOTHWEBX",
                table: "tbl_A1s",
                newName: "RACESECX");

            migrationBuilder.RenameColumn(
                name: "REFOTHREGX",
                table: "tbl_A1s",
                newName: "PRIMLANX");

            migrationBuilder.RenameColumn(
                name: "REFOTHMEDX",
                table: "tbl_A1s",
                newName: "HISPORX");

            migrationBuilder.RenameColumn(
                name: "REFLEARNED",
                table: "tbl_A1s",
                newName: "LEARNED");

            migrationBuilder.RenameColumn(
                name: "RACEWHITE",
                table: "tbl_A1s",
                newName: "INDEPEND");

            migrationBuilder.RenameColumn(
                name: "RACEUNKN",
                table: "tbl_A1s",
                newName: "HISPOR");

            migrationBuilder.RenameColumn(
                name: "RACENHPI",
                table: "tbl_A1s",
                newName: "HISPANIC");
        }
    }
}
