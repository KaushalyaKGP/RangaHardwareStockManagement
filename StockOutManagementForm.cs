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
    public partial class StockOutManagementForm : Form
    {
        public StockOutManagementForm()
        {
            InitializeComponent();
        }

        private void StockOutManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockOutType' table. You can move, or remove it, as needed.
            this.stockOutTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockOutType);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockOut' table. You can move, or remove it, as needed.
            this.stockOutTableAdapter.Fill(this.ranga_hardwareDataSet.StockOut);

        }
    }
}
