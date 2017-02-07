CREATE TABLE [dbo].[Email] (
    [Id]      INT            NOT NULL,
    [Subject] NVARCHAR (255) NULL,
    [Body]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

