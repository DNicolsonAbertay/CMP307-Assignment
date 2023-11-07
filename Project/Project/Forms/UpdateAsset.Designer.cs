namespace Project.Forms
{
    partial class UpdateAsset
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
            UpdateValue = new TextBox();
            AssetID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Close = new Button();
            checkedListBox1 = new CheckedListBox();
            Update = new Button();
            SuspendLayout();
            // 
            // UpdateValue
            // 
            UpdateValue.Location = new Point(369, 264);
            UpdateValue.Name = "UpdateValue";
            UpdateValue.Size = new Size(100, 23);
            UpdateValue.TabIndex = 15;
            // 
            // AssetID
            // 
            AssetID.Location = new Point(376, 47);
            AssetID.Name = "AssetID";
            AssetID.Size = new Size(100, 23);
            AssetID.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 267);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 13;
            label3.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 139);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 12;
            label2.Text = "Database field to be updated";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Asset ID";
            // 
            // Close
            // 
            Close.Location = new Point(376, 363);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 10;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "System Name", "Manufacturer", "Model", "C Type", "IP Address", "Purchase Date", "Additional Notes", "Employee", "Department" });
            checkedListBox1.Location = new Point(376, 83);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(114, 166);
            checkedListBox1.TabIndex = 9;
            // 
            // Update
            // 
            Update.Location = new Point(376, 319);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 8;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // UpdateAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateValue);
            Controls.Add(AssetID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Close);
            Controls.Add(checkedListBox1);
            Controls.Add(Update);
            Name = "UpdateAsset";
            Text = "UpdateAsset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UpdateValue;
        private TextBox AssetID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Close;
        private CheckedListBox checkedListBox1;
        private Button Update;
    }
}