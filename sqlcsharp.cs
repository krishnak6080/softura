using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace KonsoleApp
{
    internal class sqlcsharp
    {
        public void insData(string name, DateTime date, string city)
        {
            SqlConnection con = new SqlConnection("Data source = KRISHNA; initial catalog = Test; integrated security = true");
            SqlCommand cmd = new SqlCommand("sp_insBable", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@sdate", date);
            cmd.Parameters.AddWithValue("@city", city);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");
        }
        public static void Main()
        {
            dataa1 dat1 = new dataa1();
            dat1.insData("benn", DateTime.Now, "bangalore");
        }
    }
}
