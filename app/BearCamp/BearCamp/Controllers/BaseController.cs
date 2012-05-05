using System.Web.Mvc;
using BearEF;
using System.Web.Routing;

namespace BearCamp.Controllers
{
    public class BaseController : Controller
    {
        public bearcampEntities Db = new bearcampEntities();
        public string user;


     //   protected override void Initialize(RequestContext requestContext)
       // {

            //var permit = (from p in db.Permissions
            //              where p.FeatureID == 1
            //              select p);


      //  }

    }
}
