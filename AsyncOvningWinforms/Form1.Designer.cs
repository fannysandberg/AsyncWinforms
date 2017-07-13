namespace AsyncOvningWinforms
{
    partial class Form1
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
            this.oneWebsiteButton = new System.Windows.Forms.Button();
            this.multipleWebsitesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneWebsiteButton
            // 
            this.oneWebsiteButton.Location = new System.Drawing.Point(44, 29);
            this.oneWebsiteButton.Name = "oneWebsiteButton";
            this.oneWebsiteButton.Size = new System.Drawing.Size(182, 38);
            this.oneWebsiteButton.TabIndex = 0;
            this.oneWebsiteButton.Text = "One Website";
            this.oneWebsiteButton.UseVisualStyleBackColor = true;
            this.oneWebsiteButton.Click += new System.EventHandler(this.oneWebsiteButton_Click);
            // 
            // multipleWebsitesBtn
            // 
            this.multipleWebsitesBtn.Location = new System.Drawing.Point(44, 115);
            this.multipleWebsitesBtn.Name = "multipleWebsitesBtn";
            this.multipleWebsitesBtn.Size = new System.Drawing.Size(182, 39);
            this.multipleWebsitesBtn.TabIndex = 1;
            this.multipleWebsitesBtn.Text = "Multiple Websites";
            this.multipleWebsitesBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.multipleWebsitesBtn);
            this.Controls.Add(this.oneWebsiteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oneWebsiteButton;
        private System.Windows.Forms.Button multipleWebsitesBtn;
    }
}

