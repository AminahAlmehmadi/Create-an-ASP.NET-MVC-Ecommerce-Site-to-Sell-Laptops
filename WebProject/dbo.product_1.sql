CREATE TABLE [dbo].[product] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [Price]   FLOAT (53)     NOT NULL,
    [Details] NVARCHAR (MAX) NULL,
    [Image]   IMAGE (MAX) NULL,
    [Count]   INT            NOT NULL,
    CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED ([ID] ASC)
);

