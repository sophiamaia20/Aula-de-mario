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
    public class Tipo_NotaController : Controller
    {
        private xAlmoxarifadoEntities12 db = new xAlmoxarifadoEntities12();

        // GET: Tipo_Nota
        public ActionResult Index()
        {
            return View(db.TIPO_NOTA.ToList());
        }

        // GET: Tipo_Nota/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_NOTA tIPO_NOTA = db.TIPO_NOTA.Find(id);
            if (tIPO_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_NOTA);
        }

        // GET: Tipo_Nota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo_Nota/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TIPO_NOTA,DESCRICAO_TIPO_NOTA")] TIPO_NOTA tIPO_NOTA)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_NOTA.Add(tIPO_NOTA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_NOTA);
        }

        // GET: Tipo_Nota/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_NOTA tIPO_NOTA = db.TIPO_NOTA.Find(id);
            if (tIPO_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_NOTA);
        }

        // POST: Tipo_Nota/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TIPO_NOTA,DESCRICAO_TIPO_NOTA")] TIPO_NOTA tIPO_NOTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_NOTA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_NOTA);
        }

        // GET: Tipo_Nota/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_NOTA tIPO_NOTA = db.TIPO_NOTA.Find(id);
            if (tIPO_NOTA == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_NOTA);
        }

        // POST: Tipo_Nota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_NOTA tIPO_NOTA = db.TIPO_NOTA.Find(id);
            db.TIPO_NOTA.Remove(tIPO_NOTA);
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
