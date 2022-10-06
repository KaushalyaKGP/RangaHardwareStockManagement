
namespace RangaHardwareStock
{
    partial class SalesForm
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
            System.Windows.Forms.Label NetSalesLabel;
            System.Windows.Forms.Label CustomerLabel;
            System.Windows.Forms.Label SupplierCustomerLabel;
            System.Windows.Forms.Label SalesDataLabel;
            System.Windows.Forms.Label BatchIDLabel;
            this.SalesDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BatchIDTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.SalesItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStockTypeComboBox = new System.Windows.Forms.ComboBox();
            this.stockTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddNewSalesButton = new System.Windows.Forms.Button();
            this.DeleteSelectedSalesRecordButton = new System.Windows.Forms.Button();
            this.UnitLable = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CustomerReturnButton = new System.Windows.Forms.Button();
            this.stockTypeTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter();
            this.customerTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.CustomerTableAdapter();
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            this.AvailableStockLabel = new System.Windows.Forms.Label();
            this.AvailableStockCountLable = new System.Windows.Forms.Label();
            this.Unit2Label = new System.Windows.Forms.Label();
            NetSalesLabel = new System.Windows.Forms.Label();
            CustomerLabel = new System.Windows.Forms.Label();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            SalesDataLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NetSalesLabel
            // 
            NetSalesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NetSalesLabel.AutoSize = true;
            NetSalesLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NetSalesLabel.Location = new System.Drawing.Point(491, 384);
            NetSalesLabel.Name = "NetSalesLabel";
            NetSalesLabel.Size = new System.Drawing.Size(96, 20);
            NetSalesLabel.TabIndex = 96;
            NetSalesLabel.Text = "Net Sales :";
            // 
            // CustomerLabel
            // 
            CustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomerLabel.Location = new System.Drawing.Point(42, 384);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new System.Drawing.Size(98, 20);
            CustomerLabel.TabIndex = 94;
            CustomerLabel.Text = "Customer :";
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(721, 132);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(156, 20);
            SupplierCustomerLabel.TabIndex = 85;
            SupplierCustomerLabel.Text = "From Stock Type :";
            // 
            // SalesDataLabel
            // 
            SalesDataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SalesDataLabel.AutoSize = true;
            SalesDataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SalesDataLabel.Location = new System.Drawing.Point(329, 132);
            SalesDataLabel.Name = "SalesDataLabel";
            SalesDataLabel.Size = new System.Drawing.Size(106, 20);
            SalesDataLabel.TabIndex = 83;
            SalesDataLabel.Text = "Sales Data :";
            // 
            // BatchIDLabel
            // 
            BatchIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BatchIDLabel.AutoSize = true;
            BatchIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BatchIDLabel.Location = new System.Drawing.Point(41, 132);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 82;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.AllowUserToAddRows = false;
            this.SalesDataGridView.AllowUserToDeleteRows = false;
            this.SalesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGridView.Location = new System.Drawing.Point(41, 521);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.ReadOnly = true;
            this.SalesDataGridView.RowHeadersWidth = 51;
            this.SalesDataGridView.RowTemplate.Height = 24;
            this.SalesDataGridView.Size = new System.Drawing.Size(1317, 318);
            this.SalesDataGridView.TabIndex = 73;
            this.SalesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDataGridView_CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1202, 845);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 72;
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
            this.Titlelabel.Location = new System.Drawing.Point(241, -11);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 70;
            this.Titlelabel.Text = "Sales";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(1089, 264);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.QuantityNumericUpDown.TabIndex = 100;
            // 
            // BatchIDTextBox
            // 
            this.BatchIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDTextBox.Location = new System.Drawing.Point(143, 131);
            this.BatchIDTextBox.Name = "BatchIDTextBox";
            this.BatchIDTextBox.ReadOnly = true;
            this.BatchIDTextBox.Size = new System.Drawing.Size(126, 22);
            this.BatchIDTextBox.TabIndex = 99;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddItemButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(995, 303);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 93;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemNameComboBox.DataSource = this.itemBindingSource;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(1089, 185);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(274, 24);
            this.ItemNameComboBox.TabIndex = 89;
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
            // SalesItemsDataGridView
            // 
            this.SalesItemsDataGridView.AllowUserToDeleteRows = false;
            this.SalesItemsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Quantity,
            this.Item_Total});
            this.SalesItemsDataGridView.Location = new System.Drawing.Point(46, 192);
            this.SalesItemsDataGridView.Name = "SalesItemsDataGridView";
            this.SalesItemsDataGridView.ReadOnly = true;
            this.SalesItemsDataGridView.RowHeadersWidth = 51;
            this.SalesItemsDataGridView.RowTemplate.Height = 24;
            this.SalesItemsDataGridView.Size = new System.Drawing.Size(883, 158);
            this.SalesItemsDataGridView.TabIndex = 87;
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
            // Item_Total
            // 
            this.Item_Total.HeaderText = "Item Total";
            this.Item_Total.MinimumWidth = 6;
            this.Item_Total.Name = "Item_Total";
            this.Item_Total.ReadOnly = true;
            // 
            // FromStockTypeComboBox
            // 
            this.FromStockTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromStockTypeComboBox.DataSource = this.stockTypeBindingSource;
            this.FromStockTypeComboBox.DisplayMember = "Stock_Type";
            this.FromStockTypeComboBox.FormattingEnabled = true;
            this.FromStockTypeComboBox.Location = new System.Drawing.Point(902, 130);
            this.FromStockTypeComboBox.Name = "FromStockTypeComboBox";
            this.FromStockTypeComboBox.Size = new System.Drawing.Size(331, 24);
            this.FromStockTypeComboBox.TabIndex = 86;
            this.FromStockTypeComboBox.ValueMember = "Id";
            this.FromStockTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FromStockTypeComboBox_SelectedIndexChanged);
            // 
            // stockTypeBindingSource
            // 
            this.stockTypeBindingSource.DataMember = "StockType";
            this.stockTypeBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // SalesDateTimePicker
            // 
            this.SalesDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDateTimePicker.Location = new System.Drawing.Point(449, 131);
            this.SalesDateTimePicker.Name = "SalesDateTimePicker";
            this.SalesDateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.SalesDateTimePicker.TabIndex = 84;
            this.SalesDateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(12, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerComboBox.DataSource = this.customerBindingSource;
            this.CustomerComboBox.DisplayMember = "Name";
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(153, 382);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(274, 24);
            this.CustomerComboBox.TabIndex = 105;
            this.CustomerComboBox.ValueMember = "Customer_ID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // NetSalesTextBox
            // 
            this.NetSalesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NetSalesTextBox.Location = new System.Drawing.Point(613, 383);
            this.NetSalesTextBox.Name = "NetSalesTextBox";
            this.NetSalesTextBox.ReadOnly = true;
            this.NetSalesTextBox.Size = new System.Drawing.Size(126, 22);
            this.NetSalesTextBox.TabIndex = 106;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1142, 377);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 47);
            this.SaveButton.TabIndex = 107;
            this.SaveButton.Text = "Save New Sales";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // AddNewSalesButton
            // 
            this.AddNewSalesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddNewSalesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddNewSalesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewSalesButton.ForeColor = System.Drawing.Color.Black;
            this.AddNewSalesButton.Location = new System.Drawing.Point(41, 432);
            this.AddNewSalesButton.Name = "AddNewSalesButton";
            this.AddNewSalesButton.Size = new System.Drawing.Size(270, 80);
            this.AddNewSalesButton.TabIndex = 108;
            this.AddNewSalesButton.Text = "Add New Sales";
            this.AddNewSalesButton.UseVisualStyleBackColor = false;
            this.AddNewSalesButton.Click += new System.EventHandler(this.AddNewSalesButton_Click);
            // 
            // DeleteSelectedSalesRecordButton
            // 
            this.DeleteSelectedSalesRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteSelectedSalesRecordButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteSelectedSalesRecordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedSalesRecordButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedSalesRecordButton.Location = new System.Drawing.Point(359, 432);
            this.DeleteSelectedSalesRecordButton.Name = "DeleteSelectedSalesRecordButton";
            this.DeleteSelectedSalesRecordButton.Size = new System.Drawing.Size(270, 80);
            this.DeleteSelectedSalesRecordButton.TabIndex = 109;
            this.DeleteSelectedSalesRecordButton.Text = "Delete Selected Sales Record";
            this.DeleteSelectedSalesRecordButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedSalesRecordButton.Click += new System.EventHandler(this.DeleteSelectedSalesRecordButton_Click);
            // 
            // UnitLable
            // 
            this.UnitLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitLable.AutoSize = true;
            this.UnitLable.Location = new System.Drawing.Point(1229, 267);
            this.UnitLable.Name = "UnitLable";
            this.UnitLable.Size = new System.Drawing.Size(33, 17);
            this.UnitLable.TabIndex = 110;
            this.UnitLable.Text = "Unit";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(995, 187);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 111;
            this.ItemLabel.Text = "Item :";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(995, 265);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(87, 20);
            this.QuantityLabel.TabIndex = 112;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // CustomerReturnButton
            // 
            this.CustomerReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerReturnButton.BackColor = System.Drawing.Color.LightCoral;
            this.CustomerReturnButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReturnButton.ForeColor = System.Drawing.Color.Black;
            this.CustomerReturnButton.Location = new System.Drawing.Point(677, 435);
            this.CustomerReturnButton.Name = "CustomerReturnButton";
            this.CustomerReturnButton.Size = new System.Drawing.Size(270, 80);
            this.CustomerReturnButton.TabIndex = 113;
            this.CustomerReturnButton.Text = "Add Customer Return";
            this.CustomerReturnButton.UseVisualStyleBackColor = false;
            // 
            // stockTypeTableAdapter
            // 
            this.stockTypeTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableStockLabel
            // 
            this.AvailableStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableStockLabel.AutoSize = true;
            this.AvailableStockLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockLabel.Location = new System.Drawing.Point(1089, 212);
            this.AvailableStockLabel.Name = "AvailableStockLabel";
            this.AvailableStockLabel.Size = new System.Drawing.Size(116, 17);
            this.AvailableStockLabel.TabIndex = 114;
            this.AvailableStockLabel.Text = "Available Stock : ";
            // 
            // AvailableStockCountLable
            // 
            this.AvailableStockCountLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableStockCountLable.AutoSize = true;
            this.AvailableStockCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.AvailableStockCountLable.Location = new System.Drawing.Point(1205, 212);
            this.AvailableStockCountLable.Name = "AvailableStockCountLable";
            this.AvailableStockCountLable.Size = new System.Drawing.Size(84, 17);
            this.AvailableStockCountLable.TabIndex = 115;
            this.AvailableStockCountLable.Text = "Stock Count";
            // 
            // Unit2Label
            // 
            this.Unit2Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.ForeColor = System.Drawing.Color.SeaGreen;
            this.Unit2Label.Location = new System.Drawing.Point(1306, 212);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(33, 17);
            this.Unit2Label.TabIndex = 116;
            this.Unit2Label.Text = "Unit";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.Unit2Label);
            this.Controls.Add(this.AvailableStockCountLable);
            this.Controls.Add(this.AvailableStockLabel);
            this.Controls.Add(this.CustomerReturnButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.UnitLable);
            this.Controls.Add(this.DeleteSelectedSalesRecordButton);
            this.Controls.Add(this.AddNewSalesButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NetSalesTextBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.BatchIDTextBox);
            this.Controls.Add(NetSalesLabel);
            this.Controls.Add(CustomerLabel);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.SalesItemsDataGridView);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.FromStockTypeComboBox);
            this.Controls.Add(this.SalesDateTimePicker);
            this.Controls.Add(SalesDataLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.SalesDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "SalesForm";
            this.Text = "Ranga Hardware Stock Management / Stock Out Management / Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SalesDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.TextBox BatchIDTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.DataGridView SalesItemsDataGridView;
        private System.Windows.Forms.ComboBox FromStockTypeComboBox;
        private System.Windows.Forms.DateTimePicker SalesDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Total;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox NetSalesTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddNewSalesButton;
        private System.Windows.Forms.Button DeleteSelectedSalesRecordButton;
        private System.Windows.Forms.Label UnitLable;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button CustomerReturnButton;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource stockTypeBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockTypeTableAdapter stockTypeTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Ranga_hardwareDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Label AvailableStockLabel;
        private System.Windows.Forms.Label AvailableStockCountLable;
        private System.Windows.Forms.Label Unit2Label;
    }
}