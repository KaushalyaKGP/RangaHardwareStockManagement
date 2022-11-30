
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
            this.components = new System.ComponentModel.Container();
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
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.FromStockTypeComboBox = new System.Windows.Forms.ComboBox();
            this.stockTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Lost_DamagedDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stockTypeTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter();
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            this.Unit2Label = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            DataLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lost_DamagedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // DataLabel
            // 
            DataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DataLabel.AutoSize = true;
            DataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DataLabel.Location = new System.Drawing.Point(397, 144);
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
            // AvailableStockCountLable
            // 
            this.AvailableStockCountLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableStockCountLable.AutoSize = true;
            this.AvailableStockCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockCountLable.Location = new System.Drawing.Point(271, 239);
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
            this.AvailableStockLabel.Location = new System.Drawing.Point(155, 239);
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
            this.QuantityLabel.Location = new System.Drawing.Point(461, 214);
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
            this.ItemLabel.Location = new System.Drawing.Point(44, 214);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 139;
            this.ItemLabel.Text = "Item :";
            // 
            // UnitLable
            // 
            this.UnitLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitLable.AutoSize = true;
            this.UnitLable.Location = new System.Drawing.Point(695, 216);
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
            this.AddNew.TabIndex = 136;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1176, 305);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 47);
            this.SaveButton.TabIndex = 135;
            this.SaveButton.Text = "Save  Lost";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(555, 213);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.QuantityNumericUpDown.TabIndex = 131;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
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
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemNameComboBox.DataSource = this.itemBindingSource;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(155, 212);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(274, 24);
            this.ItemNameComboBox.TabIndex = 125;
            this.ItemNameComboBox.ValueMember = "Item_ID";
            this.ItemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FromStockTypeComboBox
            // 
            this.FromStockTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromStockTypeComboBox.DataSource = this.stockTypeBindingSource;
            this.FromStockTypeComboBox.DisplayMember = "Stock_Type";
            this.FromStockTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromStockTypeComboBox.FormattingEnabled = true;
            this.FromStockTypeComboBox.Location = new System.Drawing.Point(902, 142);
            this.FromStockTypeComboBox.Name = "FromStockTypeComboBox";
            this.FromStockTypeComboBox.Size = new System.Drawing.Size(331, 24);
            this.FromStockTypeComboBox.TabIndex = 123;
            this.FromStockTypeComboBox.ValueMember = "Id";
            this.FromStockTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FromStockTypeComboBox_SelectedIndexChanged);
            // 
            // stockTypeBindingSource
            // 
            this.stockTypeBindingSource.DataMember = "StockType";
            this.stockTypeBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(466, 143);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateTimePicker.TabIndex = 121;
            this.DateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
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
            this.Lost_DamagedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lost_DamagedDataGridView_CellClick);
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
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            // CommentLabel
            // 
            this.CommentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLabel.Location = new System.Drawing.Point(44, 276);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(97, 20);
            this.CommentLabel.TabIndex = 144;
            this.CommentLabel.Text = "Comment :";
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CommentRichTextBox.Location = new System.Drawing.Point(155, 276);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.Size = new System.Drawing.Size(987, 76);
            this.CommentRichTextBox.TabIndex = 145;
            this.CommentRichTextBox.Text = "";
            // 
            // stockTypeTableAdapter
            // 
            this.stockTypeTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // Unit2Label
            // 
            this.Unit2Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.Location = new System.Drawing.Point(396, 239);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(33, 17);
            this.Unit2Label.TabIndex = 146;
            this.Unit2Label.Text = "Unit";
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
            this.ResetButton.TabIndex = 147;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1259, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 47);
            this.ExitButton.TabIndex = 252;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LostAndDamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Unit2Label);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LostAndDamageForm_FormClosed);
            this.Load += new System.EventHandler(this.LostAndDamageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.ComboBox FromStockTypeComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView Lost_DamagedDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource stockTypeBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter stockTypeTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Label Unit2Label;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}