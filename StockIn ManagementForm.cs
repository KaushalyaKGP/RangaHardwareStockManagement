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
        bool formCloseIndex = false;
        private static StockIn_ManagementForm _stockIn_ManagementForm = new StockIn_ManagementForm();

        public static void ShowForm()
        {

            if (StockIn_ManagementForm.ActiveForm == null)
            {
                _stockIn_ManagementForm = new StockIn_ManagementForm();
            }
            _stockIn_ManagementForm.Show();
            _stockIn_ManagementForm.SetInitioalStage();
            
        }
        
        public static void HideForm()
        {
            _stockIn_ManagementForm.Hide();
        }

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
            this.TypeComboBox.Text = "All";
            this.SupplierComboBox.Text = "All";
            this.PaymentStatusComboBox.Text = "All";
            this.PaymentStatusComboBox.Enabled = false;
            this.DateInFromDateTimePicker.Value = Convert.ToDateTime("1/1/2020");
            //Fill data grid
            dt.Rows.Clear();
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
            StockInDataGridView.DataSource = dt;
        }
        //--------------------------------

        //Reset Button Click Event 
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.SetInitioalStage();
        }
        //.................................

        //Back Button Click Event
        private void BackButton_Click(object sender, EventArgs e)
        {
            StockIn_ManagementForm.ActiveForm.Close();
        }
        //--------------------------------------------

        private void StockIn_ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.PaymentStatus' table. You can move, or remove it, as needed.
            this.paymentStatusTableAdapter.Fill(this.ranga_hardwareDataSet.PaymentStatus);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.SupplierCustmerList' table. You can move, or remove it, as needed.
            this.supplierCustmerListTableAdapter.Fill(this.ranga_hardwareDataSet.SupplierCustmerList);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockInType' table. You can move, or remove it, as needed.
            this.stockInTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockInType);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockInTable' table. You can move, or remove it, as needed.
            this.stockInTableTableAdapter.Fill(this.ranga_hardwareDataSet.StockInTable);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockInType' table. You can move, or remove it, as needed.
            this.stockInTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockInType);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.PaymentStatus' table. You can move, or remove it, as needed.
            this.paymentStatusTableAdapter.Fill(this.ranga_hardwareDataSet.PaymentStatus);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.SupplierCustmerList' table. You can move, or remove it, as needed.
            this.supplierCustmerListTableAdapter.Fill(this.ranga_hardwareDataSet.SupplierCustmerList);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Customer' table. You can move, or remove it, as needed.
            this.stockInTableTableAdapter.Fill(this.ranga_hardwareDataSet.StockInTable);
            this.ActiveControl = this.SearchButton;


        }

        //Enable / desable payment stutus option based on type
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TypeComboBox.Text == "Inbound Order")
            { this.PaymentStatusComboBox.Enabled = true; }
            else
            { this.PaymentStatusComboBox.Enabled = false; }
        }
        //--------------------------------------------------------
        private void StockIn_ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(formCloseIndex == false)
            {
                HomeForm.showForm();
            }
            
        }

        //Search Optiont working when search button click
        private void SearchButton_Click(object sender, EventArgs e)
        {
             DataTable dtSearch = new DataTable();

             if (this.TypeComboBox.Text == "Inbound Order")
             {
                 if(this.BatchIDComboBox.Text=="All" && this.SupplierComboBox.Text =="All" && this.PaymentStatusComboBox.Text == "All")
                 {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '"+this.TypeComboBox.Text+"' AND (SI.In_Date>='"+this.DateInFromDateTimePicker.Value+ "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') ", con);
                     sda.Fill(dtSearch);
                 }

                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text == "All" && this.PaymentStatusComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND PS.Status = '"+this.PaymentStatusComboBox.Text+"' ", con);
                    sda.Fill(dtSearch);
                }

                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text == "All" && this.PaymentStatusComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND SI.Stock_In_ID = '"+this.BatchIDComboBox.Text+"' ", con);
                    sda.Fill(dtSearch);
                }

                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text != "All" && this.PaymentStatusComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '"+this.SupplierComboBox.Text+ "' OR C.Name = '" + this.SupplierComboBox.Text + "') ", con);
                    sda.Fill(dtSearch);
                }

                
                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text != "All" && this.PaymentStatusComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') AND PS.Status = '" + this.PaymentStatusComboBox.Text + "'", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text == "All" && this.PaymentStatusComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND  PS.Status = '" + this.PaymentStatusComboBox.Text + "' AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' ", con);
                    sda.Fill(dtSearch);
                }
               
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text != "All" && this.PaymentStatusComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' ", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text != "All" && this.PaymentStatusComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE ST.Type = '" + this.TypeComboBox.Text + "' AND (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' AND  PS.Status = '" + this.PaymentStatusComboBox.Text + "'", con);
                    sda.Fill(dtSearch);
                }


            }

             else
            {
                if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text == "All" && this.TypeComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') ", con);
                    sda.Fill(dtSearch);
                }

                
                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text == "All" && this.TypeComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND ST.Type = '"+this.TypeComboBox.Text+"' ", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text == "All" && this.TypeComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' ", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text != "All" && this.TypeComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') ", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text == "All" && this.SupplierComboBox.Text != "All" && this.TypeComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') AND ST.Type = '" + this.TypeComboBox.Text + "' ", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text == "All" && this.TypeComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND ST.Type = '" + this.TypeComboBox.Text + "'  AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "'", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text != "All" && this.TypeComboBox.Text == "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "')  AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "')", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.BatchIDComboBox.Text != "All" && this.SupplierComboBox.Text != "All" && this.TypeComboBox.Text != "All")
                {
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
 ON PS.Id = IB.Payment_Status
 WHERE  (SI.In_Date>='" + this.DateInFromDateTimePicker.Value + "' AND SI.In_Date<='" + this.DateInToDateTimePicker.Value + "') AND (S.Name = '" + this.SupplierComboBox.Text + "' OR C.Name = '" + this.SupplierComboBox.Text + "') AND SI.Stock_In_ID = '" + this.BatchIDComboBox.Text + "' AND ST.Type = '" + this.TypeComboBox.Text + "'", con);
                    sda.Fill(dtSearch);
                }
            }

            StockInDataGridView.DataSource = dtSearch;
        }

        //------------------------------------------------------------------------

        //direct to stock in form
        private void NewInboundOrderButton_Click(object sender, EventArgs e)
        {
            InboundOrderForm inboundOrder = new InboundOrderForm();
            this.Hide();
            inboundOrder.Show();
        }

        private void NewCustomerReturnButton_Click(object sender, EventArgs e)
        {
            formCloseIndex = true;
            this.Close();
            SalesForm.ShowForm();
        }
    }
        }
