CREATE TABLE [dbo].[User] (
    [userid]   INT           NOT NULL,
    [fullname] VARCHAR (MAX) NULL,
    [bdate]    DATE          NULL,
    [address]  VARCHAR (MAX) NULL,
    [username] VARCHAR (MAX) NULL,
    [password] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([userid] ASC)
);

