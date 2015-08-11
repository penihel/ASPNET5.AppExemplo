using AppExemplo.Data.Core.Repository;
using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Cadastro.Repository;
using System;
using System.Linq;
using System.Data.Entity;

namespace AppExemplo.Data.Cadastro.Repository
{
    public class ClienteRepository : RepositoryBase<Clientes, ClienteEntity, ClienteFilterEntity, Guid>, IClienteRepository
    {

        public ClienteRepository(ICadastroDbContext context) : base(context as DbContext)
        {

        }

        protected override IQueryable<Clientes> ApplyFilters(IQueryable<Clientes> query, ClienteFilterEntity filter)
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
