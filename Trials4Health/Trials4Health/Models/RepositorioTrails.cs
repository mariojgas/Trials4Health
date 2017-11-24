using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public interface RepositorioTrails
    {
         IEnumerable <Trilho> Trilhos { get;}
         IEnumerable<TrilhosPercorrido>TrilhosPercorrido  { get; }
         IEnumerable<Turista> Turistas { get; }
    }
}
