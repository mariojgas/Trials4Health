﻿using System;
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
            ViewData["Message"] = "Requisitos";

            return View();
        }

        public IActionResult Equipamentos()
        {
            ViewData["Message"] = "Equipamentos";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Login";

            return View();
        }

        public IActionResult Cuidados()
        {
            ViewData["Message"] = "Cuidados a ter";

            return View();
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
    }
}
