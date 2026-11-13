BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261113215847_CreateD1c'
)
BEGIN
    CREATE TABLE [tbl_D1cs] (
        [FormId] int NOT NULL IDENTITY,
        [PacketId] int NOT NULL,
        [Status] nvarchar(20) NOT NULL,
        [FRMDATE] datetime2 NOT NULL,
        [INITIALS] nvarchar(3) NOT NULL,
        [LANG] int NULL,
        [MODE] int NULL,
        [RMREASON] int NULL,
        [RMMODE] int NULL,
        [NOT] int NULL,
        [ADMIN] int NULL,
        [FRMDATED1C] datetime2 NULL,
        [INITIALSD1C] nvarchar(60) NULL,
        [LANGD1C] int NULL,
        [MODED1C] int NULL,
        [D1CNOT] int NULL,
        [DXPLSMABIO] int NULL,
        [DXPTAU217] int NULL,
        [PTAU217RS] int NULL,
        [PT217ANLYS] int NULL,
        [PT217INT] int NULL,
        [DXPCPT217] int NULL,
        [PCPT217RS] int NULL,
        [PCPT217INT] int NULL,
        [DXOTHPLSMA] int NULL,
        [DXOTHPLSMX] nvarchar(60) NULL,
        [OTHPLSMARS] int NULL,
        [OPLSMANLYS] int NULL,
        [OPLSMAINT] int NULL,
        [DXCSFBIO] int NULL,
        [DXPT181AB] int NULL,
        [PT181ABRS] int NULL,
        [PT181ABAYS] int NULL,
        [PT181ABINT] int NULL,
        [DXTTABETA] int NULL,
        [TTABETARS] int NULL,
        [TTABETAINT] int NULL,
        [DXAB42AB40] int NULL,
        [AB42AB40RS] int NULL,
        [AB42AB40AY] int NULL,
        [AB42AB40IT] int NULL,
        [DXOTHCSF] int NULL,
        [DXOTHCSFX] nvarchar(60) NULL,
        [OTHCSFRS] int NULL,
        [OCSFANLYS] int NULL,
        [OCSFINT] int NULL,
        [DXAPET] int NULL,
        [APETRS] int NULL,
        [APETVIS] int NULL,
        [APETQUANT] int NULL,
        [APETANLYS] int NULL,
        [APETINT] int NULL,
        [DXTAUPET] int NULL,
        [TPETMTLRS] int NULL,
        [TPETMTLVIS] int NULL,
        [TPETMTLQNT] int NULL,
        [TPETMTLAYS] int NULL,
        [TPETNEORS] int NULL,
        [TPETNEOVIS] int NULL,
        [TPETNEOQNT] int NULL,
        [TPETNEOAYS] int NULL,
        [DXTAUPTINT] int NULL,
        [INFORISCH] int NULL,
        [IMGRSINF] int NULL,
        [IMGRSINFLC] int NULL,
        [IMGRSINFCT] int NULL,
        [IMGRSMICR] int NULL,
        [IMGRSWMH] int NULL,
        [IMGRSSPSID] int NULL,
        [IMGRSOTH] int NULL,
        [IMGRSOTHX] nvarchar(60) NULL,
        [IMGRSINT] int NULL,
        [DXASYN] int NULL,
        [ASYNRS] int NULL,
        [ASYNASSAY] int NULL,
        [ASYNASSAYX] nvarchar(60) NULL,
        [ASYNANLYSX] nvarchar(60) NULL,
        [ASYNINT] int NULL,
        [AACRITMET] int NULL,
        [CR1APET] int NULL,
        [CR1PTAU217] int NULL,
        [CR1PCPT217] int NULL,
        [CR1PT181AB] int NULL,
        [CR1TTABETA] int NULL,
        [C1AB42AB40] int NULL,
        [CR1OTH] int NULL,
        [CR1OTHX] nvarchar(60) NULL,
        [BIOSTAGE] int NULL,
        [CLINSTAGE] int NULL,
        [CreatedAt] datetime2 NOT NULL,
        [CreatedBy] nvarchar(max) NOT NULL,
        [ModifiedBy] nvarchar(max) NULL,
        [DeletedBy] nvarchar(max) NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_tbl_D1cs] PRIMARY KEY ([FormId]),
        CONSTRAINT [FK_tbl_D1cs_tbl_Packets_PacketId] FOREIGN KEY ([PacketId]) REFERENCES [tbl_Packets] ([PacketId]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261113215847_CreateD1c'
)
BEGIN
    CREATE UNIQUE INDEX [IX_tbl_D1cs_PacketId] ON [tbl_D1cs] ([PacketId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261113215847_CreateD1c'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20261113215847_CreateD1c', N'10.0.1');
END;

COMMIT;
GO

