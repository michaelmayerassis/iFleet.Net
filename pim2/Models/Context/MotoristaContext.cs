using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    public class MotoristaContext : DbContext
    {
        public DbSet<Motorista> Motoristas { get; set; }

        public MotoristaContext(DbContextOptions<MotoristaContext> options) : base(options) { }
    }
}
