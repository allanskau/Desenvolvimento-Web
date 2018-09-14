CREATE TABLE [dbo].[Contatos]
(
	[Email] VARCHAR(50) NOT NULL , 
    [TipoContato] INT NOT NULL, 
    [Telefone] NCHAR(16) NULL, 
    PRIMARY KEY ([TipoContato], [Email])
)
