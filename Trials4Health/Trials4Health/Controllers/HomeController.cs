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
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "O que é Trials4Health?";

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
        public IActionResult Estatisticas()
        {
            return View();
        }
     
        private RepositorioTrails repository;
        public HomeController(RepositorioTrails repository)
            {
                this.repository = repository;
            }

        public ViewResult Estatistica => View(repository);


        
    }

    }

