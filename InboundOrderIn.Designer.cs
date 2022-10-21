
namespace RangaHardwareStock
{
    partial class InboundOrderForm
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
            System.Windows.Forms.Label DateInLabel;
            System.Windows.Forms.Label BatchIDLabel;
            System.Windows.Forms.Label TotalCostLabel;
            System.Windows.Forms.Label PaidAmountLabel;
            System.Windows.Forms.Label PendingPaymentsLabel;
            System.Windows.Forms.Label UnitCostLabel;
            this.Titlelabel = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.DateInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InboundOrderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.SaveNewInboundOrderButton = new System.Windows.Forms.Button();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.PendingPaymentsTextBox = new System.Windows.Forms.TextBox();
            this.BatchIDTextBox = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter();
            this.PeidAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ReturntoSupplierButton = new System.Windows.Forms.Button();
            this.DeleteInboundOrderButton = new System.Windows.Forms.Button();
            this.AddNewInboundOrderButton = new System.Windows.Forms.Button();
            this.InboundOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnitCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnitLable = new System.Windows.Forms.Label();
            this.Unit2Label = new System.Windows.Forms.Label();
            this.InboundStockCountLable = new System.Windows.Forms.Label();
            this.InboundStockLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            DateInLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            TotalCostLabel = new System.Windows.Forms.Label();
            PaidAmountLabel = new System.Windows.Forms.Label();
            PendingPaymentsLabel = new System.Windows.Forms.Label();
            UnitCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeidAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(705, 111);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(88, 20);
            SupplierCustomerLabel.TabIndex = 57;
            SupplierCustomerLabel.Text = "Supplier :";
            // 
            // DateInLabel
            // 
            DateInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInLabel.AutoSize = true;
            DateInLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInLabel.Location = new System.Drawing.Point(321, 111);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new System.Drawing.Size(76, 20);
            DateInLabel.TabIndex = 50;
            DateInLabel.Text = "Date In :";
            // 
            // BatchIDLabel
            // 
            BatchIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BatchIDLabel.AutoSize = true;
            BatchIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BatchIDLabel.Location = new System.Drawing.Point(41, 111);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 48;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalCostLabel.Location = new System.Drawing.Point(44, 388);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new System.Drawing.Size(102, 20);
            TotalCostLabel.TabIndex = 72;
            TotalCostLabel.Text = "Total Cost :";
            // 
            // PaidAmountLabel
            // 
            PaidAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            PaidAmountLabel.AutoSize = true;
            PaidAmountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PaidAmountLabel.Location = new System.Drawing.Point(493, 388);
            PaidAmountLabel.Name = "PaidAmountLabel";
            PaidAmountLabel.Size = new System.Drawing.Size(122, 20);
            PaidAmountLabel.TabIndex = 74;
            PaidAmountLabel.Text = "Paid Amount :";
            // 
            // PendingPaymentsLabel
            // 
            PendingPaymentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            PendingPaymentsLabel.AutoSize = true;
            PendingPaymentsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PendingPaymentsLabel.Location = new System.Drawing.Point(924, 388);
            PendingPaymentsLabel.Name = "PendingPaymentsLabel";
            PendingPaymentsLabel.Size = new System.Drawing.Size(170, 20);
            PendingPaymentsLabel.TabIndex = 76;
            PendingPaymentsLabel.Text = "Pending Payments :";
            // 
            // UnitCostLabel
            // 
            UnitCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            UnitCostLabel.AutoSize = true;
            UnitCostLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UnitCostLabel.Location = new System.Drawing.Point(983, 267);
            UnitCostLabel.Name = "UnitCostLabel";
            UnitCostLabel.Size = new System.Drawing.Size(94, 20);
            UnitCostLabel.TabIndex = 68;
            UnitCostLabel.Text = "Unit Cost :";
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, -13);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 21;
            this.Titlelabel.Text = "Inbound Order";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SupplierComboBox.DataSource = this.supplierBindingSource;
            this.SupplierComboBox.DisplayMember = "Name";
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(830, 109);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(331, 24);
            this.SupplierComboBox.TabIndex = 58;
            this.SupplierComboBox.ValueMember = "Supplier_ID";
            this.SupplierComboBox.TextChanged += new System.EventHandler(this.SupplierComboBox_TextChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateInDateTimePicker
            // 
            this.DateInDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInDateTimePicker.Location = new System.Drawing.Point(426, 110);
            this.DateInDateTimePicker.Name = "DateInDateTimePicker";
            this.DateInDateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateInDateTimePicker.TabIndex = 53;
            this.DateInDateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // InboundOrderItemsDataGridView
            // 
            this.InboundOrderItemsDataGridView.AllowUserToDeleteRows = false;
            this.InboundOrderItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InboundOrderItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InboundOrderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InboundOrderItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Quantity,
            this.unit_Cost,
            this.Total_Cost});
            this.InboundOrderItemsDataGridView.Location = new System.Drawing.Point(45, 160);
            this.InboundOrderItemsDataGridView.Name = "InboundOrderItemsDataGridView";
            this.InboundOrderItemsDataGridView.ReadOnly = true;
            this.InboundOrderItemsDataGridView.RowHeadersWidth = 51;
            this.InboundOrderItemsDataGridView.RowTemplate.Height = 24;
            this.InboundOrderItemsDataGridView.Size = new System.Drawing.Size(912, 199);
            this.InboundOrderItemsDataGridView.TabIndex = 62;
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
            // unit_Cost
            // 
            this.unit_Cost.HeaderText = "unit_Cost";
            this.unit_Cost.MinimumWidth = 6;
            this.unit_Cost.Name = "unit_Cost";
            this.unit_Cost.ReadOnly = true;
            // 
            // Total_Cost
            // 
            this.Total_Cost.HeaderText = "Total_Cost";
            this.Total_Cost.MinimumWidth = 6;
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.ReadOnly = true;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ItemNameComboBox.DisplayMember = "Supplier_ID";
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(1043, 160);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(318, 24);
            this.ItemNameComboBox.TabIndex = 64;
            this.ItemNameComboBox.ValueMember = "Supplier_ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddItemButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(1205, 312);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 70;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // SaveNewInboundOrderButton
            // 
            this.SaveNewInboundOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveNewInboundOrderButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveNewInboundOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewInboundOrderButton.ForeColor = System.Drawing.Color.White;
            this.SaveNewInboundOrderButton.Location = new System.Drawing.Point(802, 430);
            this.SaveNewInboundOrderButton.Name = "SaveNewInboundOrderButton";
            this.SaveNewInboundOrderButton.Size = new System.Drawing.Size(330, 47);
            this.SaveNewInboundOrderButton.TabIndex = 71;
            this.SaveNewInboundOrderButton.Text = "Save New Inbound Order";
            this.SaveNewInboundOrderButton.UseVisualStyleBackColor = false;
            this.SaveNewInboundOrderButton.Click += new System.EventHandler(this.AddNewInboundOrderButton_Click);
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalCostTextBox.Location = new System.Drawing.Point(178, 387);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.ReadOnly = true;
            this.TotalCostTextBox.Size = new System.Drawing.Size(226, 22);
            this.TotalCostTextBox.TabIndex = 73;
            // 
            // PendingPaymentsTextBox
            // 
            this.PendingPaymentsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PendingPaymentsTextBox.Location = new System.Drawing.Point(1134, 387);
            this.PendingPaymentsTextBox.Name = "PendingPaymentsTextBox";
            this.PendingPaymentsTextBox.ReadOnly = true;
            this.PendingPaymentsTextBox.Size = new System.Drawing.Size(226, 22);
            this.PendingPaymentsTextBox.TabIndex = 77;
            // 
            // BatchIDTextBox
            // 
            this.BatchIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDTextBox.Location = new System.Drawing.Point(163, 112);
            this.BatchIDTextBox.Name = "BatchIDTextBox";
            this.BatchIDTextBox.ReadOnly = true;
            this.BatchIDTextBox.Size = new System.Drawing.Size(115, 22);
            this.BatchIDTextBox.TabIndex = 78;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // PeidAmountNumericUpDown
            // 
            this.PeidAmountNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PeidAmountNumericUpDown.DecimalPlaces = 2;
            this.PeidAmountNumericUpDown.Location = new System.Drawing.Point(637, 387);
            this.PeidAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PeidAmountNumericUpDown.Name = "PeidAmountNumericUpDown";
            this.PeidAmountNumericUpDown.Size = new System.Drawing.Size(248, 22);
            this.PeidAmountNumericUpDown.TabIndex = 81;
            this.PeidAmountNumericUpDown.ValueChanged += new System.EventHandler(this.PeidAmountNumericUpDown_ValueChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1204, 430);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 82;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(12, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // ReturntoSupplierButton
            // 
            this.ReturntoSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturntoSupplierButton.BackColor = System.Drawing.Color.LightCoral;
            this.ReturntoSupplierButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoSupplierButton.ForeColor = System.Drawing.Color.Black;
            this.ReturntoSupplierButton.Location = new System.Drawing.Point(677, 498);
            this.ReturntoSupplierButton.Name = "ReturntoSupplierButton";
            this.ReturntoSupplierButton.Size = new System.Drawing.Size(270, 62);
            this.ReturntoSupplierButton.TabIndex = 116;
            this.ReturntoSupplierButton.Text = "Return to Supplier";
            this.ReturntoSupplierButton.UseVisualStyleBackColor = false;
            // 
            // DeleteInboundOrderButton
            // 
            this.DeleteInboundOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteInboundOrderButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteInboundOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInboundOrderButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteInboundOrderButton.Location = new System.Drawing.Point(360, 495);
            this.DeleteInboundOrderButton.Name = "DeleteInboundOrderButton";
            this.DeleteInboundOrderButton.Size = new System.Drawing.Size(270, 65);
            this.DeleteInboundOrderButton.TabIndex = 115;
            this.DeleteInboundOrderButton.Text = "Delete Selected Inbound Order";
            this.DeleteInboundOrderButton.UseVisualStyleBackColor = false;
            // 
            // AddNewInboundOrderButton
            // 
            this.AddNewInboundOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddNewInboundOrderButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddNewInboundOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewInboundOrderButton.ForeColor = System.Drawing.Color.Black;
            this.AddNewInboundOrderButton.Location = new System.Drawing.Point(45, 495);
            this.AddNewInboundOrderButton.Name = "AddNewInboundOrderButton";
            this.AddNewInboundOrderButton.Size = new System.Drawing.Size(270, 65);
            this.AddNewInboundOrderButton.TabIndex = 114;
            this.AddNewInboundOrderButton.Text = "Add New Inbound Order";
            this.AddNewInboundOrderButton.UseVisualStyleBackColor = false;
            // 
            // InboundOrderDataGridView
            // 
            this.InboundOrderDataGridView.AllowUserToAddRows = false;
            this.InboundOrderDataGridView.AllowUserToDeleteRows = false;
            this.InboundOrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InboundOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InboundOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InboundOrderDataGridView.Location = new System.Drawing.Point(46, 566);
            this.InboundOrderDataGridView.Name = "InboundOrderDataGridView";
            this.InboundOrderDataGridView.RowHeadersWidth = 51;
            this.InboundOrderDataGridView.RowTemplate.Height = 24;
            this.InboundOrderDataGridView.Size = new System.Drawing.Size(1315, 273);
            this.InboundOrderDataGridView.TabIndex = 117;
            this.InboundOrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InboundOrderDataGridView_CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1205, 845);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 118;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(1075, 226);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(235, 22);
            this.QuantityNumericUpDown.TabIndex = 79;
            // 
            // UnitCostNumericUpDown
            // 
            this.UnitCostNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UnitCostNumericUpDown.DecimalPlaces = 2;
            this.UnitCostNumericUpDown.Location = new System.Drawing.Point(1083, 266);
            this.UnitCostNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.UnitCostNumericUpDown.Name = "UnitCostNumericUpDown";
            this.UnitCostNumericUpDown.Size = new System.Drawing.Size(277, 22);
            this.UnitCostNumericUpDown.TabIndex = 80;
            // 
            // UnitLable
            // 
            this.UnitLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitLable.AutoSize = true;
            this.UnitLable.Location = new System.Drawing.Point(1325, 228);
            this.UnitLable.Name = "UnitLable";
            this.UnitLable.Size = new System.Drawing.Size(33, 17);
            this.UnitLable.TabIndex = 119;
            this.UnitLable.Text = "Unit";
            // 
            // Unit2Label
            // 
            this.Unit2Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.ForeColor = System.Drawing.Color.SeaGreen;
            this.Unit2Label.Location = new System.Drawing.Point(1261, 187);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(33, 17);
            this.Unit2Label.TabIndex = 122;
            this.Unit2Label.Text = "Unit";
            // 
            // InboundStockCountLable
            // 
            this.InboundStockCountLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InboundStockCountLable.AutoSize = true;
            this.InboundStockCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.InboundStockCountLable.Location = new System.Drawing.Point(1160, 187);
            this.InboundStockCountLable.Name = "InboundStockCountLable";
            this.InboundStockCountLable.Size = new System.Drawing.Size(96, 17);
            this.InboundStockCountLable.TabIndex = 121;
            this.InboundStockCountLable.Text = "InboundCount";
            // 
            // InboundStockLabel
            // 
            this.InboundStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InboundStockLabel.AutoSize = true;
            this.InboundStockLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.InboundStockLabel.Location = new System.Drawing.Point(1044, 187);
            this.InboundStockLabel.Name = "InboundStockLabel";
            this.InboundStockLabel.Size = new System.Drawing.Size(110, 17);
            this.InboundStockLabel.TabIndex = 120;
            this.InboundStockLabel.Text = "Inbound Stock : ";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(983, 160);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 123;
            this.ItemLabel.Text = "Item :";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(982, 226);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(87, 20);
            this.QuantityLabel.TabIndex = 124;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // InboundOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.Unit2Label);
            this.Controls.Add(this.InboundStockCountLable);
            this.Controls.Add(this.InboundStockLabel);
            this.Controls.Add(this.UnitLable);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InboundOrderDataGridView);
            this.Controls.Add(this.ReturntoSupplierButton);
            this.Controls.Add(this.DeleteInboundOrderButton);
            this.Controls.Add(this.AddNewInboundOrderButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PeidAmountNumericUpDown);
            this.Controls.Add(this.UnitCostNumericUpDown);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.BatchIDTextBox);
            this.Controls.Add(this.PendingPaymentsTextBox);
            this.Controls.Add(PendingPaymentsLabel);
            this.Controls.Add(PaidAmountLabel);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(TotalCostLabel);
            this.Controls.Add(this.SaveNewInboundOrderButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(UnitCostLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.InboundOrderItemsDataGridView);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.DateInDateTimePicker);
            this.Controls.Add(DateInLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.Titlelabel);
            this.Name = "InboundOrderForm";
            this.Text = "Ranga Hardware Stock Management / Stock In Management / New Inbound Order In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InboundOrderIn_FormClosing);
            this.Load += new System.EventHandler(this.InboundOrderIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeidAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.DateTimePicker DateInDateTimePicker;
        private System.Windows.Forms.DataGridView InboundOrderItemsDataGridView;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button SaveNewInboundOrderButton;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.TextBox PendingPaymentsTextBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.TextBox BatchIDTextBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.NumericUpDown PeidAmountNumericUpDown;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ReturntoSupplierButton;
        private System.Windows.Forms.Button DeleteInboundOrderButton;
        private System.Windows.Forms.Button AddNewInboundOrderButton;
        private System.Windows.Forms.DataGridView InboundOrderDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown UnitCostNumericUpDown;
        private System.Windows.Forms.Label UnitLable;
        private System.Windows.Forms.Label Unit2Label;
        private System.Windows.Forms.Label InboundStockCountLable;
        private System.Windows.Forms.Label InboundStockLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cost;
    }
}