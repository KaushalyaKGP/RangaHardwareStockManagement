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
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);

            this.item_NameComboBox.Text = "All";
            this.item_IDComboBox.Text = "All";
            this.supplier_NameComboBox.Text = "All";

            //fill data view
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s WHERE i.Supplier_ID = s.Supplier_ID ORDER BY i.Item_ID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CurrentStockDataGridView.DataSource = dt;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CurrentStockManagementForm.ActiveForm.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.item_NameComboBox.Text = "All";
            this.item_IDComboBox.Text = "All";
            this.supplier_NameComboBox.Text = "All";

            //need to add initial stage of table
        }
    }
}
