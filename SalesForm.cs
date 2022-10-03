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
    public partial class SalesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();
        public SalesForm()
        {
            InitializeComponent();
        }

        private void setInnitial()
        {
            this.BatchIDTextBox.Text = "";

            this.SalesDateTimePicker.Enabled = false;
            this.SalesDateTimePicker.Value = DateTime.Today;
            
            this.FromStockTypeComboBox.Enabled = false;
            this.FromStockTypeComboBox.Text = "";

            this.ItemLabel.Visible = false;
            this.ItemNameComboBox.Enabled = false;
            this.ItemNameComboBox.Visible = false;

            this.QuantityLabel.Visible = false;
            this.QuantityNumericUpDown.Enabled = false;
            this.QuantityNumericUpDown.Visible = false;

            this.AddItemButton.Enabled = false;
            this.AddItemButton.Visible = false;

            this.UnitLable.Visible = false;

            this.SaveButton.Enabled = false;
            this.SaveButton.Visible = false;

            this.CustomerComboBox.Enabled = false;
            this.CustomerComboBox.Text = "";

            this.DeleteSelectedSalesRecordButton.Enabled = false;
            this.DeleteSelectedSalesRecordButton.Visible = false;

            this.CustomerReturnButton.Enabled = false;
            this.CustomerReturnButton.Visible = false;



        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            setInnitial();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT so.Stock_Out_ID,so.Out_Date,st.Stock_Type as From_Stock_Type,i.Name as Customer_Name,i.Items,cast(i.[Net_Sales(Rs.)] as decimal(10,2)) as [Net_Sales(Rs.)] 
FROM StockOut so
LEFT JOIN StockType st
ON so.From_Stock_Type  = st.Id
LEFT JOIN (SELECT sl.Stock_Out_Id , c.Name , soi.Items,sl.[Net Sales] as [Net_Sales(Rs.)]
FROM Sales sl
LEFT JOIN Customer c
ON sl.Customer_ID = c.Customer_ID
LEFT JOIN (SELECT si.Stock_Out_Id,Items = STUFF((SELECT DISTINCT ', ' +Items FROM (SELECT si.Stock_Out_Id,CONCAT( i.Item_Name,' ','-',' ',si.Amount,' ',i.Mesuring_Unit) as Items FROM SalesItems si, Item i WHERE si.Item_ID = i.Item_ID) as a WHERE si.Stock_Out_Id = a.Stock_Out_ID FOR XML PATH('')), 1, 2, '') FROM SalesItems si, Item i WHERE si.Item_ID = i.Item_ID GROUP BY si.Stock_Out_Id) as soi
ON sl.Stock_Out_Id = soi.Stock_Out_Id) as i
ON so.Stock_Out_ID = i.Stock_Out_Id
WHERE so.Type = 1", con);
            sda.Fill(dt);
            SalesDataGridView.DataSource = dt;

        }

        private void SalesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SalesDataGridView.CurrentRow.Selected = true;
            this.BatchIDTextBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.SalesDateTimePicker.Value = DateTime.Parse(this.SalesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.FromStockTypeComboBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            SqlDataAdapter items = new SqlDataAdapter(@"SELECT i.Item_Name as Item, si.Amount as Quantity,si.[Total Price] as [ItemTotal]
FROM SalesItems si, Item i
WHERE si.Item_ID = i.Item_ID AND si.Stock_Out_Id = "+ this.SalesDataGridView.Rows[e.RowIndex].Cells[0].Value+ "", con);
            DataTable itemFillTable = new DataTable();
            items.Fill(itemFillTable);
            this.SalesItemsDataGridView.Columns.Clear();
            this.SalesItemsDataGridView.DataSource = itemFillTable;

            this.CustomerComboBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.NetSalesTextBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StockOutManagementForm.ShowForm();
        }
    }
}
