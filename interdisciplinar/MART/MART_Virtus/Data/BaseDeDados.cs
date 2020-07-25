using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MART_Virtus.Models;

namespace MART_Virtus.Data
{
    public class BaseDeDados : DbContext
    {
        public BaseDeDados(DbContextOptions<BaseDeDados> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
