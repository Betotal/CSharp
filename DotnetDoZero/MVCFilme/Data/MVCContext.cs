using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesVSCode.Modelo;

namespace MVCFilme.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext (DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesVSCode.Modelo.Filme> Filme { get; set; } = default!;
    }
}
