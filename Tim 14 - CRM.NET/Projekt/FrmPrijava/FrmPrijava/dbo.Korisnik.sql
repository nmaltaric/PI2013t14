CREATE TABLE [dbo].[Korisnik] (
    [ID_korisnika] INT          IDENTITY (1, 1) NOT NULL,
    [ime]          VARCHAR (50) NOT NULL,
    [prezime]      VARCHAR (50) NOT NULL,
    [username]      VARCHAR (50) NOT NULL,
    [lozinka]      VARCHAR (50) NOT NULL,
    [tip_korisnika]      BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_korisnika] ASC)
);
