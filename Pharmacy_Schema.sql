-- =============================================
-- Pharmacy Module Database Script
-- =============================================

USE [BeninaClinic] -- Ensure this matches your database name
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 1. Create Pharmacy_Medications Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pharmacy_Medications]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pharmacy_Medications](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Code] [nvarchar](50) NULL,
    [Name] [nvarchar](150) NOT NULL,
    [ScientificName] [nvarchar](150) NULL,
    [Type] [nvarchar](50) NULL, -- Tablet, Syrup, Injection, etc.
    [PurchasePrice] [decimal](18, 2) NOT NULL DEFAULT 0,
    [SellingPrice] [decimal](18, 2) NOT NULL DEFAULT 0,
    [Quantity] [int] NOT NULL DEFAULT 0,
    [ExpiryDate] [date] NOT NULL,
    [ProductionDate] [date] NULL,
    [AlertQuantity] [int] NOT NULL DEFAULT 10,
    [IsActive] [bit] NOT NULL DEFAULT 1,
 CONSTRAINT [PK_Pharmacy_Medications] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)
)
END
GO

-- 2. Create Pharmacy_Dispensations Table (Header)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pharmacy_Dispensations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pharmacy_Dispensations](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [DispenseDate] [datetime] NOT NULL DEFAULT GETDATE(),
    [UserId] [int] NOT NULL, -- Pharmacist
    [PatientId] [int] NULL, -- Helper to link to patient if known
    [PatientName] [nvarchar](150) NULL, -- In case patient is not registered or external
    [TotalCost] [decimal](18, 2) NOT NULL DEFAULT 0,
    [Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pharmacy_Dispensations] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)
)
END
GO

-- 3. Create Pharmacy_DispensationDetails Table (Details)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pharmacy_DispensationDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pharmacy_DispensationDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [DispensationId] [int] NOT NULL,
    [MedicationId] [int] NOT NULL,
    [Quantity] [int] NOT NULL,
    [Cost] [decimal](18, 2) NOT NULL, -- Cost at moment of dispensing
 CONSTRAINT [PK_Pharmacy_DispensationDetails] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)
)
ALTER TABLE [dbo].[Pharmacy_DispensationDetails]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_DispensationDetails_Pharmacy_Dispensations] FOREIGN KEY([DispensationId])
REFERENCES [dbo].[Pharmacy_Dispensations] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Pharmacy_DispensationDetails]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_DispensationDetails_Pharmacy_Medications] FOREIGN KEY([MedicationId])
REFERENCES [dbo].[Pharmacy_Medications] ([Id])
END
GO

-- =============================================
-- STORED PROCEDURES
-- =============================================

-- SP: Insert Medication
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_InsertMedication]
    @Code nvarchar(50),
    @Name nvarchar(150),
    @ScientificName nvarchar(150),
    @Type nvarchar(50),
    @PurchasePrice decimal(18,2),
    @SellingPrice decimal(18,2),
    @Quantity int,
    @ExpiryDate date,
    @ProductionDate date,
    @AlertQuantity int
AS
BEGIN
    INSERT INTO Pharmacy_Medications 
    (Code, Name, ScientificName, Type, PurchasePrice, SellingPrice, Quantity, ExpiryDate, ProductionDate, AlertQuantity)
    VALUES 
    (@Code, @Name, @ScientificName, @Type, @PurchasePrice, @SellingPrice, @Quantity, @ExpiryDate, @ProductionDate, @AlertQuantity)
END
GO

-- SP: Update Medication
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_UpdateMedication]
    @Id int,
    @Code nvarchar(50),
    @Name nvarchar(150),
    @ScientificName nvarchar(150),
    @Type nvarchar(50),
    @PurchasePrice decimal(18,2),
    @SellingPrice decimal(18,2),
    @Quantity int,
    @ExpiryDate date,
    @ProductionDate date,
    @AlertQuantity int
AS
BEGIN
    UPDATE Pharmacy_Medications
    SET 
        Code = @Code,
        Name = @Name,
        ScientificName = @ScientificName,
        Type = @Type,
        PurchasePrice = @PurchasePrice,
        SellingPrice = @SellingPrice,
        Quantity = @Quantity,
        ExpiryDate = @ExpiryDate,
        ProductionDate = @ProductionDate,
        AlertQuantity = @AlertQuantity
    WHERE Id = @Id
END
GO

-- SP: Delete Medication (Soft Delete preferred, but hard delete for now per request simplicity)
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_DeleteMedication]
    @Id int
AS
BEGIN
    DELETE FROM Pharmacy_Medications WHERE Id = @Id
END
GO

-- SP: Get All Medications
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_GetAllMedications]
AS
BEGIN
    SELECT * FROM Pharmacy_Medications WHERE IsActive = 1
END
GO

-- SP: Search Medications
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_SearchMedications]
    @Search nvarchar(100)
AS
BEGIN
    SELECT * FROM Pharmacy_Medications 
    WHERE IsActive = 1 
    AND (Name LIKE '%' + @Search + '%' OR ScientificName LIKE '%' + @Search + '%' OR Code LIKE '%' + @Search + '%')
END
GO

-- SP: Insert Dispensation Header
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_InsertDispensation]
    @UserId int,
    @PatientId int,
    @PatientName nvarchar(150),
    @TotalCost decimal(18,2),
    @Note nvarchar(max),
    @NewId int OUTPUT
AS
BEGIN
    INSERT INTO Pharmacy_Dispensations (DispenseDate, UserId, PatientId, PatientName, TotalCost, Note)
    VALUES (GETDATE(), @UserId, @PatientId, @PatientName, @TotalCost, @Note)
    
    SET @NewId = SCOPE_IDENTITY()
END
GO

-- SP: Insert Dispensation Detail
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_InsertDispensationDetail]
    @DispensationId int,
    @MedicationId int,
    @Quantity int,
    @Cost decimal(18,2)
AS
BEGIN
    INSERT INTO Pharmacy_DispensationDetails (DispensationId, MedicationId, Quantity, Cost)
    VALUES (@DispensationId, @MedicationId, @Quantity, @Cost)

    -- Deduct Inventory
    UPDATE Pharmacy_Medications
    SET Quantity = Quantity - @Quantity
    WHERE Id = @MedicationId
END
GO

-- SP: Get Pending Doctor Prescriptions
-- IMPORTANT: This assumes existence of Tables [Visit], [VisitMedications], [Patient]
-- Adjust column names if they differ in your actual DB.
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_GetDoctorNotifications]
AS
BEGIN
    -- Select visits from today that have medications
    -- We assume InsertVisitMedications populates a table, let's guess its name is 'VisitMedications' or similar based on existing usage
    -- If 'VisitMedications' table doesn't exist, this SP might fail until created.
    -- Based on 'InsertVisitMedications' in 'VisitManagement.cs', likely 'Visit_Medications' or similar.
    
    -- Attempting to join logically.
    SELECT 
        v.Visit_Id,
        p.PatientName,
        d.DoctorName,
        v.VisitDate,
        vm.MedicineName,
        vm.Note,
        -- vm.Dosage -- If exists
        -- vm.Quantity -- If exists
        p.Patient_Id
    FROM Visit v
    INNER JOIN Patient p ON v.Patient_Id = p.Patient_Id
    INNER JOIN Doctor d ON v.Doctor_Id = d.Doctor_Id
    INNER JOIN VisitMedications vm ON v.Visit_Id = vm.Visit_Id
    WHERE CONVERT(date, v.VisitDate) = CONVERT(date, GETDATE())
    ORDER BY v.VisitDate DESC
END
GO
