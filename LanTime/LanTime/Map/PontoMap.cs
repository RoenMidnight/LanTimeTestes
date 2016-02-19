using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity.ModelConfiguration;

namespace Lantime.Map
{
    public class PontoMap: EntityTypeConfiguration<Ponto>
    {
        public PontoMap()
        {
            ToTable("Ponto");
            HasKey(x => x.PontoId);
            Property(x => x.PontoId).IsRequired();

            Property(x => x.Ponto_Codig).IsRequired();

        }
    }
}