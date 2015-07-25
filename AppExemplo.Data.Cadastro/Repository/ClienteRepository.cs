using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Cadastro.Repository;
using System;
using System.Linq;
using System.Linq.Expressions;
using AppExemplo.Data.Core.Repository;
using System.Data.Entity;
using AppExemplo.Domain.Cadastro.FilterEntity;

namespace AppExemplo.Data.Cadastro.Repository
{
    public class ClienteRepository : RepositoryBase<Clientes, ClienteEntity, ClienteFilterEntity, Guid>, 
        IClienteRepository
    {

        public ClienteRepository(ICadastroDbContext context) : base(context as DbContext)
        {

        }

    }
}
