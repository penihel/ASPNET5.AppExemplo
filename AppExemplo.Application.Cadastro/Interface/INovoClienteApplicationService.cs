using AppExemplo.Application.Core;
using AppExemplo.Application.Core.Interface;

using AppExemplo.Domain.Cadastro.Entity;

namespace AppExemplo.Application.Cadastro.Interface
{
    public interface INovoClienteApplicationService : IApplicationService
    {
        ApplicationServiceResult<ClienteEntity> Inserir(ApplicationServiceParam<ClienteEntity> param);
    }
}
