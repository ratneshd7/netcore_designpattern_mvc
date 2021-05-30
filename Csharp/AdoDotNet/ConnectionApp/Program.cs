using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DeptDetails"].ConnectionString;
            con.Open();

            Console.WriteLine("Database Name:" + con.Database);
            Console.WriteLine("Server Name:" + con.DataSource);
            Console.WriteLine("ConnectionTimeout:" + con.ConnectionTimeout);
            Console.WriteLine("Status:" + con.State);
            //con.Close();
            //Console.WriteLine("Status:" + con.State);
            SqlDataReader sdr = null;
            try
            {
                //    con.ConnectionString = ConfigurationManager.ConnectionStrings["DeptDetails"].ConnectionString;
                //    con.Open();
                SqlCommand cm = new SqlCommand("select * from REGIONS", con);
                sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["region_id"] + " "  + sdr["region_name"]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
                Console.WriteLine("Status:" + con.State);
            }
        }
    }
}
