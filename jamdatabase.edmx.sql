
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2023 19:25:55
-- Generated from EDMX file: C:\Users\kgemp\source\repos\kemoygallimore\Jamcheck\jamdatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [jampractice];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__users__companyid__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users] DROP CONSTRAINT [FK__users__companyid__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__users__roletype__29572725]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users] DROP CONSTRAINT [FK__users__roletype__29572725];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Org]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Org];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Orgs'
CREATE TABLE [dbo].[Orgs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [company] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [id] int IDENTITY(1,1) NOT NULL,
    [RoleType] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [fname] nvarchar(20)  NOT NULL,
    [lname] nvarchar(20)  NOT NULL,
    [username] nvarchar(40)  NOT NULL,
    [email] nvarchar(50)  NOT NULL,
    [companyid] int  NOT NULL,
    [roletypeid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Orgs'
ALTER TABLE [dbo].[Orgs]
ADD CONSTRAINT [PK_Orgs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [companyid] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [FK__users__companyid__286302EC]
    FOREIGN KEY ([companyid])
    REFERENCES [dbo].[Orgs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__users__companyid__286302EC'
CREATE INDEX [IX_FK__users__companyid__286302EC]
ON [dbo].[users]
    ([companyid]);
GO

-- Creating foreign key on [roletypeid] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [FK__users__roletype__29572725]
    FOREIGN KEY ([roletypeid])
    REFERENCES [dbo].[Roles]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__users__roletype__29572725'
CREATE INDEX [IX_FK__users__roletype__29572725]
ON [dbo].[users]
    ([roletypeid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------