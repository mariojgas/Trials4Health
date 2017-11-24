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
        public IEnumerable<TrilhosPercorrido> TrilhosPercorridos => context.trilhosPercorrido;

        //public IEnumerable<TrilhosPercorrido> TrilhosPercorridos => throw new NotImplementedException();

        public IEnumerable<Turista> Turistas => context.Turistas;
        public IEnumerable<SOS> PrimeirosSocorros => context.PrimeirosSocorros;



    }
}
