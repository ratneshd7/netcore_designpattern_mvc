using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BankCore
{
    public class BankMaster
    {
        private string _name;
        private float _balance;
        private string _password;
        private string _connectionString;
        public Boolean status=false, withdraw=false;
        public BankMaster(string connectionString)
        {
            _connectionString = connectionString;
        }
        public BankMaster(string name, float balance, string password, string connectionString)
        {
            _name = name;
            _balance = balance;
            _password = password;
            _connectionString = connectionString;
        }
        
        SqlDataReader sdr = null;
        SqlTransaction transaction = null;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

       public Boolean registerUser()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();
           
            try
            {
                //SqlCommand cm = new SqlCommand("select name from bankMaster where name=@name", con);
                //cm.Parameters.AddWithValue("@name", _name);
                //sdr = cm.ExecuteReader();
                //if (sdr==null)
                //{
                //        status = true;                    
                //}
                //if (status)
                //{
                    performRegistration(con);

                //}
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
                status = false;
            }
            finally
            {
                con.Close();
            }
            return status; 
        }

        private void performRegistration(SqlConnection con)
        {
            transaction = con.BeginTransaction();
            SqlCommand cmd1 = new SqlCommand("insert into bankMaster values(@name,@balance,@password) ", con);
            cmd1.Parameters.AddWithValue("@name",_name);
            cmd1.Parameters.AddWithValue("@balance", _balance);
            cmd1.Parameters.AddWithValue("@password", _password);
            SqlCommand cmd2 = new SqlCommand("insert into bankTransaction values(@name,@amount,@types,@date) ", con);
            cmd2.Parameters.AddWithValue("@name", _name);
            cmd2.Parameters.AddWithValue("@amount", _balance);
            cmd2.Parameters.AddWithValue("@types", "D");
            cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("M/d/yyyy"));
            
            try
            {
                cmd1.Transaction = transaction;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = transaction;
                cmd2.ExecuteNonQuery();
                transaction.Commit();
                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public bool checkUser(string name)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();

            SqlCommand cm = new SqlCommand("select * from bankMaster where name=@name", con);
            cm.Parameters.AddWithValue("@name", name);
            sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                sdr.Close();
                con.Close();
                return true;
            }
            return false;
        }

        public bool authenticateUser(string name,string password)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();
            SqlCommand cm = new SqlCommand("select * from bankMaster where name=@name AND pwd=@password", con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@password", password);
            try
            {
                sdr = cm.ExecuteReader();
                while (sdr.Read())
                {

                    sdr.Close();
                    con.Close();
                    return true;
                }
                
            }
            catch (SqlException ex)
            {
                sdr.Close();
                con.Close();
            }
            return false;
        }

        public bool performDeposite(String name,String type,float amt)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();
            transaction = con.BeginTransaction();
            SqlCommand cmd1 = new SqlCommand("update bankMaster set [balance]=[balance]+@balance where [name]=@name ", con);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@balance", amt);
            SqlCommand cmd2 = new SqlCommand("insert into bankTransaction values(@name,@amount,@types,@date) ", con);
            cmd2.Parameters.AddWithValue("@name", name);
            cmd2.Parameters.AddWithValue("@amount", amt);
            cmd2.Parameters.AddWithValue("@types", type);
            cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("M/d/yyyy"));
            try
            {
                cmd1.Transaction = transaction;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = transaction;
                cmd2.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool performWithdraw(String name, String type, float amt)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();
            transaction = con.BeginTransaction();
            SqlCommand cm = new SqlCommand("select * from bankMaster where name=@name", con,transaction);
            cm.Parameters.AddWithValue("@name", name);
            
            SqlCommand cmd1 = new SqlCommand("update bankMaster set [balance]=[balance]-@balance where [name]=@name ", con);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@balance", amt);
            SqlCommand cmd2 = new SqlCommand("insert into bankTransaction values(@name,@amount,@types,@date) ", con);
            cmd2.Parameters.AddWithValue("@name", name);
            cmd2.Parameters.AddWithValue("@amount", amt);
            cmd2.Parameters.AddWithValue("@types", type);
            cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("M/d/yyyy"));

            try
            {
                sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    if (float.Parse(sdr["balance"].ToString()) - amt < 500)
                    {
                        sdr.Close();
                        transaction.Rollback();
                        con.Close();
                        withdraw = false;
                        return withdraw;
                    }
                }
                sdr.Close();
                cmd1.Transaction = transaction;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = transaction;
                cmd2.ExecuteNonQuery();
                transaction.Commit();
                withdraw = true;
            }
            catch (Exception e)
            {
                //Debug.WriteLine("");
                withdraw = false;
                transaction.Rollback();
            }
            finally
            {
                con.Close();
            }
            return withdraw;
        }
        public DataTable getPassBookData(String name, DateTime fromDate, DateTime toDate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();
            SqlCommand cm = new SqlCommand("select * from bankTransaction where(DATE BETWEEN @fromDate AND @toDate) AND name=@name ORDER BY DATE DESC", con);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@fromDate", fromDate);
            cm.Parameters.AddWithValue("@toDate", toDate);
            DataTable dt = new DataTable();
            try
            {
                sdr = cm.ExecuteReader();
               
                while (sdr.HasRows)
                {
                    dt.Load(sdr);
                }
                
            }
            catch (Exception e)
            {
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
