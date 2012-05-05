using System.Web;
using BearEF;


namespace BearCommon
{
    public class UserExport
    {
        private readonly bearcampEntities _db = new bearcampEntities();

        public void ExportCsv()
        {
            var donors = _db.Donors;
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
