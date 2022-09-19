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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        //To rederect this form when hide
        private static HomeForm home = new HomeForm();

        public static void showForm()
        { home.Show(); }

        public static void HideForm()
        { home.Hide(); }


        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globles.loginIndex = false;
            IndexForm.showForm();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globles.loginIndex = false;
            IndexForm.showForm();
        }

        private void CurrentStockButton_Click(object sender, EventArgs e)
        {
            CurrentStockManagementForm currentStock = new CurrentStockManagementForm();
            this.Hide();
            currentStock.Show();
        }

        private void currentStockManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentStockButton.PerformClick();
        }

        private void stockInManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIn_ManagementForm stockIn = new StockIn_ManagementForm();
            this.Hide();
            stockIn.Show();
        }
    }
}
