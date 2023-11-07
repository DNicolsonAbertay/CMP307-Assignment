using MySql.Data.MySqlClient;
using Project.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Asset
    {
        public DataTable DisplayAssets()
        {
            MySqlConnection conn = new MySqlConnection("server=lochnagar.abertay.ac.uk;username=sql2101522;password=4wkBAzZ2IX2I;database=sql2101522;");
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);

            string ViewQuery = "SELECT * FROM Asset";

            MySqlCommand command = new MySqlCommand(ViewQuery);
            command.Connection = conn;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                return datatable;
            }
        }

        public void AddAssets(string sysname, string manufacturer, string model, string type, string ipAddress, string date, string AddNotes, string Department, string Employee)
        {
            MySqlConnection conn = new MySqlConnection("server=lochnagar.abertay.ac.uk;username=sql2101522;password=4wkBAzZ2IX2I;database=sql2101522;");
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);

            string InsertQuery = "INSERT INTO Asset(SystemName, Manufacturer, Model, CType, ipAddress, PurchaseDate, AdditionalNotes, Employee, Department) " +
                            "VALUES(@sysname, @manufacturer, @model, @type, @ipAddress, @date, @AddNotes, @Employee, @Department)";

            MySqlCommand command = new MySqlCommand(InsertQuery, conn);
     
            command.Parameters.AddWithValue("@sysname", sysname);
            command.Parameters.AddWithValue("@manufacturer", manufacturer);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@ipAddress", ipAddress);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@AddNotes", AddNotes);
            command.Parameters.AddWithValue("@Department", Department);
            command.Parameters.AddWithValue("@Employee", Employee);

            int rowsaffected = command.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                System.Windows.Forms.MessageBox.Show("Data Inserted Successfully");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error, Please try again or Contact IT");
            }
            conn.Close();
        }
    }
}
