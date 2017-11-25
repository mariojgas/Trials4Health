using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Turista
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TuristaId { get; set; }

        public int Idade { get; set; }
        public string Nome { get; set; }
        public string CondicaoFisica { get; set; }
        public ICollection<TrilhosPercorridos> trilhosPercorridos { get; set; }
    }
}
