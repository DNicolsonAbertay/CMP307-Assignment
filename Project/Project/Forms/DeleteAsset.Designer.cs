namespace Project.Forms
{
    partial class DeleteAsset
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
            AssetID = new TextBox();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new Point(209, 188);
            Delete.Name = "Delete";
            Delete.Size = new Size(124, 23);
            Delete.TabIndex = 0;
            Delete.Text = "Delete Asset";
            Delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 108);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Asset ID";
            // 
            // AssetID
            // 
            AssetID.Location = new Point(274, 105);
            AssetID.Name = "AssetID";
            AssetID.Size = new Size(100, 23);
            AssetID.TabIndex = 2;
            // 
            // DeleteAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(553, 291);
            Controls.Add(AssetID);
            Controls.Add(label1);
            Controls.Add(Delete);
            Name = "DeleteAsset";
            Text = "DeleteAsset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete;
        private Label label1;
        private TextBox AssetID;
    }
}