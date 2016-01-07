using System;
using System.Collections.Generic;
using AppExemplo.Core;
using AppExemplo.Domain.Cadastro.FilterEntity;
using AppExemplo.Domain.Cadastro.Repository;
using AppExemplo.Domain.Cadastro.Service.Interface;
using AppExemplo.Domain.Core.Service;

namespace AppExemplo.Domain.Cadastro.Service
{
    public class ClienteService : ServiceBase, IClienteService
    {
        /// <summary>
        /// Nosso resitório querido :D
        /// </summary>
        private readonly IClienteRepository _clienteRepository;

        /// <summary>
        /// Pedimos o repositório a classe Cliente (teremos um Ioc/Service Locator em breve)
        /// </summary>
        /// <param name="clienteRepository"></param>
        public ClienteService(IClienteRepository clienteRepository)
        {
            //Sempre verificamos os parametros
            if (clienteRepository == null) throw new ArgumentNullException(nameof(clienteRepository));

            _clienteRepository = clienteRepository;
        }

        /// <summary>
        /// Recupera um cliente pela a chave (Id)
        /// </summary>
        /// <param name="key">chave (Id)</param>
        /// <returns>Objeto preenchido</returns>
        public ClienteEntity GetById(Guid key)
        {
            //Aqui não há necessidade de verificar se key é null, pois Guid é ValueType

            var entity = _clienteRepository.GetById(key);


            //Ao pedir um item não existente no repositório, representa um Exception no sistema

            if (entity == null) throw new ArgumentNullException(nameof(entity));


            return entity;
        }
        /// <summary>
        /// Recupera uma lista de clientes com base nos parametros de filtro
        /// </summary>
        /// <param name="filter">Parametros de filtro</param>
        /// <returns>Lista de Clientes</returns>
        public IList<ClienteEntity> Query(ClienteFilterEntity filter)
        {
            //Verifica o parametro
            if (filter == null) throw new ArgumentNullException(nameof(filter));


            var query = _clienteRepository.Query(filter);


            //Caso nao retornar valores, não gera erro, apenas a consulta não retorno registros
            return query ?? new List<ClienteEntity>();
        }
        /// <summary>
        /// Insere um cliente
        /// </summary>
        /// <param name="entity">objeto a ser inserido</param>
        public void Insert(ClienteEntity entity)
        {
            //Sempre valida o parametro
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            //Verifica se pode inserir
            VerifyIfCanInsert(entity);

            //Insere na base
            _clienteRepository.Insert(entity);
        }
        /// <summary>
        /// Verifica se o cliente pode ser inserido
        /// </summary>
        /// <param name="entity">Cliente</param>
        private void VerifyIfCanInsert(ClienteEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var existingEntity = _clienteRepository.GetById(entity.Id);

            if (existingEntity != null)
                throw new ArgumentException(
                    string.Format(Messages.DuplicatedEntity,
                        AppExemplo.Core.Cadastro.Messages.ClienteEntity), nameof(entity));

        }


        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="entity">objeto a ser alterado</param>
        public void Update(ClienteEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            VerifyIfCanUpdate(entity);

            _clienteRepository.Update(entity);
        }

        private void VerifyIfCanUpdate(ClienteEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var existingEntity = _clienteRepository.GetById(entity.Id);

            if (existingEntity == null)
                throw new ArgumentException(
                    string.Format(Messages.EntityNotExistis,
                        AppExemplo.Core.Cadastro.Messages.ClienteEntity), nameof(entity));
        }

        /// <summary>
        /// Exclui um cliente
        /// </summary>
        /// <param name="entity">objeto a ser Excluido</param>
        public void Delete(ClienteEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            VerifyIfCanDelete(entity);

            _clienteRepository.Delete(entity);
        }

        private void VerifyIfCanDelete(ClienteEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var existingEntity = _clienteRepository.GetById(entity.Id);

            if (existingEntity == null)
                throw new ArgumentException(
                    string.Format(Messages.EntityNotExistis,
                        AppExemplo.Core.Cadastro.Messages.ClienteEntity), nameof(entity));
        }
    }
}
