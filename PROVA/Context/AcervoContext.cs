using Microsoft.EntityFrameworkCore;
using PROVA.Configurations;
using PROVA.Domain;


namespace PROVA.Context
{
    public class AcervoContext : DbContext
    {
        public DbSet<Filme> FilmeSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string conexao
                = "server=localhost;database=acervo;port=3306;uid=root";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
