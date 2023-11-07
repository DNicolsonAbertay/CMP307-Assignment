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

        public void AddAssets(string sysname, string manufacturer, string model, string type, string ipAddress, string date, string AddNotes, string Department, string Employee)
        {
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog =mssql2101522; User ID = mssql2101522; Password = 25jC7T3rdZ";

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = connString;
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);

            string InsertQuery = "INSERT INTO ScottishGlen.Asset(SystemName, Manufacturer, Model, CType, ipAddress, PurchaseDate, AdditionalNotes, Employee, Department) " +
                            "VALUES(@sysname, @manufacturer, @model, @type, @ipAddress, @date, @AddNotes, @Employee, @Department)";

            SqlCommand command = new SqlCommand(InsertQuery, conn);
     
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
        }
    }
}
