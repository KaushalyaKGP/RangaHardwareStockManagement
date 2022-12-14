
namespace RangaHardwareStock
{
    partial class LowSrockItemsForm
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
            this.Titlelabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anualSalesQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCostPerOrderRsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimalOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimalOrderQuantityAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.optimal_Order_Quantity_AnalysisTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.Optimal_Order_Quantity_AnalysisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimalOrderQuantityAnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(585, 5);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(733, 108);
            this.Titlelabel.TabIndex = 189;
            this.Titlelabel.Text = "Stock Low Items";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.anualSalesQuantityDataGridViewTextBoxColumn,
            this.stockStatusDataGridViewTextBoxColumn,
            this.orderCostPerOrderRsDataGridViewTextBoxColumn,
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn,
            this.optimalOrderQuantityDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.optimalOrderQuantityAnalysisBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 141);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1878, 797);
            this.dataGridView.TabIndex = 190;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1753, 18);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 47);
            this.ExitButton.TabIndex = 254;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1731, 967);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 255;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // anualSalesQuantityDataGridViewTextBoxColumn
            // 
            this.anualSalesQuantityDataGridViewTextBoxColumn.DataPropertyName = "AnualSalesQuantity";
            this.anualSalesQuantityDataGridViewTextBoxColumn.HeaderText = "AnualSalesQuantity";
            this.anualSalesQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anualSalesQuantityDataGridViewTextBoxColumn.Name = "anualSalesQuantityDataGridViewTextBoxColumn";
            // 
            // stockStatusDataGridViewTextBoxColumn
            // 
            this.stockStatusDataGridViewTextBoxColumn.DataPropertyName = "Stock Status";
            this.stockStatusDataGridViewTextBoxColumn.HeaderText = "Stock Status";
            this.stockStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockStatusDataGridViewTextBoxColumn.Name = "stockStatusDataGridViewTextBoxColumn";
            // 
            // orderCostPerOrderRsDataGridViewTextBoxColumn
            // 
            this.orderCostPerOrderRsDataGridViewTextBoxColumn.DataPropertyName = "Order Cost Per Order (Rs_)";
            this.orderCostPerOrderRsDataGridViewTextBoxColumn.HeaderText = "Order Cost Per Order (Rs_)";
            this.orderCostPerOrderRsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderCostPerOrderRsDataGridViewTextBoxColumn.Name = "orderCostPerOrderRsDataGridViewTextBoxColumn";
            // 
            // holdingCostPerUnitRsDataGridViewTextBoxColumn
            // 
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn.DataPropertyName = "Holding Cost Per Unit (Rs_)";
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn.HeaderText = "Holding Cost Per Unit (Rs_)";
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.holdingCostPerUnitRsDataGridViewTextBoxColumn.Name = "holdingCostPerUnitRsDataGridViewTextBoxColumn";
            // 
            // optimalOrderQuantityDataGridViewTextBoxColumn
            // 
            this.optimalOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Optimal Order Quantity";
            this.optimalOrderQuantityDataGridViewTextBoxColumn.HeaderText = "Optimal Order Quantity";
            this.optimalOrderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.optimalOrderQuantityDataGridViewTextBoxColumn.Name = "optimalOrderQuantityDataGridViewTextBoxColumn";
            this.optimalOrderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optimalOrderQuantityAnalysisBindingSource
            // 
            this.optimalOrderQuantityAnalysisBindingSource.DataMember = "Optimal Order Quantity Analysis";
            this.optimalOrderQuantityAnalysisBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // optimal_Order_Quantity_AnalysisTableAdapter
            // 
            this.optimal_Order_Quantity_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // LowSrockItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Titlelabel);
            this.Name = "LowSrockItemsForm";
            this.Text = "Low Stock Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LowSrockItemsForm_FormClosed);
            this.Load += new System.EventHandler(this.LowSrockItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimalOrderQuantityAnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource optimalOrderQuantityAnalysisBindingSource;
        private Ranga_hardwareDataSetTableAdapters.Optimal_Order_Quantity_AnalysisTableAdapter optimal_Order_Quantity_AnalysisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anualSalesQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCostPerOrderRsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingCostPerUnitRsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimalOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
    }
}