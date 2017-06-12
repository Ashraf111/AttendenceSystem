using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AttendenceSystem.Models;

namespace AttendenceSystem.Controllers
{
    public class CsteY4_T2_StudentsController : Controller
    {
        private DataRetrive db = new DataRetrive();

        // GET: CsteY4_T2_Students
        public ActionResult Index()
        {
            return View(db.Cstey4t2studens.ToList());
        }

        // GET: CsteY4_T2_Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CsteY4_T2_Students csteY4_T2_Students = db.Cstey4t2studens.Find(id);
            if (csteY4_T2_Students == null)
            {
                return HttpNotFound();
            }
            return View(csteY4_T2_Students);
        }

        // GET: CsteY4_T2_Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CsteY4_T2_Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StudentId,StudentName,SubjectCode")] CsteY4_T2_Students csteY4_T2_Students)
        {
            if (ModelState.IsValid)
            {
                db.Cstey4t2studens.Add(csteY4_T2_Students);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(csteY4_T2_Students);
        }

        // GET: CsteY4_T2_Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CsteY4_T2_Students csteY4_T2_Students = db.Cstey4t2studens.Find(id);
            if (csteY4_T2_Students == null)
            {
                return HttpNotFound();
            }
            return View(csteY4_T2_Students);
        }

        // POST: CsteY4_T2_Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StudentId,StudentName,SubjectCode")] CsteY4_T2_Students csteY4_T2_Students)
        {
            if (ModelState.IsValid)
            {
                db.Entry(csteY4_T2_Students).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(csteY4_T2_Students);
        }

        // GET: CsteY4_T2_Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CsteY4_T2_Students csteY4_T2_Students = db.Cstey4t2studens.Find(id);
            if (csteY4_T2_Students == null)
            {
                return HttpNotFound();
            }
            return View(csteY4_T2_Students);
        }

        // POST: CsteY4_T2_Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CsteY4_T2_Students csteY4_T2_Students = db.Cstey4t2studens.Find(id);
            db.Cstey4t2studens.Remove(csteY4_T2_Students);
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
