using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity.ModelConfiguration;

namespace Lantime.Map
{
    public class FuncionarioMap: EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionario");
            HasKey(x => x.FuncionarioId);
            HasKey(x => x.Codig_Empr);

            Property(x => x.FuncionarioId).IsRequired();
            Property(x => x.Codig_Func).IsRequired();

            HasMany(x => x.PontoLista);
            HasMany(x => x.CelulLista);         
        }
    }
}