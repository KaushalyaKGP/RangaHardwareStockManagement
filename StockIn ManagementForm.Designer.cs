
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label supplier_NameLabel;
            this.ResetButton = new System.Windows.Forms.Button();
            this.CurrentStockDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.item_IDComboBox = new System.Windows.Forms.ComboBox();
            this.item_NameComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_NameComboBox = new System.Windows.Forms.ComboBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_IDLabel.AutoSize = true;
            item_IDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_IDLabel.Location = new System.Drawing.Point(42, 239);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(72, 20);
            item_IDLabel.TabIndex = 19;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_NameLabel
            // 
            item_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            item_NameLabel.AutoSize = true;
            item_NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NameLabel.Location = new System.Drawing.Point(42, 190);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(102, 20);
            item_NameLabel.TabIndex = 22;
            item_NameLabel.Text = "Item Name:";
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplier_NameLabel.Location = new System.Drawing.Point(674, 186);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(88, 20);
            supplier_NameLabel.TabIndex = 24;
            supplier_NameLabel.Text = "Supplier :";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1206, 236);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 29;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // CurrentStockDataGridView
            // 
            this.CurrentStockDataGridView.AllowUserToAddRows = false;
            this.CurrentStockDataGridView.AllowUserToDeleteRows = false;
            this.CurrentStockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrentStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentStockDataGridView.Location = new System.Drawing.Point(45, 309);
            this.CurrentStockDataGridView.Name = "CurrentStockDataGridView";
            this.CurrentStockDataGridView.ReadOnly = true;
            this.CurrentStockDataGridView.RowHeadersWidth = 51;
            this.CurrentStockDataGridView.RowTemplate.Height = 24;
            this.CurrentStockDataGridView.Size = new System.Drawing.Size(1317, 492);
            this.CurrentStockDataGridView.TabIndex = 28;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1206, 831);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1011, 236);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 47);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // item_IDComboBox
            // 
            this.item_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_IDComboBox.DisplayMember = "Item_ID";
            this.item_IDComboBox.FormattingEnabled = true;
            this.item_IDComboBox.Location = new System.Drawing.Point(164, 236);
            this.item_IDComboBox.Name = "item_IDComboBox";
            this.item_IDComboBox.Size = new System.Drawing.Size(370, 24);
            this.item_IDComboBox.TabIndex = 21;
            // 
            // item_NameComboBox
            // 
            this.item_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_NameComboBox.DisplayMember = "Item_Name";
            this.item_NameComboBox.FormattingEnabled = true;
            this.item_NameComboBox.Location = new System.Drawing.Point(164, 187);
            this.item_NameComboBox.Name = "item_NameComboBox";
            this.item_NameComboBox.Size = new System.Drawing.Size(370, 24);
            this.item_NameComboBox.TabIndex = 23;
            // 
            // supplier_NameComboBox
            // 
            this.supplier_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.supplier_NameComboBox.DisplayMember = "Name";
            this.supplier_NameComboBox.FormattingEnabled = true;
            this.supplier_NameComboBox.Location = new System.Drawing.Point(779, 183);
            this.supplier_NameComboBox.Name = "supplier_NameComboBox";
            this.supplier_NameComboBox.Size = new System.Drawing.Size(370, 24);
            this.supplier_NameComboBox.TabIndex = 25;
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
            // StockIn_ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CurrentStockDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDComboBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameComboBox);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameComboBox);
            this.Controls.Add(this.Titlelabel);
            this.Name = "StockIn_ManagementForm";
            this.Text = "Ranga Hardware Stock Management / Stock In Management";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentStockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridView CurrentStockDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox item_IDComboBox;
        private System.Windows.Forms.ComboBox item_NameComboBox;
        private System.Windows.Forms.ComboBox supplier_NameComboBox;
        private System.Windows.Forms.Label Titlelabel;
    }
}