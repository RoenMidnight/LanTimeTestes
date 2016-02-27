using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lantime.Models
{
    public class LocalDeTrabalho
    {
        [Required]
        [DisplayName("Local de Trabalho ID")]
        public int LocalDeTrabalhoId { get; set; }

        [Required]
        [DisplayName("Código")]
        public int Codig_Loca { get; set; }

        [DisplayName("Descrição")]
        public string Descr_Loca { get; set; }

        [Required]
        [DisplayName("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}