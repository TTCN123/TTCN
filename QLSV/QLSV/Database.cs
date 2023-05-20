using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace QLSV
{   
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-HOANGCZ;Initial Catalog=QLSV;Integrated Security=True";

        public DataTable SelectData(string sql,List<CustomParameter> lstP)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

  //                  sql = "exec SelectAllSinhVien";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }

            return dt;
        }
    }
}
