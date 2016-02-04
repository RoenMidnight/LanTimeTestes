using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lantime.Models
{
    public class Celular
    {
        public Celular()
        {
            Func_Celu = new Funcionario();
        }
        
        public int Imei_Celu { get; set; }
        public string Nume_Celu { get; set; }
        public virtual Funcionario Func_Celu { get; set; }
    }
}