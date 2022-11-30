
namespace RangaHardwareStock
{
    partial class ReturnToSupplierForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label ReasonLabel;
            System.Windows.Forms.Label DataLabel;
            System.Windows.Forms.Label ReturnIDLabel;
            System.Windows.Forms.Label FromStockTypeLabel;
            this.BackButton = new System.Windows.Forms.Button();
            this.InboundedQuantityCountLable = new System.Windows.Forms.Label();
            this.DiscriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InboundQuantityLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReturnIDTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.SRItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.returnToSupplierReasonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.SRDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.FromStockTypeComboBox = new System.Windows.Forms.ComboBox();
            this.stockTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stockTypeTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter();
            this.returnToSupplierReasonsTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ReturnToSupplierReasonsTableAdapter();
            this.AvailableQuantityLabel = new System.Windows.Forms.Label();
            this.AvailableStockLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ReasonLabel = new System.Windows.Forms.Label();
            DataLabel = new System.Windows.Forms.Label();
            ReturnIDLabel = new System.Windows.Forms.Label();
            FromStockTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToSupplierReasonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(41, 288);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 20);
            label1.TabIndex = 158;
            label1.Text = "Discription :";
            // 
            // ReasonLabel
            // 
            ReasonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ReasonLabel.AutoSize = true;
            ReasonLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ReasonLabel.Location = new System.Drawing.Point(960, 193);
            ReasonLabel.Name = "ReasonLabel";
            ReasonLabel.Size = new System.Drawing.Size(79, 20);
            ReasonLabel.TabIndex = 146;
            ReasonLabel.Text = "Reason :";
            // 
            // DataLabel
            // 
            DataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DataLabel.AutoSize = true;
            DataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DataLabel.Location = new System.Drawing.Point(320, 193);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new System.Drawing.Size(57, 20);
            DataLabel.TabIndex = 144;
            DataLabel.Text = "Data :";
            // 
            // ReturnIDLabel
            // 
            ReturnIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ReturnIDLabel.AutoSize = true;
            ReturnIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ReturnIDLabel.Location = new System.Drawing.Point(41, 193);
            ReturnIDLabel.Name = "ReturnIDLabel";
            ReturnIDLabel.Size = new System.Drawing.Size(95, 20);
            ReturnIDLabel.TabIndex = 143;
            ReturnIDLabel.Text = "Return ID :";
            // 
            // FromStockTypeLabel
            // 
            FromStockTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            FromStockTypeLabel.AutoSize = true;
            FromStockTypeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FromStockTypeLabel.Location = new System.Drawing.Point(534, 193);
            FromStockTypeLabel.Name = "FromStockTypeLabel";
            FromStockTypeLabel.Size = new System.Drawing.Size(156, 20);
            FromStockTypeLabel.TabIndex = 162;
            FromStockTypeLabel.Text = "From Stock Type :";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1207, 847);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 161;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InboundedQuantityCountLable
            // 
            this.InboundedQuantityCountLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InboundedQuantityCountLable.AutoSize = true;
            this.InboundedQuantityCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.InboundedQuantityCountLable.Location = new System.Drawing.Point(1232, 477);
            this.InboundedQuantityCountLable.Name = "InboundedQuantityCountLable";
            this.InboundedQuantityCountLable.Size = new System.Drawing.Size(61, 17);
            this.InboundedQuantityCountLable.TabIndex = 160;
            this.InboundedQuantityCountLable.Text = "Quantity";
            // 
            // DiscriptionRichTextBox
            // 
            this.DiscriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptionRichTextBox.Location = new System.Drawing.Point(160, 288);
            this.DiscriptionRichTextBox.Name = "DiscriptionRichTextBox";
            this.DiscriptionRichTextBox.Size = new System.Drawing.Size(1202, 60);
            this.DiscriptionRichTextBox.TabIndex = 159;
            this.DiscriptionRichTextBox.Text = "";
            // 
            // InboundQuantityLabel
            // 
            this.InboundQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InboundQuantityLabel.AutoSize = true;
            this.InboundQuantityLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.InboundQuantityLabel.Location = new System.Drawing.Point(1089, 477);
            this.InboundQuantityLabel.Name = "InboundQuantityLabel";
            this.InboundQuantityLabel.Size = new System.Drawing.Size(144, 17);
            this.InboundQuantityLabel.TabIndex = 157;
            this.InboundQuantityLabel.Text = "Inbounded Quantity : ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(995, 530);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(87, 20);
            this.QuantityLabel.TabIndex = 156;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(995, 452);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 155;
            this.ItemLabel.Text = "Item :";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(995, 705);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(368, 47);
            this.SaveButton.TabIndex = 154;
            this.SaveButton.Text = "Save Return to Supplier";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(1089, 529);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.QuantityNumericUpDown.TabIndex = 153;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // ReturnIDTextBox
            // 
            this.ReturnIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnIDTextBox.Location = new System.Drawing.Point(144, 192);
            this.ReturnIDTextBox.Name = "ReturnIDTextBox";
            this.ReturnIDTextBox.ReadOnly = true;
            this.ReturnIDTextBox.Size = new System.Drawing.Size(165, 22);
            this.ReturnIDTextBox.TabIndex = 152;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddItemButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(995, 568);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 151;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(1089, 450);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(274, 24);
            this.ItemNameComboBox.TabIndex = 149;
            this.ItemNameComboBox.ValueMember = "Item_ID";
            this.ItemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameComboBox_SelectedIndexChanged);
            // 
            // SRItemsDataGridView
            // 
            this.SRItemsDataGridView.AllowUserToDeleteRows = false;
            this.SRItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SRItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SRItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SRItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Quantity});
            this.SRItemsDataGridView.Location = new System.Drawing.Point(46, 457);
            this.SRItemsDataGridView.Name = "SRItemsDataGridView";
            this.SRItemsDataGridView.ReadOnly = true;
            this.SRItemsDataGridView.RowHeadersWidth = 51;
            this.SRItemsDataGridView.RowTemplate.Height = 24;
            this.SRItemsDataGridView.Size = new System.Drawing.Size(883, 295);
            this.SRItemsDataGridView.TabIndex = 148;
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
            // ReasonComboBox
            // 
            this.ReasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReasonComboBox.DataSource = this.returnToSupplierReasonsBindingSource;
            this.ReasonComboBox.DisplayMember = "Reason";
            this.ReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Location = new System.Drawing.Point(1051, 191);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(311, 24);
            this.ReasonComboBox.TabIndex = 147;
            this.ReasonComboBox.ValueMember = "Id";
            // 
            // returnToSupplierReasonsBindingSource
            // 
            this.returnToSupplierReasonsBindingSource.DataMember = "ReturnToSupplierReasons";
            this.returnToSupplierReasonsBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SRDateTimePicker
            // 
            this.SRDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SRDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SRDateTimePicker.Location = new System.Drawing.Point(388, 192);
            this.SRDateTimePicker.Name = "SRDateTimePicker";
            this.SRDateTimePicker.Size = new System.Drawing.Size(124, 22);
            this.SRDateTimePicker.TabIndex = 145;
            this.SRDateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, 11);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 142;
            this.Titlelabel.Text = "Return to Supplier";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromStockTypeComboBox
            // 
            this.FromStockTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromStockTypeComboBox.DataSource = this.stockTypeBindingSource;
            this.FromStockTypeComboBox.DisplayMember = "Stock_Type";
            this.FromStockTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromStockTypeComboBox.FormattingEnabled = true;
            this.FromStockTypeComboBox.Location = new System.Drawing.Point(706, 191);
            this.FromStockTypeComboBox.Name = "FromStockTypeComboBox";
            this.FromStockTypeComboBox.Size = new System.Drawing.Size(230, 24);
            this.FromStockTypeComboBox.TabIndex = 163;
            this.FromStockTypeComboBox.ValueMember = "Id";
            this.FromStockTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FromStockTypeComboBox_SelectedIndexChanged);
            // 
            // stockTypeBindingSource
            // 
            this.stockTypeBindingSource.DataMember = "StockType";
            this.stockTypeBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // stockTypeTableAdapter
            // 
            this.stockTypeTableAdapter.ClearBeforeFill = true;
            // 
            // returnToSupplierReasonsTableAdapter
            // 
            this.returnToSupplierReasonsTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableQuantityLabel
            // 
            this.AvailableQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvailableQuantityLabel.AutoSize = true;
            this.AvailableQuantityLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableQuantityLabel.Location = new System.Drawing.Point(1232, 501);
            this.AvailableQuantityLabel.Name = "AvailableQuantityLabel";
            this.AvailableQuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.AvailableQuantityLabel.TabIndex = 165;
            this.AvailableQuantityLabel.Text = "Quantity";
            // 
            // AvailableStockLabel
            // 
            this.AvailableStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvailableStockLabel.AutoSize = true;
            this.AvailableStockLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockLabel.Location = new System.Drawing.Point(1089, 501);
            this.AvailableStockLabel.Name = "AvailableStockLabel";
            this.AvailableStockLabel.Size = new System.Drawing.Size(116, 17);
            this.AvailableStockLabel.TabIndex = 164;
            this.AvailableStockLabel.Text = "Available Stock : ";
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
            this.ExitButton.TabIndex = 254;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReturnToSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AvailableQuantityLabel);
            this.Controls.Add(this.AvailableStockLabel);
            this.Controls.Add(FromStockTypeLabel);
            this.Controls.Add(this.FromStockTypeComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InboundedQuantityCountLable);
            this.Controls.Add(this.DiscriptionRichTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.InboundQuantityLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.ReturnIDTextBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.SRItemsDataGridView);
            this.Controls.Add(ReasonLabel);
            this.Controls.Add(this.ReasonComboBox);
            this.Controls.Add(this.SRDateTimePicker);
            this.Controls.Add(DataLabel);
            this.Controls.Add(ReturnIDLabel);
            this.Controls.Add(this.Titlelabel);
            this.Name = "ReturnToSupplierForm";
            this.Text = "ReturnToSupplierForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToSupplierForm_FormClosed);
            this.Load += new System.EventHandler(this.ReturnToSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToSupplierReasonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label InboundedQuantityCountLable;
        private System.Windows.Forms.RichTextBox DiscriptionRichTextBox;
        private System.Windows.Forms.Label InboundQuantityLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.TextBox ReturnIDTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.DataGridView SRItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.DateTimePicker SRDateTimePicker;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.ComboBox FromStockTypeComboBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource stockTypeBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter stockTypeTableAdapter;
        private System.Windows.Forms.BindingSource returnToSupplierReasonsBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ReturnToSupplierReasonsTableAdapter returnToSupplierReasonsTableAdapter;
        private System.Windows.Forms.Label AvailableQuantityLabel;
        private System.Windows.Forms.Label AvailableStockLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}