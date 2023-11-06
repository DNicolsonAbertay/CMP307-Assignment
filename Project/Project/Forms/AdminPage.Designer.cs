namespace Project.Forms
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logout = new Button();
            AddAsset = new Button();
            UpdateAsset = new Button();
            DeleteAsset = new Button();
            ViewAsset = new Button();
            AdminAssets = new DataGridView();
            EmployeesData = new DataGridView();
            ViewEmployees = new Button();
            DeleteEmployee = new Button();
            UpdateEmployee = new Button();
            AddEmployees = new Button();
            ((System.ComponentModel.ISupportInitialize)AdminAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesData).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.Location = new Point(48, 383);
            Logout.Name = "Logout";
            Logout.Size = new Size(124, 23);
            Logout.TabIndex = 0;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // AddAsset
            // 
            AddAsset.Location = new Point(48, 73);
            AddAsset.Name = "AddAsset";
            AddAsset.Size = new Size(124, 23);
            AddAsset.TabIndex = 1;
            AddAsset.Text = "Add Asset";
            AddAsset.UseVisualStyleBackColor = true;
            AddAsset.Click += AddAsset_Click;
            // 
            // UpdateAsset
            // 
            UpdateAsset.Location = new Point(48, 102);
            UpdateAsset.Name = "UpdateAsset";
            UpdateAsset.Size = new Size(124, 23);
            UpdateAsset.TabIndex = 2;
            UpdateAsset.Text = "Update Asset";
            UpdateAsset.UseVisualStyleBackColor = true;
            // 
            // DeleteAsset
            // 
            DeleteAsset.Location = new Point(48, 131);
            DeleteAsset.Name = "DeleteAsset";
            DeleteAsset.Size = new Size(124, 23);
            DeleteAsset.TabIndex = 3;
            DeleteAsset.Text = "Delete Asset";
            DeleteAsset.UseVisualStyleBackColor = true;
            DeleteAsset.Click += DeleteAsset_Click;
            // 
            // ViewAsset
            // 
            ViewAsset.Location = new Point(48, 44);
            ViewAsset.Name = "ViewAsset";
            ViewAsset.Size = new Size(124, 23);
            ViewAsset.TabIndex = 4;
            ViewAsset.Text = "View Assets";
            ViewAsset.UseVisualStyleBackColor = true;
            ViewAsset.Click += ViewAsset_Click;
            // 
            // AdminAssets
            // 
            AdminAssets.Location = new Point(212, 44);
            AdminAssets.Name = "AdminAssets";
            AdminAssets.Size = new Size(576, 150);
            AdminAssets.TabIndex = 11;
            // 
            // EmployeesData
            // 
            EmployeesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesData.Location = new Point(212, 213);
            EmployeesData.Name = "EmployeesData";
            EmployeesData.RowTemplate.Height = 25;
            EmployeesData.Size = new Size(576, 163);
            EmployeesData.TabIndex = 10;
            // 
            // ViewEmployees
            // 
            ViewEmployees.Location = new Point(48, 213);
            ViewEmployees.Name = "ViewEmployees";
            ViewEmployees.Size = new Size(124, 23);
            ViewEmployees.TabIndex = 9;
            ViewEmployees.Text = "View Employees";
            ViewEmployees.UseVisualStyleBackColor = true;
            ViewEmployees.Click += ViewEmployees_Click;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Location = new Point(48, 300);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(124, 23);
            DeleteEmployee.TabIndex = 8;
            DeleteEmployee.Text = "Delete Employee";
            DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // UpdateEmployee
            // 
            UpdateEmployee.Location = new Point(48, 271);
            UpdateEmployee.Name = "UpdateEmployee";
            UpdateEmployee.Size = new Size(124, 23);
            UpdateEmployee.TabIndex = 7;
            UpdateEmployee.Text = "Update Employee";
            UpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployees
            // 
            AddEmployees.Location = new Point(48, 242);
            AddEmployees.Name = "AddEmployees";
            AddEmployees.Size = new Size(124, 23);
            AddEmployees.TabIndex = 6;
            AddEmployees.Text = "Add Employee";
            AddEmployees.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmployeesData);
            Controls.Add(ViewEmployees);
            Controls.Add(DeleteEmployee);
            Controls.Add(UpdateEmployee);
            Controls.Add(AddEmployees);
            Controls.Add(AdminAssets);
            Controls.Add(ViewAsset);
            Controls.Add(DeleteAsset);
            Controls.Add(UpdateAsset);
            Controls.Add(AddAsset);
            Controls.Add(Logout);
            Name = "AdminPage";
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)AdminAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Logout;
        private Button AddAsset;
        private Button UpdateAsset;
        private Button DeleteAsset;
        private Button ViewAsset;
        private DataGridView AdminAssets;
        private DataGridView EmployeesData;
        private Button ViewEmployees;
        private Button DeleteEmployee;
        private Button UpdateEmployee;
        private Button AddEmployees;
    }
}