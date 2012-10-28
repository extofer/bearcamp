using System.Linq;
using System.Web;
using BearEF;
using BearCommon.Querries;


namespace BearCommon
{
    public class DonationsExport
    {

        public void ExportCsv()
        {
            bearcampEntities db = new bearcampEntities();

            var donations = from n in db.Donations
                            select new DonationsModel
                                {
                                    DonationsID = n.DonationsID,
                                    DonorID = n.DonorID,
                                    DonationAmount = n.DonationAmount,
                                    DonationsDate = n.DonationDate,
                                    Comments = n.Comments
                                };
            
            var csv = donations.ToCsv();

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
