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
    public class IlVeriGirisGunluksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IlVeriGirisGunluks
        public ActionResult Index()
        {
            return View(db.IlVeriGirisGunluks.ToList());
        }

        // GET: IlVeriGirisGunluks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IlVeriGirisGunluk ilVeriGirisGunluk = db.IlVeriGirisGunluks.Find(id);
            if (ilVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(ilVeriGirisGunluk);
        }

        // GET: IlVeriGirisGunluks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IlVeriGirisGunluks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PoliklinikSayisi,HastaneSevkSayisi,SinirdanGirisYapanSayisi,HastanePoliklinikSayisi,HastanedeYatanHastaSayisi,DogumSayisi,AmeliyatSayisi,VeriGirisTarihi")] IlVeriGirisGunluk ilVeriGirisGunluk)
        {
            if (ModelState.IsValid)
            {
                db.IlVeriGirisGunluks.Add(ilVeriGirisGunluk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ilVeriGirisGunluk);
        }

        // GET: IlVeriGirisGunluks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IlVeriGirisGunluk ilVeriGirisGunluk = db.IlVeriGirisGunluks.Find(id);
            if (ilVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(ilVeriGirisGunluk);
        }

        // POST: IlVeriGirisGunluks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PoliklinikSayisi,HastaneSevkSayisi,SinirdanGirisYapanSayisi,HastanePoliklinikSayisi,HastanedeYatanHastaSayisi,DogumSayisi,AmeliyatSayisi,VeriGirisTarihi")] IlVeriGirisGunluk ilVeriGirisGunluk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ilVeriGirisGunluk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ilVeriGirisGunluk);
        }

        // GET: IlVeriGirisGunluks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IlVeriGirisGunluk ilVeriGirisGunluk = db.IlVeriGirisGunluks.Find(id);
            if (ilVeriGirisGunluk == null)
            {
                return HttpNotFound();
            }
            return View(ilVeriGirisGunluk);
        }

        // POST: IlVeriGirisGunluks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IlVeriGirisGunluk ilVeriGirisGunluk = db.IlVeriGirisGunluks.Find(id);
            db.IlVeriGirisGunluks.Remove(ilVeriGirisGunluk);
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
