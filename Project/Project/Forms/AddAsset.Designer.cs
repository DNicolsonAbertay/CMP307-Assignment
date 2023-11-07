namespace Project.Forms
{
    partial class AddAsset
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Close = new Button();
            AutoFill = new Button();
            Submit = new Button();
            SysName = new TextBox();
            Manufacturer = new TextBox();
            Model = new TextBox();
            Type = new TextBox();
            IPAddress = new TextBox();
            AddNotes = new TextBox();
            label9 = new Label();
            Employee = new TextBox();
            Department = new TextBox();
            PurchaseDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 83);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "System Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 129);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Computer Manufacturer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 183);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Computer Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 237);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Computer Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 284);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "IP Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 337);
            label6.Name = "label6";
            label6.Size = new Size(357, 15);
            label6.TabIndex = 5;
            label6.Text = "Purchase Date: Please enter in dd/mm/yyyy format, or Unavailable";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 387);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 6;
            label7.Text = "Additional Notes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 527);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 7;
            label8.Text = "Employee Email";
            // 
            // Close
            // 
            Close.Location = new Point(165, 769);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 8;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // AutoFill
            // 
            AutoFill.Location = new Point(320, 769);
            AutoFill.Name = "AutoFill";
            AutoFill.Size = new Size(132, 23);
            AutoFill.TabIndex = 9;
            AutoFill.Text = "Add this Device";
            AutoFill.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            Submit.Location = new Point(536, 769);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 10;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // SysName
            // 
            SysName.Location = new Point(263, 80);
            SysName.Name = "SysName";
            SysName.Size = new Size(348, 23);
            SysName.TabIndex = 11;
            // 
            // Manufacturer
            // 
            Manufacturer.Location = new Point(263, 126);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(348, 23);
            Manufacturer.TabIndex = 12;
            // 
            // Model
            // 
            Model.Location = new Point(263, 180);
            Model.Name = "Model";
            Model.Size = new Size(348, 23);
            Model.TabIndex = 13;
            // 
            // Type
            // 
            Type.Location = new Point(263, 234);
            Type.Name = "Type";
            Type.Size = new Size(348, 23);
            Type.TabIndex = 14;
            // 
            // IPAddress
            // 
            IPAddress.Location = new Point(263, 281);
            IPAddress.Name = "IPAddress";
            IPAddress.Size = new Size(348, 23);
            IPAddress.TabIndex = 15;
            // 
            // AddNotes
            // 
            AddNotes.Location = new Point(263, 384);
            AddNotes.Multiline = true;
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(348, 126);
            AddNotes.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(124, 570);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 19;
            label9.Text = "Department";
            // 
            // Employee
            // 
            Employee.Location = new Point(263, 524);
            Employee.Name = "Employee";
            Employee.Size = new Size(348, 23);
            Employee.TabIndex = 20;
            // 
            // Department
            // 
            Department.Location = new Point(263, 567);
            Department.Name = "Department";
            Department.Size = new Size(348, 23);
            Department.TabIndex = 21;
            // 
            // PurchaseDate
            // 
            PurchaseDate.Location = new Point(392, 334);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(219, 23);
            PurchaseDate.TabIndex = 22;
            // 
            // AddAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 853);
            Controls.Add(PurchaseDate);
            Controls.Add(Department);
            Controls.Add(Employee);
            Controls.Add(label9);
            Controls.Add(AddNotes);
            Controls.Add(IPAddress);
            Controls.Add(Type);
            Controls.Add(Model);
            Controls.Add(Manufacturer);
            Controls.Add(SysName);
            Controls.Add(Submit);
            Controls.Add(AutoFill);
            Controls.Add(Close);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAsset";
            Text = "AddAsset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button Close;
        private Button AutoFill;
        private Button Submit;
        private TextBox SysName;
        private TextBox Manufacturer;
        private TextBox Model;
        private TextBox Type;
        private TextBox IPAddress;
        private TextBox AddNotes;
        private Label label9;
        private TextBox Employee;
        private TextBox Department;
        private TextBox PurchaseDate;
    }
}