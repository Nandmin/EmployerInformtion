Use [EmployeeDB]
Go

Set ANSI_NULLS ON
Go

Set Quoted_Identifier ON
GO

Create Table [dbo].[EmployeeInfo](
	[EmployeeId] [int] NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[Salary] [decimal](18,0) NULL,
	[DepartmentName] [varchar](50) NULL
) On [Primary]
Go

