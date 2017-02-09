CREATE TABLE [dbo].[Recipient] (
    [RecipientId]      INT            NOT NULL IDENTITY,
    [Name]    VARCHAR (25)   NULL,
    [Address] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([RecipientId] ASC)
);

