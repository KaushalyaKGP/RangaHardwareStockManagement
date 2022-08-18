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
    public partial class CurrentStockManagementForm : Form
    {
        public CurrentStockManagementForm()
        {
            InitializeComponent();
        }

        private void CurrentStockManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }

        

        private void CurrentStockManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CurrentStockManagementForm.ActiveForm.Close();
        }
    }
}
