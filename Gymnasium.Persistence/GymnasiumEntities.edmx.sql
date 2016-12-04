
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2016 16:46:23
-- Generated from EDMX file: C:\PROJECT\Gymnasium\Gymnasium.Persistence\GymnasiumEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GymnasiumDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LærerFag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fags] DROP CONSTRAINT [FK_LærerFag];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Lærer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lærer];
GO
IF OBJECT_ID(N'[dbo].[Elevs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Elevs];
GO
IF OBJECT_ID(N'[dbo].[Fags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fags];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Lærer'
CREATE TABLE [dbo].[Lærer] (
    [LærerId] uniqueidentifier  NOT NULL,
    [CprNummer] nvarchar(50)  NOT NULL,
    [Navn] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(250)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Elevs'
CREATE TABLE [dbo].[Elevs] (
    [ElevId] uniqueidentifier  NOT NULL,
    [CprNummer] nvarchar(50)  NOT NULL,
    [Navn] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(250)  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Fags'
CREATE TABLE [dbo].[Fags] (
    [FagId] uniqueidentifier  NOT NULL,
    [Navn] nvarchar(50)  NOT NULL,
    [Beskrivelse] nvarchar(500)  NOT NULL,
    [Deleted] bit  NOT NULL,
    [LærerLærerId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [LærerId] in table 'Lærer'
ALTER TABLE [dbo].[Lærer]
ADD CONSTRAINT [PK_Lærer]
    PRIMARY KEY CLUSTERED ([LærerId] ASC);
GO

-- Creating primary key on [ElevId] in table 'Elevs'
ALTER TABLE [dbo].[Elevs]
ADD CONSTRAINT [PK_Elevs]
    PRIMARY KEY CLUSTERED ([ElevId] ASC);
GO

-- Creating primary key on [FagId] in table 'Fags'
ALTER TABLE [dbo].[Fags]
ADD CONSTRAINT [PK_Fags]
    PRIMARY KEY CLUSTERED ([FagId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LærerLærerId] in table 'Fags'
ALTER TABLE [dbo].[Fags]
ADD CONSTRAINT [FK_LærerFag]
    FOREIGN KEY ([LærerLærerId])
    REFERENCES [dbo].[Lærer]
        ([LærerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LærerFag'
CREATE INDEX [IX_FK_LærerFag]
ON [dbo].[Fags]
    ([LærerLærerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------