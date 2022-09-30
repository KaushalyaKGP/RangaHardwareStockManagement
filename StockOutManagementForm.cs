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
            this.DateOutFromDateTimePicker.Value = Convert.ToDateTime("1/1/2020");
            this.DateOutToDateTimePicker.Value = DateTime.Today;

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
GROUP BY so.Stock_Out_ID,sot.Type,so.Out_Date,st.Stock_Type",con);
            dt.Rows.Clear();
            sda.Fill(dt);
            this.StockOutDataGridView.DataSource = dt;

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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.SetInitioalStage();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter searchAdupter;
            DataTable SearchTable = new DataTable();

            //------01----------------
            if (this.BatchIDComboBox.Text == "All" && this.TypeComboBox.Text == "All" && this.ItemComboBox.Text == "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type; ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //------------02------------
            else if (this.BatchIDComboBox.Text == "All" && this.TypeComboBox.Text == "All" && this.ItemComboBox.Text != "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND i.Item_Name LIKE '%" + this.ItemComboBox.Text + "%' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }
            

            //-------------03------------
            else if (this.BatchIDComboBox.Text != "All" && this.TypeComboBox.Text == "All" && this.ItemComboBox.Text == "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND so.Stock_Out_ID = "+this.BatchIDComboBox.Text+" GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //-------04-----------
            else if (this.BatchIDComboBox.Text == "All" && this.TypeComboBox.Text != "All" && this.ItemComboBox.Text == "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND sot.Type = '"+this.TypeComboBox.Text+"' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //----------05----------
            else if (this.BatchIDComboBox.Text == "All" && this.TypeComboBox.Text != "All" && this.ItemComboBox.Text != "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND sot.Type = '" + this.TypeComboBox.Text + "' AND i.Item_Name LIKE '%"+ this.ItemComboBox.Text+"%' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //----------06-------
            else if (this.BatchIDComboBox.Text != "All" && this.TypeComboBox.Text == "All" && this.ItemComboBox.Text != "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND so.Stock_Out_ID = " + this.BatchIDComboBox.Text + " AND i.Item_Name LIKE '%" + this.ItemComboBox.Text + "%' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //-------07------
            else if (this.BatchIDComboBox.Text != "All" && this.TypeComboBox.Text != "All" && this.ItemComboBox.Text == "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND so.Stock_Out_ID = " + this.BatchIDComboBox.Text + " AND sot.Type = '" + this.TypeComboBox.Text + "' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }

            //------08----------
            else if (this.BatchIDComboBox.Text != "All" && this.TypeComboBox.Text != "All" && this.ItemComboBox.Text != "All")
            {
                searchAdupter = new SqlDataAdapter(@"SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,Items = STUFF((SELECT DISTINCT ', ' +Item_Name FROM (SELECT so.Stock_Out_ID AS Batch_ID,sot.Type,so.Out_Date,st.Stock_Type AS From_Stock_Type ,i.Item_Name
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID) as s
WHERE s.Batch_ID = so.Stock_Out_ID FOR XML PATH('')), 1, 2, '')
FROM StockOut so
LEFT JOIN StockOutType sot
ON so.Type = sot.Id
LEFT JOIN StockType st
ON so.From_Stock_Type = st.Id
LEFT JOIN SalesItems sl
ON so.Stock_Out_ID = sl.Stock_Out_Id
LEFT JOIN ReturnToSupplierItems rs
ON so.Stock_Out_ID = rs.Stock_Out_ID
LEFT JOIN LostDamageStockOut l
ON so.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i
ON sl.Item_ID = i.Item_ID OR rs.Item_ID = i.Item_ID OR l.Item_ID = i.Item_ID
WHERE so.Out_Date>='" + DateOutFromDateTimePicker.Value + "' AND so.Out_Date<='" + DateOutToDateTimePicker.Value + "' AND so.Stock_Out_ID = " + this.BatchIDComboBox.Text + " AND sot.Type = '" + this.TypeComboBox.Text + "' AND i.Item_Name LIKE '%" + this.ItemComboBox.Text + "%' GROUP BY so.Stock_Out_ID, sot.Type, so.Out_Date, st.Stock_Type ", con);

                SearchTable.Rows.Clear();
                searchAdupter.Fill(SearchTable);
            }


            StockOutDataGridView.DataSource = SearchTable;
        }
    }
}
