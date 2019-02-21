namespace RSSReader.Forms
{
    partial class ThemeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeDialog));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.folderIDLabel = new System.Windows.Forms.Label();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.themeIDTextBox = new System.Windows.Forms.TextBox();
            this.themeNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(205, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 202);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // folderIDLabel
            // 
            this.folderIDLabel.AutoSize = true;
            this.folderIDLabel.Location = new System.Drawing.Point(13, 41);
            this.folderIDLabel.Name = "folderIDLabel";
            this.folderIDLabel.Size = new System.Drawing.Size(57, 13);
            this.folderIDLabel.TabIndex = 2;
            this.folderIDLabel.Text = "Theme ID:";
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(13, 71);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(74, 13);
            this.folderNameLabel.TabIndex = 3;
            this.folderNameLabel.Text = "Theme Name:";
            // 
            // themeIDTextBox
            // 
            this.themeIDTextBox.Location = new System.Drawing.Point(103, 41);
            this.themeIDTextBox.Name = "themeIDTextBox";
            this.themeIDTextBox.ReadOnly = true;
            this.themeIDTextBox.Size = new System.Drawing.Size(177, 20);
            this.themeIDTextBox.TabIndex = 4;
            // 
            // themeNameTextBox
            // 
            this.themeNameTextBox.Location = new System.Drawing.Point(103, 71);
            this.themeNameTextBox.Name = "themeNameTextBox";
            this.themeNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.themeNameTextBox.TabIndex = 5;
            // 
            // ThemeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 237);
            this.Controls.Add(this.themeNameTextBox);
            this.Controls.Add(this.themeIDTextBox);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.folderIDLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemeDialog";
            this.Text = "Theme properties";
            this.Load += new System.EventHandler(this.themeDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label folderIDLabel;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.TextBox themeIDTextBox;
        private System.Windows.Forms.TextBox themeNameTextBox;
    }
}