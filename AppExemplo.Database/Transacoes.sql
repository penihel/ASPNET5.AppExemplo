CREATE TABLE [dbo].[Transacoes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL , 
	[ContaId] UNIQUEIDENTIFIER NOT NULL,
    [DataHora] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Historico] NVARCHAR(100) NOT NULL,
	[Identificador] NVARCHAR(100) NOT NULL, 
    [SaldoContaAnterior] NUMERIC(18, 2) NOT NULL,
	[ValorCredito] NUMERIC(18, 2) NOT NULL, 
    [ValorDebito] NUMERIC(18, 2) NOT NULL, 
    [SaldoConta] NUMERIC(18, 2) NOT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Transacoes_Contas] FOREIGN KEY ([ContaId]) REFERENCES [Contas]([Id]), 
    CONSTRAINT [CK_Transacoes_ValorCredito] CHECK (ValorCredito >= 0),
	CONSTRAINT [CK_Transacoes_ValorDebito] CHECK (ValorDebito >= 0)
)
