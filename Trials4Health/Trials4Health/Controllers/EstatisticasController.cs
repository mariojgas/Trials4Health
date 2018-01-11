using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;

namespace Trials4Health.Controllers
{
    public class EstatisticasController : Controller
    {

        private RepositorioTrails repository;

        public IActionResult Index()
        {
            return View();
        }
        public EstatisticasController(RepositorioTrails repository)
        {
            this.repository = repository;
        }

        public ViewResult Estatistica() => View(repository);

        [HttpGet]
        public ViewResult EstatisticasSelect()
        {
            return View(repository);
        }


        public async Task<IActionResult> XS()
        {
            return View(await repository.Trilhos.ToListAsync());
        }

        public async Task<IActionResult> BuscarTrilho(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trilho t = await repository.Trilhos.SingleOrDefaultAsync(tr => tr.Id == id);
            if (t == null)
            {
                return NotFound();
            }

            return  View(t);
        }
        //
        // POST: /Home/Rsvp
        [HttpPost]
        public ViewResult EstatisticasSelect(int ?id)
        {
            BuscarTrilho(id);
            if (ModelState.IsValid)
            {
                //Repository.AddResponse(response);

                return View("EstatisticasTrilho", repository.Trilhos.Where(t => t.Id == id).First());
            }
            else
            {
                // There are validation errors
                return View();
            }
        }

    }
}