
namespace RangaHardwareStock
{
    partial class CustomerForm
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
            System.Windows.Forms.Label EmailLabel;
            System.Windows.Forms.Label SupplierCustomerLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label CustomerIDLabel;
            this.SaveUpdateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactNoTextBox = new System.Windows.Forms.TextBox();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedRecordButton = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            EmailLabel = new System.Windows.Forms.Label();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            CustomerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EmailLabel.Location = new System.Drawing.Point(551, 270);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(64, 20);
            EmailLabel.TabIndex = 202;
            EmailLabel.Text = "Email :";
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(41, 207);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(87, 20);
            SupplierCustomerLabel.TabIndex = 192;
            SupplierCustomerLabel.Text = "Address :";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameLabel.Location = new System.Drawing.Point(366, 142);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(66, 20);
            NameLabel.TabIndex = 191;
            NameLabel.Text = "Name :";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomerIDLabel.Location = new System.Drawing.Point(41, 142);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new System.Drawing.Size(120, 20);
            CustomerIDLabel.TabIndex = 190;
            CustomerIDLabel.Text = "Customer ID :";
            // 
            // SaveUpdateButton
            // 
            this.SaveUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveUpdateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveUpdateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUpdateButton.ForeColor = System.Drawing.Color.White;
            this.SaveUpdateButton.Location = new System.Drawing.Point(967, 346);
            this.SaveUpdateButton.Name = "SaveUpdateButton";
            this.SaveUpdateButton.Size = new System.Drawing.Size(197, 47);
            this.SaveUpdateButton.TabIndex = 212;
            this.SaveUpdateButton.Text = "Update Customer";
            this.SaveUpdateButton.UseVisualStyleBackColor = false;
            this.SaveUpdateButton.Click += new System.EventHandler(this.SaveUpdateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.UpdateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(330, 432);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(270, 80);
            this.UpdateButton.TabIndex = 211;
            this.UpdateButton.Text = "Update Selected Record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1170, 346);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 47);
            this.SaveButton.TabIndex = 208;
            this.SaveButton.Text = "Save  Customer";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(656, 269);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(702, 22);
            this.EmailTextBox.TabIndex = 203;
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // ContactNoTextBox
            // 
            this.ContactNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactNoTextBox.Location = new System.Drawing.Point(160, 269);
            this.ContactNoTextBox.MaxLength = 12;
            this.ContactNoTextBox.Name = "ContactNoTextBox";
            this.ContactNoTextBox.Size = new System.Drawing.Size(353, 22);
            this.ContactNoTextBox.TabIndex = 201;
            this.ContactNoTextBox.Leave += new System.EventHandler(this.ContactNoTextBox_Leave);
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressRichTextBox.Location = new System.Drawing.Point(160, 203);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(1198, 29);
            this.AddressRichTextBox.TabIndex = 200;
            this.AddressRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(438, 141);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(920, 22);
            this.NameTextBox.TabIndex = 199;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1002, 857);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 198;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(41, 270);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(110, 20);
            this.ContactLabel.TabIndex = 197;
            this.ContactLabel.Text = "Contact No :";
            // 
            // DeleteSelectedRecordButton
            // 
            this.DeleteSelectedRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteSelectedRecordButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteSelectedRecordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedRecordButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedRecordButton.Location = new System.Drawing.Point(621, 432);
            this.DeleteSelectedRecordButton.Name = "DeleteSelectedRecordButton";
            this.DeleteSelectedRecordButton.Size = new System.Drawing.Size(270, 80);
            this.DeleteSelectedRecordButton.TabIndex = 196;
            this.DeleteSelectedRecordButton.Text = "Delete Selected Record";
            this.DeleteSelectedRecordButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedRecordButton.Click += new System.EventHandler(this.DeleteSelectedRecordButton_Click);
            // 
            // AddNew
            // 
            this.AddNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddNew.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew.ForeColor = System.Drawing.Color.Black;
            this.AddNew.Location = new System.Drawing.Point(41, 432);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(270, 80);
            this.AddNew.TabIndex = 195;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(171, 141);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(183, 22);
            this.CustomerIDTextBox.TabIndex = 193;
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(41, 533);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.ReadOnly = true;
            this.CustomerDataGridView.RowHeadersWidth = 51;
            this.CustomerDataGridView.RowTemplate.Height = 24;
            this.CustomerDataGridView.Size = new System.Drawing.Size(1317, 318);
            this.CustomerDataGridView.TabIndex = 189;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1202, 857);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 188;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, 1);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 187;
            this.Titlelabel.Text = "Customer";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.SaveUpdateButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(EmailLabel);
            this.Controls.Add(this.ContactNoTextBox);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.DeleteSelectedRecordButton);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(NameLabel);
            this.Controls.Add(CustomerIDLabel);
            this.Controls.Add(this.CustomerDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveUpdateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ContactNoTextBox;
        private System.Windows.Forms.RichTextBox AddressRichTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Button DeleteSelectedRecordButton;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
    }
}