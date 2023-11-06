namespace Project.Forms
{
    partial class Homepage
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
            Login = new Button();
            label1 = new Label();
            label2 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(309, 272);
            Login.Name = "Login";
            Login.Size = new Size(153, 23);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 115);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 152);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(399, 112);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(399, 149);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 4;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "Homepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private Label label2;
        private TextBox Username;
        private TextBox Password;
    }
}