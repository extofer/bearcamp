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
    public class PermissionController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Permission/

        public ViewResult Index()
        {
            var permissions = db.Permissions.Include(p => p.Feature).Include(p => p.User);
            return View(permissions.ToList());
        }

        //
        // GET: /Permission/Details/5

        public ViewResult Details(int id)
        {
            Permission permission = db.Permissions.Find(id);
            return View(permission);
        }

        //
        // GET: /Permission/Create

        public ActionResult Create()
        {
            ViewBag.FeatureID = new SelectList(db.Features, "FeatureID", "FeatureName");
            ViewBag.UserLogin = new SelectList(db.Users, "UserLogin", "Pswd");
            return View();
        } 

        //
        // POST: /Permission/Create

        [HttpPost]
        public ActionResult Create(Permission permission)
        {
            if (ModelState.IsValid)
            {
                db.Permissions.Add(permission);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.FeatureID = new SelectList(db.Features, "FeatureID", "FeatureName", permission.FeatureID);
            ViewBag.UserLogin = new SelectList(db.Users, "UserLogin", "Pswd", permission.UserLogin);
            return View(permission);
        }
        
        //
        // GET: /Permission/Edit/5
 
        public ActionResult Edit(int id)
        {
            Permission permission = db.Permissions.Find(id);
            ViewBag.FeatureID = new SelectList(db.Features, "FeatureID", "FeatureName", permission.FeatureID);
            ViewBag.UserLogin = new SelectList(db.Users, "UserLogin", "Pswd", permission.UserLogin);
            return View(permission);
        }

        //
        // POST: /Permission/Edit/5

        [HttpPost]
        public ActionResult Edit(Permission permission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FeatureID = new SelectList(db.Features, "FeatureID", "FeatureName", permission.FeatureID);
            ViewBag.UserLogin = new SelectList(db.Users, "UserLogin", "Pswd", permission.UserLogin);
            return View(permission);
        }

        //
        // GET: /Permission/Delete/5
 
        public ActionResult Delete(int id)
        {
            Permission permission = db.Permissions.Find(id);
            return View(permission);
        }

        //
        // POST: /Permission/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Permission permission = db.Permissions.Find(id);
            db.Permissions.Remove(permission);
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