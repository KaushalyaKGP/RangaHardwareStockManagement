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
    public partial class StockIn_ManagementForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();

        public StockIn_ManagementForm()
        {
            InitializeComponent();
        }

        //Set Initil stage of form
        private void SetInitioalStage()
        {
            this.BatchIDComboBox.Text = "All";
            this.ItemNameComboBox.Text = "All";
            this.SupplierComboBox.Text = "All";
            this.PaymentStatusComboBox.Text = "All";


            StockInDataGridView.DataSource = dt;
        }
        //--------------------------------

        //Reset Button Click Event 
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.SetInitioalStage();
        }
        //.................................

        private void StockIn_ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.PaymentStatus' table. You can move, or remove it, as needed.
            this.paymentStatusTableAdapter.Fill(this.ranga_hardwareDataSet.PaymentStatus);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.SupplierCustmerList' table. You can move, or remove it, as needed.
            this.supplierCustmerListTableAdapter.Fill(this.ranga_hardwareDataSet.SupplierCustmerList);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Customer' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockInTable' table. You can move, or remove it, as needed.
            this.stockInTableTableAdapter.Fill(this.ranga_hardwareDataSet.StockInTable);
            this.ActiveControl = this.SearchButton;

            //Fill data grid
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT SI.Stock_In_ID,ST.Type,SI.In_Date AS Stock_In_Date,S.Name AS Supplier_Name, C.Name AS Customer_Name ,PS.Status AS Payment_Status 
FROM StockInTable SI
LEFT JOIN InboundOrderIn IB
ON SI.Stock_In_ID = IB.Stock_In_Id
LEFT JOIN StockInType ST
ON SI.Type = ST.Id
LEFT JOIN Supplier S
ON IB.Supplier_ID = S.Supplier_ID
LEFT JOIN CustomerReturn CR
ON CR.Stock_In_ID = SI.Stock_In_ID
LEFT JOIN Sales SL
ON SL.Stock_Out_Id = CR.Stock_Out_ID
LEFT JOIN Customer C
ON C.Customer_ID = SL.Customer_ID
LEFT JOIN PaymentStatus PS
ON PS.Id = IB.Payment_Status", con);
            sda.Fill(dt);

            this.SetInitioalStage();

        }

        private void StockIn_ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
