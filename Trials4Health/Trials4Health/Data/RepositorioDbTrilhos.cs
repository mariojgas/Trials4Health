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

    }
}
