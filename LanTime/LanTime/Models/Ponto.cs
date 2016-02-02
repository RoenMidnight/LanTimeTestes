using System;
using System.ComponentModel.DataAnnotations.Schema;
using LanTime.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanTime.Controllers
{
    public class Ponto
    {
        public int         Codig_Pont { get; set; }

        [ForeignKey("Funcionario")]
        public Funcionario Funci_Pont { get; set; }

        public DateTime    Datap_Pont { get; set; }
        public String      Horap_Pont { get; set;}
    }
}