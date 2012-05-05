using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BearEF;
using System.Web.Routing;

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

            SomeMethod();

        }


        public void SomeMethod()
        {
            if (1 != 1)
            {
                throw new NotImplementedException();
            }
        }


    }
}
