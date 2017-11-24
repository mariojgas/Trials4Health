using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;

namespace Trials4Health.Data
{
    public class RepositorioDbTrilhos:RepositorioTrails
    {
        private ApplicationDbContext context;
        public RepositorioDbTrilhos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Trilho> Trilhos => context.Trilhos;
        public IEnumerable<TrilhosPercorrido> trilhosPercorrido => context.trilhosPercorrido;

        public IEnumerable<TrilhosPercorrido> TrilhosPercorrido => throw new NotImplementedException();

        public IEnumerable<Turista> Turistas => context.Turistas;


       
    }
}
