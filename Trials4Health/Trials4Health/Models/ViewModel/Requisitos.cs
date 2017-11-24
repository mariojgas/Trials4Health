using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Requisitos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string Adequadoa { get; set; }

        public Requisitos()
        {
            Id = 0;
            Nome = "";
            Descrição = "";
            Adequadoa = "";
        }

        public void addDados(string nome, string desc, string adeq)
        {
            Id++;
            Nome = nome;
            Descrição = desc;
            Adequadoa = adeq;
        }
    }
}
