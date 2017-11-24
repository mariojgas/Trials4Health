using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Turista
    {

        public int Idade { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CondicaoFisica { get; set; }
        public ICollection<TrilhosPercorrido> trilhosPercorridos { get; set; }
    }
}
