using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplicationProjeto1.Models;

namespace WebApplicationProjeto1.Data
{
    //O : faz a herança com o DbContext
    public class BaseDeDados : DbContext
    {
        public BaseDeDados(DbContextOptions<BaseDeDados> options) : base(options)
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }

        //Modelo de criação CODEFIRST
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Permite a criação da tabela no banco de dados
            modelBuilder.Entity<Usuario>().ToTable("Usuário");
        }
    }
}
