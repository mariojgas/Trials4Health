using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860




namespace Trials4Health.Controllers
{
    public class PrimeirosSocorrosController : Controller
    {
        private IRepositorioTrails repository;

        public IActionResult Index()
        {
            return View();
        }

        public PrimeirosSocorrosController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }

        public ViewResult PrimeirosSocorros() => View();
        public ViewResult Desmaios() => View(repository.PrimeirosSocorros);
        public ViewResult Entorses() => View(repository.PrimeirosSocorros);
        public ViewResult Hipotermia() => View(repository.PrimeirosSocorros);
        public ViewResult Ataque() => View(repository.PrimeirosSocorros);
    }
}
