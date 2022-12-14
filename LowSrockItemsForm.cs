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
    public partial class LowSrockItemsForm : Form
    {
        public LowSrockItemsForm()
        {
            InitializeComponent();
        }

        private void LowSrockItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Optimal_Order_Quantity_Analysis' table. You can move, or remove it, as needed.
            this.optimal_Order_Quantity_AnalysisTableAdapter.Fill(this.ranga_hardwareDataSet.Optimal_Order_Quantity_Analysis);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Optimal_Order_Quantity_Analysis' table. You can move, or remove it, as needed.
            this.optimal_Order_Quantity_AnalysisTableAdapter.Fill(this.ranga_hardwareDataSet.Optimal_Order_Quantity_Analysis);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LowSrockItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }
    }
}
