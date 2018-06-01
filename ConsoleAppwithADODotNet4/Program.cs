using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppwithADODotNet4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("Data Source=SARIMANOK\\HYDRASERVER;Initial Catalog=School;Persist Security Info=True;User ID=SA;Password=system123")
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
                Console.ReadLine();
            }
        }
    }
}
