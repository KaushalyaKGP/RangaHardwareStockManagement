
namespace RangaHardwareStock
{
    partial class ItemForm
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
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label ItemIDLabel;
            this.SaveUpdateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StockStatusTextBox = new System.Windows.Forms.TextBox();
            this.DiscriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StockStatusLabel = new System.Windows.Forms.Label();
            this.AddNew = new System.Windows.Forms.Button();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.CurrentStockTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.CustomerReturnStockTextBox = new System.Windows.Forms.TextBox();
            this.CustomerReturnStockLabel = new System.Windows.Forms.Label();
            this.MinQuantityLabel = new System.Windows.Forms.Label();
            this.MinQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MeasuringUnitTextBox = new System.Windows.Forms.TextBox();
            this.MeasuringUnitLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.supplierTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter();
            this.ExitButton = new System.Windows.Forms.Button();
            SupplierCustomerLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            ItemIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierCustomerLabel
            // 
            SupplierCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            SupplierCustomerLabel.AutoSize = true;
            SupplierCustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SupplierCustomerLabel.Location = new System.Drawing.Point(44, 161);
            SupplierCustomerLabel.Name = "SupplierCustomerLabel";
            SupplierCustomerLabel.Size = new System.Drawing.Size(109, 20);
            SupplierCustomerLabel.TabIndex = 218;
            SupplierCustomerLabel.Text = "Discription :";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameLabel.Location = new System.Drawing.Point(44, 134);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(66, 20);
            NameLabel.TabIndex = 217;
            NameLabel.Text = "Name :";
            // 
            // ItemIDLabel
            // 
            ItemIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ItemIDLabel.AutoSize = true;
            ItemIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ItemIDLabel.Location = new System.Drawing.Point(44, 106);
            ItemIDLabel.Name = "ItemIDLabel";
            ItemIDLabel.Size = new System.Drawing.Size(76, 20);
            ItemIDLabel.TabIndex = 216;
            ItemIDLabel.Text = "Item ID :";
            // 
            // SaveUpdateButton
            // 
            this.SaveUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveUpdateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveUpdateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUpdateButton.ForeColor = System.Drawing.Color.White;
            this.SaveUpdateButton.Location = new System.Drawing.Point(948, 346);
            this.SaveUpdateButton.Name = "SaveUpdateButton";
            this.SaveUpdateButton.Size = new System.Drawing.Size(219, 47);
            this.SaveUpdateButton.TabIndex = 231;
            this.SaveUpdateButton.Text = "Update Item";
            this.SaveUpdateButton.UseVisualStyleBackColor = false;
            this.SaveUpdateButton.Click += new System.EventHandler(this.SaveUpdateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.UpdateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(333, 432);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(270, 80);
            this.UpdateButton.TabIndex = 230;
            this.UpdateButton.Text = "Update Selected Record";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1173, 346);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 47);
            this.SaveButton.TabIndex = 229;
            this.SaveButton.Text = "Save  Item";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StockStatusTextBox
            // 
            this.StockStatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StockStatusTextBox.Location = new System.Drawing.Point(186, 234);
            this.StockStatusTextBox.MaxLength = 12;
            this.StockStatusTextBox.Name = "StockStatusTextBox";
            this.StockStatusTextBox.ReadOnly = true;
            this.StockStatusTextBox.Size = new System.Drawing.Size(183, 22);
            this.StockStatusTextBox.TabIndex = 226;
            // 
            // DiscriptionRichTextBox
            // 
            this.DiscriptionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiscriptionRichTextBox.Location = new System.Drawing.Point(186, 161);
            this.DiscriptionRichTextBox.Name = "DiscriptionRichTextBox";
            this.DiscriptionRichTextBox.Size = new System.Drawing.Size(1198, 67);
            this.DiscriptionRichTextBox.TabIndex = 225;
            this.DiscriptionRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox.Location = new System.Drawing.Point(186, 133);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(1198, 22);
            this.NameTextBox.TabIndex = 224;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(1005, 857);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 47);
            this.ResetButton.TabIndex = 223;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StockStatusLabel
            // 
            this.StockStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StockStatusLabel.AutoSize = true;
            this.StockStatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockStatusLabel.Location = new System.Drawing.Point(43, 235);
            this.StockStatusLabel.Name = "StockStatusLabel";
            this.StockStatusLabel.Size = new System.Drawing.Size(121, 20);
            this.StockStatusLabel.TabIndex = 222;
            this.StockStatusLabel.Text = "Stock Status :";
            // 
            // AddNew
            // 
            this.AddNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddNew.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew.ForeColor = System.Drawing.Color.Black;
            this.AddNew.Location = new System.Drawing.Point(44, 432);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(270, 80);
            this.AddNew.TabIndex = 220;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemIDTextBox.Location = new System.Drawing.Point(186, 105);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.ReadOnly = true;
            this.ItemIDTextBox.Size = new System.Drawing.Size(183, 22);
            this.ItemIDTextBox.TabIndex = 219;
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.AllowUserToAddRows = false;
            this.ItemDataGridView.AllowUserToDeleteRows = false;
            this.ItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Location = new System.Drawing.Point(44, 533);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.ReadOnly = true;
            this.ItemDataGridView.RowHeadersWidth = 51;
            this.ItemDataGridView.RowTemplate.Height = 24;
            this.ItemDataGridView.Size = new System.Drawing.Size(1317, 318);
            this.ItemDataGridView.TabIndex = 215;
            this.ItemDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDataGridView_CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1205, 857);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 214;
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
            this.Titlelabel.Location = new System.Drawing.Point(247, 1);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 213;
            this.Titlelabel.Text = "Items";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentStockTextBox
            // 
            this.CurrentStockTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentStockTextBox.Location = new System.Drawing.Point(584, 234);
            this.CurrentStockTextBox.MaxLength = 12;
            this.CurrentStockTextBox.Name = "CurrentStockTextBox";
            this.CurrentStockTextBox.ReadOnly = true;
            this.CurrentStockTextBox.Size = new System.Drawing.Size(183, 22);
            this.CurrentStockTextBox.TabIndex = 233;
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockLabel.Location = new System.Drawing.Point(431, 235);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(132, 20);
            this.CurrentStockLabel.TabIndex = 232;
            this.CurrentStockLabel.Text = "Current Stock :";
            // 
            // CustomerReturnStockTextBox
            // 
            this.CustomerReturnStockTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerReturnStockTextBox.Location = new System.Drawing.Point(1052, 234);
            this.CustomerReturnStockTextBox.MaxLength = 12;
            this.CustomerReturnStockTextBox.Name = "CustomerReturnStockTextBox";
            this.CustomerReturnStockTextBox.ReadOnly = true;
            this.CustomerReturnStockTextBox.Size = new System.Drawing.Size(183, 22);
            this.CustomerReturnStockTextBox.TabIndex = 235;
            // 
            // CustomerReturnStockLabel
            // 
            this.CustomerReturnStockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerReturnStockLabel.AutoSize = true;
            this.CustomerReturnStockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReturnStockLabel.Location = new System.Drawing.Point(827, 235);
            this.CustomerReturnStockLabel.Name = "CustomerReturnStockLabel";
            this.CustomerReturnStockLabel.Size = new System.Drawing.Size(208, 20);
            this.CustomerReturnStockLabel.TabIndex = 234;
            this.CustomerReturnStockLabel.Text = "Customer Return Stock :";
            // 
            // MinQuantityLabel
            // 
            this.MinQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinQuantityLabel.AutoSize = true;
            this.MinQuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinQuantityLabel.Location = new System.Drawing.Point(43, 267);
            this.MinQuantityLabel.Name = "MinQuantityLabel";
            this.MinQuantityLabel.Size = new System.Drawing.Size(120, 20);
            this.MinQuantityLabel.TabIndex = 236;
            this.MinQuantityLabel.Text = "Min Quantity :";
            // 
            // MinQuantityNumericUpDown
            // 
            this.MinQuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinQuantityNumericUpDown.Location = new System.Drawing.Point(186, 262);
            this.MinQuantityNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MinQuantityNumericUpDown.Name = "MinQuantityNumericUpDown";
            this.MinQuantityNumericUpDown.Size = new System.Drawing.Size(183, 22);
            this.MinQuantityNumericUpDown.TabIndex = 237;
            this.MinQuantityNumericUpDown.ValueChanged += new System.EventHandler(this.MinQuantityNumericUpDown_ValueChanged);
            // 
            // MeasuringUnitTextBox
            // 
            this.MeasuringUnitTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MeasuringUnitTextBox.Location = new System.Drawing.Point(584, 262);
            this.MeasuringUnitTextBox.MaxLength = 12;
            this.MeasuringUnitTextBox.Name = "MeasuringUnitTextBox";
            this.MeasuringUnitTextBox.Size = new System.Drawing.Size(183, 22);
            this.MeasuringUnitTextBox.TabIndex = 239;
            // 
            // MeasuringUnitLabel
            // 
            this.MeasuringUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MeasuringUnitLabel.AutoSize = true;
            this.MeasuringUnitLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasuringUnitLabel.Location = new System.Drawing.Point(431, 263);
            this.MeasuringUnitLabel.Name = "MeasuringUnitLabel";
            this.MeasuringUnitLabel.Size = new System.Drawing.Size(142, 20);
            this.MeasuringUnitLabel.TabIndex = 238;
            this.MeasuringUnitLabel.Text = "Measuring Unit :";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(827, 263);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(99, 20);
            this.UnitPriceLabel.TabIndex = 240;
            this.UnitPriceLabel.Text = "Unit Price :";
            // 
            // UnitPriceNumericUpDown
            // 
            this.UnitPriceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitPriceNumericUpDown.DecimalPlaces = 2;
            this.UnitPriceNumericUpDown.Location = new System.Drawing.Point(1052, 262);
            this.UnitPriceNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.UnitPriceNumericUpDown.Name = "UnitPriceNumericUpDown";
            this.UnitPriceNumericUpDown.Size = new System.Drawing.Size(183, 22);
            this.UnitPriceNumericUpDown.TabIndex = 241;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 242;
            this.label1.Text = "Supplier :";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SupplierComboBox.DataSource = this.supplierBindingSource;
            this.SupplierComboBox.DisplayMember = "Name";
            this.SupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(186, 291);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(581, 24);
            this.SupplierComboBox.TabIndex = 243;
            this.SupplierComboBox.ValueMember = "Supplier_ID";
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
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1259, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 47);
            this.ExitButton.TabIndex = 250;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitPriceNumericUpDown);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.MeasuringUnitTextBox);
            this.Controls.Add(this.MeasuringUnitLabel);
            this.Controls.Add(this.MinQuantityNumericUpDown);
            this.Controls.Add(this.MinQuantityLabel);
            this.Controls.Add(this.CustomerReturnStockTextBox);
            this.Controls.Add(this.CustomerReturnStockLabel);
            this.Controls.Add(this.CurrentStockTextBox);
            this.Controls.Add(this.CurrentStockLabel);
            this.Controls.Add(this.SaveUpdateButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StockStatusTextBox);
            this.Controls.Add(this.DiscriptionRichTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StockStatusLabel);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.ItemIDTextBox);
            this.Controls.Add(SupplierCustomerLabel);
            this.Controls.Add(NameLabel);
            this.Controls.Add(ItemIDLabel);
            this.Controls.Add(this.ItemDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemForm_FormClosed);
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveUpdateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox StockStatusTextBox;
        private System.Windows.Forms.RichTextBox DiscriptionRichTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label StockStatusLabel;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.TextBox CurrentStockTextBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.TextBox CustomerReturnStockTextBox;
        private System.Windows.Forms.Label CustomerReturnStockLabel;
        private System.Windows.Forms.Label MinQuantityLabel;
        private System.Windows.Forms.NumericUpDown MinQuantityNumericUpDown;
        private System.Windows.Forms.TextBox MeasuringUnitTextBox;
        private System.Windows.Forms.Label MeasuringUnitLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.NumericUpDown UnitPriceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Ranga_hardwareDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.Button ExitButton;
    }
}