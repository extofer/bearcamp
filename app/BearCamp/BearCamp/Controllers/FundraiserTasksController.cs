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
    public class FundraiserTasksController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /FundraiserTasks/

        public ViewResult Index()
        {
            var fundraisingtasks = db.FundraisingTasks.Include(f => f.Campaign1);
            return View(fundraisingtasks.ToList());
        }

        //
        // GET: /FundraiserTasks/Details/5

        public ViewResult Details(int id)
        {
            FundraisingTask fundraisingtask = db.FundraisingTasks.Find(id);
            return View(fundraisingtask);
        }

        //
        // GET: /FundraiserTasks/Create

        public ActionResult Create()
        {
            ViewBag.Campaign = new SelectList(db.Campaigns, "ID", "Name");
            return View();
        } 

        //
        // POST: /FundraiserTasks/Create

        [HttpPost]
        public ActionResult Create(FundraisingTask fundraisingtask)
        {
            if (ModelState.IsValid)
            {
                db.FundraisingTasks.Add(fundraisingtask);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.Campaign = new SelectList(db.Campaigns, "ID", "Name", fundraisingtask.Campaign);
            return View(fundraisingtask);
        }
        
        //
        // GET: /FundraiserTasks/Edit/5
 
        public ActionResult Edit(int id)
        {
            FundraisingTask fundraisingtask = db.FundraisingTasks.Find(id);
            ViewBag.Campaign = new SelectList(db.Campaigns, "ID", "Name", fundraisingtask.Campaign);
            return View(fundraisingtask);
        }

        //
        // POST: /FundraiserTasks/Edit/5

        [HttpPost]
        public ActionResult Edit(FundraisingTask fundraisingtask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fundraisingtask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Campaign = new SelectList(db.Campaigns, "ID", "Name", fundraisingtask.Campaign);
            return View(fundraisingtask);
        }

        //
        // GET: /FundraiserTasks/Delete/5
 
        public ActionResult Delete(int id)
        {
            FundraisingTask fundraisingtask = db.FundraisingTasks.Find(id);
            return View(fundraisingtask);
        }

        //
        // POST: /FundraiserTasks/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            FundraisingTask fundraisingtask = db.FundraisingTasks.Find(id);
            db.FundraisingTasks.Remove(fundraisingtask);
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