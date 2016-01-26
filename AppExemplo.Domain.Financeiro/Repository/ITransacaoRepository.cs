using System;
using AppExemplo.Domain.Core.Repository;
using AppExemplo.Domain.Financeiro.Entity;
using AppExemplo.Domain.Financeiro.FilterEntity;

namespace AppExemplo.Domain.Financeiro.Repository
{
    public interface ITransacaoRepository : IRepository<TransacaoEntity, TransacaoFilterEntity, Guid>
    {
    }
}
