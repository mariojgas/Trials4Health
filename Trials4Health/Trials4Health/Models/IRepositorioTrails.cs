using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public interface IRepositorioTrails
    {
        IEnumerable<Trilho> Trilhos { get; }
        IEnumerable<TrilhosPercorridos> TrilhosPercorridos { get; }
        IEnumerable<Turista> Turistas { get; }
        IEnumerable<SOS> PrimeirosSocorros { get; }
        IEnumerable<Equipamentos> Equipamentos { get; }
        IEnumerable<Cuidados> Cuidados { get; }
        IEnumerable<Requisitos> Requisitos { get; }

    }
}
