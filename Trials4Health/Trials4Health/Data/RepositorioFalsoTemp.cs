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

        public IEnumerable<SOS> PrimeirosSocorros => new List<SOS>
        {
            new SOS{ Nome = "Ataque", Descriçao="", Tecnicas="Ajudar o paciente a colocar-se na posição que lhe for mais confortável"
                    +"Desapertar-lhe a roupa"
                    +"Não tentar levantá-lo nem transportá-lo;"
                    +"Não lhe dar nada para beber"
                    +"Permanecer calmo"
                    +"Tentar traquilizar a vítima"
                    +"Recordar, mentalemnte, as técnicas de reanimação cardiopulmonar para o caso de o paciente perder o pulso e a respiração parar." },
             new SOS{ Nome = "Entorses", Descriçao="", Tecnicas=" Coloca a articulação traumatizada em posição confortável e num plano elevado"+
                     "Evitar que o doente faça movimentos"+
                     "As pessoas com entorses no joelho ou no tornozelo devem evitar andar;"+
                     "Aplica um saco de gelo ou uma compressa fria para reduzir a dor e o inchaço" },
             new SOS{ Nome = "Hipotermia", Descriçao =  "A hipotermia é uma situação que ocorre quando a temperatura do corpo baixa "+
                                                        "para valores inferiores a 35ºC. O organismo deixa de consegui produzir"+
                                                        " calor suficiente para manter os níveis de temperatura considerados normais e"+
                                                        " torna-se impossível que ocorra o aquecimento espontâneo do corpo. A hipotermia"+
                                                        " pode mesmo levar à morte."+
                                                        "",

                 Tecnicas=" Retira-lhe as roupas frias ou molhadas"+
                    " Limpa e cobre-a com roupas secas e quentes"+
                     "Coloca-a em local abrigado e, se possível, aquece o ambiente"+
                     "Assegura que a vítima é observada por um médico"},

               new SOS{ Nome = "Desmaios", Descriçao=   "É provocado por falta de oxigénio no cérebro, "+
                                                        "a que o organismo reage de forma automática, com perda"+
                                                        "de consciência e queda do corpo brusca e desamparada."+
                                                        "Normalmente, o desmaio dura 2 ou 3 minutos."+

                                                        "",
                                           Tecnicas =   "Sentá-la"+
                                                        " Colocar-lhe a cabeça entre as pernas"+
                                                        "Molhar-lhe a testa com água fria"+
                                                        "Dar-lhe a beber água, chá ou café açucarados" }

        };

        // public IEnumerable<TrilhosPercorrido> TrilhosPercorrido => throw new NotImplementedException();
    }
}
