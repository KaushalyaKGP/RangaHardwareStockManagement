
namespace RangaHardwareStock
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.Title1label = new System.Windows.Forms.Label();
            this.Title2label = new System.Windows.Forms.Label();
            this.CurrentStockButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title1label
            // 
            this.Title1label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title1label.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Title1label.Location = new System.Drawing.Point(117, 52);
            this.Title1label.Name = "Title1label";
            this.Title1label.Size = new System.Drawing.Size(644, 139);
            this.Title1label.TabIndex = 0;
            this.Title1label.Text = "Welcome !";
            this.Title1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title2label
            // 
            this.Title2label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title2label.BackColor = System.Drawing.Color.Transparent;
            this.Title2label.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2label.Location = new System.Drawing.Point(187, 207);
            this.Title2label.Margin = new System.Windows.Forms.Padding(0);
            this.Title2label.Name = "Title2label";
            this.Title2label.Size = new System.Drawing.Size(504, 375);
            this.Title2label.TabIndex = 1;
            this.Title2label.Text = "Ranga\r\nHardware\r\nStock\r\nManagement";
            this.Title2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentStockButton
            // 
            this.CurrentStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CurrentStockButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockButton.ForeColor = System.Drawing.Color.White;
            this.CurrentStockButton.Location = new System.Drawing.Point(271, 615);
            this.CurrentStockButton.Name = "CurrentStockButton";
            this.CurrentStockButton.Size = new System.Drawing.Size(336, 88);
            this.CurrentStockButton.TabIndex = 2;
            this.CurrentStockButton.Text = "View Current Stock";
            this.CurrentStockButton.UseVisualStyleBackColor = false;
            this.CurrentStockButton.Click += new System.EventHandler(this.CurrentStockButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(271, 722);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(336, 88);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 849);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CurrentStockButton);
            this.Controls.Add(this.Title2label);
            this.Controls.Add(this.Title1label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranga Hardware Stock Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IndexForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title1label;
        private System.Windows.Forms.Label Title2label;
        private System.Windows.Forms.Button CurrentStockButton;
        private System.Windows.Forms.Button LoginButton;
    }
}