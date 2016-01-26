using System;
using AppExemplo.Domain.Core.Service;
using AppExemplo.Domain.Financeiro.Entity;
using AppExemplo.Domain.Financeiro.FilterEntity;

namespace AppExemplo.Domain.Financeiro.Service.Interface
{

    public interface ITransacaoService :
        IQueryable<TransacaoEntity, TransacaoFilterEntity, Guid>,
        IInsertable<TransacaoEntity>
    {

    }
}
