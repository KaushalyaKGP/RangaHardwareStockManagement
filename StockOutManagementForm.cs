using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangaHardwareStock
{
    public partial class StockOutManagementForm : Form
    {
        private static StockOutManagementForm _stockOutManagementForm = new StockOutManagementForm();

        public static void ShowForm()
        {

            if (StockOutManagementForm.ActiveForm == null)
            {
                _stockOutManagementForm = new StockOutManagementForm();
            }
            _stockOutManagementForm.Show();
            _stockOutManagementForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _stockOutManagementForm.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();

        public StockOutManagementForm()
        {
            InitializeComponent();
        }

        private void SetInitioalStage()
        {
            this.BatchIDComboBox.Text = "All";
            this.TypeComboBox.Text = "All";
            this.ItemComboBox.Text = "All";
            this.DateInFromDateTimePicker.Value = Convert.ToDateTime("1/1/2020");
            this.DateInToDateTimePicker.Value = DateTime.Today;
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

        public static implicit operator StockOutManagementForm(StockIn_ManagementForm v)
        {
            throw new NotImplementedException();
        }

        private void StockOutManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StockOutManagementForm.ActiveForm.Close();
        }
    }
}
