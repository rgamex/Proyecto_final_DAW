using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyectoTienda.Models;

namespace proyectoTienda.Controllers
{
    public class img_prodController : Controller
    {
        private ModeloTienda db = new ModeloTienda();

        // GET: img_prod
        public ActionResult Index()
        {
            return View(db.img_prod.ToList());
        }

        // GET: img_prod/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            img_prod img_prod = db.img_prod.Find(id);
            if (img_prod == null)
            {
                return HttpNotFound();
            }
            return View(img_prod);
        }

        // GET: img_prod/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: img_prod/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ruta,descripción,id_producto")] img_prod img_prod)
        {
            if (ModelState.IsValid)
            {
                db.img_prod.Add(img_prod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(img_prod);
        }

        // GET: img_prod/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            img_prod img_prod = db.img_prod.Find(id);
            if (img_prod == null)
            {
                return HttpNotFound();
            }
            return View(img_prod);
        }

        // POST: img_prod/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ruta,descripción,id_producto")] img_prod img_prod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(img_prod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(img_prod);
        }

        // GET: img_prod/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            img_prod img_prod = db.img_prod.Find(id);
            if (img_prod == null)
            {
                return HttpNotFound();
            }
            return View(img_prod);
        }

        // POST: img_prod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            img_prod img_prod = db.img_prod.Find(id);
            db.img_prod.Remove(img_prod);
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
