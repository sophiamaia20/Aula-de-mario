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
    public class SecretariaController : Controller
    {
        private xAlmoxarifadoEntities6 db = new xAlmoxarifadoEntities6();

        // GET: Secretaria
        public ActionResult Index()
        {
            return View(db.SECRETARIA.ToList());
        }

        // GET: Secretaria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECRETARIA sECRETARIA = db.SECRETARIA.Find(id);
            if (sECRETARIA == null)
            {
                return HttpNotFound();
            }
            return View(sECRETARIA);
        }

        // GET: Secretaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secretaria/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SEC,NOME_SEC,ENDRECO_SEC,BAIRRO_SEC,EMAIL,TEL")] SECRETARIA sECRETARIA)
        {
            if (ModelState.IsValid)
            {
                db.SECRETARIA.Add(sECRETARIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sECRETARIA);
        }

        // GET: Secretaria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECRETARIA sECRETARIA = db.SECRETARIA.Find(id);
            if (sECRETARIA == null)
            {
                return HttpNotFound();
            }
            return View(sECRETARIA);
        }

        // POST: Secretaria/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SEC,NOME_SEC,ENDRECO_SEC,BAIRRO_SEC,EMAIL,TEL")] SECRETARIA sECRETARIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sECRETARIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sECRETARIA);
        }

        // GET: Secretaria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECRETARIA sECRETARIA = db.SECRETARIA.Find(id);
            if (sECRETARIA == null)
            {
                return HttpNotFound();
            }
            return View(sECRETARIA);
        }

        // POST: Secretaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SECRETARIA sECRETARIA = db.SECRETARIA.Find(id);
            db.SECRETARIA.Remove(sECRETARIA);
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
