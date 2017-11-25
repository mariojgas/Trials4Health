using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Trilho
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrilhoId { get; set; }

        public string Nome { get; set; }
        public decimal Distancia { get; set; }
        //public Estatisticas estatisticas { get; set; }
        public ICollection<TrilhosPercorridos> trilhosPercorridos { get; set; }
      
    }
}
