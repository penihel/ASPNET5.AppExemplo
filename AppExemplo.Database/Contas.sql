CREATE TABLE [dbo].[Contas]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ClienteId] UNIQUEIDENTIFIER NOT NULL, 
    [DataCriacao] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Numero] NVARCHAR(50) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    CONSTRAINT [FK_Contas_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes]([Id]), 
    CONSTRAINT [UK_Contas_Numero] UNIQUE ([Numero]) 
)
