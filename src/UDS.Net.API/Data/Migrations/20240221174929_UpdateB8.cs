using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateB8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALIENLML",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "ALIENLMR",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "ALSFIND",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "APRAXL",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "APRAXR",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "ATAXL",
                table: "tbl_B8s");

            migrationBuilder.RenameColumn(
                name: "SOMATR",
                table: "tbl_B8s",
                newName: "VHGAZEPAL");

            migrationBuilder.RenameColumn(
                name: "SOMATL",
                table: "tbl_B8s",
                newName: "VFIELDCUT");

            migrationBuilder.RenameColumn(
                name: "SLOWINGR",
                table: "tbl_B8s",
                newName: "UNISOMATO");

            migrationBuilder.RenameColumn(
                name: "SLOWINGL",
                table: "tbl_B8s",
                newName: "UMNDIST");

            migrationBuilder.RenameColumn(
                name: "SIVDFIND",
                table: "tbl_B8s",
                newName: "TREMREST");

            migrationBuilder.RenameColumn(
                name: "RIGIDR",
                table: "tbl_B8s",
                newName: "TREMPOST");

            migrationBuilder.RenameColumn(
                name: "RIGIDL",
                table: "tbl_B8s",
                newName: "TREMKINE");

            migrationBuilder.RenameColumn(
                name: "RESTTRR",
                table: "tbl_B8s",
                newName: "STOOPED");

            migrationBuilder.RenameColumn(
                name: "RESTTRL",
                table: "tbl_B8s",
                newName: "SMTAGNO");

            migrationBuilder.RenameColumn(
                name: "PSPCBS",
                table: "tbl_B8s",
                newName: "SLOWINGFM");

            migrationBuilder.RenameColumn(
                name: "POSTCORT",
                table: "tbl_B8s",
                newName: "RIGIDLEG");

            migrationBuilder.RenameColumn(
                name: "PARKGAIT",
                table: "tbl_B8s",
                newName: "RIGIDARM");

            migrationBuilder.RenameColumn(
                name: "OTHNEURX",
                table: "tbl_B8s",
                newName: "GAITOTHRX");

            migrationBuilder.RenameColumn(
                name: "OTHNEUR",
                table: "tbl_B8s",
                newName: "PSPOAGNO");

            migrationBuilder.RenameColumn(
                name: "NORMEXAM",
                table: "tbl_B8s",
                newName: "OTHERSIGN");

            migrationBuilder.RenameColumn(
                name: "MYOCLRT",
                table: "tbl_B8s",
                newName: "OPTICATAX");

            migrationBuilder.RenameColumn(
                name: "MYOCLLT",
                table: "tbl_B8s",
                newName: "NEUREXAM");

            migrationBuilder.RenameColumn(
                name: "GAITPSP",
                table: "tbl_B8s",
                newName: "MYOCLON");

            migrationBuilder.RenameColumn(
                name: "GAITNPH",
                table: "tbl_B8s",
                newName: "MASKING");

            migrationBuilder.RenameColumn(
                name: "EYEPSP",
                table: "tbl_B8s",
                newName: "LMNDIST");

            migrationBuilder.RenameColumn(
                name: "DYSTONR",
                table: "tbl_B8s",
                newName: "LIMBATAX");

            migrationBuilder.RenameColumn(
                name: "DYSTONL",
                table: "tbl_B8s",
                newName: "LIMBAPRAX");

            migrationBuilder.RenameColumn(
                name: "DYSPSP",
                table: "tbl_B8s",
                newName: "HSPATNEG");

            migrationBuilder.RenameColumn(
                name: "CVDSIGNS",
                table: "tbl_B8s",
                newName: "GAITFIND");

            migrationBuilder.RenameColumn(
                name: "CVDMOTR",
                table: "tbl_B8s",
                newName: "GAITABN");

            migrationBuilder.RenameColumn(
                name: "CVDMOTL",
                table: "tbl_B8s",
                newName: "DYSTLEG");

            migrationBuilder.RenameColumn(
                name: "CORTVISR",
                table: "tbl_B8s",
                newName: "DYSTARM");

            migrationBuilder.RenameColumn(
                name: "CORTVISL",
                table: "tbl_B8s",
                newName: "DYSARTH");

            migrationBuilder.RenameColumn(
                name: "CORTSENR",
                table: "tbl_B8s",
                newName: "CHOREA");

            migrationBuilder.RenameColumn(
                name: "CORTSENL",
                table: "tbl_B8s",
                newName: "AXIALRIG");

            migrationBuilder.RenameColumn(
                name: "CORTDEF",
                table: "tbl_B8s",
                newName: "APRAXGAZE");

            migrationBuilder.RenameColumn(
                name: "BRADY",
                table: "tbl_B8s",
                newName: "APHASIA");

            migrationBuilder.RenameColumn(
                name: "AXIALPSP",
                table: "tbl_B8s",
                newName: "AMPMOTOR");

            migrationBuilder.RenameColumn(
                name: "ATAXR",
                table: "tbl_B8s",
                newName: "ALIENLIMB");

            migrationBuilder.AddColumn<bool>(
                name: "NORMNREXAM",
                table: "tbl_B8s",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NORMNREXAM",
                table: "tbl_B8s");

            migrationBuilder.RenameColumn(
                name: "VHGAZEPAL",
                table: "tbl_B8s",
                newName: "SOMATR");

            migrationBuilder.RenameColumn(
                name: "VFIELDCUT",
                table: "tbl_B8s",
                newName: "SOMATL");

            migrationBuilder.RenameColumn(
                name: "UNISOMATO",
                table: "tbl_B8s",
                newName: "SLOWINGR");

            migrationBuilder.RenameColumn(
                name: "UMNDIST",
                table: "tbl_B8s",
                newName: "SLOWINGL");

            migrationBuilder.RenameColumn(
                name: "TREMREST",
                table: "tbl_B8s",
                newName: "SIVDFIND");

            migrationBuilder.RenameColumn(
                name: "TREMPOST",
                table: "tbl_B8s",
                newName: "RIGIDR");

            migrationBuilder.RenameColumn(
                name: "TREMKINE",
                table: "tbl_B8s",
                newName: "RIGIDL");

            migrationBuilder.RenameColumn(
                name: "STOOPED",
                table: "tbl_B8s",
                newName: "RESTTRR");

            migrationBuilder.RenameColumn(
                name: "SMTAGNO",
                table: "tbl_B8s",
                newName: "RESTTRL");

            migrationBuilder.RenameColumn(
                name: "SLOWINGFM",
                table: "tbl_B8s",
                newName: "PSPCBS");

            migrationBuilder.RenameColumn(
                name: "RIGIDLEG",
                table: "tbl_B8s",
                newName: "POSTCORT");

            migrationBuilder.RenameColumn(
                name: "RIGIDARM",
                table: "tbl_B8s",
                newName: "PARKGAIT");

            migrationBuilder.RenameColumn(
                name: "PSPOAGNO",
                table: "tbl_B8s",
                newName: "OTHNEUR");

            migrationBuilder.RenameColumn(
                name: "OTHERSIGN",
                table: "tbl_B8s",
                newName: "NORMEXAM");

            migrationBuilder.RenameColumn(
                name: "OPTICATAX",
                table: "tbl_B8s",
                newName: "MYOCLRT");

            migrationBuilder.RenameColumn(
                name: "NEUREXAM",
                table: "tbl_B8s",
                newName: "MYOCLLT");

            migrationBuilder.RenameColumn(
                name: "MYOCLON",
                table: "tbl_B8s",
                newName: "GAITPSP");

            migrationBuilder.RenameColumn(
                name: "MASKING",
                table: "tbl_B8s",
                newName: "GAITNPH");

            migrationBuilder.RenameColumn(
                name: "LMNDIST",
                table: "tbl_B8s",
                newName: "EYEPSP");

            migrationBuilder.RenameColumn(
                name: "LIMBATAX",
                table: "tbl_B8s",
                newName: "DYSTONR");

            migrationBuilder.RenameColumn(
                name: "LIMBAPRAX",
                table: "tbl_B8s",
                newName: "DYSTONL");

            migrationBuilder.RenameColumn(
                name: "HSPATNEG",
                table: "tbl_B8s",
                newName: "DYSPSP");

            migrationBuilder.RenameColumn(
                name: "GAITOTHRX",
                table: "tbl_B8s",
                newName: "OTHNEURX");

            migrationBuilder.RenameColumn(
                name: "GAITFIND",
                table: "tbl_B8s",
                newName: "CVDSIGNS");

            migrationBuilder.RenameColumn(
                name: "GAITABN",
                table: "tbl_B8s",
                newName: "CVDMOTR");

            migrationBuilder.RenameColumn(
                name: "DYSTLEG",
                table: "tbl_B8s",
                newName: "CVDMOTL");

            migrationBuilder.RenameColumn(
                name: "DYSTARM",
                table: "tbl_B8s",
                newName: "CORTVISR");

            migrationBuilder.RenameColumn(
                name: "DYSARTH",
                table: "tbl_B8s",
                newName: "CORTVISL");

            migrationBuilder.RenameColumn(
                name: "CHOREA",
                table: "tbl_B8s",
                newName: "CORTSENR");

            migrationBuilder.RenameColumn(
                name: "AXIALRIG",
                table: "tbl_B8s",
                newName: "CORTSENL");

            migrationBuilder.RenameColumn(
                name: "APRAXGAZE",
                table: "tbl_B8s",
                newName: "CORTDEF");

            migrationBuilder.RenameColumn(
                name: "APHASIA",
                table: "tbl_B8s",
                newName: "BRADY");

            migrationBuilder.RenameColumn(
                name: "AMPMOTOR",
                table: "tbl_B8s",
                newName: "AXIALPSP");

            migrationBuilder.RenameColumn(
                name: "ALIENLIMB",
                table: "tbl_B8s",
                newName: "ATAXR");

            migrationBuilder.AddColumn<int>(
                name: "ALIENLML",
                table: "tbl_B8s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ALIENLMR",
                table: "tbl_B8s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ALSFIND",
                table: "tbl_B8s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "APRAXL",
                table: "tbl_B8s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "APRAXR",
                table: "tbl_B8s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ATAXL",
                table: "tbl_B8s",
                type: "int",
                nullable: true);
        }
    }
}
