CREATE TABLE [dbo].[Stavka_računa] (
    [ID_stavke] INT NOT NULL IDENTITY,
    [ID_računa] INT NOT NULL,
    [ID_usluge] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID_stavke] ASC), 
    CONSTRAINT [FK_Stavka_računa_ID_računa] FOREIGN KEY ([ID_računa]) REFERENCES [Račun]([ID_računa]), 
    CONSTRAINT [FK_Stavka_računa_ID_usluge] FOREIGN KEY ([ID_usluge]) REFERENCES [Usluga]([ID_usluge])
);
