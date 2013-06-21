CREATE TABLE [dbo].[Stavka_cjenika] (
    [ID_stavke] INT NOT NULL IDENTITY,
    [ID_cjenika]  INT NOT NULL,
    [ID_usluge] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID_stavke] ASC), 
    CONSTRAINT [FK_Stavka_cjenika_ID_cjenika] FOREIGN KEY ([ID_cjenika]) REFERENCES [Cjenik]([ID_cjenika]), 
    CONSTRAINT [FK_Stavka_cjenika_ID_usluge] FOREIGN KEY ([ID_usluge]) REFERENCES [Usluga]([ID_usluge])
);
