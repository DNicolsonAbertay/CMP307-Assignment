namespace Project.Forms
{
    partial class DeleteEmployee
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
            Delete = new Button();
            label1 = new Label();
            EmployeeID = new TextBox();
            Close = new Button();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new Point(311, 288);
            Delete.Name = "Delete";
            Delete.Size = new Size(145, 23);
            Delete.TabIndex = 0;
            Delete.Text = "Delete Employee";
            Delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 202);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee ID";
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(392, 199);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(100, 23);
            EmployeeID.TabIndex = 2;
            // 
            // Close
            // 
            Close.Location = new Point(342, 334);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 3;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(Close);
            Controls.Add(EmployeeID);
            Controls.Add(label1);
            Controls.Add(Delete);
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete;
        private Label label1;
        private TextBox EmployeeID;
        private Button Close;
    }
}