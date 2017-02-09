CREATE TABLE [dbo].[Email] (
    [EmailId]      INT            NOT NULL IDENTITY,
    [Subject] NVARCHAR (255) NULL,
    [Body]    NVARCHAR (MAX) NULL,
    [Sent] DATETIME2 NOT NULL, 
    PRIMARY KEY CLUSTERED ([EmailId] ASC)
);

