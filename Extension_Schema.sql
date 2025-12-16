-- =============================================
-- Extension Schema for Benina Clinic
-- Features: Employee Medication Dispensing, Audit Logging
-- =============================================

USE [BeninaClinic]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- 1. Employee Dispensing Tables
-- =============================================

-- Table: Pharmacy_EmployeeDispensations (Header)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pharmacy_EmployeeDispensations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pharmacy_EmployeeDispensations](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [DispenseDate] [datetime] NOT NULL DEFAULT GETDATE(),
    [UserId] [int] NOT NULL, -- Pharmacist/User who dispensed
    [EmployeeId] [int] NOT NULL, -- Employee receiving the medication
    [EmployeeName] [nvarchar](150) NULL, -- Snapshot of name in case of deletion
    [TotalCost] [decimal](18, 2) NOT NULL DEFAULT 0,
    [Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pharmacy_EmployeeDispensations] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)
)
END
GO

-- Table: Pharmacy_EmployeeDispensationDetails (Details)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pharmacy_EmployeeDispensationDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pharmacy_EmployeeDispensationDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [DispensationId] [int] NOT NULL,
    [MedicationId] [int] NOT NULL,
    [Quantity] [int] NOT NULL,
    [Cost] [decimal](18, 2) NOT NULL, -- Cost at moment of dispensing (SellingPrice)
 CONSTRAINT [PK_Pharmacy_EmployeeDispensationDetails] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)
)

ALTER TABLE [dbo].[Pharmacy_EmployeeDispensationDetails]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_EmployeeDispensationDetails_Header] FOREIGN KEY([DispensationId])
REFERENCES [dbo].[Pharmacy_EmployeeDispensations] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Pharmacy_EmployeeDispensationDetails]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_EmployeeDispensationDetails_Medication] FOREIGN KEY([MedicationId])
REFERENCES [dbo].[Pharmacy_Medications] ([Id])
END
GO

-- =============================================
-- 2. Audit Log Table
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuditLogs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AuditLogs](
    [LogId] [bigint] IDENTITY(1,1) NOT NULL,
    [ActionType] [nvarchar](50) NOT NULL, -- Insert, Update, Delete, Login, Logout, Dispense
    [TableName] [nvarchar](100) NULL, -- Target Table (e.g., Pharmacy_Medications)
    [RecordId] [nvarchar](50) NULL, -- Target Record ID
    [UserId] [int] NULL, -- User performing the action
    [ActionDate] [datetime] NOT NULL DEFAULT GETDATE(),
    [OldValue] [nvarchar](max) NULL, -- JSON or concatenated string
    [NewValue] [nvarchar](max) NULL,
    [MachineName] [nvarchar](100) NULL,
    [IPAddress] [nvarchar](50) NULL,
 CONSTRAINT [PK_AuditLogs] PRIMARY KEY CLUSTERED 
(
    [LogId] ASC
)
)
END
GO

-- =============================================
-- 3. Stored Procedures for Employee Dispensing
-- =============================================

-- SP: Insert Employee Dispensation Header
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_InsertEmployeeDispensation]
    @UserId int,
    @EmployeeId int,
    @EmployeeName nvarchar(150),
    @TotalCost decimal(18,2),
    @Note nvarchar(max),
    @NewId int OUTPUT
AS
BEGIN
    INSERT INTO Pharmacy_EmployeeDispensations (DispenseDate, UserId, EmployeeId, EmployeeName, TotalCost, Note)
    VALUES (GETDATE(), @UserId, @EmployeeId, @EmployeeName, @TotalCost, @Note)
    
    SET @NewId = SCOPE_IDENTITY()
END
GO

-- SP: Insert Employee Dispensation Detail
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_InsertEmployeeDispensationDetail]
    @DispensationId int,
    @MedicationId int,
    @Quantity int,
    @Cost decimal(18,2)
AS
BEGIN
    INSERT INTO Pharmacy_EmployeeDispensationDetails (DispensationId, MedicationId, Quantity, Cost)
    VALUES (@DispensationId, @MedicationId, @Quantity, @Cost)

    -- Deduct Inventory
    UPDATE Pharmacy_Medications
    SET Quantity = Quantity - @Quantity
    WHERE Id = @MedicationId
END
GO

-- =============================================
-- 4. Stored Procedures for Audit Logs
-- =============================================

-- SP: Insert Log
CREATE OR ALTER PROCEDURE [dbo].[Audit_InsertLog]
    @ActionType nvarchar(50),
    @TableName nvarchar(100),
    @RecordId nvarchar(50),
    @UserId int,
    @OldValue nvarchar(max),
    @NewValue nvarchar(max),
    @MachineName nvarchar(100),
    @IPAddress nvarchar(50)
AS
BEGIN
    INSERT INTO AuditLogs (ActionType, TableName, RecordId, UserId, ActionDate, OldValue, NewValue, MachineName, IPAddress)
    VALUES (@ActionType, @TableName, @RecordId, @UserId, GETDATE(), @OldValue, @NewValue, @MachineName, @IPAddress)
END
GO

-- SP: Get Logs (Optional, for viewing)
CREATE OR ALTER PROCEDURE [dbo].[Audit_GetLogs]
    @FromDate datetime = NULL,
    @ToDate datetime = NULL
AS
BEGIN
    SELECT * FROM AuditLogs
    WHERE (@FromDate IS NULL OR ActionDate >= @FromDate)
      AND (@ToDate IS NULL OR ActionDate <= @ToDate)
    ORDER BY ActionDate DESC
END
GO
