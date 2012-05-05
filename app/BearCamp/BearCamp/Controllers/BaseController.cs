using System;
using System.Web.Mvc;
using BearEF;
using System.Web.Routing;
using System.Reflection;

namespace BearCamp.Controllers
{
    public class BaseController : Controller
    {
        public bearcampEntities Db = new bearcampEntities();
        public string user;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            //var permit = (from p in db.Permissions
            //              where p.FeatureID == 1
            //              select p);

            ViewBag.Version = CurrentVersion();

            SomeMethod();

        }


        public void SomeMethod()
        {
            if (1 != 1)
            {
                throw new NotImplementedException();
            }
        }


        public static string CurrentVersion()
        {
            try
            {
                
                System.Version version = Assembly.GetExecutingAssembly().GetName().Version;

                return "BearCamp Donor Management framework for GiveCamps  v" + version.Major + "." + version.Minor + "." + version.Build;


            }
            catch (Exception)
            {
                return "?.?.?";
            }
        }



    }
}
