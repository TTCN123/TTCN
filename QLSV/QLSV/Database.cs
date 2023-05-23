using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLSV
{
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-HOANGCZ;Initial Catalog=QLSV;Integrated Security=True";
        private SqlCommand cmd;
        private DataTable dt;
        SqlConnection conn;

        public DataTable SelectData(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (cmd = new SqlCommand(sql, conn))
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

        public DataRow Select(string sql)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Err" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int Excute(string sql)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return -100;
            }
            finally { conn.Close(); }
        }
    }
}
