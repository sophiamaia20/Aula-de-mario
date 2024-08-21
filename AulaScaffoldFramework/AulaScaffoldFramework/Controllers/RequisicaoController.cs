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
    public class RequisicaoController : Controller
    {
        private xAlmoxarifadoEntities11 db = new xAlmoxarifadoEntities11();

        // GET: Requisicao
        public ActionResult Index()
        {
            return View(db.REQUISICAO.ToList());
        }

        // GET: Requisicao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REQUISICAO rEQUISICAO = db.REQUISICAO.Find(id);
            if (rEQUISICAO == null)
            {
                return HttpNotFound();
            }
            return View(rEQUISICAO);
        }

        // GET: Requisicao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requisicao/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REQ,ID_CLI,TOTAL_REQ,QTD_ITEN,DATA_REQ,ANO,MES,ID_SEC,ID_SET,OBSERVACAO")] REQUISICAO rEQUISICAO)
        {
            if (ModelState.IsValid)
            {
                db.REQUISICAO.Add(rEQUISICAO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rEQUISICAO);
        }

        // GET: Requisicao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REQUISICAO rEQUISICAO = db.REQUISICAO.Find(id);
            if (rEQUISICAO == null)
            {
                return HttpNotFound();
            }
            return View(rEQUISICAO);
        }

        // POST: Requisicao/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REQ,ID_CLI,TOTAL_REQ,QTD_ITEN,DATA_REQ,ANO,MES,ID_SEC,ID_SET,OBSERVACAO")] REQUISICAO rEQUISICAO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rEQUISICAO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rEQUISICAO);
        }

        // GET: Requisicao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REQUISICAO rEQUISICAO = db.REQUISICAO.Find(id);
            if (rEQUISICAO == null)
            {
                return HttpNotFound();
            }
            return View(rEQUISICAO);
        }

        // POST: Requisicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REQUISICAO rEQUISICAO = db.REQUISICAO.Find(id);
            db.REQUISICAO.Remove(rEQUISICAO);
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
