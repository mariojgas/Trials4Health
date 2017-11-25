using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;

namespace Trials4Health.Data
{
    public class RepositorioDbTrilhos:IRepositorioTrails
    {
        private ApplicationDbContext context;
        public RepositorioDbTrilhos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Trilho> Trilhos => context.Trilhos;
        public IEnumerable<TrilhosPercorridos> TrilhosPercorridos => context.trilhosPercorridos;

        public IEnumerable<Turista> Turistas => context.Turistas;
        public IEnumerable<SOS> PrimeirosSocorros => context.PrimeirosSocorros;
        public IEnumerable<Equipamentos> Equipamentos => context.Equipamentos;
        public IEnumerable<Cuidados> Cuidados => context.Cuidados;
        public IEnumerable<Requisitos> Requisitos => context.Requisitos;



    }
}
