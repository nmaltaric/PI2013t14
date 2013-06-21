CREATE TABLE [dbo].[Usluga] (
    [ID_usluge]   INT          IDENTITY (1, 1) NOT NULL,
    [naziv]       VARCHAR (50) NOT NULL,
    [opis]        VARCHAR (50) NULL,
    [mj_jedinica] VARCHAR (50) NOT NULL,
    [cijena]      MONEY        NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_usluge] ASC)
);

