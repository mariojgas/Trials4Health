using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;

namespace Trials4Health.Data
{
    public class RepositorioFalsoTemp : RepositorioTrails
    {
        public IEnumerable<TrilhosPercorrido> TrilhosPercorridos => new List<TrilhosPercorrido> {
            new TrilhosPercorrido { Id=1,tempo=new TimeSpan(1,2,3),calorias=1005,IdTrilho=1,IdTurista=1},
            new TrilhosPercorrido { Id=2,tempo=new TimeSpan(1,12,3),calorias=1589,IdTrilho=1,IdTurista=2 },
            new TrilhosPercorrido { Id=3,tempo=new TimeSpan(1,44,3),calorias=1234,IdTrilho=1,IdTurista=3 },
            new TrilhosPercorrido { Id=4,tempo=new TimeSpan(2,11,3),calorias=1700,IdTrilho=1,IdTurista=2 },
            new TrilhosPercorrido { Id=5,tempo=new TimeSpan(2,44,3),calorias=1600,IdTrilho=2,IdTurista=2 },
            new TrilhosPercorrido { Id=6,tempo=new TimeSpan(3,44,3),calorias=1589,IdTrilho=2,IdTurista=3 },
            new TrilhosPercorrido { Id=7,tempo=new TimeSpan(1,44,3),calorias=1234,IdTrilho=3,IdTurista=1 },
            new TrilhosPercorrido { Id=8,tempo=new TimeSpan(2,11,3),calorias=1700,IdTrilho=3,IdTurista=2 }
        };
        public IEnumerable<Trilho> Trilhos => new List<Trilho> {
            new Trilho { Nome="Trilho 1",Id=1,Distancia=3000},
            new Trilho { Nome="Trilho 2",Id=2,Distancia=5500 },
            new Trilho { Nome="Trilho 3",Id=3,Distancia=2300 }
        };
        public IEnumerable<Turista> Turistas => new List<Turista> {
            new Turista {Id=1,Nome="João",Idade=72 },
            new Turista {Id=2,Nome="Maria",Idade=18 },
            new Turista {Id=3,Nome="Marcia",Idade=24 }
        };

       // public IEnumerable<TrilhosPercorrido> TrilhosPercorrido => throw new NotImplementedException();
    }
}
