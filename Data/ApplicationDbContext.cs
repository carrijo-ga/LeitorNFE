using LeitorNfe.Models;
using Microsoft.EntityFrameworkCore;

namespace LeitorNfe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Nota> Notas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Emitente> Emitentes { get; set; }
        public DbSet<Destinatario> Destinatarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //    //{
        //    //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
        //    //}
        //}
    }
}
