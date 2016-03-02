using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyTest.Models;

namespace MyTest.Controllers
{
    public class CleanerController : Controller
    {
        private DatabaseEntities1 db = new DatabaseEntities1();

        // GET: /Cleaner/
        public ActionResult Index()
        {
            return View(db.Cleaner.ToList());
        }

        // GET: /Cleaner/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleaner cleaner = db.Cleaner.Find(id);
            if (cleaner == null)
            {
                return HttpNotFound();
            }
            return View(cleaner);
        }

        // GET: /Cleaner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Cleaner/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cleaner_id,first_name,last_name,gender")] Cleaner cleaner)
        {
            if (ModelState.IsValid)
            {
                db.Cleaner.Add(cleaner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cleaner);
        }

        // GET: /Cleaner/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleaner cleaner = db.Cleaner.Find(id);
            if (cleaner == null)
            {
                return HttpNotFound();
            }
            return View(cleaner);
        }

        // POST: /Cleaner/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cleaner_id,first_name,last_name,gender")] Cleaner cleaner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cleaner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cleaner);
        }

        // GET: /Cleaner/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cleaner cleaner = db.Cleaner.Find(id);
            if (cleaner == null)
            {
                return HttpNotFound();
            }
            return View(cleaner);
        }

        // POST: /Cleaner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Cleaner cleaner = db.Cleaner.Find(id);
            db.Cleaner.Remove(cleaner);
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
