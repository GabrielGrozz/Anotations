using Anotations.Models;
using Microsoft.EntityFrameworkCore;

namespace Anotations.Context
{
    public class AppDbContext : DbContext
    {
        //construtor que irá carregar as informações necessárias configurar o DbContext
        public AppDbContext(DbContextOptions options) : base(options) { }

        public object Anotation { get; internal set; }
        public DbSet<Anotation> Anotations { get; set; }
    }
}
