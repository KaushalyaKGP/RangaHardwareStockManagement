
namespace RangaHardwareStock
{
    partial class InboundOrderIn
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
            System.Windows.Forms.Label ItemNameLabel;
            System.Windows.Forms.Label AmountLabel;
            System.Windows.Forms.Label UnitCostLabel;
            System.Windows.Forms.Label TotalCostLabel;
            System.Windows.Forms.Label PaidAmountLabel;
            System.Windows.Forms.Label PendingPaymentsLabel;
            this.Titlelabel = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.DateInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InboundOrderItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AddNewInboundOrderButton = new System.Windows.Forms.Button();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.PaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.PendingPaymentsTextBox = new System.Windows.Forms.TextBox();
            this.BatchIDTextBox = new System.Windows.Forms.TextBox();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnitCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.supplierTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            DateInLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ItemNameLabel = new System.Windows.Forms.Label();
            AmountLabel = new System.Windows.Forms.Label();
            UnitCostLabel = new System.Windows.Forms.Label();
            TotalCostLabel = new System.Windows.Forms.Label();
            PaidAmountLabel = new System.Windows.Forms.Label();
            PendingPaymentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(705, 202);
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
            DateInLabel.Location = new System.Drawing.Point(321, 202);
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
            BatchIDLabel.Location = new System.Drawing.Point(41, 202);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 48;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ItemNameLabel.Location = new System.Drawing.Point(41, 316);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new System.Drawing.Size(54, 20);
            ItemNameLabel.TabIndex = 63;
            ItemNameLabel.Text = "Item :";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AmountLabel.Location = new System.Drawing.Point(495, 316);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new System.Drawing.Size(81, 20);
            AmountLabel.TabIndex = 66;
            AmountLabel.Text = "Amount :";
            // 
            // UnitCostLabel
            // 
            UnitCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            UnitCostLabel.AutoSize = true;
            UnitCostLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UnitCostLabel.Location = new System.Drawing.Point(782, 316);
            UnitCostLabel.Name = "UnitCostLabel";
            UnitCostLabel.Size = new System.Drawing.Size(94, 20);
            UnitCostLabel.TabIndex = 68;
            UnitCostLabel.Text = "Unit Cost :";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalCostLabel.Location = new System.Drawing.Point(45, 747);
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
            PaidAmountLabel.Location = new System.Drawing.Point(494, 747);
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
            PendingPaymentsLabel.Location = new System.Drawing.Point(925, 747);
            PendingPaymentsLabel.Name = "PendingPaymentsLabel";
            PendingPaymentsLabel.Size = new System.Drawing.Size(170, 20);
            PendingPaymentsLabel.TabIndex = 76;
            PendingPaymentsLabel.Text = "Pending Payments :";
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, 31);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 21;
            this.Titlelabel.Text = "New Inbound Order";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SupplierComboBox.DataSource = this.supplierBindingSource;
            this.SupplierComboBox.DisplayMember = "Name";
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(830, 200);
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
            this.DateInDateTimePicker.Location = new System.Drawing.Point(426, 201);
            this.DateInDateTimePicker.Name = "DateInDateTimePicker";
            this.DateInDateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateInDateTimePicker.TabIndex = 53;
            this.DateInDateTimePicker.Value = new System.DateTime(2022, 9, 23, 0, 0, 0, 0);
            // 
            // InboundOrderItemsDataGridView
            // 
            this.InboundOrderItemsDataGridView.AllowUserToDeleteRows = false;
            this.InboundOrderItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InboundOrderItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InboundOrderItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InboundOrderItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.amount,
            this.unit_Cost,
            this.Total_Cost});
            this.InboundOrderItemsDataGridView.Location = new System.Drawing.Point(45, 377);
            this.InboundOrderItemsDataGridView.Name = "InboundOrderItemsDataGridView";
            this.InboundOrderItemsDataGridView.RowHeadersWidth = 51;
            this.InboundOrderItemsDataGridView.RowTemplate.Height = 24;
            this.InboundOrderItemsDataGridView.Size = new System.Drawing.Size(1316, 332);
            this.InboundOrderItemsDataGridView.TabIndex = 62;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemNameComboBox.DisplayMember = "Supplier_ID";
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(154, 314);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(265, 24);
            this.ItemNameComboBox.TabIndex = 64;
            this.ItemNameComboBox.ValueMember = "Supplier_ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 264);
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
            this.AddItemButton.Location = new System.Drawing.Point(1205, 301);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 70;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // AddNewInboundOrderButton
            // 
            this.AddNewInboundOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddNewInboundOrderButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddNewInboundOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewInboundOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddNewInboundOrderButton.Location = new System.Drawing.Point(1031, 798);
            this.AddNewInboundOrderButton.Name = "AddNewInboundOrderButton";
            this.AddNewInboundOrderButton.Size = new System.Drawing.Size(330, 47);
            this.AddNewInboundOrderButton.TabIndex = 71;
            this.AddNewInboundOrderButton.Text = "Save New Inbound Order";
            this.AddNewInboundOrderButton.UseVisualStyleBackColor = false;
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalCostTextBox.Location = new System.Drawing.Point(179, 746);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.Size = new System.Drawing.Size(226, 22);
            this.TotalCostTextBox.TabIndex = 73;
            // 
            // PaidAmountTextBox
            // 
            this.PaidAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaidAmountTextBox.Location = new System.Drawing.Point(650, 746);
            this.PaidAmountTextBox.Name = "PaidAmountTextBox";
            this.PaidAmountTextBox.Size = new System.Drawing.Size(226, 22);
            this.PaidAmountTextBox.TabIndex = 75;
            // 
            // PendingPaymentsTextBox
            // 
            this.PendingPaymentsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PendingPaymentsTextBox.Location = new System.Drawing.Point(1135, 746);
            this.PendingPaymentsTextBox.Name = "PendingPaymentsTextBox";
            this.PendingPaymentsTextBox.Size = new System.Drawing.Size(226, 22);
            this.PendingPaymentsTextBox.TabIndex = 77;
            // 
            // BatchIDTextBox
            // 
            this.BatchIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDTextBox.Location = new System.Drawing.Point(163, 203);
            this.BatchIDTextBox.Name = "BatchIDTextBox";
            this.BatchIDTextBox.ReadOnly = true;
            this.BatchIDTextBox.Size = new System.Drawing.Size(115, 22);
            this.BatchIDTextBox.TabIndex = 78;
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AmountNumericUpDown.Location = new System.Drawing.Point(608, 315);
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.AmountNumericUpDown.TabIndex = 79;
            // 
            // UnitCostNumericUpDown
            // 
            this.UnitCostNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitCostNumericUpDown.DecimalPlaces = 2;
            this.UnitCostNumericUpDown.Location = new System.Drawing.Point(913, 315);
            this.UnitCostNumericUpDown.Name = "UnitCostNumericUpDown";
            this.UnitCostNumericUpDown.Size = new System.Drawing.Size(248, 22);
            this.UnitCostNumericUpDown.TabIndex = 80;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item";
            this.Item_ID.MinimumWidth = 6;
            this.Item_ID.Name = "Item_ID";
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // unit_Cost
            // 
            this.unit_Cost.HeaderText = "unit_Cost";
            this.unit_Cost.MinimumWidth = 6;
            this.unit_Cost.Name = "unit_Cost";
            // 
            // Total_Cost
            // 
            this.Total_Cost.HeaderText = "Total_Cost";
            this.Total_Cost.MinimumWidth = 6;
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.ReadOnly = true;
            // 
            // InboundOrderIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.UnitCostNumericUpDown);
            this.Controls.Add(this.AmountNumericUpDown);
            this.Controls.Add(this.BatchIDTextBox);
            this.Controls.Add(this.PendingPaymentsTextBox);
            this.Controls.Add(PendingPaymentsLabel);
            this.Controls.Add(this.PaidAmountTextBox);
            this.Controls.Add(PaidAmountLabel);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(TotalCostLabel);
            this.Controls.Add(this.AddNewInboundOrderButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(UnitCostLabel);
            this.Controls.Add(AmountLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(ItemNameLabel);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.InboundOrderItemsDataGridView);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.DateInDateTimePicker);
            this.Controls.Add(DateInLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.Titlelabel);
            this.Name = "InboundOrderIn";
            this.Text = "Ranga Hardware Stock Management / Stock In Management / New Inbound Order In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InboundOrderIn_FormClosing);
            this.Load += new System.EventHandler(this.InboundOrderIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InboundOrderItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button AddNewInboundOrderButton;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.TextBox PaidAmountTextBox;
        private System.Windows.Forms.TextBox PendingPaymentsTextBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.TextBox BatchIDTextBox;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.NumericUpDown UnitCostNumericUpDown;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cost;
    }
}