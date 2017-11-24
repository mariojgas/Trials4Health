using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Cuidados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }

        public Cuidados()
        {
            Id = 0;
            Nome = "";
            Descrição = "";
        }

        public void addDados(string nome, string desc)
        {
            Id++;
            Nome = nome;
            Descrição = desc;
        }
    }
}
