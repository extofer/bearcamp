using System.Linq;
using System.Web;
using BearEF;
using BearCommon.Querries;

namespace BearCommon
{
    public class UserExport
    {
        

        public void ExportCsv()
        {
            bearcampEntities db = new bearcampEntities();
            var donors = from n in db.Donors
                         select new DonorModel
                             {
                                 DonorID = n.DonorID,
                                 FirstName = n.FirstName,
                                 LastName = n.LastName,
                                 Email = n.Email,
                                 HomePhone = n.HomePhone,
                                 BusinessPhone = n.Business_Phone,
                                 MobilePhone = n.Mobile_Phone,
                                 Address1 = n.Address1,
                                 Address2 = n.Address2,
                                 City = n.City,
                                 State = n.State,
                                 Zip = n.Zip
                             };

            var csv = donors.ToCsv();

            const string attachment = "attachment; filename=output.csv";
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ClearHeaders();
            HttpContext.Current.Response.ClearContent();
            HttpContext.Current.Response.AddHeader("content-disposition", attachment);
            HttpContext.Current.Response.ContentType = "text/csv";
            HttpContext.Current.Response.AddHeader("Pragma", "public");
            HttpContext.Current.Response.Write(csv);
            HttpContext.Current.Response.End();

        }
        
    }
}
