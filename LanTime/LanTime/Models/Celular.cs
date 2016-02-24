using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lantime.Models
{
    public class Celular
    {
        [DisplayName("Celular ID")]
        public int CelularId { get; set; }

        [Required]
        [DisplayName("IMEI")]
        [StringLength(15)]
        public string Imei_Celu { get; set; }

        [Required]
        [StringLength(9)]
        [DisplayName("Numero do Celular")]
        public string Nume_Celu { get; set; }

        [Required]
        [DisplayName("Nome do Funcionário")]
        public int   FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

    }
}