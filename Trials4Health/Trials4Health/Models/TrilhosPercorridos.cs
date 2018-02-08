using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class TrilhosPercorridos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Turista { get; set; }
        public IEnumerable<Turista> Turistas { get; set; }

        public int ID_Trilho { get; set; }
        public IEnumerable<Trilho> Trilhos { get; set; }

        public TimeSpan Tempo { get; set; }
        public int Calorias { get; set; }
    }
}
