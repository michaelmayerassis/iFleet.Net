using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    public class PecaContext : DbContext
    {
        public DbSet<Peca> Pecas { get; set; }

        public PecaContext(DbContextOptions<PecaContext> options) : base(options) { }
    }
}
