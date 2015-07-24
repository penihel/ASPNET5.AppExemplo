

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "AppExemplo.Data.Financeiro\App.config"
//     Connection String Name: "AppExemplo"
//     Connection String:      "Data Source=(localdb)\ProjectsV12;Initial Catalog=AppExemplo.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

// Database Edition: Express Edition (64-bit)
// Database Engine Edition: Express

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace AppExemplo.Data.Financeiro
{
    // ************************************************************************
    // Unit of work
    public interface IFinanceiroDbContext : IDisposable
    {
        IDbSet<Clientes> Clientes { get; set; } // Clientes
        IDbSet<Contas> Contas { get; set; } // Contas
        IDbSet<RefactorLog> RefactorLog { get; set; } // __RefactorLog
        IDbSet<Transacoes> Transacoes { get; set; } // Transacoes

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class FinanceiroDbContext : DbContext, IFinanceiroDbContext
    {
        public IDbSet<Clientes> Clientes { get; set; } // Clientes
        public IDbSet<Contas> Contas { get; set; } // Contas
        public IDbSet<RefactorLog> RefactorLog { get; set; } // __RefactorLog
        public IDbSet<Transacoes> Transacoes { get; set; } // Transacoes
        
        static FinanceiroDbContext()
        {
            System.Data.Entity.Database.SetInitializer<FinanceiroDbContext>(null);
        }

        public FinanceiroDbContext()
            : base("Name=AppExemplo")
        {
        }

        public FinanceiroDbContext(string connectionString) : base(connectionString)
        {
        }

        public FinanceiroDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClientesConfiguration());
            modelBuilder.Configurations.Add(new ContasConfiguration());
            modelBuilder.Configurations.Add(new RefactorLogConfiguration());
            modelBuilder.Configurations.Add(new TransacoesConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ClientesConfiguration(schema));
            modelBuilder.Configurations.Add(new ContasConfiguration(schema));
            modelBuilder.Configurations.Add(new RefactorLogConfiguration(schema));
            modelBuilder.Configurations.Add(new TransacoesConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class FakeFinanceiroDbContext : IFinanceiroDbContext
    {
        public IDbSet<Clientes> Clientes { get; set; }
        public IDbSet<Contas> Contas { get; set; }
        public IDbSet<RefactorLog> RefactorLog { get; set; }
        public IDbSet<Transacoes> Transacoes { get; set; }

        public FakeFinanceiroDbContext()
        {
            Clientes = new FakeDbSet<Clientes>();
            Contas = new FakeDbSet<Contas>();
            RefactorLog = new FakeDbSet<RefactorLog>();
            Transacoes = new FakeDbSet<Transacoes>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // Clientes
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class Clientes
    {
        public Guid Id { get; set; } // Id (Primary key)
        public string Nome { get; set; } // Nome
        public string Documento { get; set; } // Documento
        public DateTime DataCriacao { get; set; } // DataCriacao

        // Reverse navigation
        public virtual ICollection<Contas> Contas { get; set; } // Contas.FK_Contas_Clientes
        
        public Clientes()
        {
            DataCriacao = System.DateTime.Now;
            Contas = new List<Contas>();
        }
    }

    // Contas
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class Contas
    {
        public Guid Id { get; set; } // Id (Primary key)
        public Guid ClienteId { get; set; } // ClienteId
        public DateTime DataCriacao { get; set; } // DataCriacao
        public string Numero { get; set; } // Numero
        public bool Ativo { get; set; } // Ativo

        // Reverse navigation
        public virtual ICollection<Transacoes> Transacoes { get; set; } // Transacoes.FK_Transacoes_Contas

        // Foreign keys
        public virtual Clientes Clientes { get; set; } // FK_Contas_Clientes
        
        public Contas()
        {
            DataCriacao = System.DateTime.Now;
            Transacoes = new List<Transacoes>();
        }
    }

    // __RefactorLog
    public class RefactorLog
    {
        public Guid OperationKey { get; set; } // OperationKey (Primary key)
    }

    // Transacoes
    public class Transacoes
    {
        public Guid Id { get; set; } // Id (Primary key)
        public Guid ContaId { get; set; } // ContaId
        public DateTime DataHora { get; set; } // DataHora
        public string Historico { get; set; } // Historico
        public string Identificador { get; set; } // Identificador
        public decimal SaldoContaAnterior { get; set; } // SaldoContaAnterior
        public decimal ValorCredito { get; set; } // ValorCredito
        public decimal ValorDebito { get; set; } // ValorDebito
        public decimal SaldoConta { get; set; } // SaldoConta

        // Foreign keys
        public virtual Contas Contas { get; set; } // FK_Transacoes_Contas
        
        public Transacoes()
        {
            DataHora = System.DateTime.Now;
        }
    }


    // ************************************************************************
    // POCO Configuration

    // Clientes
    internal class ClientesConfiguration : EntityTypeConfiguration<Clientes>
    {
        public ClientesConfiguration()
            : this("dbo")
        {
        }
 
        public ClientesConfiguration(string schema)
        {
            ToTable(schema + ".Clientes");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.Documento).HasColumnName("Documento").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DataCriacao).HasColumnName("DataCriacao").IsRequired().HasColumnType("datetime");
        }
    }

    // Contas
    internal class ContasConfiguration : EntityTypeConfiguration<Contas>
    {
        public ContasConfiguration()
            : this("dbo")
        {
        }
 
        public ContasConfiguration(string schema)
        {
            ToTable(schema + ".Contas");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ClienteId).HasColumnName("ClienteId").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.DataCriacao).HasColumnName("DataCriacao").IsRequired().HasColumnType("datetime");
            Property(x => x.Numero).HasColumnName("Numero").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Ativo).HasColumnName("Ativo").IsRequired().HasColumnType("bit");

            // Foreign keys
            HasRequired(a => a.Clientes).WithMany(b => b.Contas).HasForeignKey(c => c.ClienteId); // FK_Contas_Clientes
        }
    }

    // __RefactorLog
    internal class RefactorLogConfiguration : EntityTypeConfiguration<RefactorLog>
    {
        public RefactorLogConfiguration()
            : this("dbo")
        {
        }
 
        public RefactorLogConfiguration(string schema)
        {
            ToTable(schema + ".__RefactorLog");
            HasKey(x => x.OperationKey);

            Property(x => x.OperationKey).HasColumnName("OperationKey").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }

    // Transacoes
    internal class TransacoesConfiguration : EntityTypeConfiguration<Transacoes>
    {
        public TransacoesConfiguration()
            : this("dbo")
        {
        }
 
        public TransacoesConfiguration(string schema)
        {
            ToTable(schema + ".Transacoes");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContaId).HasColumnName("ContaId").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.DataHora).HasColumnName("DataHora").IsRequired().HasColumnType("datetime");
            Property(x => x.Historico).HasColumnName("Historico").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Identificador).HasColumnName("Identificador").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.SaldoContaAnterior).HasColumnName("SaldoContaAnterior").IsRequired().HasColumnType("numeric").HasPrecision(18,2);
            Property(x => x.ValorCredito).HasColumnName("ValorCredito").IsRequired().HasColumnType("numeric").HasPrecision(18,2);
            Property(x => x.ValorDebito).HasColumnName("ValorDebito").IsRequired().HasColumnType("numeric").HasPrecision(18,2);
            Property(x => x.SaldoConta).HasColumnName("SaldoConta").IsRequired().HasColumnType("numeric").HasPrecision(18,2);

            // Foreign keys
            HasRequired(a => a.Contas).WithMany(b => b.Transacoes).HasForeignKey(c => c.ContaId); // FK_Transacoes_Contas
        }
    }


    // ************************************************************************
    // Stored procedure return models

}

