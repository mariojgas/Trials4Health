using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;

namespace Trials4Health.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "O que é Trials4Health?";
            return View();
        }

        public IActionResult PrimeirosSocorros()
        {
            ViewData["Message"] = "Primeiros Socorros";

            return View();


        }
        

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Message"] = "Login";

            return View();
        }

        [HttpPost]
        public IActionResult Login(RegExTestClass model)
        {
            if (ModelState.IsValid)
            {
                return View("RegExOk");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Contactos()
        {
            ViewData["Message"] = "Pagina de Contactos";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        private IRepositorioTrails repository;
        public HomeController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }

        public ViewResult Estatistica() => View(repository);
        public ViewResult Desmaios() => View(repository.PrimeirosSocorros);
        public ViewResult Entorses() => View(repository.PrimeirosSocorros);
        public ViewResult Hipotermia() => View(repository.PrimeirosSocorros);
        public ViewResult Ataque() => View(repository.PrimeirosSocorros);
        public ViewResult Cuidados() => View(repository.Cuidados);
        public ViewResult Requisitos() => View(repository.Requisitos);
        public ViewResult Equipamentos() => View(repository.Equipamentos);
    }
}

