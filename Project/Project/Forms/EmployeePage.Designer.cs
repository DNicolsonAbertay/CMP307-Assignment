namespace Project.Forms
{
    partial class EmployeePage
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
            Display = new Button();
            Logout = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Location = new Point(332, 49);
            Display.Name = "Display";
            Display.Size = new Size(135, 23);
            Display.TabIndex = 0;
            Display.Text = "Display Assets";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Display_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(675, 382);
            Logout.Name = "Logout";
            Logout.Size = new Size(75, 23);
            Logout.TabIndex = 1;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Logout);
            Controls.Add(Display);
            Name = "EmployeePage";
            Text = "EmployeePage";
            Load += EmployeePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Display;
        private Button Logout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}