using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project.Forms
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

        }

        Asset asset = new Asset();
        Employee employee = new Employee();

        private void ViewAsset_Click(object sender, EventArgs e)
        {
            DataTable Assets = asset.DisplayAssets();
            AdminAssets.DataSource = Assets;
        }

        private void AddAsset_Click(object sender, EventArgs e)
        {
            AddAsset addAsset = new AddAsset();
            addAsset.Show();
        }

        private void ViewEmployees_Click(object sender, EventArgs e)
        {
            DataTable Employees = employee.ViewEmployee();
            EmployeesData.DataSource = Employees;
        }

        private void DeleteAsset_Click(object sender, EventArgs e)
        {
            DeleteAsset deleteAsset = new DeleteAsset();
            deleteAsset.Show();
        }
    }
}
