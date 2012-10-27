using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BearEF;

namespace BearCamp.Controllers
{ 
    public class EventsController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Events/

        public ViewResult Index()
        {
            return View(db.Events1.ToList());
        }

        //
        // GET: /Events/Details/5

        public ViewResult Details(int id)
        {
            Events events = db.Events1.Find(id);
            return View(events);
        }

        //
        // GET: /Events/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Events/Create

        [HttpPost]
        public ActionResult Create(Events events)
        {
            if (ModelState.IsValid)
            {
                db.Events1.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(events);
        }
        
        //
        // GET: /Events/Edit/5
 
        public ActionResult Edit(int id)
        {
            Events events = db.Events1.Find(id);
            return View(events);
        }

        //
        // POST: /Events/Edit/5

        [HttpPost]
        public ActionResult Edit(Events events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(events);
        }

        //
        // GET: /Events/Delete/5
 
        public ActionResult Delete(int id)
        {
            Events events = db.Events1.Find(id);
            return View(events);
        }

        //
        // POST: /Events/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Events events = db.Events1.Find(id);
            db.Events1.Remove(events);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}