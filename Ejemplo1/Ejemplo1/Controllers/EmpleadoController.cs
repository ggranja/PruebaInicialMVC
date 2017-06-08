using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejemplo1.Models;

namespace Ejemplo1.Controllers
{
    public class EmpleadoController : Controller
    {
        static List<Empleado> listaEmpleado = new List<Empleado>();
        // GET: Empleado
        public ActionResult Index()
        {
            return View(listaEmpleado);
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            foreach (Empleado e in listaEmpleado)
                if (e.Id == id)
                    return View();
            return View();
        }

        // GET: Empleado/Create
        public ActionResult Create(Empleado e)
        {
            listaEmpleado.Add(e);
            return View();
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            foreach (Empleado e in listaEmpleado)
                if (e.Id == id)
                    return View();
            return View();
        }

        //// POST: Empleado/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}



        //// POST: Empleado/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Empleado/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Empleado/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
