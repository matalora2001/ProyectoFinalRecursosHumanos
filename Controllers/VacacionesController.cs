using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalRecursosHumanos.Controllers
{
    public class VacacionesController : Controller
    {
        // GET: Vacaciones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vacaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vacaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vacaciones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vacaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vacaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
