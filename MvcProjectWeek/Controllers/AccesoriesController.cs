using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcProjectWeek.Models;

namespace MvcProjectWeek.Controllers
{
    public class AccesoriesController : Controller
    {
        private MvcProjectWeekContext db = new MvcProjectWeekContext();

        // GET: Accesories
        public ActionResult Index()
        {
            return View(db.Accesories.ToList());
        }

        // GET: Accesories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesories accesories = db.Accesories.Find(id);
            if (accesories == null)
            {
                return HttpNotFound();
            }
            return View(accesories);
        }

        // GET: Accesories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accesories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccesoriesId,Nickname,Type,Color,Season,Occasion,Photo")] Accesories accesories)
        {
            if (ModelState.IsValid)
            {
                db.Accesories.Add(accesories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accesories);
        }

        // GET: Accesories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesories accesories = db.Accesories.Find(id);
            if (accesories == null)
            {
                return HttpNotFound();
            }
            return View(accesories);
        }

        // POST: Accesories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccesoriesId,Nickname,Type,Color,Season,Occasion,Photo")] Accesories accesories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accesories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accesories);
        }

        // GET: Accesories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesories accesories = db.Accesories.Find(id);
            if (accesories == null)
            {
                return HttpNotFound();
            }
            return View(accesories);
        }

        // POST: Accesories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accesories accesories = db.Accesories.Find(id);
            db.Accesories.Remove(accesories);
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
