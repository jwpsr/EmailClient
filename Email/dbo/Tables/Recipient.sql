CREATE TABLE [dbo].[Recipient] (
    [Id]      INT            NOT NULL,
    [Name]    VARCHAR (25)   NULL,
    [Address] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

