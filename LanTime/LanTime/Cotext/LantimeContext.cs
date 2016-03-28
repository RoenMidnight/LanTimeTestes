using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lantime.Cotext
{
    public class LantimeContext: DbContext
    {
        public LantimeContext()
            :base ("LantimeContext")
        {
            Configuration.LazyLoadingEnabled   = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ponto> Pontos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<LocalDeTrabalho> LocaisDeTrabalhos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}