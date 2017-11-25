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
        public int TrilhosPercorridosId { get; set; }
        public TimeSpan tempo { get; set; }
        public int calorias { get; set; }
        public Turista turista { get; set; }
        public Trilho trilho { get; set; }
        
        public int TuristaId { get; set; }        
        public int TrilhoId { get; set; }
    }
}
