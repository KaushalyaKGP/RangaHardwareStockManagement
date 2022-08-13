
namespace RangaHardwareStock
{
    partial class HomeForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentStockManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutManahementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentStockButton = new System.Windows.Forms.Button();
            this.Title2label = new System.Windows.Forms.Label();
            this.Title1label = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.menuStrip);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(363, 1033);
            this.MenuPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.currentStockManagementToolStripMenuItem,
            this.stockInManagementToolStripMenuItem,
            this.stockOutManahementToolStripMenuItem,
            this.toolStripMenuItem3,
            this.supplierManagementToolStripMenuItem,
            this.itemManagementToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(363, 436);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(1, 10, 1, 10);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(359, 4);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(359, 32);
            this.toolStripMenuItem2.Text = "-------------------------------------------------";
            // 
            // currentStockManagementToolStripMenuItem
            // 
            this.currentStockManagementToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.currentStockManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.currentStockManagementToolStripMenuItem.Name = "currentStockManagementToolStripMenuItem";
            this.currentStockManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.currentStockManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.currentStockManagementToolStripMenuItem.Text = "Current Stock Management";
            // 
            // stockInManagementToolStripMenuItem
            // 
            this.stockInManagementToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.stockInManagementToolStripMenuItem.Name = "stockInManagementToolStripMenuItem";
            this.stockInManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.stockInManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.stockInManagementToolStripMenuItem.Text = "Stock In Management";
            // 
            // stockOutManahementToolStripMenuItem
            // 
            this.stockOutManahementToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.stockOutManahementToolStripMenuItem.Name = "stockOutManahementToolStripMenuItem";
            this.stockOutManahementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.stockOutManahementToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.stockOutManahementToolStripMenuItem.Text = "Stock Out Manahement";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(359, 32);
            this.toolStripMenuItem3.Text = "------------------------------------------------";
            // 
            // supplierManagementToolStripMenuItem
            // 
            this.supplierManagementToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.supplierManagementToolStripMenuItem.Name = "supplierManagementToolStripMenuItem";
            this.supplierManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.supplierManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.supplierManagementToolStripMenuItem.Text = "Supplier Management";
            // 
            // itemManagementToolStripMenuItem
            // 
            this.itemManagementToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.itemManagementToolStripMenuItem.Name = "itemManagementToolStripMenuItem";
            this.itemManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.itemManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 52);
            this.itemManagementToolStripMenuItem.Text = "Item Management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::RangaHardwareStock.Properties.Resources.hardware_tools_isolated_on_white_background_E9HYP9_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.CurrentStockButton);
            this.panel1.Controls.Add(this.Title2label);
            this.panel1.Controls.Add(this.Title1label);
            this.panel1.Location = new System.Drawing.Point(357, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 1033);
            this.panel1.TabIndex = 1;
            // 
            // CurrentStockButton
            // 
            this.CurrentStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStockButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CurrentStockButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockButton.ForeColor = System.Drawing.Color.White;
            this.CurrentStockButton.Location = new System.Drawing.Point(617, 754);
            this.CurrentStockButton.Name = "CurrentStockButton";
            this.CurrentStockButton.Size = new System.Drawing.Size(336, 88);
            this.CurrentStockButton.TabIndex = 5;
            this.CurrentStockButton.Text = "View Current Stock";
            this.CurrentStockButton.UseVisualStyleBackColor = false;
            // 
            // Title2label
            // 
            this.Title2label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title2label.BackColor = System.Drawing.Color.Transparent;
            this.Title2label.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2label.Location = new System.Drawing.Point(533, 346);
            this.Title2label.Margin = new System.Windows.Forms.Padding(0);
            this.Title2label.Name = "Title2label";
            this.Title2label.Size = new System.Drawing.Size(504, 375);
            this.Title2label.TabIndex = 4;
            this.Title2label.Text = "Ranga\r\nHardware\r\nStock\r\nManagement";
            this.Title2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title1label
            // 
            this.Title1label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title1label.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Title1label.Location = new System.Drawing.Point(463, 191);
            this.Title1label.Name = "Title1label";
            this.Title1label.Size = new System.Drawing.Size(644, 139);
            this.Title1label.TabIndex = 3;
            this.Title1label.Text = "Welcome !";
            this.Title1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = "Ranga Hardware Stock Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem currentStockManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutManahementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem supplierManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemManagementToolStripMenuItem;
        private System.Windows.Forms.Button CurrentStockButton;
        private System.Windows.Forms.Label Title2label;
        private System.Windows.Forms.Label Title1label;
    }
}