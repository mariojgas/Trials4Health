using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trials4Health.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "O que é Trials4Health?";

            return View();
        }

        public IActionResult Estatisticas()
        {
            ViewData["Message"] = "Estatisticas";

            return View();
        }

        public IActionResult PrimeirosSocorros()
        {
            ViewData["Message"] = "Primeiros Socorros";

            return View();
        }

        public IActionResult Requisitos()
        {
            ViewData["Message"] = "Requesitos,Equipamentos e Cuidados a ter";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
