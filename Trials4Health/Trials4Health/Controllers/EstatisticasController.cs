using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;
using Trials4Health.Models.ViewModel;

namespace Trials4Health.Controllers
{
    public class EstatisticasController : Controller
    {

        private IRepositorioTrails repository;

        public IActionResult Index()
        {
            return View();
        }

        public EstatisticasController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }

        public ViewResult Estatistica() => View(repository);

       
        

        

        public  async Task<IActionResult> BuscarTrilho(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trilho t =  repository.Trilhos.FirstOrDefault(tr => tr.ID_Trilho == id);
            if (t == null)
            {
                return NotFound();
            }

            return  View(t);
        }
        //

        [HttpGet]
        public ViewResult EstatisticasSelect() => View(repository);

        // POST: /Home/Rsvp
        [HttpGet]
        public  ViewResult  Trilho(int id)
        {
            
            
            //BuscarTrilho(id);
            Trilho t =  repository.Trilhos.SingleOrDefault(tr => tr.ID_Trilho == id);
            VisualizarEstatisticas ve = new VisualizarEstatisticas(t,repository);

            if (ModelState.IsValid)
            {
                //Repository.AddResponse(response);
                
                return View("EstatisticasTrilho", ve);
            }
            else
                // There are validation errors
                return View(repository);
           
        }

    }
}