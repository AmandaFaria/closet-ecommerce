using Closet.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Closet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CadastroUsuarioModel>? CadastroUsuarios {get;set;}
        public DbSet<CategoriaModel>? Categorias {get;set;}
        public DbSet<RoupaModel>? Roupas {get;set;}
        public DbSet<UsuarioLoginModel>? UsuarioLogins {get;set;}
        public DbSet<CarrinhoCompraModel>? CarrinhoCompras {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlite("DataSource=closet.db;Cache=Shared"); 
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
    }
}
