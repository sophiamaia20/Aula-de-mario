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
    public class Unidade_MedidaController : Controller
    {
        private xAlmoxarifadoEntities7 db = new xAlmoxarifadoEntities7();

        // GET: Unidade_Medida
        public ActionResult Index()
        {
            return View(db.UNIDADE_MEDIDA.ToList());
        }

        // GET: Unidade_Medida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UNIDADE_MEDIDA uNIDADE_MEDIDA = db.UNIDADE_MEDIDA.Find(id);
            if (uNIDADE_MEDIDA == null)
            {
                return HttpNotFound();
            }
            return View(uNIDADE_MEDIDA);
        }

        // GET: Unidade_Medida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unidade_Medida/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_UN_MED,NOME_UN_MED,SIGLA")] UNIDADE_MEDIDA uNIDADE_MEDIDA)
        {
            if (ModelState.IsValid)
            {
                db.UNIDADE_MEDIDA.Add(uNIDADE_MEDIDA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uNIDADE_MEDIDA);
        }

        // GET: Unidade_Medida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UNIDADE_MEDIDA uNIDADE_MEDIDA = db.UNIDADE_MEDIDA.Find(id);
            if (uNIDADE_MEDIDA == null)
            {
                return HttpNotFound();
            }
            return View(uNIDADE_MEDIDA);
        }

        // POST: Unidade_Medida/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_UN_MED,NOME_UN_MED,SIGLA")] UNIDADE_MEDIDA uNIDADE_MEDIDA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uNIDADE_MEDIDA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uNIDADE_MEDIDA);
        }

        // GET: Unidade_Medida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UNIDADE_MEDIDA uNIDADE_MEDIDA = db.UNIDADE_MEDIDA.Find(id);
            if (uNIDADE_MEDIDA == null)
            {
                return HttpNotFound();
            }
            return View(uNIDADE_MEDIDA);
        }

        // POST: Unidade_Medida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UNIDADE_MEDIDA uNIDADE_MEDIDA = db.UNIDADE_MEDIDA.Find(id);
            db.UNIDADE_MEDIDA.Remove(uNIDADE_MEDIDA);
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
