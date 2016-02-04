using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Lantime.Models
{
    public class Ponto
    {
        public Ponto()
        {
            Func_Pont = new Funcionario();
        }
        public int Codig_Pont { get; set; }
        public DateTime Datap_Pont { get; set; }
        public String Horap_Pont { get; set; }
        public virtual Funcionario Func_Pont { get; set; }
    }
}