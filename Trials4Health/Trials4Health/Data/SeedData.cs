using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;

namespace Trials4Health.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider)
        {
            ApplicationDbContext dbContext = (ApplicationDbContext)serviceProvider.GetService(typeof(ApplicationDbContext));

            dbContext.Database.EnsureCreated();

            #region EnsureDatabaseData
            if (!dbContext.Trilhos.Any())
            {
                EnsureTrilhosPopulated(dbContext);
            }

            if (!dbContext.Turistas.Any())
            {
                EnsureTuristaPopulated(dbContext);
            }

            if (!dbContext.Requisitos.Any())
            {
                EnsureRequisitosPopulated(dbContext);
            }

            if (!dbContext.Equipamentos.Any())
            {
                EnsureEquipamentosPopulated(dbContext);
            }

            if (!dbContext.Cuidados.Any())
            {
                EnsureCuidadosPopulated(dbContext);
            }

            if (!dbContext.PrimeirosSocorros.Any())
            {
                EnsureSOSPopulated(dbContext);
            }

            if (!dbContext.trilhosPercorridos.Any())
            {
                EnsureTrilhosPercorridosPopulated(dbContext);
            }
            #endregion

            dbContext.SaveChanges();
        }

        public static void EnsureTrilhosPopulated(ApplicationDbContext dbContext)
        {
            dbContext.Trilhos.AddRange(
            new Trilho { Nome = "Trilho 1", Distancia = 3000 },
            new Trilho { Nome = "Trilho 2", Distancia = 5500 },
            new Trilho { Nome = "Trilho 3", Distancia = 2300 }

            );
            dbContext.SaveChanges();
        }


        public static void EnsureRequisitosPopulated(ApplicationDbContext dbContext)
        {
            dbContext.Requisitos.AddRange(

        new Requisitos { Nome = "Guia", Descrição = "O Trilhos necessita de guia?" },
            new Requisitos { Nome = "GPS", Descrição = "O Trilhos necessita de gps?" },
            new Requisitos { Nome = "Medico", Descrição = "O Trilhos necessita de assistencia medica?" }

            );
            dbContext.SaveChanges();
        }


        public static void EnsureEquipamentosPopulated(ApplicationDbContext dbContext)
        {
            dbContext.Equipamentos.AddRange(
                new Equipamentos { Nome = "Botas de montanhismo", Descrição = "Botas adequadas para montanhismo" },
            new Equipamentos { Nome = "GPS", Descrição = "Equipamento de GPS" },
            new Equipamentos { Nome = "Kit Primeiros Socorros", Descrição = "Kit de primeiros socorros para Trilhos de elevada dificuldade" }

            );
            dbContext.SaveChanges();
        }


        public static void EnsureCuidadosPopulated(ApplicationDbContext dbContext)
        {
            dbContext.Cuidados.AddRange(

        new Cuidados { Nome = "Protetor Solar", Descrição = "Trilho com bastante exposição solar" },
            new Cuidados { Nome = "Calçado adequado", Descrição = "Trilho necessita de calçado adequado" },
            new Cuidados { Nome = "Ravinas", Descrição = "Cuidado com o Trilhos que possui caminhos estreitos e de passagem perigosa" }

            );
            dbContext.SaveChanges();
        }


        public static void EnsureSOSPopulated(ApplicationDbContext dbContext)
        {
            dbContext.PrimeirosSocorros.AddRange(
        new PrimeirosSocorros
        {
            Nome = "Ataque",
            Descriçao = "",
            Tecnicas = "Ajudar o paciente a colocar-se na posição que lhe for mais confortável."
                    + "Desapertar-lhe a roupa."
                    + "Não tentar levantá-lo nem transportá-lo."
                    + "Não lhe dar nada para beber."
                    + "Permanecer calmo."
                    + "Tentar traquilizar a vítima."
                    + "Recordar, mentalemnte, as técnicas de reanimação cardiopulmonar para o caso de o paciente perder o pulso e a respiração parar."
        },
             new PrimeirosSocorros
             {
                 Nome = "Entorses",
                 Descriçao = "",
                 Tecnicas = " Colocar a articulação traumatizada em posição confortável e num plano elevado." +
                     "Evitar que o doente faça movimentos." +
                     "As pessoas com entorses no joelho ou no tornozelo devem evitar andar." +
                     "Aplicar um saco de gelo ou uma compressa fria para reduzir a dor e o inchaço."
             },
             new PrimeirosSocorros
             {
                 Nome = "Hipotermia",
                 Descriçao = "A hipotermia é uma situação que ocorre quando a temperatura do corpo baixa" +
                                                        " para valores inferiores a 35ºC.O organismo deixa de consegui produzir" +
                                                        " calor suficiente para manter os níveis de temperatura considerados normais e" +
                                                        " torna-se impossível que ocorra o aquecimento espontâneo do corpo. A hipotermia" +
                                                        " pode mesmo levar à morte.",

                 Tecnicas = "Retirar as roupas frias ou molhadas." +
                    "Limpar e cobrir com roupas secas e quentes." +
                     "Colocar a vítima em local abrigado e, se possível, aquece o ambiente." +
                     "Assegurar que a vítima é observada por um médico."
             },

               new PrimeirosSocorros
               {
                   Nome = "Desmaios",
                   Descriçao = "É provocado por falta de oxigénio no cérebro," +
                                                        " a que o organismo reage de forma automática, com perda" +
                                                        " de consciência e queda do corpo brusca e desamparada." +
                                                        "Normalmente, o desmaio dura 2 ou 3 minutos.",
                   Tecnicas = "Sentár a vítima." +
                                                        "Colocar-lhe a cabeça entre as pernas." +
                                                        "Molhar-lhe a testa com água fria." +
                                                        "Dar-lhe a beber água, chá ou café açucarados."
               }
            );
            dbContext.SaveChanges();
        }



        public static void EnsureTrilhosPercorridosPopulated(ApplicationDbContext dbContext)
        {
            dbContext.trilhosPercorridos.AddRange(
            new TrilhosPercorridos { Tempo = new TimeSpan(1, 2, 3), Calorias = 1005, ID_Trilho = 1, ID_Turista = 1 },
            new TrilhosPercorridos { Tempo = new TimeSpan(1, 12, 3), Calorias = 1589, ID_Trilho = 1, ID_Turista = 2 },
            new TrilhosPercorridos { Tempo = new TimeSpan(1, 44, 3), Calorias = 1234, ID_Trilho = 1, ID_Turista = 3 },
            new TrilhosPercorridos { Tempo = new TimeSpan(2, 11, 3), Calorias = 1700, ID_Trilho = 1, ID_Turista = 2 },
            new TrilhosPercorridos { Tempo = new TimeSpan(2, 44, 3), Calorias = 1600, ID_Trilho = 2, ID_Turista = 2 },
            new TrilhosPercorridos { Tempo = new TimeSpan(3, 44, 3), Calorias = 1589, ID_Trilho = 2, ID_Turista = 3 },
            new TrilhosPercorridos { Tempo = new TimeSpan(1, 44, 3), Calorias = 1234, ID_Trilho = 3, ID_Turista = 1 },
            new TrilhosPercorridos { Tempo = new TimeSpan(2, 11, 3), Calorias = 1700, ID_Trilho = 3, ID_Turista = 2 }
                );
            dbContext.SaveChanges();

        }

        public static void EnsureTuristaPopulated(ApplicationDbContext dbContext)
        {
            dbContext.AddRange(
            new Turista { Nome = "João", Idade = 72 },
            new Turista { Nome = "Maria", Idade = 18 },
            new Turista { Nome = "Marcia", Idade = 24 });

            dbContext.SaveChanges();
        }
    }
}