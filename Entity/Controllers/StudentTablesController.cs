using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity.Models;

namespace Entity.Controllers
{
    public class StudentTablesController : Controller
    {
        private StudentDB db = new StudentDB();

        // GET: StudentTables
        public ActionResult Index()
        {
            StudentTable studtab3 = new StudentTable() { StudentName = "Tom" };
            StudentTable studtab1 = new StudentTable() { StudentName = "Jack" };
            StudentTable studtab2 = new StudentTable() { StudentName = "Hunter" };
            StudentTable studtab = new StudentTable() { StudentName = "Twister" };
            db.StudTable.Add(studtab3);
            db.StudTable.Add(studtab1);
            db.StudTable.Add(studtab2);
            db.StudTable.Add(studtab);
            db.TeachTable.Add(new TeachersTable() {TeacherName="aa", studentTables=studtab });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "bb", studentTables = studtab });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "cc", studentTables = studtab2 });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "dd", studentTables = studtab3 });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "ee", studentTables = studtab });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "ff", studentTables = studtab1 });
            db.TeachTable.Add(new TeachersTable() { TeacherName = "gg", studentTables = studtab2 });
            
            db.SaveChanges();
            return View(db.StudTable.ToList());
        }

        // GET: StudentTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // GET: StudentTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentTabs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,StudentName,StudentAge")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                db.StudTable.Add(studentTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentTable);
        }

        // GET: StudentTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // POST: StudentTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,StudentName,Age")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentTable);
        }

        // GET: StudentTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // POST: StudentTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentTable studentTable = db.StudTable.Find(id);
            db.StudTable.Remove(studentTable);
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
