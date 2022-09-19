
namespace RangaHardwareStock
{
    partial class CurrentStockManagementForm
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label StockLevelLabel;
            this.Titlelabel = new System.Windows.Forms.Label();
            this.item_IDComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.item_NameComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_NameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.CurrentStockDataGridView = new System.Windows.Forms.DataGridView();
            this.itemTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ItemTableAdapter();
            this.ResetButton = new System.Windows.Forms.Button();
            this.supplierTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter();
            this.StockLevelComboBox = new System.Windows.Forms.ComboBox();
            this.stockLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockLevelTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.StockLevelTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            StockLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_IDLabel.AutoSize = true;
            item_IDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_IDLabel.Location = new System.Drawing.Point(37, 253);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(72, 20);
            item_IDLabel.TabIndex = 5;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_NameLabel
            // 
            item_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_NameLabel.AutoSize = true;
            item_NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NameLabel.Location = new System.Drawing.Point(37, 204);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(102, 20);
            item_NameLabel.TabIndex = 7;
            item_NameLabel.Text = "Item Name:";
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplier_NameLabel.Location = new System.Drawing.Point(551, 204);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(88, 20);
            supplier_NameLabel.TabIndex = 13;
            supplier_NameLabel.Text = "Supplier :";
            // 
            // StockLevelLabel
            // 
            StockLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            StockLevelLabel.AutoSize = true;
            StockLevelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StockLevelLabel.Location = new System.Drawing.Point(551, 256);
            StockLevelLabel.Name = "StockLevelLabel";
            StockLevelLabel.Size = new System.Drawing.Size(113, 20);
            StockLevelLabel.TabIndex = 19;
            StockLevelLabel.Text = "Stock Level :";
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(403, 41);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(541, 108);
            this.Titlelabel.TabIndex = 5;
            this.Titlelabel.Text = "Current Stock";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_IDComboBox
            // 
            this.item_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_IDComboBox.DataSource = this.itemBindingSource;
            this.item_IDComboBox.DisplayMember = "Item_ID";
            this.item_IDComboBox.FormattingEnabled = true;
            this.item_IDComboBox.Location = new System.Drawing.Point(159, 250);
            this.item_IDComboBox.Name = "item_IDComboBox";
            this.item_IDComboBox.Size = new System.Drawing.Size(355, 24);
            this.item_IDComboBox.TabIndex = 6;
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
            // item_NameComboBox
            // 
            this.item_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_NameComboBox.DataSource = this.itemBindingSource;
            this.item_NameComboBox.DisplayMember = "Item_Name";
            this.item_NameComboBox.FormattingEnabled = true;
            this.item_NameComboBox.Location = new System.Drawing.Point(159, 201);
            this.item_NameComboBox.Name = "item_NameComboBox";
            this.item_NameComboBox.Size = new System.Drawing.Size(355, 24);
            this.item_NameComboBox.TabIndex = 8;
            // 
            // supplier_NameComboBox
            // 
            this.supplier_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.supplier_NameComboBox.DataSource = this.supplierBindingSource;
            this.supplier_NameComboBox.DisplayMember = "Name";
            this.supplier_NameComboBox.FormattingEnabled = true;
            this.supplier_NameComboBox.Location = new System.Drawing.Point(676, 201);
            this.supplier_NameComboBox.Name = "supplier_NameComboBox";
            this.supplier_NameComboBox.Size = new System.Drawing.Size(355, 24);
            this.supplier_NameComboBox.TabIndex = 14;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1039, 250);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 47);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CurrentStockDataGridView
            // 
            this.CurrentStockDataGridView.AllowUserToAddRows = false;
            this.CurrentStockDataGridView.AllowUserToDeleteRows = false;
            this.CurrentStockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrentStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentStockDataGridView.Location = new System.Drawing.Point(40, 323);
            this.CurrentStockDataGridView.Name = "CurrentStockDataGridView";
            this.CurrentStockDataGridView.ReadOnly = true;
            this.CurrentStockDataGridView.RowHeadersWidth = 51;
            this.CurrentStockDataGridView.RowTemplate.Height = 24;
            this.CurrentStockDataGridView.Size = new System.Drawing.Size(1260, 492);
            this.CurrentStockDataGridView.TabIndex = 17;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1201, 250);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 18;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // StockLevelComboBox
            // 
            this.StockLevelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StockLevelComboBox.DataSource = this.stockLevelBindingSource;
            this.StockLevelComboBox.DisplayMember = "Value";
            this.StockLevelComboBox.FormattingEnabled = true;
            this.StockLevelComboBox.Location = new System.Drawing.Point(676, 253);
            this.StockLevelComboBox.Name = "StockLevelComboBox";
            this.StockLevelComboBox.Size = new System.Drawing.Size(355, 24);
            this.StockLevelComboBox.TabIndex = 20;
            this.StockLevelComboBox.ValueMember = "LevelCode";
            // 
            // stockLevelBindingSource
            // 
            this.stockLevelBindingSource.DataMember = "StockLevel";
            this.stockLevelBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // stockLevelTableAdapter
            // 
            this.stockLevelTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1144, 831);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(156, 47);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CurrentStockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 904);
            this.Controls.Add(this.backButton);
            this.Controls.Add(StockLevelLabel);
            this.Controls.Add(this.StockLevelComboBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CurrentStockDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDComboBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameComboBox);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameComboBox);
            this.Controls.Add(this.Titlelabel);
            this.MinimizeBox = false;
            this.Name = "CurrentStockManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranga Hardware Stock Management / Current Stock Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentStockManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.CurrentStockManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.ComboBox item_IDComboBox;
        private System.Windows.Forms.ComboBox item_NameComboBox;
        private System.Windows.Forms.ComboBox supplier_NameComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView CurrentStockDataGridView;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.ComboBox StockLevelComboBox;
        private System.Windows.Forms.BindingSource stockLevelBindingSource;
        private Ranga_hardwareDataSetTableAdapters.StockLevelTableAdapter stockLevelTableAdapter;
        private System.Windows.Forms.Button backButton;
    }
}