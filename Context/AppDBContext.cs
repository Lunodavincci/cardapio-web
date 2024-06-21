using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext //responsável pela comunicação com o bd
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }
        public DbSet<Categoria> Categorias { get; set; }  //referencia as classes models para as que estão nas tabelas
        public DbSet<Produto> Produtos { get; set; }

    }
}
