using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class TrilhosPercorrido
    {
        public int Id { get; set; }
        public TimeSpan tempo { get; set; }
        public int calorias { get; set; }
        public Turista turista;
        public Trilho trilho;
        public int IdTurista;
        public int IdTrilho;
    }
}
