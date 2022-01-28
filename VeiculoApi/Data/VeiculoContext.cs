using Microsoft.EntityFrameworkCore;
using VeiculoApi.Models;

namespace VeiculoApi.Data
{
    public class VeiculoContext : DbContext
    {

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Dono> Donos { get; set; }

        public VeiculoContext(DbContextOptions<VeiculoContext> opt) : base(opt)
        {

        }

        
    }
}
