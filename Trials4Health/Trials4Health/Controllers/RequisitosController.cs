using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trials4Health.Models;
using Microsoft.AspNetCore.Http;
using Trials4Health.Data;

namespace Trials4Health.Controllers
{
    public class RequisitosController : Controller
    {
        private IRepositorioTrails repository;
        private ApplicationDbContext repositorio = SeedData.dbContext;

        // GET: Requisitos
        public ActionResult Index()
            {
                return View();
            }

            // GET: Requisitos/Details/5
            public ActionResult Details(int id)
            {
                return View();
            }

            // GET: Requisitos/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Requisitos/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(Requisitos collection)
            {
                try
                {
                    repositorio.Requisitos.Add(new Requisitos() { Nome = collection.Nome, Descrição = collection.Descrição });
                    repositorio.SaveChanges();
                
                    return RedirectToAction("Visualizar", "Requisitos", repositorio.Requisitos.AsEnumerable());
                }
                catch
                {
                    return View();
                }
            }

            // GET: Requisitos/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: Requisitos/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add update logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: Requisitos/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Requisitos/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }


        public RequisitosController(IRepositorioTrails repository)
        {
            this.repository = repository;
        }


        public ViewResult Visualizar() => View(repositorio.Requisitos.AsEnumerable());
        public ViewResult Requisitos() => View();
    }
}