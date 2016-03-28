using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lantime.Models;
using System.Data.Entity.ModelConfiguration;

namespace Lantime.Map
{
    public class EmpresaMap: EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap() {

            ToTable("Empresa");
            HasKey(x => x.EmpresaId);
            HasKey(x => x.Codig_Empr);

            HasRequired(x => x.Razao_Empr);
            HasRequired(x => x.ECNPJ_Empr);

        }
    }
}