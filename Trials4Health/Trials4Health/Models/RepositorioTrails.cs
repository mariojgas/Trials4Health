using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public interface RepositorioTrails
    {
        public IEnumerable <Trilho> Trilhos { get; set; }
        public IEnumerable<Historico> Historicos { get; set; }
        public IEnumerable<Utilizador> Utilizadores { get; set; }
    }
}
