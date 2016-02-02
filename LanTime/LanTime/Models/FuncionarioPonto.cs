using System;
using System.ComponentModel.DataAnnotations.Schema;
using LanTime.Controllers;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanTime.Controllers
{
    public class FuncionarioPonto
    {
        public FuncionarioPonto()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [ForeignKey("Funcionario")]
        public int Codig_Func { get; set; }
        public Funcionario Funcionario { get; set; }

        [ForeignKey("Ponto")]
        public int Codig_Pont  { get; set; }
        public Ponto Ponto { get; set; }

        
        
    }
}