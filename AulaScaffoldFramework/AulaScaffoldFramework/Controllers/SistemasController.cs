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
    public class SistemasController : Controller
    {
        private xAlmoxarifadoEntities10 db = new xAlmoxarifadoEntities10();

        // GET: Sistemas
        public ActionResult Index()
        {
            return View(db.SISTEMAS.ToList());
        }

        // GET: Sistemas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // GET: Sistemas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sistemas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SISID,SISDESCRICAO,SISCHAVE,DA,DU")] SISTEMAS sISTEMAS)
        {
            if (ModelState.IsValid)
            {
                db.SISTEMAS.Add(sISTEMAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sISTEMAS);
        }

        // GET: Sistemas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // POST: Sistemas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SISID,SISDESCRICAO,SISCHAVE,DA,DU")] SISTEMAS sISTEMAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sISTEMAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sISTEMAS);
        }

        // GET: Sistemas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // POST: Sistemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            db.SISTEMAS.Remove(sISTEMAS);
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
