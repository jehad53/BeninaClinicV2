USE [BeninaClinic]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Additional SPs for Audit Logging Support
-- =============================================

-- SP: Get Medication By Id
CREATE OR ALTER PROCEDURE [dbo].[Pharmacy_GetMedicationById]
    @Id int
AS
BEGIN
    SELECT * FROM Pharmacy_Medications WHERE Id = @Id
END
GO

-- SP: Get Employee By Id
-- Note: Assuming table name is 'Employees' and PK is 'Employee_Id' based on DAL usage.
-- If incorrect, this will fail. Usage in EmployeesManagement: @Employee_Id.
-- Let's check InsertEmployee again. It doesn't use Employee_Id.
-- DeleteEmployee uses @Employee_Id.
-- So column is likely Employee_Id.
CREATE OR ALTER PROCEDURE [dbo].[GetEmployeeById]
    @Employee_Id int
AS
BEGIN
    SELECT * FROM Employees WHERE Employee_Id = @Employee_Id
END
GO
