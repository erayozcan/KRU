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
    public class KampVeriGirisGunluksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: KampVeriGirisGunluks
        public ActionResult Index()
        {
            return View(db.KampVeriGirisGunluks.ToList());
        }

        // GET: KampVeriGirisGunluks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KampVeriGirisGunluk kampVeriGirisGunluk = db.KampVeriGirisGunluks.Find(id);
            if (kampVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(kampVeriGirisGunluk);
        }

        // GET: KampVeriGirisGunluks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KampVeriGirisGunluks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PoliklinikSayisi,HastaneSevkSayisi,VeriGirisTarihi")] KampVeriGirisGunluk kampVeriGirisGunluk)
        {
            if (ModelState.IsValid)
            {
                db.KampVeriGirisGunluks.Add(kampVeriGirisGunluk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kampVeriGirisGunluk);
        }

        // GET: KampVeriGirisGunluks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KampVeriGirisGunluk kampVeriGirisGunluk = db.KampVeriGirisGunluks.Find(id);
            if (kampVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(kampVeriGirisGunluk);
        }

        // POST: KampVeriGirisGunluks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PoliklinikSayisi,HastaneSevkSayisi,VeriGirisTarihi")] KampVeriGirisGunluk kampVeriGirisGunluk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kampVeriGirisGunluk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kampVeriGirisGunluk);
        }

        // GET: KampVeriGirisGunluks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KampVeriGirisGunluk kampVeriGirisGunluk = db.KampVeriGirisGunluks.Find(id);
            if (kampVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(kampVeriGirisGunluk);
        }

        // POST: KampVeriGirisGunluks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KampVeriGirisGunluk kampVeriGirisGunluk = db.KampVeriGirisGunluks.Find(id);
            db.KampVeriGirisGunluks.Remove(kampVeriGirisGunluk);
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
