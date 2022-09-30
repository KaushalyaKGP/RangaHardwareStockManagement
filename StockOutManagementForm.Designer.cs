
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
            System.Windows.Forms.Label SupplierCustomerLabel;
            System.Windows.Forms.Label DateInToLabel;
            System.Windows.Forms.Label DateInFromLabel;
            System.Windows.Forms.Label DateInLabel;
            System.Windows.Forms.Label BatchIDLabel;
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.DateInToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateInFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BatchIDComboBox = new System.Windows.Forms.ComboBox();
            this.ReturnToSupplierButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.LostDamagedButton = new System.Windows.Forms.Button();
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.stockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockOutTableAdapter();
            this.stockOutTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutTypeTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockOutTypeTableAdapter();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            TypeLabel = new System.Windows.Forms.Label();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            DateInToLabel = new System.Windows.Forms.Label();
            DateInFromLabel = new System.Windows.Forms.Label();
            DateInLabel = new System.Windows.Forms.Label();
            BatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockOutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(51, 399);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(54, 20);
            SupplierCustomerLabel.TabIndex = 64;
            SupplierCustomerLabel.Text = "Item :";
            // 
            // DateInToLabel
            // 
            DateInToLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInToLabel.AutoSize = true;
            DateInToLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInToLabel.Location = new System.Drawing.Point(510, 343);
            DateInToLabel.Name = "DateInToLabel";
            DateInToLabel.Size = new System.Drawing.Size(39, 20);
            DateInToLabel.TabIndex = 63;
            DateInToLabel.Text = "To :";
            // 
            // DateInFromLabel
            // 
            DateInFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInFromLabel.AutoSize = true;
            DateInFromLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInFromLabel.Location = new System.Drawing.Point(167, 343);
            DateInFromLabel.Name = "DateInFromLabel";
            DateInFromLabel.Size = new System.Drawing.Size(60, 20);
            DateInFromLabel.TabIndex = 61;
            DateInFromLabel.Text = "From :";
            // 
            // DateInLabel
            // 
            DateInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DateInLabel.AutoSize = true;
            DateInLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateInLabel.Location = new System.Drawing.Point(51, 343);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new System.Drawing.Size(76, 20);
            DateInLabel.TabIndex = 57;
            DateInLabel.Text = "Date In :";
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
            // DateInToDateTimePicker
            // 
            this.DateInToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateInToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInToDateTimePicker.Location = new System.Drawing.Point(572, 342);
            this.DateInToDateTimePicker.Name = "DateInToDateTimePicker";
            this.DateInToDateTimePicker.Size = new System.Drawing.Size(238, 22);
            this.DateInToDateTimePicker.TabIndex = 62;
            // 
            // DateInFromDateTimePicker
            // 
            this.DateInFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateInFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInFromDateTimePicker.Location = new System.Drawing.Point(233, 342);
            this.DateInFromDateTimePicker.Name = "DateInFromDateTimePicker";
            this.DateInFromDateTimePicker.Size = new System.Drawing.Size(223, 22);
            this.DateInFromDateTimePicker.TabIndex = 60;
            this.DateInFromDateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
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
            // ReturnToSupplierButton
            // 
            this.ReturnToSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnToSupplierButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ReturnToSupplierButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToSupplierButton.ForeColor = System.Drawing.Color.White;
            this.ReturnToSupplierButton.Location = new System.Drawing.Point(449, 172);
            this.ReturnToSupplierButton.Name = "ReturnToSupplierButton";
            this.ReturnToSupplierButton.Size = new System.Drawing.Size(336, 88);
            this.ReturnToSupplierButton.TabIndex = 54;
            this.ReturnToSupplierButton.Text = "Return To Supplier";
            this.ReturnToSupplierButton.UseVisualStyleBackColor = false;
            // 
            // SalesButton
            // 
            this.SalesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SalesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Location = new System.Drawing.Point(44, 172);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(336, 88);
            this.SalesButton.TabIndex = 53;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = false;
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
            this.LostDamagedButton.Location = new System.Drawing.Point(854, 172);
            this.LostDamagedButton.Name = "LostDamagedButton";
            this.LostDamagedButton.Size = new System.Drawing.Size(336, 88);
            this.LostDamagedButton.TabIndex = 68;
            this.LostDamagedButton.Text = "Lost / Damaged";
            this.LostDamagedButton.UseVisualStyleBackColor = false;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockOutBindingSource
            // 
            this.stockOutBindingSource.DataMember = "StockOut";
            this.stockOutBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // stockOutTableAdapter
            // 
            this.stockOutTableAdapter.ClearBeforeFill = true;
            // 
            // stockOutTypeBindingSource
            // 
            this.stockOutTypeBindingSource.DataMember = "StockOutType";
            this.stockOutTypeBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // stockOutTypeTableAdapter
            // 
            this.stockOutTypeTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.ranga_hardwareDataSet;
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
            this.Controls.Add(this.LostDamagedButton);
            this.Controls.Add(TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(DateInToLabel);
            this.Controls.Add(this.DateInToDateTimePicker);
            this.Controls.Add(DateInFromLabel);
            this.Controls.Add(this.DateInFromDateTimePicker);
            this.Controls.Add(DateInLabel);
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
            this.Load += new System.EventHandler(this.StockOutManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.DateTimePicker DateInToDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateInFromDateTimePicker;
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
        private System.Windows.Forms.BindingSource stockOutBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockOutTableAdapter stockOutTableAdapter;
        private System.Windows.Forms.BindingSource stockOutTypeBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockOutTypeTableAdapter stockOutTypeTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
    }
}