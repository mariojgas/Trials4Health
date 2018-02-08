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
        public int ID_Turista { get; set; }

        public int Idade { get; set; }
        public string Nome { get; set; }
        public string CondicaoFisica { get; set; }


        public IEnumerable<TrilhosPercorridos> TrilhosPercorridos { get; set; }
    }
}
