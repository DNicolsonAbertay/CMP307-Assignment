using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public class Employee
    {
        public DataTable ViewEmployee()
        {
            MySqlConnection conn = new MySqlConnection("server=lochnagar.abertay.ac.uk;username=sql2101522;password=4wkBAzZ2IX2I;database=sql2101522;");
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);

            string ViewQuery = "SELECT EmployeeID, Firstname, Lastname, Email, Department, AccessLevel FROM Employee";

            MySqlCommand command = new MySqlCommand(ViewQuery, conn);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                return datatable;
            }
        }
    }
}
