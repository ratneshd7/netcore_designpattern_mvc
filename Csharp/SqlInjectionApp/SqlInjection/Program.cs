using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            var connnectionString = ConfigurationManager.ConnectionStrings["DeptDetails"].ConnectionString;
            con.ConnectionString = connnectionString;
            con.Open();
                      
            Console.WriteLine("Enter Department No");
            var deptNo=Console.ReadLine();
            
            try
            {
                //SqlCommand cm = new SqlCommand("select * from DEPT where DEPTNO="+ deptNo, con); pass value with sql injection like 10 or 1=1
                SqlCommand cm = new SqlCommand("select * from DEPT where DEPTNO=@deptNo", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@deptNo";
                param.Value = deptNo;
                cm.Parameters.Add(param);

                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["DEPTNO"] + " " + sdr["DNAME"]+" " +sdr["LOC"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
