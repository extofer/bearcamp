using System.Data;
using System.Linq;
using System.Web.Mvc;
using BearEF;

namespace BearCamp.Controllers
{ 
    public class DonationTypeController : Controller
    {
        private bearcampEntities db = new bearcampEntities();

        //
        // GET: /DonationType/

        public ViewResult Index()
        {
            return View(db.DonationTypeIDs.ToList());
        }

        //
        // GET: /DonationType/Details/5

        public ViewResult Details(int id)
        {
            DonationTypeID donationtypeid = db.DonationTypeIDs.Find(id);
            return View(donationtypeid);
        }

        //
        // GET: /DonationType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DonationType/Create

        [HttpPost]
        public ActionResult Create(DonationTypeID donationtypeid)
        {
            if (ModelState.IsValid)
            {
                db.DonationTypeIDs.Add(donationtypeid);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(donationtypeid);
        }
        
        //
        // GET: /DonationType/Edit/5
 
        public ActionResult Edit(int id)
        {
            DonationTypeID donationtypeid = db.DonationTypeIDs.Find(id);
            return View(donationtypeid);
        }

        //
        // POST: /DonationType/Edit/5

        [HttpPost]
        public ActionResult Edit(DonationTypeID donationtypeid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donationtypeid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donationtypeid);
        }

        //
        // GET: /DonationType/Delete/5
 
        public ActionResult Delete(int id)
        {
            DonationTypeID donationtypeid = db.DonationTypeIDs.Find(id);
            return View(donationtypeid);
        }

        //
        // POST: /DonationType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            DonationTypeID donationtypeid = db.DonationTypeIDs.Find(id);
            db.DonationTypeIDs.Remove(donationtypeid);
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