using System;
using System.Data.Entity;
using System.Linq;
using AppExemplo.Data.Core.Repository;
using AppExemplo.Domain.Financeiro.Entity;
using AppExemplo.Domain.Financeiro.FilterEntity;
using AppExemplo.Domain.Financeiro.Repository;

namespace AppExemplo.Data.Financeiro.Repository
{
    public class TransacaoRepository : RepositoryBase<Transacoes, TransacaoEntity, TransacaoFilterEntity, Guid>, ITransacaoRepository
    {

        public TransacaoRepository(IFinanceiroDbContext context) : base(context as DbContext)
        {

        }

        protected override IQueryable<Transacoes> ApplyFilters(IQueryable<Transacoes> query, TransacaoFilterEntity filter)
        {
            //Estou pensando se matenho este método aqui ou mando a IQueryable<Clientes> para o Domain e faço o filter
            // pelas specifications

            //Novamente existem duas opniõs diferentes, ainda não tenho a minha definida, mas estou mais pra deixar aqui mesmo
            //e não usar mais "Specification" para queries

            //http://stackoverflow.com/questions/25953828/specification-pattern-in-domain-driven-design

            return query;
        }
    }
}
