CREATE TABLE [dbo].[Račun] (
    [ID_računa]    INT      IDENTITY (1, 1) NOT NULL,
    [datum]        DATETIME NOT NULL,
    [ID_korisnika] INT      NOT NULL,
    [ID_klijenta]  INT      NULL,
    PRIMARY KEY CLUSTERED ([ID_računa] ASC), 
    CONSTRAINT [FK_Račun_ID_korisnika] FOREIGN KEY ([ID_korisnika]) REFERENCES [Korisnik]([ID_korisnika]), 
    CONSTRAINT [FK_Račun_ID_klijenta] FOREIGN KEY ([ID_klijenta]) REFERENCES [Klijent]([ID_klijenta])
);

