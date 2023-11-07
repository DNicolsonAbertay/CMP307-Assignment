using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        Asset asset = new Asset();
        Employee employee = new Employee();

        private void EmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            DataTable datatable = asset.DisplayAssets();
            EmpAssets.DataSource = datatable;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
