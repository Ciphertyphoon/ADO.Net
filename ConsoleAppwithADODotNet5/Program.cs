using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppwithADODotNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=SARIMANOK\\HYDRASERVER;Initial Catalog=School;Persist Security Info=True;User ID=SA;Password=system123");
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {   // Closing the connection  
                con.Close();
            }
        }
    }
}
