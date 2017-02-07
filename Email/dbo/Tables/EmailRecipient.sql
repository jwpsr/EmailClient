CREATE TABLE [dbo].[EmailRecipient] (
    [Id]          INT NOT NULL,
    [EmailId]     INT NOT NULL,
    [RecipientId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EmailRecipient_Email] FOREIGN KEY ([EmailId]) REFERENCES [dbo].[Email] ([Id]),
    CONSTRAINT [FK_EmailRecipient_Recipient] FOREIGN KEY ([RecipientId]) REFERENCES [dbo].[Recipient] ([Id])
);

