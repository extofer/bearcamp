using System;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace BearCommon
{
    public class UserExport
    {

        public void ExportCSV(string filepath, string sConn)
        {
            //using System.Configuration;
            //string sConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            SqlConnection conn = new SqlConnection(sConn);

            SqlDataAdapter da = new SqlDataAdapter("select * from Donor", conn);

            DataSet ds = new DataSet();

            da.Fill(ds, "doner");

            DataTable dt = ds.Tables["doner"];

            CreateCSVFile(dt, filepath); //"c:\\csvData.csv"

        }



        private void CreateCSVFile(DataTable dt, string strFilePath)
        {

            #region Export Grid to CSV



            // Create the CSV file to which grid data will be exported.

            StreamWriter sw = new StreamWriter(strFilePath, false);

            // First we will write the headers.

            //DataTable dt = m_dsProducts.Tables[0];

            int iColCount = dt.Columns.Count;

            for (int i = 0; i < iColCount; i++)
            {

                sw.Write(dt.Columns[i]);

                if (i < iColCount - 1)
                {

                    sw.Write(",");

                }

            }

            sw.Write(sw.NewLine);

            // Now write all the rows.

            foreach (DataRow dr in dt.Rows)
            {

                for (int i = 0; i < iColCount; i++)
                {

                    if (!Convert.IsDBNull(dr[i]))
                    {

                        sw.Write(dr[i].ToString());

                    }

                    if (i < iColCount - 1)
                    {

                        sw.Write(",");

                    }

                }

                sw.Write(sw.NewLine);

            }

            sw.Close();



            #endregion

        }
    }
}
