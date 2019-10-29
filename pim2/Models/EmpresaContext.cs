using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        public EmpresaContext(DbContextOptions<EmpresaContext> options) : base(options) { }
    }
}
