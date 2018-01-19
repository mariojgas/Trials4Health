using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;
using Trials4Health.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860




namespace Trials4Health.Controllers
{
    public class PrimeirosSocorrosController : Controller
    {
        private IRepositorioTrails repository;
        private ApplicationDbContext repositorio = SeedData.dbContext;

        public IActionResult Index()
        {
            return View();
        }

        public PrimeirosSocorrosController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }

        // GET: PrimeirosSocorros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrimeirosSocorros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PrimeirosSocorros collection)
        {
            try
            {
                repositorio.PrimeirosSocorros.Add(new PrimeirosSocorros() { Nome = collection.Nome, Descriçao = collection.Descriçao, Tecnicas = collection.Tecnicas });
                repositorio.SaveChanges();
                
                return RedirectToAction("PrimeirosSocorros", "PrimeirosSocorros", repositorio.PrimeirosSocorros.AsEnumerable());
            }
            catch
            {
                return View();
            }
        }
        public ViewResult PrimeirosSocorros() => View();
        public ViewResult Desmaios() => View(repository.PrimeirosSocorros);
        public ViewResult Entorses() => View(repository.PrimeirosSocorros);
        public ViewResult Hipotermia() => View(repository.PrimeirosSocorros);
        public ViewResult Ataque() => View(repository.PrimeirosSocorros);
    }
}
