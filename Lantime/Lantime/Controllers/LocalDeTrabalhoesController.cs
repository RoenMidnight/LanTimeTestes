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
    public class LocalDeTrabalhoesController : Controller
    {
        private LantimeContext db = new LantimeContext();

        // GET: LocalDeTrabalhoes
        public ActionResult Index()
        {
            var locaisDeTrabalhos = db.LocaisDeTrabalhos.Include(l => l.Empresa);
            return View(locaisDeTrabalhos.ToList());
        }

        // GET: LocalDeTrabalhoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalDeTrabalho localDeTrabalho = db.LocaisDeTrabalhos.Find(id);
            if (localDeTrabalho == null)
            {
                return HttpNotFound();
            }
            return View(localDeTrabalho);
        }

        // GET: LocalDeTrabalhoes/Create
        public ActionResult Create()
        {
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "Razao_Empr");
            return View();
        }

        // POST: LocalDeTrabalhoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocalDeTrabalhoId,Codig_Loca,Descr_Loca,EmpresaId")] LocalDeTrabalho localDeTrabalho)
        {
            if (ModelState.IsValid)
            {
                db.LocaisDeTrabalhos.Add(localDeTrabalho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "Razao_Empr", localDeTrabalho.EmpresaId);
            return View(localDeTrabalho);
        }

        // GET: LocalDeTrabalhoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalDeTrabalho localDeTrabalho = db.LocaisDeTrabalhos.Find(id);
            if (localDeTrabalho == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "Razao_Empr", localDeTrabalho.EmpresaId);
            return View(localDeTrabalho);
        }

        // POST: LocalDeTrabalhoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalDeTrabalhoId,Codig_Loca,Descr_Loca,EmpresaId")] LocalDeTrabalho localDeTrabalho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localDeTrabalho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "EmpresaId", "Razao_Empr", localDeTrabalho.EmpresaId);
            return View(localDeTrabalho);
        }

        // GET: LocalDeTrabalhoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalDeTrabalho localDeTrabalho = db.LocaisDeTrabalhos.Find(id);
            if (localDeTrabalho == null)
            {
                return HttpNotFound();
            }
            return View(localDeTrabalho);
        }

        // POST: LocalDeTrabalhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalDeTrabalho localDeTrabalho = db.LocaisDeTrabalhos.Find(id);
            db.LocaisDeTrabalhos.Remove(localDeTrabalho);
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
