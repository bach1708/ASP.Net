using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvbLesson09Db.Models;

namespace NvbLesson09Db.Controllers
{
    public class NvbKhoasController : Controller
    {
        private NvbK22CNT2Lesson09DbEntities db = new NvbK22CNT2Lesson09DbEntities();

        // GET: NvbKhoas
        public ActionResult NvbIndex()
        {
            return View(db.nvbKhoas.ToList());
        }

        // GET: NvbKhoas/Details/5
        public ActionResult NvbDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvbKhoa nvbKhoa = db.nvbKhoas.Find(id);
            if (nvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvbKhoa);
        }

        // GET: NvbKhoas/Create
        public ActionResult NvbCreate()
        {
            return View();
        }

        // POST: NvbKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvbCreate([Bind(Include = "NvbMaKH,NvbTenKH,NvbTrangThai")] nvbKhoa nvbKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nvbKhoas.Add(nvbKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvbKhoa);
        }

        // GET: NvbKhoas/Edit/5
        public ActionResult NvbEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvbKhoa nvbKhoa = db.nvbKhoas.Find(id);
            if (nvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvbKhoa);
        }

        // POST: NvbKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvbEdit([Bind(Include = "NvbMaKH,NvbTenKH,NvbTrangThai")] nvbKhoa nvbKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvbKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvbKhoa);
        }

        // GET: NvbKhoas/Delete/5
        public ActionResult NvbDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvbKhoa nvbKhoa = db.nvbKhoas.Find(id);
            if (nvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvbKhoa);
        }

        // POST: NvbKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvbKhoa nvbKhoa = db.nvbKhoas.Find(id);
            db.nvbKhoas.Remove(nvbKhoa);
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
