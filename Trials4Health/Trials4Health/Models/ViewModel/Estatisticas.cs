using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials4Health.Models
{
    public class Estatisticas
    {
        public int nPessoas { get; set; }

        //Criar ViewModel Para ser guardado na base de dados
        public Estatisticas()
        {
            caloriasMedias = 0;
            tempoMedio = new TimeSpan(0, 0, 0);
            totalTempo = 0;
            totalCal = 0;
            totalIdade = 0;
            nPessoas = 0;
            idadeMax = 0;
            idadeMin = 999;
            velocidadeMedia = 0;
            distancia = 0;
            totalminutos = 0;
            totalhoras = 0;
            totalsegundos = 0;
        }

        /*public void addDados(DadosPessoais dados)
        {
            //incrementar o número de Pessoas
            nPessoas++;

            //Tempo Médio
            totalTempo = dados.tempo.horas * 3600 + dados.tempo.minutos * 60 + dados.tempo.segundos;
            long segundosMedios = totalTempo / nPessoas;
            tempoMedio = new Tempo(segundosMedios);


            //calorias Médias
            totalCal += dados.calorias;
            caloriasMedias = totalCal / nPessoas;

            //Idade Minima e máxima
            totalIdade += dados.idade;
            if (idadeMax < dados.idade)
                idadeMax = dados.idade;
            else if (idadeMin > dados.idade)
                idadeMin = dados.idade;

            //velocidade Média em metros por segundos
            velocidadeMedia = distancia / (float)segundosMedios;

        }*/
        public void gerarEstatisticas(TrilhosPercorridos trilhosPercorridos,int idade) {
            nPessoas++;
            //Tempo Médio
            totalTempo += trilhosPercorridos.tempo.Hours * 3600 + trilhosPercorridos.tempo.Minutes * 60 + trilhosPercorridos.tempo.Seconds;
            totalsegundos += trilhosPercorridos.tempo.Seconds;
            totalminutos += trilhosPercorridos.tempo.Minutes;
            totalhoras += trilhosPercorridos.tempo.Hours;
            int segundosMedios = totalTempo / nPessoas;
            tempoMedio = new TimeSpan(totalhoras/nPessoas,totalminutos/nPessoas,totalsegundos/nPessoas);
            
            

            
            //calorias Médias
            totalCal += trilhosPercorridos.calorias;
            caloriasMedias = totalCal / nPessoas;

            //Idade Minima e máxima
            totalIdade += idade;
            if (idadeMax < idade)
                idadeMax = idade;
            else if (idadeMin > idade)
                idadeMin = idade;
            idadeMedia = totalIdade / nPessoas;
            //velocidade Média em metros por segundos
            velocidadeMedia = (float)distancia / (float)segundosMedios;
        }
        public float caloriasMedias { get; set; }
        public TimeSpan tempoMedio { get; set; }
        public int idadeMin { get; set; }
        public int idadeMax { get; set; }
        public int totalTempo { get; set; }
        public long totalCal { get; set; }
        public int totalIdade { get; set; }
        public int idadeMedia { get; set; }
        public float velocidadeMedia { get; set; }
        public decimal distancia { get; set; }
        public int totalhoras { get; set; }
        public int totalminutos { get; set; }
        public int totalsegundos { get; set; }
    }
}
