
namespace RangaHardwareStock
{
    partial class StockIn_ManagementForm
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
            System.Windows.Forms.Label DateInLabel;
            System.Windows.Forms.Label BatchIDLabel;
            System.Windows.Forms.Label PaymentStatusLabel;
            System.Windows.Forms.Label ItemNameLabel;
            System.Windows.Forms.Label DateInFromLabel;
            System.Windows.Forms.Label DateInToLabel;
            System.Windows.Forms.Label SupplierCustomerLabel;
            this.ResetButton = new System.Windows.Forms.Button();
            this.StockInDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.NewInboundOrderButton = new System.Windows.Forms.Button();
            this.NewCustomerReturnButton = new System.Windows.Forms.Button();
            this.BatchIDComboBox = new System.Windows.Forms.ComboBox();
            this.stockInTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.PaymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateInFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateInToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.stockInTableTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockInTableTableAdapter();
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            this.supplierCustmerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierCustmerListTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.SupplierCustmerListTableAdapter();
            this.paymentStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentStatusTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.PaymentStatusTableAdapter();
            DateInLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            PaymentStatusLabel = new System.Windows.Forms.Label();
            ItemNameLabel = new System.Windows.Forms.Label();
            DateInFromLabel = new System.Windows.Forms.Label();
            DateInToLabel = new System.Windows.Forms.Label();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockInDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCustmerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateInLabel
            // 
            DateInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInLabel.AutoSize = true;
            DateInLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInLabel.Location = new System.Drawing.Point(52, 337);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new System.Drawing.Size(76, 20);
            DateInLabel.TabIndex = 34;
            DateInLabel.Text = "Date In :";
            // 
            // BatchIDLabel
            // 
            BatchIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BatchIDLabel.AutoSize = true;
            BatchIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BatchIDLabel.Location = new System.Drawing.Point(52, 285);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 32;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // PaymentStatusLabel
            // 
            PaymentStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            PaymentStatusLabel.AutoSize = true;
            PaymentStatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PaymentStatusLabel.Location = new System.Drawing.Point(927, 396);
            PaymentStatusLabel.Name = "PaymentStatusLabel";
            PaymentStatusLabel.Size = new System.Drawing.Size(145, 20);
            PaymentStatusLabel.TabIndex = 38;
            PaymentStatusLabel.Text = "Payment Status :";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ItemNameLabel.Location = new System.Drawing.Point(52, 396);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new System.Drawing.Size(54, 20);
            ItemNameLabel.TabIndex = 36;
            ItemNameLabel.Text = "Item :";
            // 
            // DateInFromLabel
            // 
            DateInFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInFromLabel.AutoSize = true;
            DateInFromLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInFromLabel.Location = new System.Drawing.Point(168, 337);
            DateInFromLabel.Name = "DateInFromLabel";
            DateInFromLabel.Size = new System.Drawing.Size(60, 20);
            DateInFromLabel.TabIndex = 41;
            DateInFromLabel.Text = "From :";
            // 
            // DateInToLabel
            // 
            DateInToLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInToLabel.AutoSize = true;
            DateInToLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInToLabel.Location = new System.Drawing.Point(492, 337);
            DateInToLabel.Name = "DateInToLabel";
            DateInToLabel.Size = new System.Drawing.Size(39, 20);
            DateInToLabel.TabIndex = 43;
            DateInToLabel.Text = "To :";
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(428, 396);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(173, 20);
            SupplierCustomerLabel.TabIndex = 44;
            SupplierCustomerLabel.Text = "Supplier/Customer :";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1206, 445);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 29;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StockInDataGridView
            // 
            this.StockInDataGridView.AllowUserToAddRows = false;
            this.StockInDataGridView.AllowUserToDeleteRows = false;
            this.StockInDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StockInDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockInDataGridView.Location = new System.Drawing.Point(45, 524);
            this.StockInDataGridView.Name = "StockInDataGridView";
            this.StockInDataGridView.ReadOnly = true;
            this.StockInDataGridView.RowHeadersWidth = 51;
            this.StockInDataGridView.RowTemplate.Height = 24;
            this.StockInDataGridView.Size = new System.Drawing.Size(1317, 277);
            this.StockInDataGridView.TabIndex = 28;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1206, 819);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1005, 445);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 47);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, 27);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 20;
            this.Titlelabel.Text = "Stock In Management";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewInboundOrderButton
            // 
            this.NewInboundOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewInboundOrderButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NewInboundOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInboundOrderButton.ForeColor = System.Drawing.Color.White;
            this.NewInboundOrderButton.Location = new System.Drawing.Point(45, 166);
            this.NewInboundOrderButton.Name = "NewInboundOrderButton";
            this.NewInboundOrderButton.Size = new System.Drawing.Size(336, 88);
            this.NewInboundOrderButton.TabIndex = 30;
            this.NewInboundOrderButton.Text = "New Inbound Order";
            this.NewInboundOrderButton.UseVisualStyleBackColor = false;
            // 
            // NewCustomerReturnButton
            // 
            this.NewCustomerReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewCustomerReturnButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NewCustomerReturnButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerReturnButton.ForeColor = System.Drawing.Color.White;
            this.NewCustomerReturnButton.Location = new System.Drawing.Point(461, 166);
            this.NewCustomerReturnButton.Name = "NewCustomerReturnButton";
            this.NewCustomerReturnButton.Size = new System.Drawing.Size(336, 88);
            this.NewCustomerReturnButton.TabIndex = 31;
            this.NewCustomerReturnButton.Text = "New Customer Return";
            this.NewCustomerReturnButton.UseVisualStyleBackColor = false;
            // 
            // BatchIDComboBox
            // 
            this.BatchIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDComboBox.DataSource = this.stockInTableBindingSource;
            this.BatchIDComboBox.DisplayMember = "Stock_In_ID";
            this.BatchIDComboBox.FormattingEnabled = true;
            this.BatchIDComboBox.Location = new System.Drawing.Point(152, 283);
            this.BatchIDComboBox.Name = "BatchIDComboBox";
            this.BatchIDComboBox.Size = new System.Drawing.Size(277, 24);
            this.BatchIDComboBox.TabIndex = 33;
            // 
            // stockInTableBindingSource
            // 
            this.stockInTableBindingSource.DataMember = "StockInTable";
            this.stockInTableBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentStatusComboBox
            // 
            this.PaymentStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaymentStatusComboBox.DataSource = this.paymentStatusBindingSource;
            this.PaymentStatusComboBox.DisplayMember = "Status";
            this.PaymentStatusComboBox.FormattingEnabled = true;
            this.PaymentStatusComboBox.Location = new System.Drawing.Point(1097, 394);
            this.PaymentStatusComboBox.Name = "PaymentStatusComboBox";
            this.PaymentStatusComboBox.Size = new System.Drawing.Size(265, 24);
            this.PaymentStatusComboBox.TabIndex = 39;
            this.PaymentStatusComboBox.ValueMember = "Id";
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemNameComboBox.DataSource = this.itemBindingSource;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(127, 394);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(265, 24);
            this.ItemNameComboBox.TabIndex = 37;
            this.ItemNameComboBox.ValueMember = "Item_ID";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // DateInFromDateTimePicker
            // 
            this.DateInFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateInFromDateTimePicker.Location = new System.Drawing.Point(234, 336);
            this.DateInFromDateTimePicker.Name = "DateInFromDateTimePicker";
            this.DateInFromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateInFromDateTimePicker.TabIndex = 40;
            // 
            // DateInToDateTimePicker
            // 
            this.DateInToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateInToDateTimePicker.Location = new System.Drawing.Point(554, 336);
            this.DateInToDateTimePicker.Name = "DateInToDateTimePicker";
            this.DateInToDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateInToDateTimePicker.TabIndex = 42;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SupplierComboBox.DataSource = this.supplierCustmerListBindingSource;
            this.SupplierComboBox.DisplayMember = "Name";
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(622, 396);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(265, 24);
            this.SupplierComboBox.TabIndex = 45;
            this.SupplierComboBox.ValueMember = "Supplier_or_Customer_ID";
            // 
            // stockInTableTableAdapter
            // 
            this.stockInTableTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // supplierCustmerListBindingSource
            // 
            this.supplierCustmerListBindingSource.DataMember = "SupplierCustmerList";
            this.supplierCustmerListBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // supplierCustmerListTableAdapter
            // 
            this.supplierCustmerListTableAdapter.ClearBeforeFill = true;
            // 
            // paymentStatusBindingSource
            // 
            this.paymentStatusBindingSource.DataMember = "PaymentStatus";
            this.paymentStatusBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // paymentStatusTableAdapter
            // 
            this.paymentStatusTableAdapter.ClearBeforeFill = true;
            // 
            // StockIn_ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(DateInToLabel);
            this.Controls.Add(this.DateInToDateTimePicker);
            this.Controls.Add(DateInFromLabel);
            this.Controls.Add(this.DateInFromDateTimePicker);
            this.Controls.Add(PaymentStatusLabel);
            this.Controls.Add(this.PaymentStatusComboBox);
            this.Controls.Add(ItemNameLabel);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(DateInLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.BatchIDComboBox);
            this.Controls.Add(this.NewCustomerReturnButton);
            this.Controls.Add(this.NewInboundOrderButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StockInDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "StockIn_ManagementForm";
            this.Text = "Ranga Hardware Stock Management / Stock In Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockIn_ManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.StockIn_ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockInDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierCustmerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridView StockInDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button NewInboundOrderButton;
        private System.Windows.Forms.Button NewCustomerReturnButton;
        private System.Windows.Forms.ComboBox BatchIDComboBox;
        private System.Windows.Forms.ComboBox PaymentStatusComboBox;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.DateTimePicker DateInFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateInToDateTimePicker;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource stockInTableBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockInTableTableAdapter stockInTableTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource supplierCustmerListBindingSource;
        private Ranga_hardwareDataSetTableAdapters.SupplierCustmerListTableAdapter supplierCustmerListTableAdapter;
        private System.Windows.Forms.BindingSource paymentStatusBindingSource;
        private Ranga_hardwareDataSetTableAdapters.PaymentStatusTableAdapter paymentStatusTableAdapter;
    }
}