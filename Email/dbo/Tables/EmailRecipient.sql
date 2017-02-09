CREATE TABLE [dbo].[EmailRecipient] (
    [EmailRecipientId]          INT NOT NULL IDENTITY,
    [EmailId]     INT NOT NULL,
    [RecipientId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([EmailRecipientId] ASC),
    CONSTRAINT [FK_EmailRecipient_Email] FOREIGN KEY ([EmailId]) REFERENCES [dbo].[Email] ([EmailId]),
    CONSTRAINT [FK_EmailRecipient_Recipient] FOREIGN KEY ([RecipientId]) REFERENCES [dbo].[Recipient] ([RecipientId])
);

