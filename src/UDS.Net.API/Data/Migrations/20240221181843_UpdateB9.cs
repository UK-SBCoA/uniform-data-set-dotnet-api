using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateB9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALSAGE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEAGE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEFPRED",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEFPREDX",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEMODE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEMODEX",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEOTHR",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEOTHRX",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEREMAGO",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "BEVHAGO",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "COGFLAGO",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "COGFPREX",
                table: "tbl_B9s");

            migrationBuilder.RenameColumn(
                name: "PARKAGE",
                table: "tbl_B9s",
                newName: "PSYCHSYMIN");

            migrationBuilder.RenameColumn(
                name: "MOTREM",
                table: "tbl_B9s",
                newName: "PSYCHSYM");

            migrationBuilder.RenameColumn(
                name: "MOSLOW",
                table: "tbl_B9s",
                newName: "PERCHAGE");

            migrationBuilder.RenameColumn(
                name: "MOMOPARK",
                table: "tbl_B9s",
                newName: "DECMOTIN");

            migrationBuilder.RenameColumn(
                name: "MOMODEX",
                table: "tbl_B9s",
                newName: "OTHSUBUSEX");

            migrationBuilder.RenameColumn(
                name: "MOMODE",
                table: "tbl_B9s",
                newName: "DECMOT");

            migrationBuilder.RenameColumn(
                name: "MOMOALS",
                table: "tbl_B9s",
                newName: "DECCOGIN");

            migrationBuilder.RenameColumn(
                name: "MOGAIT",
                table: "tbl_B9s",
                newName: "DECCOG");

            migrationBuilder.RenameColumn(
                name: "MOFRST",
                table: "tbl_B9s",
                newName: "COGAGE");

            migrationBuilder.RenameColumn(
                name: "MOFALLS",
                table: "tbl_B9s",
                newName: "BEVPATT");

            migrationBuilder.RenameColumn(
                name: "MOAGE",
                table: "tbl_B9s",
                newName: "BESUBAB");

            migrationBuilder.RenameColumn(
                name: "LBDEVAL",
                table: "tbl_B9s",
                newName: "BEOBCOM");

            migrationBuilder.RenameColumn(
                name: "FTLDEVAL",
                table: "tbl_B9s",
                newName: "BEHAGE");

            migrationBuilder.RenameColumn(
                name: "FRSTCHG",
                table: "tbl_B9s",
                newName: "BEEUPH");

            migrationBuilder.RenameColumn(
                name: "DECSUB",
                table: "tbl_B9s",
                newName: "BEEMPATH");

            migrationBuilder.RenameColumn(
                name: "DECCLMOT",
                table: "tbl_B9s",
                newName: "BEANGER");

            migrationBuilder.RenameColumn(
                name: "DECAGE",
                table: "tbl_B9s",
                newName: "BEAHSIMP");

            migrationBuilder.RenameColumn(
                name: "COURSE",
                table: "tbl_B9s",
                newName: "BEAHCOMP");

            migrationBuilder.RenameColumn(
                name: "COGFPRED",
                table: "tbl_B9s",
                newName: "BEAGGRS");

            migrationBuilder.AlterColumn<bool>(
                name: "DECCLCOG",
                table: "tbl_B9s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ALCUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "COCAINEUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DECCLIN",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OPIATEUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OTHSUBUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SEDUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALCUSE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "COCAINEUSE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "DECCLIN",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "OPIATEUSE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "OTHSUBUSE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "SEDUSE",
                table: "tbl_B9s");

            migrationBuilder.RenameColumn(
                name: "PSYCHSYMIN",
                table: "tbl_B9s",
                newName: "PARKAGE");

            migrationBuilder.RenameColumn(
                name: "PSYCHSYM",
                table: "tbl_B9s",
                newName: "MOTREM");

            migrationBuilder.RenameColumn(
                name: "PERCHAGE",
                table: "tbl_B9s",
                newName: "MOSLOW");

            migrationBuilder.RenameColumn(
                name: "OTHSUBUSEX",
                table: "tbl_B9s",
                newName: "MOMODEX");

            migrationBuilder.RenameColumn(
                name: "DECMOTIN",
                table: "tbl_B9s",
                newName: "MOMOPARK");

            migrationBuilder.RenameColumn(
                name: "DECMOT",
                table: "tbl_B9s",
                newName: "MOMODE");

            migrationBuilder.RenameColumn(
                name: "DECCOGIN",
                table: "tbl_B9s",
                newName: "MOMOALS");

            migrationBuilder.RenameColumn(
                name: "DECCOG",
                table: "tbl_B9s",
                newName: "MOGAIT");

            migrationBuilder.RenameColumn(
                name: "COGAGE",
                table: "tbl_B9s",
                newName: "MOFRST");

            migrationBuilder.RenameColumn(
                name: "BEVPATT",
                table: "tbl_B9s",
                newName: "MOFALLS");

            migrationBuilder.RenameColumn(
                name: "BESUBAB",
                table: "tbl_B9s",
                newName: "MOAGE");

            migrationBuilder.RenameColumn(
                name: "BEOBCOM",
                table: "tbl_B9s",
                newName: "LBDEVAL");

            migrationBuilder.RenameColumn(
                name: "BEHAGE",
                table: "tbl_B9s",
                newName: "FTLDEVAL");

            migrationBuilder.RenameColumn(
                name: "BEEUPH",
                table: "tbl_B9s",
                newName: "FRSTCHG");

            migrationBuilder.RenameColumn(
                name: "BEEMPATH",
                table: "tbl_B9s",
                newName: "DECSUB");

            migrationBuilder.RenameColumn(
                name: "BEANGER",
                table: "tbl_B9s",
                newName: "DECCLMOT");

            migrationBuilder.RenameColumn(
                name: "BEAHSIMP",
                table: "tbl_B9s",
                newName: "DECAGE");

            migrationBuilder.RenameColumn(
                name: "BEAHCOMP",
                table: "tbl_B9s",
                newName: "COURSE");

            migrationBuilder.RenameColumn(
                name: "BEAGGRS",
                table: "tbl_B9s",
                newName: "COGFPRED");

            migrationBuilder.AlterColumn<int>(
                name: "DECCLCOG",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ALSAGE",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEAGE",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEFPRED",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BEFPREDX",
                table: "tbl_B9s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEMODE",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BEMODEX",
                table: "tbl_B9s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEOTHR",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BEOTHRX",
                table: "tbl_B9s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEREMAGO",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BEVHAGO",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "COGFLAGO",
                table: "tbl_B9s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COGFPREX",
                table: "tbl_B9s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }
    }
}
