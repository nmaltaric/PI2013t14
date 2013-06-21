CREATE TABLE [dbo].[Klijent] (
    [ID_klijenta]    INT          IDENTITY (1, 1) NOT NULL,
    [ime]            VARCHAR (50) NOT NULL,
    [prezime]        VARCHAR (50) NOT NULL,
	[spol]			 VARCHAR (50) NOT NULL,
    [email]          VARCHAR (50) NULL,
    [telefon]        VARCHAR (50) NULL,
    [newsletter]     BIT          NOT NULL,
    [broj_dolazaka]  INT          NULL,
    [zadnji_dolazak] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([ID_klijenta] ASC)
);
