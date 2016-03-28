using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity.ModelConfiguration;

namespace Lantime.Map
{
    public class LocalDeTrabalhoMap: EntityTypeConfiguration<LocalDeTrabalho>
    {
        public LocalDeTrabalhoMap() {

            ToTable("LocalDeTrabalho");
            HasKey(x => x.LocalDeTrabalhoId);
            HasKey(x => x.Codig_Loca);
            HasKey(x => x.EmpresaId);

            HasRequired(x => x.Descr_Loca);          

        }
    }
}