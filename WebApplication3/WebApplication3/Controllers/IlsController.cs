using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class IlsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ils
        public ActionResult Index()
        {
            return View(db.Ils.ToList());
        }

        // GET: Ils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Il il = db.Ils.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // GET: Ils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IlAdi,ToplamPoliklinik,ToplamHastaneSevkSayisi,IptalMi")] Il il)
        {
            if (ModelState.IsValid)
            {
                db.Ils.Add(il);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(il);
        }

        // GET: Ils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Il il = db.Ils.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // POST: Ils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IlAdi,ToplamPoliklinik,ToplamHastaneSevkSayisi,IptalMi")] Il il)
        {
            if (ModelState.IsValid)
            {
                db.Entry(il).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(il);
        }

        // GET: Ils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Il il = db.Ils.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // POST: Ils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Il il = db.Ils.Find(id);
            db.Ils.Remove(il);
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
