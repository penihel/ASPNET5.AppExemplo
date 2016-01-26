using System;
using AppExemplo.Domain.Cadastro.Entity;
using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Core.Service;

namespace AppExemplo.Domain.Cadastro.Service.Interface
{
    /// <summary>
    /// Contém as operações para Manter um cliente no Sistema
    /// </summary>
    public interface IClienteService : 
        IQueryable<ClienteEntity, ClienteFilterEntity, Guid>,
        IInsertable<ClienteEntity>,
        IUpdateable<ClienteEntity>,
        IDeletable<ClienteEntity>
    {

    }
}
