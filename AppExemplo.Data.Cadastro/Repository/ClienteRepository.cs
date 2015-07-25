using AppExemplo.Data.Core.Repository;
using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Cadastro.Repository;
using System;
using System.Data.Entity;

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
