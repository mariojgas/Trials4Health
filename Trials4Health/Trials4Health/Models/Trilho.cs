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
        public int ID_Trilho { get; set; }
        public int ID_Segurança { get; set; }
        public int ID_Dificuldade { get; set; }

        public string Nome { get; set; }
        public decimal Distancia { get; set; }
        //public Estatisticas estatisticas { get; set; }

    }
}
