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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private static IndexForm index = new IndexForm();

        public static void showForm()
        { index.Show(); }

        public static void HideForm()
        { index.Hide(); }
        private void CurrentStockButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentStockManagementForm currentStock = new CurrentStockManagementForm();
            currentStock.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //to - do -- direct to login page
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void IndexForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
