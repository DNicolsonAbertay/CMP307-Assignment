using Project.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Asset
    {
        public DataTable DisplayAssets()
        {
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog =mssql2101522; User ID = mssql2101522; Password = 25jC7T3rdZ";

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = connString;
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);

            string ViewQuery = "SELECT * FROM ScottishGlen.Asset";

            SqlCommand command = new SqlCommand(ViewQuery);
            command.Connection = conn;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                return datatable;
            }
        }
    }
}
