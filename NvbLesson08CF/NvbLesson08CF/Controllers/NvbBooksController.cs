using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvbLesson08CF.Models;

namespace NvbLesson08CF.Controllers
{
    public class NvbBooksController : Controller
    {
        private NvbBookStore db = new NvbBookStore();

        // GET: NvbBooks
        public ActionResult NvbIndex()
        {
            var books = db.Books.Include(n => n.NvbCategory);
            return View(books.ToList());
        }

        // GET: NvbBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvbBook nvbBook = db.Books.Find(id);
            if (nvbBook == null)
            {
                return HttpNotFound();
            }
            return View(nvbBook);
        }

        // GET: NvbBooks/Create
        public ActionResult Create()
        {
            ViewBag.NvbCategoryId = new SelectList(db.NvbCategories, "NvbCategoryId", "NvbCategoryName");
            return View();
        }

        // POST: NvbBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvbBookId,NvbTitle,NvbAuthor,NvbYear,NvbPublisher,NvbPicture,NvbCategoryId")] NvbBook nvbBook)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(nvbBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NvbCategoryId = new SelectList(db.NvbCategories, "NvbCategoryId", "NvbCategoryName", nvbBook.NvbCategoryId);
            return View(nvbBook);
        }

        // GET: NvbBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvbBook nvbBook = db.Books.Find(id);
            if (nvbBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.NvbCategoryId = new SelectList(db.NvbCategories, "NvbCategoryId", "NvbCategoryName", nvbBook.NvbCategoryId);
            return View(nvbBook);
        }

        // POST: NvbBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvbBookId,NvbTitle,NvbAuthor,NvbYear,NvbPublisher,NvbPicture,NvbCategoryId")] NvbBook nvbBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvbBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NvbCategoryId = new SelectList(db.NvbCategories, "NvbCategoryId", "NvbCategoryName", nvbBook.NvbCategoryId);
            return View(nvbBook);
        }

        // GET: NvbBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvbBook nvbBook = db.Books.Find(id);
            if (nvbBook == null)
            {
                return HttpNotFound();
            }
            return View(nvbBook);
        }

        // POST: NvbBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvbBook nvbBook = db.Books.Find(id);
            db.Books.Remove(nvbBook);
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
