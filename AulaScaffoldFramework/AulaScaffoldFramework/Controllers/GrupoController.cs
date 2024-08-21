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
    public class GrupoController : Controller
    {
        private xAlmoxarifadoEntities2 db = new xAlmoxarifadoEntities2();

        // GET: Grupo
        public ActionResult Index()
        {
            return View(db.GRUPO.ToList());
        }

        // GET: Grupo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GRUPO gRUPO = db.GRUPO.Find(id);
            if (gRUPO == null)
            {
                return HttpNotFound();
            }
            return View(gRUPO);
        }

        // GET: Grupo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grupo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_GRU,NOME_GRU,SUGESTAO_GRU")] GRUPO gRUPO)
        {
            if (ModelState.IsValid)
            {
                db.GRUPO.Add(gRUPO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gRUPO);
        }

        // GET: Grupo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GRUPO gRUPO = db.GRUPO.Find(id);
            if (gRUPO == null)
            {
                return HttpNotFound();
            }
            return View(gRUPO);
        }

        // POST: Grupo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_GRU,NOME_GRU,SUGESTAO_GRU")] GRUPO gRUPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gRUPO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gRUPO);
        }

        // GET: Grupo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GRUPO gRUPO = db.GRUPO.Find(id);
            if (gRUPO == null)
            {
                return HttpNotFound();
            }
            return View(gRUPO);
        }

        // POST: Grupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GRUPO gRUPO = db.GRUPO.Find(id);
            db.GRUPO.Remove(gRUPO);
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
