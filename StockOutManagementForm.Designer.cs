
namespace RangaHardwareStock
{
    partial class StockOutManagementForm
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
            System.Windows.Forms.Label TypeLabel;
            System.Windows.Forms.Label ItemLabel;
            System.Windows.Forms.Label DateOutToLabel;
            System.Windows.Forms.Label DateOutFromLabel;
            System.Windows.Forms.Label DateOutLabel;
            System.Windows.Forms.Label BatchIDLabel;
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.stockOutTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateOutToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateOutFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BatchIDComboBox = new System.Windows.Forms.ComboBox();
            this.stockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReturnToSupplierButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.LostDamagedButton = new System.Windows.Forms.Button();
            this.OtherStockOutButton = new System.Windows.Forms.Button();
            this.stockOutTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockOutTableAdapter();
            this.stockOutTypeTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockOutTypeTableAdapter();
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            TypeLabel = new System.Windows.Forms.Label();
            ItemLabel = new System.Windows.Forms.Label();
            DateOutToLabel = new System.Windows.Forms.Label();
            DateOutFromLabel = new System.Windows.Forms.Label();
            DateOutLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TypeLabel.Location = new System.Drawing.Point(491, 289);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(59, 20);
            TypeLabel.TabIndex = 66;
            TypeLabel.Text = "Type :";
            // 
            // ItemLabel
            // 
            ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ItemLabel.AutoSize = true;
            ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ItemLabel.Location = new System.Drawing.Point(51, 399);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new System.Drawing.Size(54, 20);
            ItemLabel.TabIndex = 64;
            ItemLabel.Text = "Item :";
            // 
            // DateOutToLabel
            // 
            DateOutToLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateOutToLabel.AutoSize = true;
            DateOutToLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOutToLabel.Location = new System.Drawing.Point(510, 343);
            DateOutToLabel.Name = "DateOutToLabel";
            DateOutToLabel.Size = new System.Drawing.Size(39, 20);
            DateOutToLabel.TabIndex = 63;
            DateOutToLabel.Text = "To :";
            // 
            // DateOutFromLabel
            // 
            DateOutFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateOutFromLabel.AutoSize = true;
            DateOutFromLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOutFromLabel.Location = new System.Drawing.Point(167, 343);
            DateOutFromLabel.Name = "DateOutFromLabel";
            DateOutFromLabel.Size = new System.Drawing.Size(60, 20);
            DateOutFromLabel.TabIndex = 61;
            DateOutFromLabel.Text = "From :";
            // 
            // DateOutLabel
            // 
            DateOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateOutLabel.AutoSize = true;
            DateOutLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOutLabel.Location = new System.Drawing.Point(51, 343);
            DateOutLabel.Name = "DateOutLabel";
            DateOutLabel.Size = new System.Drawing.Size(90, 20);
            DateOutLabel.TabIndex = 57;
            DateOutLabel.Text = "Date Out :";
            // 
            // BatchIDLabel
            // 
            BatchIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            BatchIDLabel.AutoSize = true;
            BatchIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BatchIDLabel.Location = new System.Drawing.Point(51, 291);
            BatchIDLabel.Name = "BatchIDLabel";
            BatchIDLabel.Size = new System.Drawing.Size(88, 20);
            BatchIDLabel.TabIndex = 55;
            BatchIDLabel.Text = "Batch ID :";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeComboBox.DataSource = this.stockOutTypeBindingSource;
            this.TypeComboBox.DisplayMember = "Type";
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(579, 287);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(277, 24);
            this.TypeComboBox.TabIndex = 67;
            this.TypeComboBox.ValueMember = "Id";
            // 
            // stockOutTypeBindingSource
            // 
            this.stockOutTypeBindingSource.DataMember = "StockOutType";
            this.stockOutTypeBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemComboBox.DataSource = this.itemBindingSource;
            this.ItemComboBox.DisplayMember = "Item_Name";
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(151, 399);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(265, 24);
            this.ItemComboBox.TabIndex = 65;
            this.ItemComboBox.ValueMember = "Item_ID";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // DateOutToDateTimePicker
            // 
            this.DateOutToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateOutToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOutToDateTimePicker.Location = new System.Drawing.Point(572, 342);
            this.DateOutToDateTimePicker.Name = "DateOutToDateTimePicker";
            this.DateOutToDateTimePicker.Size = new System.Drawing.Size(238, 22);
            this.DateOutToDateTimePicker.TabIndex = 62;
            // 
            // DateOutFromDateTimePicker
            // 
            this.DateOutFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateOutFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOutFromDateTimePicker.Location = new System.Drawing.Point(233, 342);
            this.DateOutFromDateTimePicker.Name = "DateOutFromDateTimePicker";
            this.DateOutFromDateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateOutFromDateTimePicker.TabIndex = 60;
            this.DateOutFromDateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // BatchIDComboBox
            // 
            this.BatchIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatchIDComboBox.DataSource = this.stockOutBindingSource;
            this.BatchIDComboBox.DisplayMember = "Stock_Out_ID";
            this.BatchIDComboBox.FormattingEnabled = true;
            this.BatchIDComboBox.Location = new System.Drawing.Point(151, 289);
            this.BatchIDComboBox.Name = "BatchIDComboBox";
            this.BatchIDComboBox.Size = new System.Drawing.Size(277, 24);
            this.BatchIDComboBox.TabIndex = 56;
            this.BatchIDComboBox.ValueMember = "Stock_Out_ID";
            // 
            // stockOutBindingSource
            // 
            this.stockOutBindingSource.DataMember = "StockOut";
            this.stockOutBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ReturnToSupplierButton
            // 
            this.ReturnToSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnToSupplierButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ReturnToSupplierButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToSupplierButton.ForeColor = System.Drawing.Color.White;
            this.ReturnToSupplierButton.Location = new System.Drawing.Point(390, 172);
            this.ReturnToSupplierButton.Name = "ReturnToSupplierButton";
            this.ReturnToSupplierButton.Size = new System.Drawing.Size(284, 88);
            this.ReturnToSupplierButton.TabIndex = 54;
            this.ReturnToSupplierButton.Text = "Return To Supplier";
            this.ReturnToSupplierButton.UseVisualStyleBackColor = false;
            this.ReturnToSupplierButton.Click += new System.EventHandler(this.ReturnToSupplierButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SalesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Location = new System.Drawing.Point(44, 172);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(284, 88);
            this.SalesButton.TabIndex = 53;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1205, 451);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 52;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StockOutDataGridView
            // 
            this.StockOutDataGridView.AllowUserToAddRows = false;
            this.StockOutDataGridView.AllowUserToDeleteRows = false;
            this.StockOutDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StockOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockOutDataGridView.Location = new System.Drawing.Point(44, 530);
            this.StockOutDataGridView.Name = "StockOutDataGridView";
            this.StockOutDataGridView.ReadOnly = true;
            this.StockOutDataGridView.RowHeadersWidth = 51;
            this.StockOutDataGridView.RowTemplate.Height = 24;
            this.StockOutDataGridView.Size = new System.Drawing.Size(1317, 277);
            this.StockOutDataGridView.TabIndex = 51;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1205, 825);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 50;
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
            this.SearchButton.Location = new System.Drawing.Point(1004, 451);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 47);
            this.SearchButton.TabIndex = 49;
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
            this.Titlelabel.Location = new System.Drawing.Point(244, 33);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 48;
            this.Titlelabel.Text = "Stock Out Management";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LostDamagedButton
            // 
            this.LostDamagedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LostDamagedButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LostDamagedButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostDamagedButton.ForeColor = System.Drawing.Color.White;
            this.LostDamagedButton.Location = new System.Drawing.Point(736, 172);
            this.LostDamagedButton.Name = "LostDamagedButton";
            this.LostDamagedButton.Size = new System.Drawing.Size(284, 88);
            this.LostDamagedButton.TabIndex = 68;
            this.LostDamagedButton.Text = "Lost / Damaged";
            this.LostDamagedButton.UseVisualStyleBackColor = false;
            this.LostDamagedButton.Click += new System.EventHandler(this.LostDamagedButton_Click);
            // 
            // OtherStockOutButton
            // 
            this.OtherStockOutButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OtherStockOutButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OtherStockOutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherStockOutButton.ForeColor = System.Drawing.Color.White;
            this.OtherStockOutButton.Location = new System.Drawing.Point(1082, 172);
            this.OtherStockOutButton.Name = "OtherStockOutButton";
            this.OtherStockOutButton.Size = new System.Drawing.Size(284, 88);
            this.OtherStockOutButton.TabIndex = 69;
            this.OtherStockOutButton.Text = "Other";
            this.OtherStockOutButton.UseVisualStyleBackColor = false;
            // 
            // stockOutTableAdapter
            // 
            this.stockOutTableAdapter.ClearBeforeFill = true;
            // 
            // stockOutTypeTableAdapter
            // 
            this.stockOutTypeTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // StockOutManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.OtherStockOutButton);
            this.Controls.Add(this.LostDamagedButton);
            this.Controls.Add(TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(ItemLabel);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(DateOutToLabel);
            this.Controls.Add(this.DateOutToDateTimePicker);
            this.Controls.Add(DateOutFromLabel);
            this.Controls.Add(this.DateOutFromDateTimePicker);
            this.Controls.Add(DateOutLabel);
            this.Controls.Add(BatchIDLabel);
            this.Controls.Add(this.BatchIDComboBox);
            this.Controls.Add(this.ReturnToSupplierButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StockOutDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "StockOutManagementForm";
            this.Text = "Ranga Hardware Stock Management / Stock Out Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockOutManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.StockOutManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockOutDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.DateTimePicker DateOutToDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateOutFromDateTimePicker;
        private System.Windows.Forms.ComboBox BatchIDComboBox;
        private System.Windows.Forms.Button ReturnToSupplierButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridView StockOutDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button LostDamagedButton;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.Button OtherStockOutButton;
        private System.Windows.Forms.BindingSource stockOutBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockOutTableAdapter stockOutTableAdapter;
        private System.Windows.Forms.BindingSource stockOutTypeBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockOutTypeTableAdapter stockOutTypeTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
    }
}