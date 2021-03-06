﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models.ViewModel
{
    public class VisualizarEstatisticas
    {
        public Trilho trilho { get; set; }
        public IEnumerable<TrilhosPercorridos> TrilhosPercorridos { get; set; }
        public IEnumerable<Turista> Turistas { get; set; }
        public VisualizarEstatisticas(Trilho t,IRepositorioTrails rp) {
            trilho = t;
            
            TrilhosPercorridos = rp.TrilhosPercorridos.Where(tp => tp.ID_Trilho == t.ID_Trilho);
            Turistas = rp.Turistas;

        }
    }
}
