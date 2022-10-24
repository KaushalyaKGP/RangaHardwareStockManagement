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
        private static SalesForm _salesForm = new SalesForm();

        public static void ShowForm()
        {

            if (SalesForm.ActiveForm == null)
            {
                _salesForm = new SalesForm();
            }
            _salesForm.Show();
            _salesForm.setInnitial();

        }

        public static void HideForm()
        {
            _salesForm.Hide();
        }


        public static int SalesId = -1;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();

        float netSales = 0;
        DataTable salesItemsAddTable = new DataTable();
        
        public SalesForm()
        {
            InitializeComponent();
        }

        private void setInnitial()
        {
            netSales = 0;
            
            //set items table
            salesItemsAddTable.Columns.Clear();
            salesItemsAddTable.Rows.Clear();
            salesItemsAddTable.Columns.Add("Stock_out_Id", typeof(int));
            salesItemsAddTable.Columns.Add("Item_ID", typeof(int));
            salesItemsAddTable.Columns.Add("Amount", typeof(int));
            salesItemsAddTable.Columns.Add("Total_Price", typeof(float));
            //-------------------

            SalesDataGridView.Enabled = true;

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

            this.SalesItemsDataGridView.DataSource = null;
            this.SalesItemsDataGridView.Columns.Clear();
            this.SalesItemsDataGridView.ColumnCount = 3;
            this.SalesItemsDataGridView.Columns[0].Name = "Item";
            this.SalesItemsDataGridView.Columns[1].Name = "Quantity";
            this.SalesItemsDataGridView.Columns[2].Name = "ItemTotal";
            this.salesItemsAddTable.Rows.Clear();

            this.AddItemButton.Enabled = false;
            this.AddItemButton.Visible = false;

            this.UnitLable.Visible = false;
            this.AvailableStockLabel.Visible = false;
            this.AvailableStockCountLable.Visible = false;
            this.Unit2Label.Visible = false;


            this.SaveButton.Enabled = false;
            this.SaveButton.Visible = false;

            this.CustomerComboBox.Enabled = false;
            this.CustomerComboBox.Text = "";

            this.NetSalesTextBox.Text = "";


            this.DeleteSelectedSalesRecordButton.Enabled = false;
            this.DeleteSelectedSalesRecordButton.Visible = false;

            this.CustomerReturnButton.Enabled = false;
            this.CustomerReturnButton.Visible = false;

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
            dt.Rows.Clear();
            sda.Fill(dt);
            SalesDataGridView.DataSource = dt;

        }

        private void getAvailableStock()
        {
            //Get available Quantity base on stock type
            if (ItemNameComboBox.SelectedValue != null)
            {
                SqlCommand quantityCommand = new SqlCommand();
                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    quantityCommand = new SqlCommand(@"SELECT i.Current_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                }
                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    quantityCommand = new SqlCommand(@"SELECT i.Customer_Return_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                }

                con.Open();
                this.AvailableStockCountLable.Text = quantityCommand.ExecuteScalar().ToString();
                con.Close();
            }
                

            //--------------------------------------
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.ranga_hardwareDataSet.Customer);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockType' table. You can move, or remove it, as needed.
            this.stockTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockType);
            setInnitial();

            


        }

        private void SalesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesId = (int)this.SalesDataGridView.Rows[e.RowIndex].Cells[0].Value;
            this.SalesDataGridView.CurrentRow.Selected = true;
            this.BatchIDTextBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.SalesDateTimePicker.Value = DateTime.Parse(this.SalesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.FromStockTypeComboBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            SqlDataAdapter items = new SqlDataAdapter(@"SELECT i.Item_Name as Item, si.Amount as Quantity,si.[Total Price] as [ItemTotal]
FROM SalesItems si, Item i
WHERE si.Item_ID = i.Item_ID AND si.Stock_Out_Id = "+ this.SalesDataGridView.Rows[e.RowIndex].Cells[0].Value+ "", con);
            DataTable itemFillTable = new DataTable();
            itemFillTable.Rows.Clear();
            items.Fill(itemFillTable);
            this.SalesItemsDataGridView.Columns.Clear();
            this.SalesItemsDataGridView.DataSource = itemFillTable;

            this.CustomerComboBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.NetSalesTextBox.Text = this.SalesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            this.DeleteSelectedSalesRecordButton.Enabled = true;
            this.DeleteSelectedSalesRecordButton.Visible = true;

            this.CustomerReturnButton.Enabled = true;
            this.CustomerReturnButton.Visible = true;


        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StockOutManagementForm.ShowForm();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SalesForm.ActiveForm.Close();
        }

        private void AddNewSalesButton_Click(object sender, EventArgs e)
        {
            //Set Batch ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Stock_Out_ID as int)),0)+1 FROM StockOut", con);
            con.Open();
            this.BatchIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------
            this.SalesDateTimePicker.Enabled = true;
            this.SalesDateTimePicker.Value = DateTime.Today;

            this.FromStockTypeComboBox.Enabled = true;
            this.FromStockTypeComboBox.SelectedIndex = 1;
            this.FromStockTypeComboBox.SelectedIndex = 0;

            //clear Item List & Add Columns
            this.SalesItemsDataGridView.DataSource = null;
            this.SalesItemsDataGridView.Columns.Clear();
            this.SalesItemsDataGridView.ColumnCount = 3;
            this.SalesItemsDataGridView.Columns[0].Name = "Item";
            this.SalesItemsDataGridView.Columns[1].Name = "Quantity";
            this.SalesItemsDataGridView.Columns[2].Name = "ItemTotal";
            //---------------------

            this.ItemLabel.Visible = true; this.ItemNameComboBox.Enabled = true;
            this.ItemNameComboBox.Visible = true;
            this.ItemNameComboBox.SelectedIndex = 1;
            this.ItemNameComboBox.SelectedIndex = 0;
            this.AvailableStockCountLable.Visible = true;
            this.AvailableStockLabel.Visible = true;
            this.Unit2Label.Visible = true;

            this.QuantityLabel.Visible = true;
            this.QuantityNumericUpDown.Enabled = true;
            this.QuantityNumericUpDown.Visible = true;
            this.QuantityNumericUpDown.Value = 0;
            this.UnitLable.Visible = true;

            this.AddItemButton.Enabled = true;
            this.AddItemButton.Visible = true;

            this.CustomerComboBox.Enabled = true;
            this.CustomerComboBox.SelectedIndex = 1;
            this.CustomerComboBox.SelectedIndex = 0;

            this.NetSalesTextBox.Text = "";


            this.DeleteSelectedSalesRecordButton.Enabled = false;
            this.DeleteSelectedSalesRecordButton.Visible = false;

            this.CustomerReturnButton.Enabled = false;
            this.CustomerReturnButton.Visible = false;

            this.SalesDataGridView.Enabled = false;

            this.SaveButton.Enabled = true;
            this.SaveButton.Visible = true;

            




        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show Relevent Measuring Unit
            if(ItemNameComboBox.SelectedValue!=null)
            {
                SqlCommand unitCommand = new SqlCommand(@"SELECT i.Mesuring_Unit
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                con.Open();
                this.UnitLable.Text = unitCommand.ExecuteScalar().ToString();
                con.Close();
                this.Unit2Label.Text = this.UnitLable.Text;
                getAvailableStock();
            }
            //-----------------------------------

            
        }


        private void FromStockTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FromStockTypeComboBox.SelectedValue!=null)
            {
                getAvailableStock();
            }
            
        }

        private void DeleteSelectedSalesRecordButton_Click(object sender, EventArgs e)
        { 
            //check id user realy want to delete
            DialogResult result= MessageBox.Show("Do you realy want to delete the record? \ndeleted records will not be abeled to recovered!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                DataTable itemlistTable = new DataTable();
                SqlDataAdapter itemsListAdupter = new SqlDataAdapter(@"SELECT si.Item_Id, si.Amount, i.Min_Quentity,i.Current_Stock
FROM SalesItems si,Item i 
WHERE si.Stock_Out_Id =" + int.Parse(this.BatchIDTextBox.Text) + " AND si.Item_ID = i.Item_ID ", con);
                itemsListAdupter.Fill(itemlistTable);


                SqlCommand changeStockCommand = new SqlCommand();

                foreach (DataRow dataRow in itemlistTable.Rows)
                {
                    //Update stock level & Stock Status
                    if (this.FromStockTypeComboBox.Text == "CurrentStock")
                    {
                        int CurrentStock = (int)dataRow[3] + (int)dataRow[1];
                        int Min_Quentity = (int)dataRow[2];
                        int Stock_Status;

                        if (CurrentStock <= Min_Quentity)
                        {
                            Stock_Status = 2;
                        }
                        else
                        {
                            Stock_Status = 1;
                        }
                        changeStockCommand = new SqlCommand(@"UPDATE Item SET Current_Stock += " + int.Parse(dataRow[1].ToString()) + ",Stock_Status = " + Stock_Status + "  WHERE Item_ID = " + int.Parse(dataRow[0].ToString()) + "", con);
                    }
                    else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                    {
                        changeStockCommand = new SqlCommand(@"UPDATE Item SET Customer_Return_Stock +=" + int.Parse(dataRow[1].ToString()) + "  WHERE Item_ID = " + int.Parse(dataRow[0].ToString()) + "", con);
                    }
                    con.Open();
                    changeStockCommand.ExecuteNonQuery();
                    con.Close();
                    //---------------------------------------------------------

                }

                //Delete SalesItem Records
                SqlCommand DeleteItemsCommand = new SqlCommand(@"DELETE FROM SalesItems WHERE Stock_Out_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                con.Open();
                DeleteItemsCommand.ExecuteNonQuery();
                con.Close();
                //-----------------------

                //Delete sales record
                SqlCommand DeleteSalesCommand = new SqlCommand(@"DELETE FROM Sales WHERE Stock_Out_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                con.Open();
                DeleteSalesCommand.ExecuteNonQuery();
                con.Close();
                //--------------------

                //Delete stockout record
                SqlCommand DeleteStockOutCommand = new SqlCommand(@"DELETE FROM StockOut WHERE Stock_Out_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                con.Open();
                DeleteStockOutCommand.ExecuteNonQuery();
                con.Close();
                //---------------------

                MessageBox.Show("Record Deleted");
                setInnitial();
            }
            
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {

            //Validate same item repitition
            int repeat = -1;
            

            if (SalesItemsDataGridView.Rows.Count > 0)
            {
                string searchItem = this.ItemNameComboBox.Text;

                foreach (DataGridViewRow row in SalesItemsDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {

                        if (row.Cells[0].Value.ToString().Equals(searchItem))
                        {
                            MessageBox.Show("Same Item Repeating !");
                            repeat = 1;
                        }

                    }
                }

            }




            //validate amount is>0 & amount<current stock or customer return stock

            if ((QuantityNumericUpDown.Value > 0) && (repeat == -1))
            {
                bool stockAvailability = true;

                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    SqlCommand currentStockCommand = new SqlCommand(@"SELECT i.Current_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + ";", con);
                    con.Open();
                    int currentStock = int.Parse(currentStockCommand.ExecuteScalar().ToString());
                    con.Close();

                    if(this.QuantityNumericUpDown.Value > currentStock)
                    {
                        stockAvailability = false;
                    }
                }

                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    SqlCommand CRStockCommand = new SqlCommand(@"SELECT i.Customer_Return_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + ";", con);
                    con.Open();
                    int customerReturnStock = int.Parse(CRStockCommand.ExecuteScalar().ToString());
                    con.Close();

                    if (this.QuantityNumericUpDown.Value > customerReturnStock)
                    {
                        stockAvailability = false;
                    }
                }

                if(stockAvailability == true)
                {
                    float itemTotal = 0;
                    float itemPrice = 0;
                    SqlCommand itemPriceCommand = new SqlCommand(@"SELECT i.Unit_Price
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + ";", con);
                    con.Open();
                    itemPrice = int.Parse(itemPriceCommand.ExecuteScalar().ToString());
                    con.Close();

                    itemTotal = (float)this.QuantityNumericUpDown.Value * itemPrice;
                    netSales += itemTotal;

                    this.NetSalesTextBox.Text = netSales.ToString("0.00");

                    //Add data to table
                    salesItemsAddTable.Rows.Add(new object[] { int.Parse(BatchIDTextBox.Text), ItemNameComboBox.SelectedValue, QuantityNumericUpDown.Value, itemTotal });
                    //---------------------------

                    //Update data grid
                    this.SalesItemsDataGridView.Rows.Add(this.ItemNameComboBox.Text, this.QuantityNumericUpDown.Text,itemTotal.ToString("0.00"));
                    //-----------



                }
                else
                {
                    MessageBox.Show("Available stock not enough for this sales");
                }

                

                
                //clear add item data input options
                this.ItemNameComboBox.SelectedIndex = 0;
                this.QuantityNumericUpDown.Value = 0;
                //-------------

                this.FromStockTypeComboBox.Enabled = false;


            }

            else if ((QuantityNumericUpDown.Value <= 0) && (repeat == -1))
            {
                MessageBox.Show("Please Enter Quantity");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //check items added
            if(salesItemsAddTable.Rows.Count!=0)
            {
                //Save into stockOut Tabale
                SqlCommand stockOutTableInsertCommand = new SqlCommand(@"INSERT INTO StockOut (Stock_Out_ID,Type,Out_Date,From_Stock_Type )
VALUES(" + int.Parse(this.BatchIDTextBox.Text) + ",1,'" + this.SalesDateTimePicker.Value + "'," + this.FromStockTypeComboBox.SelectedValue + ")", con);

                con.Open();
                stockOutTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //------------------------------------


                //Saving To Sales Table
                SqlCommand salesTableInsertCommand = new SqlCommand(@"INSERT INTO Sales (Stock_Out_Id,Customer_ID,[Net Sales])
VALUES(" + int.Parse(this.BatchIDTextBox.Text) + ", "+this.CustomerComboBox.SelectedValue+", "+float.Parse(this.NetSalesTextBox.Text)+")", con);

                con.Open();
                salesTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //----------------------

                //Saving to SalesItem Table & Update stock level & stock status In item table
                for (int i = 0; i < salesItemsAddTable.Rows.Count; i++)
                {
                    //update sales item table
                    int Stock_out_Id = (int)salesItemsAddTable.Rows[i][0];
                    int Item_ID = (int)salesItemsAddTable.Rows[i][1];
                    int Amount = (int)salesItemsAddTable.Rows[i][2];
                    float Total_Price = (float)salesItemsAddTable.Rows[i][3];

                    SqlCommand salesItemTabaleInsertCommand = new SqlCommand(@"INSERT INTO SalesItems(Stock_Out_Id,Item_ID,Amount,[Total Price])
VALUES ("+Stock_out_Id+","+Item_ID+","+Amount+","+Total_Price+")", con);
                
                    con.Open();
                    salesItemTabaleInsertCommand.ExecuteNonQuery();
                    con.Close();
                    //------------------------------

                    //Update stock level & stock status In item table
                    if(this.FromStockTypeComboBox.Text == "CurrentStock")
                    {
                        SqlDataAdapter ItemAdupter = new SqlDataAdapter(@"SELECT Current_Stock,Min_Quentity FROM[Item] WHERE Item_ID = " + Item_ID + ";", con);
                        DataTable dataTable = new DataTable();
                        dataTable.Clear();

                        ItemAdupter.Fill(dataTable);
                        int CurrentStock = (int)dataTable.Rows[0][0] - Amount;
                        int Min_Quentity = (int)dataTable.Rows[0][1];
                        int Stock_Status;

                        if (CurrentStock == 0)
                        {
                            Stock_Status = 0;
                        }
                        else if (CurrentStock < Min_Quentity)
                        {
                            Stock_Status = 1;
                        }
                        else
                        {
                            Stock_Status = 2;
                        }

                        SqlCommand itemTableUpdateCommand = new SqlCommand(@"UPDATE Item SET Current_Stock = " + CurrentStock + ", Stock_Status = " + Stock_Status + " WHERE Item_ID = " + Item_ID + "; ", con);
                        con.Open();
                        itemTableUpdateCommand.ExecuteNonQuery();
                        con.Close();
                        //----------------------------------------------------
                    }
                    else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                    {
                       SqlCommand itemTableUpdateCommand = new SqlCommand(@"UPDATE Item SET Customer_Return_Stock -= " + Amount+ " WHERE Item_ID = " + Item_ID + "", con);

                        con.Open();
                        itemTableUpdateCommand.ExecuteNonQuery();
                        con.Close();
                    }


                }

                //-------------------------------

                    MessageBox.Show("New Sales Record Saved.");
                setInnitial();
            }
            else
            {
                MessageBox.Show("Please Add Items");
            }

        }

        private void CustomerReturnButton_Click(object sender, EventArgs e)
        {   //check if selected sale already has a customer return
            SqlCommand Command = new SqlCommand(@"SELECT  c.Stock_In_ID
FROM CustomerReturn c, Sales s
WHERE s.Stock_Out_Id = c.Stock_Out_ID AND s.Stock_Out_Id = "+SalesId+"", con);
            con.Open();
            
            
            if (Command.ExecuteScalar()==null)
            {
                con.Close();
                this.Hide();
                CustomerReturnForm customerReturn = new CustomerReturnForm();
                customerReturn.Show();
            }
            else
            {
                con.Close();
                MessageBox.Show("Selectes sales already has a customer return record !");
            }
            
        }
    }
}
