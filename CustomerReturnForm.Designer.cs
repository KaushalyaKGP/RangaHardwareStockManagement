
namespace RangaHardwareStock
{
    partial class CustomerReturnForm
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
            System.Windows.Forms.Label ReasonLabel;
            System.Windows.Forms.Label DataLabel;
            System.Windows.Forms.Label CustomerReturnIDLabel;
            System.Windows.Forms.Label label1;
            this.SoldQuantityLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CustomerReturnIDTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.CRItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.customerReturnReasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.CRDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiscriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Unit2Label = new System.Windows.Forms.Label();
            this.SoldQuantityCountLable = new System.Windows.Forms.Label();
            this.UnitLable = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.customerReturnReasonTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.CustomerReturnReasonTableAdapter();
            ReasonLabel = new System.Windows.Forms.Label();
            DataLabel = new System.Windows.Forms.Label();
            CustomerReturnIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReturnReasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReasonLabel
            // 
            ReasonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ReasonLabel.AutoSize = true;
            ReasonLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ReasonLabel.Location = new System.Drawing.Point(915, 191);
            ReasonLabel.Name = "ReasonLabel";
            ReasonLabel.Size = new System.Drawing.Size(79, 20);
            ReasonLabel.TabIndex = 119;
            ReasonLabel.Text = "Reason :";
            // 
            // DataLabel
            // 
            DataLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DataLabel.AutoSize = true;
            DataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DataLabel.Location = new System.Drawing.Point(469, 191);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new System.Drawing.Size(57, 20);
            DataLabel.TabIndex = 117;
            DataLabel.Text = "Data :";
            // 
            // CustomerReturnIDLabel
            // 
            CustomerReturnIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CustomerReturnIDLabel.AutoSize = true;
            CustomerReturnIDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomerReturnIDLabel.Location = new System.Drawing.Point(45, 191);
            CustomerReturnIDLabel.Name = "CustomerReturnIDLabel";
            CustomerReturnIDLabel.Size = new System.Drawing.Size(179, 20);
            CustomerReturnIDLabel.TabIndex = 116;
            CustomerReturnIDLabel.Text = "Customer Return ID :";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(45, 286);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 20);
            label1.TabIndex = 136;
            label1.Text = "Discription :";
            // 
            // SoldQuantityLabel
            // 
            this.SoldQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SoldQuantityLabel.AutoSize = true;
            this.SoldQuantityLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.SoldQuantityLabel.Location = new System.Drawing.Point(1093, 475);
            this.SoldQuantityLabel.Name = "SoldQuantityLabel";
            this.SoldQuantityLabel.Size = new System.Drawing.Size(105, 17);
            this.SoldQuantityLabel.TabIndex = 135;
            this.SoldQuantityLabel.Text = "Sold Quantity : ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(999, 528);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(87, 20);
            this.QuantityLabel.TabIndex = 134;
            this.QuantityLabel.Text = "Quantity :";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(999, 450);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemLabel.TabIndex = 133;
            this.ItemLabel.Text = "Item :";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(999, 703);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(368, 47);
            this.SaveButton.TabIndex = 132;
            this.SaveButton.Text = "Save Customer Return";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(1093, 527);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.QuantityNumericUpDown.TabIndex = 128;
            // 
            // CustomerReturnIDTextBox
            // 
            this.CustomerReturnIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerReturnIDTextBox.Location = new System.Drawing.Point(240, 190);
            this.CustomerReturnIDTextBox.Name = "CustomerReturnIDTextBox";
            this.CustomerReturnIDTextBox.ReadOnly = true;
            this.CustomerReturnIDTextBox.Size = new System.Drawing.Size(165, 22);
            this.CustomerReturnIDTextBox.TabIndex = 127;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddItemButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(999, 566);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(156, 47);
            this.AddItemButton.TabIndex = 124;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(1093, 448);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(274, 24);
            this.ItemNameComboBox.TabIndex = 122;
            this.ItemNameComboBox.ValueMember = "Item_ID";
            this.ItemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameComboBox_SelectedIndexChanged);
            // 
            // CRItemsDataGridView
            // 
            this.CRItemsDataGridView.AllowUserToDeleteRows = false;
            this.CRItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CRItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CRItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CRItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Quantity});
            this.CRItemsDataGridView.Location = new System.Drawing.Point(50, 455);
            this.CRItemsDataGridView.Name = "CRItemsDataGridView";
            this.CRItemsDataGridView.ReadOnly = true;
            this.CRItemsDataGridView.RowHeadersWidth = 51;
            this.CRItemsDataGridView.RowTemplate.Height = 24;
            this.CRItemsDataGridView.Size = new System.Drawing.Size(883, 295);
            this.CRItemsDataGridView.TabIndex = 121;
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
            // ReasonComboBox
            // 
            this.ReasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReasonComboBox.DataSource = this.customerReturnReasonBindingSource;
            this.ReasonComboBox.DisplayMember = "Reason";
            this.ReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Location = new System.Drawing.Point(1015, 189);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(346, 24);
            this.ReasonComboBox.TabIndex = 120;
            this.ReasonComboBox.ValueMember = "Id";
            // 
            // customerReturnReasonBindingSource
            // 
            this.customerReturnReasonBindingSource.DataMember = "CustomerReturnReason";
            this.customerReturnReasonBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CRDateTimePicker
            // 
            this.CRDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CRDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CRDateTimePicker.Location = new System.Drawing.Point(535, 190);
            this.CRDateTimePicker.Name = "CRDateTimePicker";
            this.CRDateTimePicker.Size = new System.Drawing.Size(309, 22);
            this.CRDateTimePicker.TabIndex = 118;
            this.CRDateTimePicker.Value = new System.DateTime(2022, 9, 26, 0, 0, 0, 0);
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(244, 9);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(917, 108);
            this.Titlelabel.TabIndex = 115;
            this.Titlelabel.Text = "Customer Return";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(16, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 5);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // DiscriptionRichTextBox
            // 
            this.DiscriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptionRichTextBox.Location = new System.Drawing.Point(164, 286);
            this.DiscriptionRichTextBox.Name = "DiscriptionRichTextBox";
            this.DiscriptionRichTextBox.Size = new System.Drawing.Size(1202, 60);
            this.DiscriptionRichTextBox.TabIndex = 137;
            this.DiscriptionRichTextBox.Text = "";
            // 
            // Unit2Label
            // 
            this.Unit2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Unit2Label.AutoSize = true;
            this.Unit2Label.ForeColor = System.Drawing.Color.SeaGreen;
            this.Unit2Label.Location = new System.Drawing.Point(1328, 475);
            this.Unit2Label.Name = "Unit2Label";
            this.Unit2Label.Size = new System.Drawing.Size(33, 17);
            this.Unit2Label.TabIndex = 140;
            this.Unit2Label.Text = "Unit";
            // 
            // SoldQuantityCountLable
            // 
            this.SoldQuantityCountLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SoldQuantityCountLable.AutoSize = true;
            this.SoldQuantityCountLable.ForeColor = System.Drawing.Color.SeaGreen;
            this.SoldQuantityCountLable.Location = new System.Drawing.Point(1217, 475);
            this.SoldQuantityCountLable.Name = "SoldQuantityCountLable";
            this.SoldQuantityCountLable.Size = new System.Drawing.Size(61, 17);
            this.SoldQuantityCountLable.TabIndex = 139;
            this.SoldQuantityCountLable.Text = "Quantity";
            // 
            // UnitLable
            // 
            this.UnitLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UnitLable.AutoSize = true;
            this.UnitLable.Location = new System.Drawing.Point(1241, 530);
            this.UnitLable.Name = "UnitLable";
            this.UnitLable.Size = new System.Drawing.Size(33, 17);
            this.UnitLable.TabIndex = 138;
            this.UnitLable.Text = "Unit";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1211, 845);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 141;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // customerReturnReasonTableAdapter
            // 
            this.customerReturnReasonTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Unit2Label);
            this.Controls.Add(this.SoldQuantityCountLable);
            this.Controls.Add(this.UnitLable);
            this.Controls.Add(this.DiscriptionRichTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.SoldQuantityLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.CustomerReturnIDTextBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.CRItemsDataGridView);
            this.Controls.Add(ReasonLabel);
            this.Controls.Add(this.ReasonComboBox);
            this.Controls.Add(this.CRDateTimePicker);
            this.Controls.Add(DataLabel);
            this.Controls.Add(CustomerReturnIDLabel);
            this.Controls.Add(this.Titlelabel);
            this.Name = "CustomerReturnForm";
            this.Text = "Ranga Hardware Stock Management / Stock Out Management / Sales / Customer Return";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerReturnForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReturnReasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoldQuantityLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.TextBox CustomerReturnIDTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.DataGridView CRItemsDataGridView;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.DateTimePicker CRDateTimePicker;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.RichTextBox DiscriptionRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label Unit2Label;
        private System.Windows.Forms.Label SoldQuantityCountLable;
        private System.Windows.Forms.Label UnitLable;
        private System.Windows.Forms.Button BackButton;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource customerReturnReasonBindingSource;
        private Ranga_hardwareDataSetTableAdapters.CustomerReturnReasonTableAdapter customerReturnReasonTableAdapter;
    }
}