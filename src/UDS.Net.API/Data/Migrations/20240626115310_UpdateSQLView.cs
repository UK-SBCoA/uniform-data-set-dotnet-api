using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSQLView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"ALTER VIEW[dbo].[vw_FormStatuses]
            AS
                SELECT a1.[FormId], a1.[VisitId], a1.[Status], a1.[FRMDATE], a1.[INITIALS], a1.[LANG], a1.[MODE], a1.[RMMODE], a1.[RMREASON], a1.[NOT], 'A1' as Kind, a1.[CreatedAt], a1.[CreatedBy], a1.[ModifiedBy], a1.[DeletedBy], a1.[IsDeleted]
                FROM dbo.tbl_A1s as a1
                UNION
                SELECT a1a.[FormId], a1a.[VisitId], a1a.[Status], a1a.[FRMDATE], a1a.[INITIALS], a1a.[LANG], a1a.[MODE], a1a.[RMMODE], a1a.[RMREASON], a1a.[NOT], 'A1a' as Kind, a1a.[CreatedAt], a1a.[CreatedBy], a1a.[ModifiedBy], a1a.[DeletedBy], a1a.[IsDeleted]
                FROM dbo.tbl_A1as as a1a
                UNION
                SELECT a2.[FormId], a2.[VisitId], a2.[Status], a2.[FRMDATE], a2.[INITIALS], a2.[LANG], a2.[MODE], a2.[RMMODE], a2.[RMREASON], a2.[NOT], 'A2' as Kind, a2.[CreatedAt], a2.[CreatedBy], a2.[ModifiedBy], a2.[DeletedBy], a2.[IsDeleted]
                FROM dbo.tbl_A2s as a2
                UNION
                SELECT a3.[FormId], a3.[VisitId], a3.[Status], a3.[FRMDATE], a3.[INITIALS], a3.[LANG], a3.[MODE], a3.[RMMODE], a3.[RMREASON], a3.[NOT], 'A3' as Kind, a3.[CreatedAt], a3.[CreatedBy], a3.[ModifiedBy], a3.[DeletedBy], a3.[IsDeleted]
                FROM dbo.tbl_A3s as a3
                UNION
                SELECT a4.[FormId], a4.[VisitId], a4.[Status], a4.[FRMDATE], a4.[INITIALS], a4.[LANG], a4.[MODE], a4.[RMMODE], a4.[RMREASON], a4.[NOT], 'A4' as Kind, a4.[CreatedAt], a4.[CreatedBy], a4.[ModifiedBy], a4.[DeletedBy], a4.[IsDeleted]
                FROM dbo.tbl_A4s as a4
                UNION
                SELECT a4a.[FormId], a4a.[VisitId], a4a.[Status], a4a.[FRMDATE], a4a.[INITIALS], a4a.[LANG], a4a.[MODE], a4a.[RMMODE], a4a.[RMREASON], a4a.[NOT], 'A4a' as Kind, a4a.[CreatedAt], a4a.[CreatedBy], a4a.[ModifiedBy], a4a.[DeletedBy], a4a.[IsDeleted]
                FROM dbo.tbl_A4as as a4a
                UNION
                SELECT a5d2.[FormId], a5d2.[VisitId], a5d2.[Status], a5d2.[FRMDATE], a5d2.[INITIALS], a5d2.[LANG], a5d2.[MODE], a5d2.[RMMODE], a5d2.[RMREASON], a5d2.[NOT], 'A5D2' as Kind, a5d2.[CreatedAt], a5d2.[CreatedBy], a5d2.[ModifiedBy], a5d2.[DeletedBy], a5d2.[IsDeleted]
                FROM dbo.tbl_A5D2s as a5d2
                UNION
                SELECT b1.[FormId], b1.[VisitId], b1.[Status], b1.[FRMDATE], b1.[INITIALS], b1.[LANG], b1.[MODE], b1.[RMMODE], b1.[RMREASON], b1.[NOT], 'B1' as Kind, b1.[CreatedAt], b1.[CreatedBy], b1.[ModifiedBy], b1.[DeletedBy], b1.[IsDeleted]
                FROM dbo.tbl_B1s as b1
                UNION
                SELECT b3.[FormId], b3.[VisitId], b3.[Status], b3.[FRMDATE], b3.[INITIALS], b3.[LANG], b3.[MODE], b3.[RMMODE], b3.[RMREASON], b3.[NOT], 'B3' as Kind, b3.[CreatedAt], b3.[CreatedBy], b3.[ModifiedBy], b3.[DeletedBy], b3.[IsDeleted]
                FROM dbo.tbl_B3s as b3
                UNION
                SELECT b4.[FormId], b4.[VisitId], b4.[Status], b4.[FRMDATE], b4.[INITIALS], b4.[LANG], b4.[MODE], b4.[RMMODE], b4.[RMREASON], b4.[NOT], 'B4' as Kind, b4.[CreatedAt], b4.[CreatedBy], b4.[ModifiedBy], b4.[DeletedBy], b4.[IsDeleted]
                FROM dbo.tbl_B4s as b4
                UNION
                SELECT b5.[FormId], b5.[VisitId], b5.[Status], b5.[FRMDATE], b5.[INITIALS], b5.[LANG], b5.[MODE], b5.[RMMODE], b5.[RMREASON], b5.[NOT], 'B5' as Kind, b5.[CreatedAt], b5.[CreatedBy], b5.[ModifiedBy], b5.[DeletedBy], b5.[IsDeleted]
                FROM dbo.tbl_B5s as b5
                UNION
                SELECT b6.[FormId], b6.[VisitId], b6.[Status], b6.[FRMDATE], b6.[INITIALS], b6.[LANG], b6.[MODE], b6.[RMMODE], b6.[RMREASON], b6.[NOT], 'B6' as Kind, b6.[CreatedAt], b6.[CreatedBy], b6.[ModifiedBy], b6.[DeletedBy], b6.[IsDeleted]
                FROM dbo.tbl_B6s as b6
                UNION
                SELECT b7.[FormId], b7.[VisitId], b7.[Status], b7.[FRMDATE], b7.[INITIALS], b7.[LANG], b7.[MODE], b7.[RMMODE], b7.[RMREASON], b7.[NOT], 'B7' as Kind, b7.[CreatedAt], b7.[CreatedBy], b7.[ModifiedBy], b7.[DeletedBy], b7.[IsDeleted]
                FROM dbo.tbl_B7s as b7
                UNION
                SELECT b8.[FormId], b8.[VisitId], b8.[Status], b8.[FRMDATE], b8.[INITIALS], b8.[LANG], b8.[MODE], b8.[RMMODE], b8.[RMREASON], b8.[NOT], 'B8' as Kind, b8.[CreatedAt], b8.[CreatedBy], b8.[ModifiedBy], b8.[DeletedBy], b8.[IsDeleted]
                FROM dbo.tbl_B8s as b8
                UNION
                SELECT b9.[FormId], b9.[VisitId], b9.[Status], b9.[FRMDATE], b9.[INITIALS], b9.[LANG], b9.[MODE], b9.[RMMODE], b9.[RMREASON], b9.[NOT], 'B9' as Kind, b9.[CreatedAt], b9.[CreatedBy], b9.[ModifiedBy], b9.[DeletedBy], b9.[IsDeleted]
                FROM dbo.tbl_B9s as b9
                UNION
                SELECT c1.[FormId], c1.[VisitId], c1.[Status], c1.[FRMDATE], c1.[INITIALS], c1.[LANG], c1.[MODE], c1.[RMMODE], c1.[RMREASON], c1.[NOT], 'C1' as Kind, c1.[CreatedAt], c1.[CreatedBy], c1.[ModifiedBy], c1.[DeletedBy], c1.[IsDeleted]
                FROM dbo.tbl_C1s as c1
                UNION
                SELECT c2.[FormId], c2.[VisitId], c2.[Status], c2.[FRMDATE], c2.[INITIALS], c2.[LANG], c2.[MODE], c2.[RMMODE], c2.[RMREASON], c2.[NOT], 'C2' as Kind, c2.[CreatedAt], c2.[CreatedBy], c2.[ModifiedBy], c2.[DeletedBy], c2.[IsDeleted]
                FROM dbo.tbl_C2s as c2
                UNION
                SELECT d1a.[FormId], d1a.[VisitId], d1a.[Status], d1a.[FRMDATE], d1a.[INITIALS], d1a.[LANG], d1a.[MODE], d1a.[RMMODE], d1a.[RMREASON], d1a.[NOT], 'D1a' as Kind, d1a.[CreatedAt], d1a.[CreatedBy], d1a.[ModifiedBy], d1a.[DeletedBy], d1a.[IsDeleted]
                FROM dbo.tbl_D1as as d1a
                UNION
                SELECT d1b.[FormId], d1b.[VisitId], d1b.[Status], d1b.[FRMDATE], d1b.[INITIALS], d1b.[LANG], d1b.[MODE], d1b.[RMMODE], d1b.[RMREASON], d1b.[NOT], 'D1b' as Kind, d1b.[CreatedAt], d1b.[CreatedBy], d1b.[ModifiedBy], d1b.[DeletedBy], d1b.[IsDeleted]
                FROM dbo.tbl_D1bs as d1b
                UNION
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[FRMDATE], t1.[INITIALS], t1.[LANG], t1.[MODE], t1.[RMMODE], t1.[RMREASON], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"ALTER VIEW[dbo].[vw_FormStatuses]
            AS
                SELECT a1.[FormId], a1.[VisitId], a1.[Status], a1.[LANG], a1.[MODE], a1.[REMOTEMODE], a1.[REMOTEREASON], a1.[SUB], a1.[NOT], 'A1' as Kind, a1.[CreatedAt], a1.[CreatedBy], a1.[ModifiedBy], a1.[DeletedBy], a1.[IsDeleted]
                FROM dbo.tbl_A1s as a1
                UNION
                SELECT a1a.[FormId], a1a.[VisitId], a1a.[Status], a1a.[LANG], a1a.[MODE], a1a.[REMOTEMODE], a1a.[REMOTEREASON], a1a.[SUB], a1a.[NOT], 'A1a' as Kind, a1a.[CreatedAt], a1a.[CreatedBy], a1a.[ModifiedBy], a1a.[DeletedBy], a1a.[IsDeleted]
                FROM dbo.tbl_A1as as a1a
                UNION
                SELECT a2.[FormId], a2.[VisitId], a2.[Status], a2.[LANG], a2.[MODE], a2.[REMOTEMODE], a2.[REMOTEREASON], a2.[SUB], a2.[NOT], 'A2' as Kind, a2.[CreatedAt], a2.[CreatedBy], a2.[ModifiedBy], a2.[DeletedBy], a2.[IsDeleted]
                FROM dbo.tbl_A2s as a2
                UNION
                SELECT a3.[FormId], a3.[VisitId], a3.[Status], a3.[LANG], a3.[MODE], a3.[REMOTEMODE], a3.[REMOTEREASON], a3.[SUB], a3.[NOT], 'A3' as Kind, a3.[CreatedAt], a3.[CreatedBy], a3.[ModifiedBy], a3.[DeletedBy], a3.[IsDeleted]
                FROM dbo.tbl_A3s as a3
                UNION
                SELECT a4.[FormId], a4.[VisitId], a4.[Status], a4.[LANG], a4.[MODE], a4.[REMOTEMODE], a4.[REMOTEREASON], a4.[SUB], a4.[NOT], 'A4' as Kind, a4.[CreatedAt], a4.[CreatedBy], a4.[ModifiedBy], a4.[DeletedBy], a4.[IsDeleted]
                FROM dbo.tbl_A4s as a4
                UNION
                SELECT a4a.[FormId], a4a.[VisitId], a4a.[Status], a4a.[LANG], a4a.[MODE], a4a.[REMOTEMODE], a4a.[REMOTEREASON], a4a.[SUB], a4a.[NOT], 'A4a' as Kind, a4a.[CreatedAt], a4a.[CreatedBy], a4a.[ModifiedBy], a4a.[DeletedBy], a4a.[IsDeleted]
                FROM dbo.tbl_A4as as a4a
                UNION
                SELECT a5d2.[FormId], a5d2.[VisitId], a5d2.[Status], a5d2.[LANG], a5d2.[MODE], a5d2.[REMOTEMODE], a5d2.[REMOTEREASON], a5d2.[SUB], a5d2.[NOT], 'A5D2' as Kind, a5d2.[CreatedAt], a5d2.[CreatedBy], a5d2.[ModifiedBy], a5d2.[DeletedBy], a5d2.[IsDeleted]
                FROM dbo.tbl_A5D2s as a5d2
                UNION
                SELECT b1.[FormId], b1.[VisitId], b1.[Status], b1.[LANG], b1.[MODE], b1.[REMOTEMODE], b1.[REMOTEREASON], b1.[SUB], b1.[NOT], 'B1' as Kind, b1.[CreatedAt], b1.[CreatedBy], b1.[ModifiedBy], b1.[DeletedBy], b1.[IsDeleted]
                FROM dbo.tbl_B1s as b1
                UNION
                SELECT b3.[FormId], b3.[VisitId], b3.[Status], b3.[LANG], b3.[MODE], b3.[REMOTEMODE], b3.[REMOTEREASON], b3.[SUB], b3.[NOT], 'B3' as Kind, b3.[CreatedAt], b3.[CreatedBy], b3.[ModifiedBy], b3.[DeletedBy], b3.[IsDeleted]
                FROM dbo.tbl_B3s as b3
                UNION
                SELECT b4.[FormId], b4.[VisitId], b4.[Status], b4.[LANG], b4.[MODE], b4.[REMOTEMODE], b4.[REMOTEREASON], b4.[SUB], b4.[NOT], 'B4' as Kind, b4.[CreatedAt], b4.[CreatedBy], b4.[ModifiedBy], b4.[DeletedBy], b4.[IsDeleted]
                FROM dbo.tbl_B4s as b4
                UNION
                SELECT b5.[FormId], b5.[VisitId], b5.[Status], b5.[LANG], b5.[MODE], b5.[REMOTEMODE], b5.[REMOTEREASON], b5.[SUB], b5.[NOT], 'B5' as Kind, b5.[CreatedAt], b5.[CreatedBy], b5.[ModifiedBy], b5.[DeletedBy], b5.[IsDeleted]
                FROM dbo.tbl_B5s as b5
                UNION
                SELECT b6.[FormId], b6.[VisitId], b6.[Status], b6.[LANG], b6.[MODE], b6.[REMOTEMODE], b6.[REMOTEREASON], b6.[SUB], b6.[NOT], 'B6' as Kind, b6.[CreatedAt], b6.[CreatedBy], b6.[ModifiedBy], b6.[DeletedBy], b6.[IsDeleted]
                FROM dbo.tbl_B6s as b6
                UNION
                SELECT b7.[FormId], b7.[VisitId], b7.[Status], b7.[LANG], b7.[MODE], b7.[REMOTEMODE], b7.[REMOTEREASON], b7.[SUB], b7.[NOT], 'B7' as Kind, b7.[CreatedAt], b7.[CreatedBy], b7.[ModifiedBy], b7.[DeletedBy], b7.[IsDeleted]
                FROM dbo.tbl_B7s as b7
                UNION
                SELECT b8.[FormId], b8.[VisitId], b8.[Status], b8.[LANG], b8.[MODE], b8.[REMOTEMODE], b8.[REMOTEREASON], b8.[SUB], b8.[NOT], 'B8' as Kind, b8.[CreatedAt], b8.[CreatedBy], b8.[ModifiedBy], b8.[DeletedBy], b8.[IsDeleted]
                FROM dbo.tbl_B8s as b8
                UNION
                SELECT b9.[FormId], b9.[VisitId], b9.[Status], b9.[LANG], b9.[MODE], b9.[REMOTEMODE], b9.[REMOTEREASON], b9.[SUB], b9.[NOT], 'B9' as Kind, b9.[CreatedAt], b9.[CreatedBy], b9.[ModifiedBy], b9.[DeletedBy], b9.[IsDeleted]
                FROM dbo.tbl_B9s as b9
                UNION
                SELECT c1.[FormId], c1.[VisitId], c1.[Status], c1.[LANG], c1.[MODE], c1.[REMOTEMODE], c1.[REMOTEREASON], c1.[SUB], c1.[NOT], 'C1' as Kind, c1.[CreatedAt], c1.[CreatedBy], c1.[ModifiedBy], c1.[DeletedBy], c1.[IsDeleted]
                FROM dbo.tbl_C1s as c1
                UNION
                SELECT c2.[FormId], c2.[VisitId], c2.[Status], c2.[LANG], c2.[MODE], c2.[REMOTEMODE], c2.[REMOTEREASON], c2.[SUB], c2.[NOT], 'C2' as Kind, c2.[CreatedAt], c2.[CreatedBy], c2.[ModifiedBy], c2.[DeletedBy], c2.[IsDeleted]
                FROM dbo.tbl_C2s as c2
                UNION
                SELECT d1a.[FormId], d1a.[VisitId], d1a.[Status], d1a.[LANG], d1a.[MODE], d1a.[REMOTEMODE], d1a.[REMOTEREASON], d1a.[SUB], d1a.[NOT], 'D1a' as Kind, d1a.[CreatedAt], d1a.[CreatedBy], d1a.[ModifiedBy], d1a.[DeletedBy], d1a.[IsDeleted]
                FROM dbo.tbl_D1as as d1a
                UNION
                SELECT d1b.[FormId], d1b.[VisitId], d1b.[Status], d1b.[LANG], d1b.[MODE], d1b.[REMOTEMODE], d1b.[REMOTEREASON], d1b.[SUB], d1b.[NOT], 'D1b' as Kind, d1b.[CreatedAt], d1b.[CreatedBy], d1b.[ModifiedBy], d1b.[DeletedBy], d1b.[IsDeleted]
                FROM dbo.tbl_D1bs as d1b
                UNION
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[LANG], t1.[MODE], t1.[REMOTEMODE], t1.[REMOTEREASON], t1.[SUB], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1");
        }
    }
}
