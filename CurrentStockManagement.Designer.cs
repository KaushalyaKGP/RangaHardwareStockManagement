
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            this.Titlelabel = new System.Windows.Forms.Label();
            this.item_IDComboBox = new System.Windows.Forms.ComboBox();
            this.item_NameComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_IDComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CurrentStockDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesuring_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(452, 41);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(501, 108);
            this.Titlelabel.TabIndex = 5;
            this.Titlelabel.Text = "Current Stock";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_IDLabel
            // 
            item_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(37, 253);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(55, 17);
            item_IDLabel.TabIndex = 5;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_IDComboBox
            // 
            this.item_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_IDComboBox.FormattingEnabled = true;
            this.item_IDComboBox.Location = new System.Drawing.Point(142, 250);
            this.item_IDComboBox.Name = "item_IDComboBox";
            this.item_IDComboBox.Size = new System.Drawing.Size(362, 24);
            this.item_IDComboBox.TabIndex = 6;
            // 
            // item_NameLabel
            // 
            item_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_NameLabel.AutoSize = true;
            item_NameLabel.Location = new System.Drawing.Point(37, 204);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(79, 17);
            item_NameLabel.TabIndex = 7;
            item_NameLabel.Text = "Item Name:";
            // 
            // item_NameComboBox
            // 
            this.item_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_NameComboBox.FormattingEnabled = true;
            this.item_NameComboBox.Location = new System.Drawing.Point(142, 201);
            this.item_NameComboBox.Name = "item_NameComboBox";
            this.item_NameComboBox.Size = new System.Drawing.Size(362, 24);
            this.item_NameComboBox.TabIndex = 8;
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(588, 200);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(81, 17);
            supplier_IDLabel.TabIndex = 13;
            supplier_IDLabel.Text = "Supplier ID:";
            // 
            // supplier_IDComboBox
            // 
            this.supplier_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.supplier_IDComboBox.FormattingEnabled = true;
            this.supplier_IDComboBox.Location = new System.Drawing.Point(693, 197);
            this.supplier_IDComboBox.Name = "supplier_IDComboBox";
            this.supplier_IDComboBox.Size = new System.Drawing.Size(362, 24);
            this.supplier_IDComboBox.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1201, 235);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 47);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1201, 845);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CurrentStockDataGridView
            // 
            this.CurrentStockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrentStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Item_Name,
            this.Current_Stock,
            this.Mesuring_Unit,
            this.Supplier});
            this.CurrentStockDataGridView.Location = new System.Drawing.Point(40, 323);
            this.CurrentStockDataGridView.Name = "CurrentStockDataGridView";
            this.CurrentStockDataGridView.RowHeadersWidth = 51;
            this.CurrentStockDataGridView.RowTemplate.Height = 24;
            this.CurrentStockDataGridView.Size = new System.Drawing.Size(1317, 492);
            this.CurrentStockDataGridView.TabIndex = 17;
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.MinimumWidth = 6;
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Current_Stock
            // 
            this.Current_Stock.HeaderText = "Current_Stock";
            this.Current_Stock.MinimumWidth = 6;
            this.Current_Stock.Name = "Current_Stock";
            this.Current_Stock.ReadOnly = true;
            // 
            // Mesuring_Unit
            // 
            this.Mesuring_Unit.HeaderText = "Mesuring_Unit";
            this.Mesuring_Unit.MinimumWidth = 6;
            this.Mesuring_Unit.Name = "Mesuring_Unit";
            this.Mesuring_Unit.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // CurrentStockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.CurrentStockDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDComboBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameComboBox);
            this.Controls.Add(supplier_IDLabel);
            this.Controls.Add(this.supplier_IDComboBox);
            this.Controls.Add(this.Titlelabel);
            this.Name = "CurrentStockManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranga Hardware Stock Management / Current Stock Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentStockManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.CurrentStockManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.ComboBox item_IDComboBox;
        private System.Windows.Forms.ComboBox item_NameComboBox;
        private System.Windows.Forms.ComboBox supplier_IDComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView CurrentStockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesuring_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
    }
}