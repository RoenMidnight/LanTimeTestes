using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Lantime.Cotext;
using Lantime.Models;



namespace Lantime.Controllers
{
    public class PontosController:Controller
    {
        private LantimeContext db = new LantimeContext();

        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(db.Pontos.ToList());
            }
            Funcionario funcionario = db.Funcionarios.Find(id);

            if (funcionario == null) {
                return HttpNotFound();
            }

            IEnumerable<Ponto> pontoList = db.Pontos.Where(x => x.Funcionario.FuncionarioId == funcionario.FuncionarioId).ToList();

            return View(pontoList);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ponto ponto = db.Pontos.Find(id);
            if (ponto == null)
            {
                return HttpNotFound();
            }
            return View(ponto);
        }

        [HttpPost]
        public ActionResult Create(Ponto ponto, int? id)
        {
            try
            {
                Funcionario funcionario = db.Funcionarios.Find(id);

                if (ModelState.IsValid)
                {
                    ponto.Funcionario = funcionario;
                    ponto.Datap_Pont = DateTime.Parse("dd/MM/yyyy");
                    ponto.Horap_Pont = DateTime.Parse("HH:mm:ss");
                    ponto.Ponto_Codig = DateTime.Today.Ticks;

                    db.Pontos.Add(ponto);
                    db.SaveChanges();

                    return Json(new { sucess = true }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { sucess = false }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                return Json(new { sucess = false, message = e.GetBaseException().Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}