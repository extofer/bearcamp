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
    public class FeatureController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Feature/

        public ViewResult Index()
        {
            return View(db.Features.ToList());
        }

        //
        // GET: /Feature/Details/5

        public ViewResult Details(int id)
        {
            Feature feature = db.Features.Find(id);
            return View(feature);
        }

        //
        // GET: /Feature/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Feature/Create

        [HttpPost]
        public ActionResult Create(Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Features.Add(feature);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(feature);
        }
        
        //
        // GET: /Feature/Edit/5
 
        public ActionResult Edit(int id)
        {
            Feature feature = db.Features.Find(id);
            return View(feature);
        }

        //
        // POST: /Feature/Edit/5

        [HttpPost]
        public ActionResult Edit(Feature feature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }

        //
        // GET: /Feature/Delete/5
 
        public ActionResult Delete(int id)
        {
            Feature feature = db.Features.Find(id);
            return View(feature);
        }

        //
        // POST: /Feature/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Feature feature = db.Features.Find(id);
            db.Features.Remove(feature);
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