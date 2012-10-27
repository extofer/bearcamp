using System.Data;
using System.Linq;
using System.Web.Mvc;
using BearEF;
using System.Configuration;
using BearCommon;

namespace BearCamp.Controllers
{
    public class DonorsController : BaseController
    {

        //
        // GET: /Donors/
        [Authorize]
        public ViewResult Index()
        {
            return View(Db.Donors.ToList());
        }

        //
        // GET: /Donors/Details/5
        [Authorize]
        public ViewResult Details(int id)
        {
            Donor donor = Db.Donors.Find(id);
            return View(donor);
        }

        //
        // GET: /Donors/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult ExportUsers()
        {
            if (ModelState.IsValid)
            {
                var export = new UserExport();
                //string sConn = ConfigurationManager.ConnectionStrings["export2csvConn"].ToString();

                export.ExportCsv();


                //db.Users.Add(user);
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }

            return Redirect("/Donors"); //View(db.Users.ToList());
        }
    
        //
        // POST: /Donors/Create


        [HttpPost]
        public ActionResult Create(Donor donor)
        {
            if (ModelState.IsValid)
            {
                Db.Donors.Add(donor);
                Db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(donor);
        }
        
        //
        // GET: /Donors/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            Donor donor = Db.Donors.Find(id);
            return View(donor);
        }

        //
        // POST: /Donors/Edit/5

        [HttpPost]
        public ActionResult Edit(Donor donor)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(donor).State = EntityState.Modified;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donor);
        }

        //
        // GET: /Donors/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            Donor donor = Db.Donors.Find(id);
            return View(donor);
        }

        //
        // POST: /Donors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Donor donor = Db.Donors.Find(id);
            Db.Donors.Remove(donor);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            Db.Dispose();
            base.Dispose(disposing);
        }
    }
}