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
    public class ProdutoController : Controller
    {
        private xAlmoxarifadoEntities db = new xAlmoxarifadoEntities();

        // GET: Produto
        public ActionResult Index()
        {
            return View(db.PRODUTO.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PRO,ID_CLAS,ID_UN_MED,DESCRICAO,OBSERVACAO,ESTOQUE_MIN,PERECIVEL,QTD_EMBALAGEM")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.PRODUTO.Add(pRODUTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRODUTO);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // POST: Produto/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PRO,ID_CLAS,ID_UN_MED,DESCRICAO,OBSERVACAO,ESTOQUE_MIN,PERECIVEL,QTD_EMBALAGEM")] PRODUTO pRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRODUTO);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            if (pRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(pRODUTO);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUTO pRODUTO = db.PRODUTO.Find(id);
            db.PRODUTO.Remove(pRODUTO);
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
