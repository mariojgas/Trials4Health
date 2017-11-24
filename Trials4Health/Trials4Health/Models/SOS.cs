using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public interface Isosrepository {
        IEnumerable<SOS> SOSs { get; }
    }
    public class FakeSosRepository : Isosrepository {
        public IEnumerable<SOS> SOSs => new List<SOS>
        {
            new SOS{ Nome = "Ataque", Descriçao="OLA OLA " } 
        };
    }


    public class SOS
    {

        int ID_SOS { get; set; }
        string Nome { get; set; }
        string Descriçao { get; set; }
        string Tecnicas { get; set; }

    }
}
