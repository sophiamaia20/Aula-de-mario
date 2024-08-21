using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AulaScaffoldFramework.Models;

namespace AulaScaffoldFramework.Controllers
{
    public class Mes_CompetenciaController : Controller
    {
        private xAlmoxarifadoEntities9 db = new xAlmoxarifadoEntities9();

        // GET: Mes_Competencia
        public ActionResult Index()
        {
            return View(db.MES_COMPETENCIA.ToList());
        }

        // GET: Mes_Competencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MES_COMPETENCIA mES_COMPETENCIA = db.MES_COMPETENCIA.Find(id);
            if (mES_COMPETENCIA == null)
            {
                return HttpNotFound();
            }
            return View(mES_COMPETENCIA);
        }

        // GET: Mes_Competencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mes_Competencia/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MES,ANO,ABERTO")] MES_COMPETENCIA mES_COMPETENCIA)
        {
            if (ModelState.IsValid)
            {
                db.MES_COMPETENCIA.Add(mES_COMPETENCIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mES_COMPETENCIA);
        }

        // GET: Mes_Competencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MES_COMPETENCIA mES_COMPETENCIA = db.MES_COMPETENCIA.Find(id);
            if (mES_COMPETENCIA == null)
            {
                return HttpNotFound();
            }
            return View(mES_COMPETENCIA);
        }

        // POST: Mes_Competencia/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MES,ANO,ABERTO")] MES_COMPETENCIA mES_COMPETENCIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mES_COMPETENCIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mES_COMPETENCIA);
        }

        // GET: Mes_Competencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MES_COMPETENCIA mES_COMPETENCIA = db.MES_COMPETENCIA.Find(id);
            if (mES_COMPETENCIA == null)
            {
                return HttpNotFound();
            }
            return View(mES_COMPETENCIA);
        }

        // POST: Mes_Competencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MES_COMPETENCIA mES_COMPETENCIA = db.MES_COMPETENCIA.Find(id);
            db.MES_COMPETENCIA.Remove(mES_COMPETENCIA);
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
