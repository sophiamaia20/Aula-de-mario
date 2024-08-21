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
    public class SetorController : Controller
    {
        private xAlmoxarifadoEntities5 db = new xAlmoxarifadoEntities5();

        // GET: Setor
        public ActionResult Index()
        {
            return View(db.SETOR.ToList());
        }

        // GET: Setor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SETOR sETOR = db.SETOR.Find(id);
            if (sETOR == null)
            {
                return HttpNotFound();
            }
            return View(sETOR);
        }

        // GET: Setor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Setor/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SET,ID_SEC,NOME_SET")] SETOR sETOR)
        {
            if (ModelState.IsValid)
            {
                db.SETOR.Add(sETOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sETOR);
        }

        // GET: Setor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SETOR sETOR = db.SETOR.Find(id);
            if (sETOR == null)
            {
                return HttpNotFound();
            }
            return View(sETOR);
        }

        // POST: Setor/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SET,ID_SEC,NOME_SET")] SETOR sETOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sETOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sETOR);
        }

        // GET: Setor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SETOR sETOR = db.SETOR.Find(id);
            if (sETOR == null)
            {
                return HttpNotFound();
            }
            return View(sETOR);
        }

        // POST: Setor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SETOR sETOR = db.SETOR.Find(id);
            db.SETOR.Remove(sETOR);
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
