namespace Project.Forms
{
    partial class AddEmployee
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
            Submit = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            FName = new TextBox();
            LName = new TextBox();
            Email = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            Department = new TextBox();
            Access = new TextBox();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Location = new Point(403, 435);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(236, 435);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 156);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 195);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 241);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 292);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 7;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 342);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 8;
            label7.Text = "AccessLevel";
            // 
            // FName
            // 
            FName.Location = new Point(378, 63);
            FName.Name = "FName";
            FName.Size = new Size(100, 23);
            FName.TabIndex = 9;
            // 
            // LName
            // 
            LName.Location = new Point(378, 106);
            LName.Name = "LName";
            LName.Size = new Size(100, 23);
            LName.TabIndex = 10;
            // 
            // Email
            // 
            Email.Location = new Point(378, 153);
            Email.Name = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 11;
            // 
            // Username
            // 
            Username.Location = new Point(378, 192);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 12;
            // 
            // Password
            // 
            Password.Location = new Point(378, 238);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 13;
            // 
            // Department
            // 
            Department.Location = new Point(378, 289);
            Department.Name = "Department";
            Department.Size = new Size(100, 23);
            Department.TabIndex = 14;
            // 
            // Access
            // 
            Access.Location = new Point(378, 339);
            Access.Name = "Access";
            Access.Size = new Size(100, 23);
            Access.TabIndex = 15;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(706, 530);
            Controls.Add(Access);
            Controls.Add(Department);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Email);
            Controls.Add(LName);
            Controls.Add(FName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Submit);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox FName;
        private TextBox LName;
        private TextBox Email;
        private TextBox Username;
        private TextBox Password;
        private TextBox Department;
        private TextBox Access;
    }
}