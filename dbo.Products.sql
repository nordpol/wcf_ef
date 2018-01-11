USE [wcf]
GO

/****** Object: Table [dbo].[Products] Script Date: 11.01.2018 23:56:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [ProductID]    INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]  NVARCHAR (MAX) NULL,
    [UnitInStock]  INT            NOT NULL,
    [CategoryName] NVARCHAR (MAX) NULL,
    [CategoryID]   INT            NOT NULL
);


