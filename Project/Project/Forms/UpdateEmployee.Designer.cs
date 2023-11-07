namespace Project.Forms
{
    partial class UpdateEmployee
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
            Update = new Button();
            checkedListBox1 = new CheckedListBox();
            Close = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmployeeID = new TextBox();
            UpdateValue = new TextBox();
            SuspendLayout();
            // 
            // Update
            // 
            Update.Location = new Point(365, 309);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 0;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Firstname", "Lastname", "Email", "Username", "Password", "Department", "AccessLevel" });
            checkedListBox1.Location = new Point(365, 73);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(93, 130);
            checkedListBox1.TabIndex = 1;
            // 
            // Close
            // 
            Close.Location = new Point(365, 353);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 2;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 129);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 4;
            label2.Text = "Database field to be updated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 239);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Value";
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(365, 37);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(100, 23);
            EmployeeID.TabIndex = 6;
            // 
            // UpdateValue
            // 
            UpdateValue.Location = new Point(358, 236);
            UpdateValue.Name = "UpdateValue";
            UpdateValue.Size = new Size(100, 23);
            UpdateValue.TabIndex = 7;
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateValue);
            Controls.Add(EmployeeID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Close);
            Controls.Add(checkedListBox1);
            Controls.Add(Update);
            Name = "UpdateEmployee";
            Text = "UpdateEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Update;
        private CheckedListBox checkedListBox1;
        private Button Close;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmployeeID;
        private TextBox UpdateValue;
    }
}