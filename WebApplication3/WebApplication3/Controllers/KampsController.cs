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
    public class KampsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Kamps
        public ActionResult Index()
        {
            return View(db.Kamps.ToList());
        }

        // GET: Kamps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kamp kamp = db.Kamps.Find(id);
            if (kamp == null)
            {
                return HttpNotFound();
            }
            return View(kamp);
        }

        // GET: Kamps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kamps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,KampAdi,IptalMi,Aciklama,AcilisTarihi,ToplamPoliklinikSayisi,ToplamHastaneSevkSayisi")] Kamp kamp)
        {
            if (ModelState.IsValid)
            {
                db.Kamps.Add(kamp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kamp);
        }

        // GET: Kamps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kamp kamp = db.Kamps.Find(id);
            if (kamp == null)
            {
                return HttpNotFound();
            }
            return View(kamp);
        }

        // POST: Kamps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,KampAdi,IptalMi,Aciklama,AcilisTarihi,ToplamPoliklinikSayisi,ToplamHastaneSevkSayisi")] Kamp kamp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kamp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kamp);
        }

        // GET: Kamps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kamp kamp = db.Kamps.Find(id);
            if (kamp == null)
            {
                return HttpNotFound();
            }
            return View(kamp);
        }

        // POST: Kamps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kamp kamp = db.Kamps.Find(id);
            db.Kamps.Remove(kamp);
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
