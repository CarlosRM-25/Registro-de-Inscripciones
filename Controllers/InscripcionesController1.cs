using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registro_de_Inscripciones.Data;
using Registro_de_Inscripciones.Models;

namespace Registro_de_Inscripciones.Controllers
{
    public class InscripcionesController1 : Controller
    {
        // GET: InscripcionesController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: InscripcionesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InscripcionesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InscripcionesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InscripcionesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InscripcionesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InscripcionesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InscripcionesController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
