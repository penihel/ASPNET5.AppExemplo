using AppExemplo.Domain.Core.Entity;
using System;

namespace AppExemplo.Domain.Cadastro.FilterEntity
{
    public class ClienteEntity : EntityBase<Guid>
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
