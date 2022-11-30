
namespace RangaHardwareStock
{
    partial class ResetPasswordForm
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
            this.resetPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetPasswordLabel
            // 
            this.resetPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPasswordLabel.BackColor = System.Drawing.Color.White;
            this.resetPasswordLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resetPasswordLabel.Location = new System.Drawing.Point(112, 55);
            this.resetPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Size = new System.Drawing.Size(658, 100);
            this.resetPasswordLabel.TabIndex = 11;
            this.resetPasswordLabel.Text = "RESET PASSWORD";
            this.resetPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(204, 235);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(475, 34);
            this.currentPasswordTextBox.TabIndex = 10;
            this.currentPasswordTextBox.Tag = "";
            this.currentPasswordTextBox.Text = "Current Password";
            this.currentPasswordTextBox.Enter += new System.EventHandler(this.currentPasswordTextBox_Enter);
            this.currentPasswordTextBox.Leave += new System.EventHandler(this.currentPasswordTextBox_Leave);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resetPasswordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.resetPasswordButton.Location = new System.Drawing.Point(204, 445);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(475, 48);
            this.resetPasswordButton.TabIndex = 9;
            this.resetPasswordButton.Text = "Reset Password";
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(204, 195);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(475, 34);
            this.UsernameTextBox.TabIndex = 8;
            this.UsernameTextBox.Tag = "";
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // newPasswordTextBox1
            // 
            this.newPasswordTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.newPasswordTextBox1.Location = new System.Drawing.Point(204, 320);
            this.newPasswordTextBox1.Name = "newPasswordTextBox1";
            this.newPasswordTextBox1.Size = new System.Drawing.Size(475, 34);
            this.newPasswordTextBox1.TabIndex = 13;
            this.newPasswordTextBox1.Tag = "";
            this.newPasswordTextBox1.Text = "New Password";
            this.newPasswordTextBox1.Enter += new System.EventHandler(this.newPasswordTextBox1_Enter);
            this.newPasswordTextBox1.Leave += new System.EventHandler(this.newPasswordTextBox1_Leave);
            // 
            // newPasswordTextBox2
            // 
            this.newPasswordTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.newPasswordTextBox2.Location = new System.Drawing.Point(204, 360);
            this.newPasswordTextBox2.Name = "newPasswordTextBox2";
            this.newPasswordTextBox2.Size = new System.Drawing.Size(475, 34);
            this.newPasswordTextBox2.TabIndex = 14;
            this.newPasswordTextBox2.Tag = "";
            this.newPasswordTextBox2.Text = "Re Enter New Password";
            this.newPasswordTextBox2.Enter += new System.EventHandler(this.newPasswordTextBox2_Enter);
            this.newPasswordTextBox2.Leave += new System.EventHandler(this.newPasswordTextBox2_Leave);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(737, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 47);
            this.ExitButton.TabIndex = 253;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.newPasswordTextBox2);
            this.Controls.Add(this.newPasswordTextBox1);
            this.Controls.Add(this.resetPasswordLabel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.UsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ResetPasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranga Hardware Stock Management / Login / Reset Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResetPasswordForm_FormClosed);
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resetPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox1;
        private System.Windows.Forms.TextBox newPasswordTextBox2;
        private System.Windows.Forms.Button ExitButton;
    }
}