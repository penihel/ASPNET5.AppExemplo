using System;
using AppExemplo.Domain.Core.Service;
using AppExemplo.Domain.Financeiro.Entity;
using AppExemplo.Domain.Financeiro.FilterEntity;

namespace AppExemplo.Domain.Financeiro.Service.Interface
{
    
    public interface IContaService : 
        IQueryable<ContaEntity, ContaFilterEntity, Guid>,
        IInsertable<ContaEntity>,
        IUpdateable<ContaEntity>
    {

    }
}
