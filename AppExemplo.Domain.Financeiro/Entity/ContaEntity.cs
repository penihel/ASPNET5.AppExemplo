using System;
using AppExemplo.Domain.Core.Entity;

namespace AppExemplo.Domain.Financeiro.Entity
{
    public class ContaEntity : EntityBase<Guid>
    {

        public Guid ClienteId { get; set; } // ClienteId
        public DateTime DataCriacao { get; set; } // DataCriacao
        public string Numero { get; set; } // Numero
        public bool Ativo { get; set; } // Ativo

        //// Reverse navigation
        //public virtual ICollection<Transacoes> Transacoes { get; set; } // Transacoes.FK_Transacoes_Contas

        //// Foreign keys
        //public virtual Clientes Clientes { get; set; } // FK_Contas_Clientes

        //public Contas()
        //{
        //    DataCriacao = System.DateTime.Now;
        //    Transacoes = new List<Transacoes>();
        //}
    }
}
