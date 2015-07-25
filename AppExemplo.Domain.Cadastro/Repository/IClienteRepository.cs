

using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Core.Repository;
using System;

namespace AppExemplo.Domain.Cadastro.Repository
{
    public interface IClienteRepository : IRepository<ClienteEntity, ClienteFilterEntity, Guid>
    {
    }
}
