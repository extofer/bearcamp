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
    public class DonorsController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Donors/

        public ViewResult Index()
        {
            return View(db.Donors.ToList());
        }

        //
        // GET: /Donors/Details/5

        public ViewResult Details(int id)
        {
            Donor donor = db.Donors.Find(id);
            return View(donor);
        }

        //
        // GET: /Donors/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Donors/Create

        [HttpPost]
        public ActionResult Create(Donor donor)
        {
            if (ModelState.IsValid)
            {
                db.Donors.Add(donor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(donor);
        }
        
        //
        // GET: /Donors/Edit/5
 
        public ActionResult Edit(int id)
        {
            Donor donor = db.Donors.Find(id);
            return View(donor);
        }

        //
        // POST: /Donors/Edit/5

        [HttpPost]
        public ActionResult Edit(Donor donor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donor);
        }

        //
        // GET: /Donors/Delete/5
 
        public ActionResult Delete(int id)
        {
            Donor donor = db.Donors.Find(id);
            return View(donor);
        }

        //
        // POST: /Donors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Donor donor = db.Donors.Find(id);
            db.Donors.Remove(donor);
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