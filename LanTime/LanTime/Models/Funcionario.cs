using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Lantime.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            PontoLista = new List<Ponto>();
            CelulLista = new List<Celular>();
        }
        [DisplayName("Id Funcionário")]
        public int FuncionarioId { get; set; }
        [DisplayName("Código")]
        public int Codig_Func { get; set; }
        [DisplayName("Crachá")]
        public int Crach_Func { get; set; }
        [DisplayName("Funcionário")]
        public string Nome_Func { get; set; }

        [DisplayName("Ponto")]
        public virtual ICollection<Ponto>   PontoLista { get; set; }
        public virtual ICollection<Celular> CelulLista { get; set; }

        [DisplayName("Empresa")]
        public int Codig_Empr { get; set; }
        public virtual Empresa Empresa { get; set; } 
    }
}