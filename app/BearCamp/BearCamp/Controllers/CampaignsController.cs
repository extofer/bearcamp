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
    public class CampaignsController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Campaigns/

        public ViewResult Index()
        {
            return View(db.Campaigns.ToList());
        }

        //
        // GET: /Campaigns/Details/5

        public ViewResult Details(int id)
        {
            Campaign campaign = db.Campaigns.Find(id);
            return View(campaign);
        }

        //
        // GET: /Campaigns/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Campaigns/Create

        [HttpPost]
        public ActionResult Create(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(campaign);
        }
        
        //
        // GET: /Campaigns/Edit/5
 
        public ActionResult Edit(int id)
        {
            Campaign campaign = db.Campaigns.Find(id);
            return View(campaign);
        }

        //
        // POST: /Campaigns/Edit/5

        [HttpPost]
        public ActionResult Edit(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campaign);
        }

        //
        // GET: /Campaigns/Delete/5
 
        public ActionResult Delete(int id)
        {
            Campaign campaign = db.Campaigns.Find(id);
            return View(campaign);
        }

        //
        // POST: /Campaigns/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Campaign campaign = db.Campaigns.Find(id);
            db.Campaigns.Remove(campaign);
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