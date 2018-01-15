using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860




namespace Trials4Health.Controllers
{
    public class SOSController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PrimeirosSocorros()
        {
            ViewData["Message"] = "Primeiros Socorros";

            return View();


        }
    }
}
