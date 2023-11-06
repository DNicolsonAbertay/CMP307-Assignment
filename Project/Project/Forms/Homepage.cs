using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog =mssql2101522; User ID = mssql2101522; Password = 25jC7T3rdZ";

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = connString;
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);


            string LoginQuery = "SELECT Username, Password, AccessLevel FROM ScottishGlen.Employee";

            SqlCommand command = new SqlCommand(LoginQuery);
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == Username.Text & reader[1].ToString() == Password.Text)
                {
                    if (reader[2].ToString() == "Admin")
                    {                       
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                        //this.Close();
                    }
                    else if (reader[2].ToString() == "Employee")
                    {
                        EmployeePage employeePage = new EmployeePage();
                        employeePage.Show();
                        //this.Close();
                    }
                }
            }
            conn.Close();
        }
    }
}
