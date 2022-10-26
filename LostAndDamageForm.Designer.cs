
namespace RangaHardwareStock
{
    partial class LostAndDamageForm
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
            System.Windows.Forms.Label SupplierCustomerLabel;
            System.Windows.Forms.Label DataLabel;
            System.Windows.Forms.Label BatchIDLabel;
            this.AvailableStockCountLable = new System.Windows.Forms.Label();
            this.AvailableStockLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.UnitLable = new System.Windows.Forms.Label();
            this.DeleteSelectedRecordButton = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BatchIDTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.SalesItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.FromStockTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Lost_DamagedDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            DataLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lost_DamagedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableStockCountLable
            // 
            this.AvailableStockCountLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableStockCountLable.AutoSize = true;
            this.AvailableStockCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockCountLable.Location = new System.Drawing.Point(934, 231);
            this.AvailableStockCountLable.Name = "AvailableStockCountLable";
            this.AvailableStockCountLable.Size = new System.Drawing.Size(84, 17);
            this.AvailableStockCountLable.TabIndex = 143;
            this.AvailableStockCountLable.Text = "Stock Count";
            // 
            // AvailableStockLabel
            // 
            this.AvailableStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableStockLabel.AutoSize = true;
            this.AvailableStockLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockLabel.Location = new System.Drawing.Point(818, 231);
            this.AvailableStockLabel.Name = "AvailableStockLabel";
            this.AvailableStockLabel.Size = new System.Drawing.Size(116, 17);
            this.AvailableStockLabel.TabIndex = 142;
            this.AvailableStockLabel.Text = "Available Stock : ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(1124, 206);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(87, 20);
            this.QuantityLabel.TabIndex = 140;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(707, 207);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 139;
            this.ItemLabel.Text = "Item :";
            // 
            // UnitLable
            // 
            this.UnitLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitLable.AutoSize = true;
            this.UnitLable.Location = new System.Drawing.Point(1358, 208);
            this.UnitLable.Name = "UnitLable";
            this.UnitLable.Size = new System.Drawing.Size(33, 17);
            this.UnitLable.TabIndex = 138;
            this.UnitLable.Text = "Unit";
            // 
            // DeleteSelectedRecordButton
            // 
            this.DeleteSelectedRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteSelectedRecordButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteSelectedRecordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedRecordButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedRecordButton.Location = new System.Drawing.Point(359, 432);
            this.DeleteSelectedRecordButton.Name = "DeleteSelectedRecordButton";
            this.DeleteSelectedRecordButton.Size = new System.Drawing.Size(270, 80);
            this.DeleteSelectedRecordButton.TabIndex = 137;
            this.DeleteSelectedRecordButton.Text = "Delete Selected Record";
            this.DeleteSelectedRecordButton.UseVisualStyleBackColor = false;
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
            this.AddNew.TabIndex = 136;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1175, 389);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 47);
            this.SaveButton.TabIndex = 135;
            this.SaveButton.Text = "Save New Sales";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(1218, 205);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.QuantityNumericUpDown.TabIndex = 131;
            // 
            // BatchIDTextBox
            // 
            this.BatchIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDTextBox.Location = new System.Drawing.Point(143, 143);
            this.BatchIDTextBox.Name = "BatchIDTextBox";
            this.BatchIDTextBox.ReadOnly = true;
            this.BatchIDTextBox.Size = new System.Drawing.Size(221, 22);
            this.BatchIDTextBox.TabIndex = 130;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddItemButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(1235, 315);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 127;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(818, 204);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(274, 24);
            this.ItemNameComboBox.TabIndex = 125;
            this.ItemNameComboBox.ValueMember = "Item_ID";
            // 
            // SalesItemsDataGridView
            // 
            this.SalesItemsDataGridView.AllowUserToDeleteRows = false;
            this.SalesItemsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Quantity,
            this.Comment});
            this.SalesItemsDataGridView.Location = new System.Drawing.Point(46, 204);
            this.SalesItemsDataGridView.Name = "SalesItemsDataGridView";
            this.SalesItemsDataGridView.ReadOnly = true;
            this.SalesItemsDataGridView.RowHeadersWidth = 51;
            this.SalesItemsDataGridView.RowTemplate.Height = 24;
            this.SalesItemsDataGridView.Size = new System.Drawing.Size(634, 158);
            this.SalesItemsDataGridView.TabIndex = 124;
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(721, 144);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(156, 20);
            SupplierCustomerLabel.TabIndex = 122;
            SupplierCustomerLabel.Text = "From Stock Type :";
            // 
            // FromStockTypeComboBox
            // 
            this.FromStockTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromStockTypeComboBox.DisplayMember = "Stock_Type";
            this.FromStockTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromStockTypeComboBox.FormattingEnabled = true;
            this.FromStockTypeComboBox.Location = new System.Drawing.Point(902, 142);
            this.FromStockTypeComboBox.Name = "FromStockTypeComboBox";
            this.FromStockTypeComboBox.Size = new System.Drawing.Size(331, 24);
            this.FromStockTypeComboBox.TabIndex = 123;
            this.FromStockTypeComboBox.ValueMember = "Id";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(449, 143);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateTimePicker.TabIndex = 121;
            this.DateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // DataLabel
            // 
            DataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DataLabel.AutoSize = true;
            DataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DataLabel.Location = new System.Drawing.Point(370, 144);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new System.Drawing.Size(57, 20);
            DataLabel.TabIndex = 120;
            DataLabel.Text = "Data :";
            // 
            // BatchIDLabel
            // 
            BatchIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BatchIDLabel.AutoSize = true;
            BatchIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BatchIDLabel.Location = new System.Drawing.Point(41, 144);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 119;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // Lost_DamagedDataGridView
            // 
            this.Lost_DamagedDataGridView.AllowUserToAddRows = false;
            this.Lost_DamagedDataGridView.AllowUserToDeleteRows = false;
            this.Lost_DamagedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lost_DamagedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Lost_DamagedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lost_DamagedDataGridView.Location = new System.Drawing.Point(41, 533);
            this.Lost_DamagedDataGridView.Name = "Lost_DamagedDataGridView";
            this.Lost_DamagedDataGridView.ReadOnly = true;
            this.Lost_DamagedDataGridView.RowHeadersWidth = 51;
            this.Lost_DamagedDataGridView.RowTemplate.Height = 24;
            this.Lost_DamagedDataGridView.Size = new System.Drawing.Size(1317, 318);
            this.Lost_DamagedDataGridView.TabIndex = 118;
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
            this.BackButton.TabIndex = 117;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(241, 1);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 116;
            this.Titlelabel.Text = "Lost and Damage Stock Out";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(12, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox2.TabIndex = 132;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item";
            this.Item_ID.MinimumWidth = 6;
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLabel.Location = new System.Drawing.Point(707, 266);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(97, 20);
            this.CommentLabel.TabIndex = 144;
            this.CommentLabel.Text = "Comment :";
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Location = new System.Drawing.Point(818, 266);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.Size = new System.Drawing.Size(411, 96);
            this.CommentRichTextBox.TabIndex = 145;
            this.CommentRichTextBox.Text = "";
            // 
            // LostAndDamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.CommentRichTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.AvailableStockCountLable);
            this.Controls.Add(this.AvailableStockLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.UnitLable);
            this.Controls.Add(this.DeleteSelectedRecordButton);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.BatchIDTextBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.SalesItemsDataGridView);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.FromStockTypeComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(DataLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.Lost_DamagedDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "LostAndDamageForm";
            this.Text = "LostAndDamageForm";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lost_DamagedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvailableStockCountLable;
        private System.Windows.Forms.Label AvailableStockLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label UnitLable;
        private System.Windows.Forms.Button DeleteSelectedRecordButton;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.TextBox BatchIDTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.DataGridView SalesItemsDataGridView;
        private System.Windows.Forms.ComboBox FromStockTypeComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView Lost_DamagedDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
    }
}