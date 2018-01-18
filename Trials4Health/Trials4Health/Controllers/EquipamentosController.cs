using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;

namespace Trials4Health.Controllers
{
    public class EquipamentosController : Controller
    {
        private IRepositorioTrails repository;

        public IActionResult Index()
        {
            return View();
        }

        public EquipamentosController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }


        public ViewResult Equipamentos() => View(repository.Equipamentos);
    }
}