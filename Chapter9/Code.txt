
-- --------------------------------------------------
-- Date Created: 12/05/2009 08:32:14
-- Generated from EDMX file: C:\Projects\APress\Chapter9\ModelFirst\ModelFirst\Motocross.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
SET ANSI_NULLS ON;
GO

USE [AdventureWorks]
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]')
GO

-- --------------------------------------------------
-- Dropping existing FK constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BrandTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams] DROP CONSTRAINT [FK_BrandTeam]
GO
IF OBJECT_ID(N'[dbo].[FK_RiderTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams] DROP CONSTRAINT [FK_RiderTeam]
GO
IF OBJECT_ID(N'[dbo].[FK_ClassRider]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Riders] DROP CONSTRAINT [FK_ClassRider]
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams];
GO
IF OBJECT_ID(N'[dbo].[Riders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Riders];
GO
IF OBJECT_ID(N'[dbo].[Classes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Classes];
GO
IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [TeamID] int IDENTITY(1,1) NOT NULL,
    [TeamName] nvarchar(max)  NOT NULL,
    [IsSupportTeam] bit  NOT NULL,
    [BrandID] int  NOT NULL,
    [Brand_BrandID] int  NOT NULL
);
GO
-- Creating table 'Riders'
CREATE TABLE [dbo].[Riders] (
    [RiderID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Age] smallint  NOT NULL,
    [ClassID] int  NOT NULL,
    [TeamID] int  NOT NULL,
    [Class_ClassID] int  NOT NULL,
    [Team_TeamID] int  NOT NULL
);
GO
-- Creating table 'Classes'
CREATE TABLE [dbo].[Classes] (
    [ClassID] int IDENTITY(1,1) NOT NULL,
    [ClassName] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [BrandID] int IDENTITY(1,1) NOT NULL,
    [BrandName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all Primary Key Constraints
-- --------------------------------------------------

-- Creating primary key on [TeamID] in table 'Teams'
ALTER TABLE [dbo].[Teams] WITH NOCHECK 
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([TeamID] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [RiderID] in table 'Riders'
ALTER TABLE [dbo].[Riders] WITH NOCHECK 
ADD CONSTRAINT [PK_Riders]
    PRIMARY KEY CLUSTERED ([RiderID] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [ClassID] in table 'Classes'
ALTER TABLE [dbo].[Classes] WITH NOCHECK 
ADD CONSTRAINT [PK_Classes]
    PRIMARY KEY CLUSTERED ([ClassID] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [BrandID] in table 'Brands'
ALTER TABLE [dbo].[Brands] WITH NOCHECK 
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([BrandID] ASC)
    ON [PRIMARY]
GO

-- --------------------------------------------------
-- Creating all Foreign Key Constraints
-- --------------------------------------------------

-- Creating foreign key on [Brand_BrandID] in table 'Teams'
ALTER TABLE [dbo].[Teams] WITH NOCHECK 
ADD CONSTRAINT [FK_BrandTeam]
    FOREIGN KEY ([Brand_BrandID])
    REFERENCES [dbo].[Brands]
        ([BrandID])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Class_ClassID] in table 'Riders'
ALTER TABLE [dbo].[Riders] WITH NOCHECK 
ADD CONSTRAINT [FK_ClassRider]
    FOREIGN KEY ([Class_ClassID])
    REFERENCES [dbo].[Classes]
        ([ClassID])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Team_TeamID] in table 'Riders'
ALTER TABLE [dbo].[Riders] WITH NOCHECK 
ADD CONSTRAINT [FK_TeamRider]
    FOREIGN KEY ([Team_TeamID])
    REFERENCES [dbo].[Teams]
        ([TeamID])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------