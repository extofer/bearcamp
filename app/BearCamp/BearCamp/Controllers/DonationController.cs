using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BearEF;
using BearCommon;

namespace BearCamp.Controllers
{ 
    public class DonationController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /Donation/

        public ViewResult Index()
        {
            if (db.Donations != null)
            {
                return View(db.Donations.ToList());

            }
        }

        //
        // GET: /Donation/Details/5

        public ViewResult Details(int id)
        {
            Donation donation = db.Donations.Find(id);
            return View(donation);
        }

        //
        // GET: /Donation/Create

        public ActionResult Create()
        {
            ViewBag.DonationType = new SelectList(db.DonationTypeIDs, "DonationTypeID1", "DonationDesc");
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "FastName");
            return View();
        }


        public ActionResult ExportDonations()
        {
            if (ModelState.IsValid)
            {
                var export = new DonationsExport();
                //string sConn = ConfigurationManager.ConnectionStrings["export2csvConn"].ToString();

                export.ExportCsv();


                //db.Users.Add(user);
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }

            return Redirect("/Donors"); //View(db.Users.ToList());
        }

        //
        // POST: /Donation/Create

        [HttpPost]
        public ActionResult Create(Donation donation)
        {
            if (ModelState.IsValid)
            {
                db.Donations.Add(donation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.DonationType = new SelectList(db.DonationTypeIDs, "DonationTypeID1", "DonationDesc", donation.DonationType);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "FastName", donation.DonorID);
            return View(donation);
        }
        
        //
        // GET: /Donation/Edit/5
 
        public ActionResult Edit(int id)
        {
            Donation donation = db.Donations.Find(id);
            ViewBag.DonationType = new SelectList(db.DonationTypeIDs, "DonationTypeID1", "DonationDesc", donation.DonationType);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "FastName", donation.DonorID);
            return View(donation);
        }

        //
        // POST: /Donation/Edit/5

        [HttpPost]
        public ActionResult Edit(Donation donation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DonationType = new SelectList(db.DonationTypeIDs, "DonationTypeID1", "DonationDesc", donation.DonationType);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "FastName", donation.DonorID);
            return View(donation);
        }

        //
        // GET: /Donation/Delete/5
 
        public ActionResult Delete(int id)
        {
            Donation donation = db.Donations.Find(id);
            return View(donation);
        }

        //
        // POST: /Donation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Donation donation = db.Donations.Find(id);
            db.Donations.Remove(donation);
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