using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;

namespace Trials4Health.Data
{
    public class TrilhosFalsos
    {
        public static void DefaultTrilhos(IServiceProvider serviceProvider) {
            ApplicationDbContext dbContext = (ApplicationDbContext)serviceProvider.GetService(typeof(ApplicationDbContext));
            if (!dbContext.Trilhos.Any())
            {
                EnsureProductsPopulated(dbContext);
            }

            dbContext.SaveChanges();

        }
        private static void CriarTrilhos(ApplicationDbContext dbContext)
        {
            dbContext.Trilhos.AddRange(
                 new Trilho {Id=1,Nome="Trilho 1",Distancia=8.4,estatisticas=null },
                 new Trilho { Id = 2, Nome = "Trilho 2", Distancia = 12.2, estatisticas = null }

            );
        }
    }
}
/*Para orientar
 namespace SportsStore.Models {
    public static class SeedData {
        public static void EnsurePopulated(IServiceProvider serviceProvider) {
            ApplicationDbContext dbContext = (ApplicationDbContext)serviceProvider.GetService(typeof(ApplicationDbContext));

            if (!dbContext.Products.Any()) {
                EnsureProductsPopulated(dbContext);
            }

            dbContext.SaveChanges();
        }

        private static void EnsureProductsPopulated(ApplicationDbContext dbContext) {
            dbContext.Products.AddRange(
                 new Product { Name = "Kayak", Description = "A boat for one person", Category = "Watersports", Price = 275 },
                 new Product { Name = "Lifejacket", Description = "Protective and fashionable", Category = "Watersports", Price = 48.95m },
                 new Product { Name = "Soccer Ball", Description = "FIFA-approved size and weight", Category = "Soccer", Price = 19.50m },
                 new Product { Name = "Corner Flags", Description = "Give your playing field a professional touch", Category = "Soccer", Price = 34.95m },
                 new Product { Name = "Stadium", Description = "Flat-packed 35,000-seat stadium", Category = "Soccer", Price = 79500 },
                 new Product { Name = "Thinking Cap", Description = "Improve brain efficiency by 75%", Category = "Chess", Price = 16 },
                 new Product { Name = "Unsteady Chair", Description = "Secretly give your opponent a disadvantage", Category = "Chess", Price = 29.95m },
                 new Product { Name = "Human Chess Board", Description = "A fun game for the family", Category = "Chess", Price = 75 },
                 new Product { Name = "Bling-Bling King", Description = "Gold-plated, diamond-studded King", Category = "Chess", Price = 1200 }
            );
        }
    }
}*/
