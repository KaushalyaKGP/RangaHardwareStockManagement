
namespace RangaHardwareStock
{
    partial class ABC_Analysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.ranga_hardwareDataSet = new RangaHardwareStock.Ranga_hardwareDataSet();
            this.aBCClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_ClassTableAdapter = new RangaHardwareStock.Ranga_hardwareDataSetTableAdapters.ABC_ClassTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClassADataGridView = new System.Windows.Forms.DataGridView();
            this.ClassA_Label = new System.Windows.Forms.Label();
            this.ClassB_Label = new System.Windows.Forms.Label();
            this.ClassBDataGridView = new System.Windows.Forms.DataGridView();
            this.ClassC_Label = new System.Windows.Forms.Label();
            this.ClassCDataGridView = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Titlelabel.BackColor = System.Drawing.SystemColors.Control;
            this.Titlelabel.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Black;
            this.Titlelabel.Location = new System.Drawing.Point(446, -7);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(506, 108);
            this.Titlelabel.TabIndex = 188;
            this.Titlelabel.Text = "ABC Analysis";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(928, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 50);
            this.label1.TabIndex = 189;
            this.label1.Text = "(Based on Sales Amount)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 190;
            this.label2.Text = "For the Year from :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FromDateLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateLabel.ForeColor = System.Drawing.Color.Black;
            this.FromDateLabel.Location = new System.Drawing.Point(228, 121);
            this.FromDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(145, 34);
            this.FromDateLabel.TabIndex = 191;
            this.FromDateLabel.Text = "From Date";
            this.FromDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(362, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 34);
            this.label4.TabIndex = 192;
            this.label4.Text = "To :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ToDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ToDateLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLabel.ForeColor = System.Drawing.Color.Black;
            this.ToDateLabel.Location = new System.Drawing.Point(409, 121);
            this.ToDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(145, 34);
            this.ToDateLabel.TabIndex = 193;
            this.ToDateLabel.Text = "To Date";
            this.ToDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ranga_hardwareDataSet
            // 
            this.ranga_hardwareDataSet.DataSetName = "Ranga_hardwareDataSet";
            this.ranga_hardwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBCClassBindingSource
            // 
            this.aBCClassBindingSource.DataMember = "ABC_Class";
            this.aBCClassBindingSource.DataSource = this.ranga_hardwareDataSet;
            // 
            // aBC_ClassTableAdapter
            // 
            this.aBC_ClassTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.aBCClassBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(48, 211);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Class";
            series1.XValueMember = "Class";
            series1.YValueMembers = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(452, 601);
            this.chart1.TabIndex = 194;
            this.chart1.Text = "chart1";
            // 
            // ClassADataGridView
            // 
            this.ClassADataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassADataGridView.Location = new System.Drawing.Point(580, 192);
            this.ClassADataGridView.Name = "ClassADataGridView";
            this.ClassADataGridView.ReadOnly = true;
            this.ClassADataGridView.RowHeadersWidth = 51;
            this.ClassADataGridView.RowTemplate.Height = 24;
            this.ClassADataGridView.Size = new System.Drawing.Size(772, 167);
            this.ClassADataGridView.TabIndex = 195;
            // 
            // ClassA_Label
            // 
            this.ClassA_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassA_Label.BackColor = System.Drawing.SystemColors.Control;
            this.ClassA_Label.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassA_Label.ForeColor = System.Drawing.Color.Black;
            this.ClassA_Label.Location = new System.Drawing.Point(576, 157);
            this.ClassA_Label.Margin = new System.Windows.Forms.Padding(0);
            this.ClassA_Label.Name = "ClassA_Label";
            this.ClassA_Label.Size = new System.Drawing.Size(316, 34);
            this.ClassA_Label.TabIndex = 196;
            this.ClassA_Label.Text = "Class A : ~70%";
            this.ClassA_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassB_Label
            // 
            this.ClassB_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassB_Label.BackColor = System.Drawing.SystemColors.Control;
            this.ClassB_Label.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassB_Label.ForeColor = System.Drawing.Color.Black;
            this.ClassB_Label.Location = new System.Drawing.Point(576, 377);
            this.ClassB_Label.Margin = new System.Windows.Forms.Padding(0);
            this.ClassB_Label.Name = "ClassB_Label";
            this.ClassB_Label.Size = new System.Drawing.Size(176, 34);
            this.ClassB_Label.TabIndex = 198;
            this.ClassB_Label.Text = "Class B : ~20%";
            this.ClassB_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassBDataGridView
            // 
            this.ClassBDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassBDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassBDataGridView.Location = new System.Drawing.Point(580, 416);
            this.ClassBDataGridView.Name = "ClassBDataGridView";
            this.ClassBDataGridView.ReadOnly = true;
            this.ClassBDataGridView.RowHeadersWidth = 51;
            this.ClassBDataGridView.RowTemplate.Height = 24;
            this.ClassBDataGridView.Size = new System.Drawing.Size(772, 167);
            this.ClassBDataGridView.TabIndex = 197;
            // 
            // ClassC_Label
            // 
            this.ClassC_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassC_Label.BackColor = System.Drawing.SystemColors.Control;
            this.ClassC_Label.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassC_Label.ForeColor = System.Drawing.Color.Black;
            this.ClassC_Label.Location = new System.Drawing.Point(576, 603);
            this.ClassC_Label.Margin = new System.Windows.Forms.Padding(0);
            this.ClassC_Label.Name = "ClassC_Label";
            this.ClassC_Label.Size = new System.Drawing.Size(176, 34);
            this.ClassC_Label.TabIndex = 200;
            this.ClassC_Label.Text = "Class C : ~10%";
            this.ClassC_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassCDataGridView
            // 
            this.ClassCDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassCDataGridView.Location = new System.Drawing.Point(580, 643);
            this.ClassCDataGridView.Name = "ClassCDataGridView";
            this.ClassCDataGridView.ReadOnly = true;
            this.ClassCDataGridView.RowHeadersWidth = 51;
            this.ClassCDataGridView.RowTemplate.Height = 24;
            this.ClassCDataGridView.Size = new System.Drawing.Size(772, 167);
            this.ClassCDataGridView.TabIndex = 199;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1259, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 47);
            this.ExitButton.TabIndex = 253;
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
            this.BackButton.Location = new System.Drawing.Point(1236, 845);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 47);
            this.BackButton.TabIndex = 254;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ABC_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 904);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.ClassC_Label);
            this.Controls.Add(this.ClassCDataGridView);
            this.Controls.Add(this.ClassB_Label);
            this.Controls.Add(this.ClassBDataGridView);
            this.Controls.Add(this.ClassA_Label);
            this.Controls.Add(this.ClassADataGridView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABC_Analysis";
            this.Text = "ABC_Analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABC_Analysis_FormClosed);
            this.Load += new System.EventHandler(this.ABC_Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ranga_hardwareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassCDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ToDateLabel;
        private Ranga_hardwareDataSet ranga_hardwareDataSet;
        private System.Windows.Forms.BindingSource aBCClassBindingSource;
        private Ranga_hardwareDataSetTableAdapters.ABC_ClassTableAdapter aBC_ClassTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView ClassADataGridView;
        private System.Windows.Forms.Label ClassA_Label;
        private System.Windows.Forms.Label ClassB_Label;
        private System.Windows.Forms.DataGridView ClassBDataGridView;
        private System.Windows.Forms.Label ClassC_Label;
        private System.Windows.Forms.DataGridView ClassCDataGridView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
    }
}