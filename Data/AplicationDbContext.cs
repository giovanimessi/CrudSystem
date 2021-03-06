using CrudSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudSystem.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        { }

        //instanciar o modelo departamento
        public DbSet<Departamento>Departamento { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
    }
}
