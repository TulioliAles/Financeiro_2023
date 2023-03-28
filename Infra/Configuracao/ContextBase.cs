using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuracao
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options) 
        {            
        }

        public DbSet<SistemaFinanceiro> SistemaFinanceiro { set;  get; }
        public DbSet<UsuariosSistemaFinaceiro> UsuariosSistemaFinaceiro { set;  get; }
        public DbSet<Categoria> Categoria { set;  get; }
        public DbSet<Despesa> Despesa { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t  => t.Id);

            base.OnModelCreating(builder);
        }

        public string ObterStringConexao()
        {
            return "Data Source=RBPN310100110\\SQLEXPRESS; Initial Catalog=FINANCEIRO_2023; Integrated Security=True";
        }
    }
}
