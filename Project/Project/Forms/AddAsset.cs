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
    public partial class AddAsset : Form
    {
        public AddAsset()
        {
            InitializeComponent();
        }

        Asset asset = new Asset();

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Retrieve Data for insertion
            string sysName = SysName.Text;
            string manufacturer = Manufacturer.Text;
            string model = Model.Text;
            string type = Type.Text;
            string ipAddress = IPAddress.Text;
            string date = PurchaseDate.Text;
            string additionalNotes = AddNotes.Text;
            string department = Department.Text;
            string employee = Employee.Text;

            //Begin Query
            asset.AddAssets(sysName, manufacturer, model, type, ipAddress, date, additionalNotes, department, employee);
        }
    }
}
