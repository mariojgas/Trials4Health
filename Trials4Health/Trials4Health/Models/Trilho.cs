using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Trilho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Distancia { get; set; }
        //public Estatisticas estatisticas { get; set; }
        public ICollection<TrilhosPercorrido> trilhosPercorrido { get; set; }
      
    }
}
