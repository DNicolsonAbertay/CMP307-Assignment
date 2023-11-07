using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
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
            MySqlConnection conn = new MySqlConnection("server=lochnagar.abertay.ac.uk;username=sql2101522;password=4wkBAzZ2IX2I;database=sql2101522;");
            conn.Open();

            Console.WriteLine("State: {0}", conn.State);
            Console.WriteLine("Connection String: {0}", conn.ConnectionString);


            string LoginQuery = "SELECT Username, Password, AccessLevel FROM Employee";

            MySqlCommand command = new MySqlCommand(LoginQuery);
            command.Connection = conn;

            MySqlDataReader reader = command.ExecuteReader();
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
