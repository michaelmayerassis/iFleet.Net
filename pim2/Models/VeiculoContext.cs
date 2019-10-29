using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    public class VeiculoContext : DbContext
    {
        public DbSet<Veiculo> Veiculo { get; set; }

        public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options) { }
    }
}
