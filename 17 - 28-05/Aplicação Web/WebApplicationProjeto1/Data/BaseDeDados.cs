using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationProjeto1.Models;

namespace WebApplicationProjeto1.Data
{
    public class BaseDeDados : DbContext
    {
        public BaseDeDados(DbContextOptions<BaseDeDados> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Turma> Turma { get; set; }

        //Modelo de criação CODEFIRST
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //permite a criação da tabela no banco de dados
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            modelBuilder.Entity<Turma>().ToTable("Turma");
        }
            //permite a criação da tabela no banco de dados
            


    }
}
