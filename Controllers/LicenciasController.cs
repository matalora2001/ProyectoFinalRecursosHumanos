using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class LicenciasController : Controller
    {
        // GET: Licencias
        public ActionResult Index()
        {
            return View();
        }

        // GET: Licencias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Licencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Licencias/Create
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

        // GET: Licencias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Licencias/Edit/5
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

        // GET: Licencias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Licencias/Delete/5
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
