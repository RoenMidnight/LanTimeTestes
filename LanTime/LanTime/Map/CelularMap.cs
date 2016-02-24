using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity.ModelConfiguration;

namespace Lantime.Map
{
    public class CelularMap: EntityTypeConfiguration<Celular>
    {
        public CelularMap()
        {
            ToTable("Celular");
            HasKey(x => x.CelularId);

            Property(x => x.Imei_Celu).HasMaxLength(15).IsRequired();
            Property(x => x.Nume_Celu).HasMaxLength(9).IsRequired();

        
            HasRequired(x => x.Imei_Celu);
            HasRequired(x => x.Nume_Celu);
            HasRequired(x => x.Funcionario)
                .WithMany();
        }
    }
}