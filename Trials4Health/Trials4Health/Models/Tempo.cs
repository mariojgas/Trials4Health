using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Tempo
    {
        public int horas { get; set; }
        public int minutos { get; set; }
        public int segundos { get; set; }
        public string toString() {
            return horas+":"+minutos+":" + segundos;
        }
        public Tempo(int horas, int minutos, int segundos) {
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
        }
        public Tempo(long segundosTotais)
        {
            horas = segundosTotais / 3600;
            
            minutos = segundosTotais % 3600 / 60;

            segundos = segundosTotais % 3600 % 60;
          
        }
    }
}
