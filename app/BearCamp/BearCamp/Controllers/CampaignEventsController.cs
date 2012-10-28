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
    public class CampaignEventsController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /CampaignEvents/

        public ViewResult Index()
        {
            return View(db.CampaignEvents.ToList());
        }

        //
        // GET: /CampaignEvents/Details/5

        public ViewResult Details(int id)
        {
            CampaignEvent campaignevent = db.CampaignEvents.Find(id);
            return View(campaignevent);
        }

        //
        // GET: /CampaignEvents/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CampaignEvents/Create

        [HttpPost]
        public ActionResult Create(CampaignEvent campaignevent)
        {
            if (ModelState.IsValid)
            {
                db.CampaignEvents.Add(campaignevent);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(campaignevent);
        }
        
        //
        // GET: /CampaignEvents/Edit/5
 
        public ActionResult Edit(int id)
        {
            CampaignEvent campaignevent = db.CampaignEvents.Find(id);
            return View(campaignevent);
        }

        //
        // POST: /CampaignEvents/Edit/5

        [HttpPost]
        public ActionResult Edit(CampaignEvent campaignevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaignevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campaignevent);
        }

        //
        // GET: /CampaignEvents/Delete/5
 
        public ActionResult Delete(int id)
        {
            CampaignEvent campaignevent = db.CampaignEvents.Find(id);
            return View(campaignevent);
        }

        //
        // POST: /CampaignEvents/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            CampaignEvent campaignevent = db.CampaignEvents.Find(id);
            db.CampaignEvents.Remove(campaignevent);
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