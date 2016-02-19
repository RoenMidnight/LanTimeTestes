using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace Lantime.Models
{
    public class Ponto
    {
        public Ponto()
        {
            Funcionario = new Funcionario();
        }
        public int PontoId{ get; set; }

        [DisplayName("Código do Ponto")]
        public long Ponto_Codig { get; set; }
        [DisplayName("Data do Ponto")]
        public DateTime Datap_Pont { get; set; }
        [DisplayName("Hora do Ponto")]
        public DateTime Horap_Pont { get; set; }
        [DisplayName("Funcionário")]
        public virtual Funcionario Funcionario { get; set; }
    }
}