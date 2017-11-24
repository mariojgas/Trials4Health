using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Equipamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string Tipo { get; set; }
        public DateTime UltimaRevisão { get; set; }


        public Equipamentos()
        {
            Id = 0;
            Nome = "";
            Descrição = "";
            UltimaRevisão = DateTime.Now;
        }

        public void addDados(string nome, string desc, string tipo, DateTime date)
        {
            Id++;
            Nome = nome;
            Descrição = desc;
            Tipo = tipo;
            UltimaRevisão = date;
        }
    }
}
