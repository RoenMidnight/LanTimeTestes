using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Lantime.Models
{
    public class Celular
    {
        public Celular()
        {
            Funcionario = new Funcionario();
        }
        [DisplayName("Celular ID")]
        public int CelularId { get; set; }
        [DisplayName("IMEI")]
        public string Imei_Celu { get; set; }
        [DisplayName("Numero do Celular")]
        public string Nume_Celu { get; set; }
        [DisplayName("Nome do Funcionário")]
        public virtual Funcionario Funcionario { get; set; }
    }
}