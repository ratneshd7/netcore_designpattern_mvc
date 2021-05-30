using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TransactionDetails"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();

            SqlTransaction transaction=null;
            try
            {
                transaction = con.BeginTransaction();
                SqlCommand cmd1 = new SqlCommand("update merchant set m_balance = m_balance + 5000 where merchant_id = 'M01'", con);

                SqlCommand cmd2 = new SqlCommand("update customer set c_balance = c_balance - 5000 where customer_id = 'C01'", con);

                cmd1.Transaction = transaction;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = transaction;
                cmd2.ExecuteNonQuery();
                transaction.Commit();
                SqlCommand cmd3= new SqlCommand("select * from customer ", con);
                SqlDataReader sdr = cmd3.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["customer_id"] + " " + sdr["c_name"] + " " + sdr["c_balance"]);
                }
            }
            catch (SqlException sqlError)
            {
                if(transaction!=null)
                transaction.Rollback();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
