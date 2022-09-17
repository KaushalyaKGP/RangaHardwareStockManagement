using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangaHardwareStock
{
    public partial class StockIn_ManagementForm : Form
    {
        public StockIn_ManagementForm()
        {
            InitializeComponent();
        }

        //Set Initil stage of form
        private void SetInitioalStage()
        {
            this.BatchIDComboBox.Text = "All";
            //this.item_IDComboBox.Text = "All";
            //this.supplier_NameComboBox.Text = "All";
            //this.StockLevelComboBox.Text = "All";


            //CurrentStockDataGridView.DataSource = dt;
        }
        //--------------------------------

        private void StockIn_ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockInTable' table. You can move, or remove it, as needed.
            this.stockInTableTableAdapter.Fill(this.ranga_hardwareDataSet.StockInTable);

        }

        private void StockIn_ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }
    }
}
