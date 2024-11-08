using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace dalSQL
{
    public class SQLContexto : DbContext
    {
        public SQLContexto() { }
        public SQLContexto(DbContextOptions<SQLContexto> options) : base(options){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DotNetDoZero;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoCategoria>().HasKey(pc => new { pc.PRODUTO_ID, pc.CATEGORIA_ID });
        }
        public DbSet<Produto> Product {get; set;}
        public DbSet<Estoque> Stock {get; set;}
        public DbSet<Categoria> Category {get; set;}

        public DbSet<ProdutoCategoria> CategoryProduct { get; set; }


    }
}