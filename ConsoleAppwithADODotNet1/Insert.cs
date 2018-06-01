using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppwithADODotNet
{
    class Insert
    {
        static void Main(string[] args)
        {
            new Insert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=SARIMANOK\\HYDRASERVER;Initial Catalog=School;Persist Security Info=True;User ID=SA;Password=system123");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into Student(id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017'), ('102', 'Hillary Clinton', 'hillary@example.com', '1/24/2017')", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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
