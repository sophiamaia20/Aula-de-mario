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
    public class SubgrupoController : Controller
    {
        private xAlmoxarifadoEntities3 db = new xAlmoxarifadoEntities3();

        // GET: Subgrupo
        public ActionResult Index()
        {
            return View(db.SUBGRUPO.ToList());
        }

        // GET: Subgrupo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBGRUPO sUBGRUPO = db.SUBGRUPO.Find(id);
            if (sUBGRUPO == null)
            {
                return HttpNotFound();
            }
            return View(sUBGRUPO);
        }

        // GET: Subgrupo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subgrupo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SUB_GRU,ID_GRU,NOME_SUB_GRU")] SUBGRUPO sUBGRUPO)
        {
            if (ModelState.IsValid)
            {
                db.SUBGRUPO.Add(sUBGRUPO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sUBGRUPO);
        }

        // GET: Subgrupo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBGRUPO sUBGRUPO = db.SUBGRUPO.Find(id);
            if (sUBGRUPO == null)
            {
                return HttpNotFound();
            }
            return View(sUBGRUPO);
        }

        // POST: Subgrupo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SUB_GRU,ID_GRU,NOME_SUB_GRU")] SUBGRUPO sUBGRUPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sUBGRUPO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sUBGRUPO);
        }

        // GET: Subgrupo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUBGRUPO sUBGRUPO = db.SUBGRUPO.Find(id);
            if (sUBGRUPO == null)
            {
                return HttpNotFound();
            }
            return View(sUBGRUPO);
        }

        // POST: Subgrupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SUBGRUPO sUBGRUPO = db.SUBGRUPO.Find(id);
            db.SUBGRUPO.Remove(sUBGRUPO);
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
