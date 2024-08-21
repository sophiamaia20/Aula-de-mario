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
    public class ClasseController : Controller
    {
        private xAlmoxarifadoEntities1 db = new xAlmoxarifadoEntities1();

        // GET: Classe
        public ActionResult Index()
        {
            return View(db.CLASSE.ToList());
        }

        // GET: Classe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLASSE cLASSE = db.CLASSE.Find(id);
            if (cLASSE == null)
            {
                return HttpNotFound();
            }
            return View(cLASSE);
        }

        // GET: Classe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classe/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CLAS,ID_SUB_GRU,NOME_CLA")] CLASSE cLASSE)
        {
            if (ModelState.IsValid)
            {
                db.CLASSE.Add(cLASSE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cLASSE);
        }

        // GET: Classe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLASSE cLASSE = db.CLASSE.Find(id);
            if (cLASSE == null)
            {
                return HttpNotFound();
            }
            return View(cLASSE);
        }

        // POST: Classe/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CLAS,ID_SUB_GRU,NOME_CLA")] CLASSE cLASSE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLASSE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cLASSE);
        }

        // GET: Classe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLASSE cLASSE = db.CLASSE.Find(id);
            if (cLASSE == null)
            {
                return HttpNotFound();
            }
            return View(cLASSE);
        }

        // POST: Classe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CLASSE cLASSE = db.CLASSE.Find(id);
            db.CLASSE.Remove(cLASSE);
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
