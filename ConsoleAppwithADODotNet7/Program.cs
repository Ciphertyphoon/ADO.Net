using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppwithADODotNet7
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().GetData();
        }
        public void GetData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=SARIMANOK\\HYDRASERVER;Initial Catalog=School;Persist Security Info=True;User ID=SA;Password=system123");
                // writing sql query  
                SqlCommand cm = new SqlCommand("select * from student", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
