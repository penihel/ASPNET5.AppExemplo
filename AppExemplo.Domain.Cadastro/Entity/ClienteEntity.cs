using System;
using AppExemplo.Domain.Core.Entity;

namespace AppExemplo.Domain.Cadastro.Entity
{
    public class ClienteEntity : EntityBase<Guid>
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
