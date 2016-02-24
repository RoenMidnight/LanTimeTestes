using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lantime.Cotext;
using Lantime.Models;

namespace Lantime.Controllers
{
    public class CelularesController : Controller
    {
        private LantimeContext db = new LantimeContext();

        // GET: Celulares
        public ActionResult Index()
        {            
            return View(db.Celulares.ToList());
        }

        // GET: Celulares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = db.Celulares.Find(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // GET: Celulares/Create
        public ActionResult Create()
        {
            ViewBag.FuncList = new SelectList(db.Funcionarios, "FuncionarioId", "Nome_Func");

            return View();
        }

        // POST: Celulares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CelularId,Imei_Celu,Nume_Celu,FuncionarioId")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                db.Celulares.Add(celular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(celular);
        }

        // GET: Celulares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = db.Celulares.Find(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // POST: Celulares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CelularId,Imei_Celu,Nume_Celu")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(celular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(celular);
        }

        // GET: Celulares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = db.Celulares.Find(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Celular celular = db.Celulares.Find(id);
            db.Celulares.Remove(celular);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
