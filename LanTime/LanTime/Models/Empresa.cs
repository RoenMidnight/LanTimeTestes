using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lantime.Models
{
    public class Empresa
    {
        [Required]
        [DisplayName("Empresa ID")]
        public int EmpresaId { get; set; }

        [Required]
        [DisplayName("Código")]
        public int Codig_Empr { get; set; }

        [Required]
        [DisplayName("Razao")]
        public string Razao_Empr { get; set; }

        [Required]
        [DisplayName("CNPJ")]
        public string ECNPJ_Empr { get; set; }

    }
}