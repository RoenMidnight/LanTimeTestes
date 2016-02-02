using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using LanTime.Controllers;

namespace LanTime.Controllers
{
    public class FuncionarioCelular
    {
        public FuncionarioCelular()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [ForeignKey("Funcionario")]
        public int         Codig_Func  { get; set; }
        public Funcionario Funcionario { get; set; }

        [ForeignKey("Celular")]
        public int     Imei_Celu { get; set; }
        public Celular Celular   { get; set; }
    }
}