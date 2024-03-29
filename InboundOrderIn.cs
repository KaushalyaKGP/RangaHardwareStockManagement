﻿using System;
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
    public partial class InboundOrderForm : Form
    {

        private static InboundOrderForm _inboundOrderForm = new InboundOrderForm();
        bool returnFlag = false;

        public static void ShowForm()
        {

            if (_inboundOrderForm.IsDisposed)
            {
                _inboundOrderForm = new InboundOrderForm();
            }
            _inboundOrderForm.Show();
            _inboundOrderForm.setInitials();

        }

        public static void HideForm()
        {
            _inboundOrderForm.Hide();
        }





        public static int StockInID;
        float TotalCost = 0;
        float pendingPaynemts;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();

        //data of items
        DataTable InboundOrderInItems = new DataTable();
        //------------

        public InboundOrderForm()
        {
            InitializeComponent();
        }

        private void setInitials()
        {
            //set items table
            InboundOrderInItems.Columns.Clear();
            InboundOrderInItems.Clear();
            InboundOrderInItems.Columns.Add("Stock_In_Id", typeof(int));
            InboundOrderInItems.Columns.Add("Item_ID", typeof(int));
            InboundOrderInItems.Columns.Add("amount", typeof(int));
            InboundOrderInItems.Columns.Add("unit_Cost", typeof(float));
            InboundOrderInItems.Columns.Add("Total_Cost", typeof(float));
            //-------------------

            //Set Inbound order Data Grid

            InboundOrderDataGridView.Enabled = true;

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT si.Stock_In_ID,si.In_Date,i.Supplier,i.[Payment Status],i.Cost,i.Paid_Amount,i.Pending_Payment,i.Items,ri.ReturnToSupplierID,ri.[Return Reason],ri.Comment,ri.Items as [Returned items] 
FROM StockInTable si
LEFT JOIN (SELECT ib.Stock_In_Id , s.Name as Supplier,ps.Status as [Payment Status],ib.Cost, ib.Paid_Amount,ib.Pending_Payment , ioi.Items
FROM InboundOrderIn ib
LEFT JOIN Supplier s
ON ib.Supplier_ID = s.Supplier_ID
LEFT JOIN PaymentStatus ps
ON ib.Payment_Status = ps.Id
LEFT JOIN (SELECT ibi.Stock_In_Id,Items = STUFF((SELECT DISTINCT ', ' +Items FROM (SELECT ibi.Stock_In_Id,CONCAT( i.Item_Name,' ','-',' ',ibi.amount,' ',i.Mesuring_Unit) as Items FROM InboundOrderItems ibi, Item i WHERE ibi.Item_ID = i.Item_ID) as a WHERE ibi.Stock_In_Id = a.Stock_In_Id FOR XML PATH('')), 1, 2, '') FROM InboundOrderItems ibi, Item i WHERE ibi.Item_ID = i.Item_ID GROUP BY ibi.Stock_In_Id) as ioi
ON ib.Stock_In_Id = ioi.Stock_In_Id) as i
ON si.Stock_In_ID = i.Stock_In_Id
LEFT JOIN (SELECT rs.Stock_In_ID,rs.Stock_Out_ID as ReturnToSupplierID,rsr.Reason as [Return Reason],rs.Comment ,rsi.Items
FROM ReturnToSupplier rs
LEFT JOIN ReturnToSupplierReasons rsr
ON rsr.Id = rs.Reason
LEFT JOIN (SELECT rsi.Stock_Out_ID,Items = STUFF((SELECT DISTINCT ', ' +Items FROM (SELECT rsi.Stock_Out_ID,CONCAT( i.Item_Name,' ','-',' ',rsi.Amount,' ',i.Mesuring_Unit) as Items FROM ReturnToSupplierItems rsi, Item i WHERE rsi.Item_ID = i.Item_ID) as a WHERE rsi.Stock_Out_ID = a.Stock_Out_ID FOR XML PATH('')), 1, 2, '') FROM ReturnToSupplierItems rsi, Item i WHERE rsi.Item_ID = i.Item_ID GROUP BY rsi.Stock_Out_ID) as rsi
ON rs.Stock_Out_ID = rsi.Stock_Out_ID) as ri
ON si.Stock_In_ID = ri.Stock_In_ID
WHERE si.Type = 1", con);
            dt.Rows.Clear();
            sda.Fill(dt);
            InboundOrderDataGridView.DataSource = dt;
            //-------------------------------------------------


            this.BatchIDTextBox.Text = "";

            this.DateInDateTimePicker.Enabled = true;
            this.DateInDateTimePicker.Value = DateTime.Today;

            this.SupplierComboBox.Enabled = true;
            this.SupplierComboBox.Text = "";


            this.ItemLabel.Visible = false;

            this.ItemNameComboBox.Enabled = false;
            this.ItemNameComboBox.Visible = false;

            this.UnitLable.Visible = false;

            this.QuantityLabel.Visible = false;
            this.QuantityNumericUpDown.Enabled = false;
            this.QuantityNumericUpDown.Visible = false;

            this.UnitCostLabel.Visible = false;
            this.UnitCostNumericUpDown.Enabled = false;
            this.UnitCostNumericUpDown.Visible = false;

            this.AddItemButton.Enabled = false;
            this.AddItemButton.Visible = false;

            this.InboundOrderItemsDataGridView.DataSource = null;
            this.InboundOrderItemsDataGridView.Columns.Clear();
            this.InboundOrderItemsDataGridView.ColumnCount = 4;
            this.InboundOrderItemsDataGridView.Columns[0].Name = "Item";
            this.InboundOrderItemsDataGridView.Columns[1].Name = "Quantity";
            this.InboundOrderItemsDataGridView.Columns[2].Name = "Unit Cost";
            this.InboundOrderItemsDataGridView.Columns[3].Name = "ItemTotal";
            this.InboundOrderInItems.Rows.Clear();

            this.SaveNewInboundOrderButton.Enabled = false;
            this.SaveNewInboundOrderButton.Visible = false;

            this.ResetButton.Enabled = false;
            this.ResetButton.Visible = false;

            this.TotalCostTextBox.Text = "";
            this.PeidAmountNumericUpDown.Enabled = false;
            this.PeidAmountNumericUpDown.Value = 0;
            this.PendingPaymentsTextBox.Text = "";

            this.DeleteInboundOrderButton.Enabled = false;
            this.DeleteInboundOrderButton.Visible = false;

            this.ReturntoSupplierButton.Enabled = false;
            this.ReturntoSupplierButton.Visible = false;
            this.EditPaymentButton.Enabled = false;
            this.EditPaymentButton.Visible = false;

            this.UpdateButton.Enabled = false;
            this.UpdateButton.Visible = false;
            this.AddNewInboundOrderButton.Enabled = true;
            this.AddNewInboundOrderButton.Visible = true;

        }

        private void InboundOrderIn_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sdaSupplier = new SqlDataAdapter(@"SELECT Name,Supplier_ID
FROM Supplier", con);
            DataTable dtSupplier = new DataTable();
            


            this.SupplierComboBox.DataSource = null;
            SupplierComboBox.Items.Clear();
            try
            {
                sdaSupplier.Fill(dtSupplier);
                this.SupplierComboBox.DataSource = dtSupplier;
                this.SupplierComboBox.DisplayMember = dtSupplier.Columns["Name"].ColumnName;
                this.SupplierComboBox.ValueMember = dtSupplier.Columns["Supplier_ID"].ColumnName;
            }
            catch
            {

            }
            //set date today
            this.DateInDateTimePicker.Value = DateTime.Today;
            //--------------
            setInitials();


        }

        private void SetItemList()
        {
            //View Item List Based on Selected Supplier
            SqlDataAdapter sda2 = new SqlDataAdapter(@"SELECT Item_ID,Item_Name
FROM Item
WHERE Supplier_ID = " + this.SupplierComboBox.SelectedValue + "", con);


            DataTable dt2 = new DataTable();
            this.ItemNameComboBox.DataSource = null;
            ItemNameComboBox.Items.Clear();
            try
            { 
                sda2.Fill(dt2);
                this.ItemNameComboBox.DataSource = dt2;
                this.ItemNameComboBox.DisplayMember = dt2.Columns["Item_Name"].ColumnName;
                this.ItemNameComboBox.ValueMember = dt2.Columns["Item_ID"].ColumnName;
            }
            catch
            {

            }
            //------------------------------------------------
        }

        private void SupplierComboBox_TextChanged(object sender, EventArgs e)
        {
            SetItemList();
        }

        private void InboundOrderIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            StockIn_ManagementForm.ShowForm();
        }


        private void PeidAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(PeidAmountNumericUpDown.Enabled==true)
            {
                if ((float)PeidAmountNumericUpDown.Value > float.Parse(TotalCostTextBox.Text))
                {
                    MessageBox.Show("Invalid Paid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    PeidAmountNumericUpDown.Value = 0;
                }
                else
                {
                    pendingPaynemts = float.Parse(TotalCostTextBox.Text) - (float)this.PeidAmountNumericUpDown.Value;
                    PendingPaymentsTextBox.Text = pendingPaynemts.ToString("0.00");
                }
            }
            

        }

       

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.DateInDateTimePicker.Value = DateTime.Today;
            this.SupplierComboBox.SelectedIndex = 0;
            this.QuantityNumericUpDown.Value = 0;
            this.UnitCostNumericUpDown.Value = 0;
            this.InboundOrderItemsDataGridView.Rows.Clear();
            this.InboundOrderInItems.Rows.Clear();
            this.TotalCost = 0;
            this.TotalCostTextBox.Text = TotalCost.ToString("0.00");
            this.PeidAmountNumericUpDown.Value = 0;
            this.PendingPaymentsTextBox.Text = "";

        }

        private void InboundOrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            returnFlag = false;

            StockInID = (int)this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[0].Value;
            this.InboundOrderDataGridView.CurrentRow.Selected = true;
            this.BatchIDTextBox.Text = this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DateInDateTimePicker.Value = DateTime.Parse(this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.SupplierComboBox.Text = this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            if(this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString()!="")
            {
                returnFlag = true;
            }

            SqlDataAdapter items = new SqlDataAdapter(@"SELECT i.Item_Name as Item, ii.amount as Quantity,ii.unit_Cost,ii.Total_Cost
FROM InboundOrderItems ii, Item i
WHERE ii.Item_ID = i.Item_ID AND ii.Stock_In_Id = " + StockInID + "", con);
            DataTable itemFillTable = new DataTable();
            itemFillTable.Rows.Clear();
            items.Fill(itemFillTable);
            this.InboundOrderItemsDataGridView.Columns.Clear();
            this.InboundOrderItemsDataGridView.DataSource = itemFillTable;

            this.TotalCostTextBox.Text = this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.PeidAmountNumericUpDown.Text = this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.PendingPaymentsTextBox.Text = this.InboundOrderDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

            this.DeleteInboundOrderButton.Enabled = true;
            this.DeleteInboundOrderButton.Visible = true;

            this.ReturntoSupplierButton.Enabled = true;
            this.ReturntoSupplierButton.Visible = true;

            this.EditPaymentButton.Enabled = true;
            this.EditPaymentButton.Visible = true;

        }

        private void DeleteInboundOrderButton_Click(object sender, EventArgs e)
        {
            //Check if it has return to supplier
            if (returnFlag == true)
            {
                MessageBox.Show("This record cant be deleted! " +
                    "This has a return record!");
            }
            else
            {
                //check iF user realy want to delete
                DialogResult result = MessageBox.Show("Do you realy want to delete the record? \ndeleted records will not be abeled to recovered!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataTable itemlistTable = new DataTable();
                    SqlDataAdapter itemsListAdupter = new SqlDataAdapter(@"SELECT ii.Item_Id, ii.Amount, i.Min_Quentity,i.Current_Stock
FROM InboundOrderItems ii ,Item i 
WHERE ii.Stock_In_Id = " + StockInID + " AND ii.Item_ID = i.Item_ID", con);
                    itemsListAdupter.Fill(itemlistTable);


                    SqlCommand changeStockCommand = new SqlCommand();

                    foreach (DataRow dataRow in itemlistTable.Rows)
                    {
                        //Update stock level & Stock Status

                        int CurrentStock = (int)dataRow[3] - (int)dataRow[1];
                        int Min_Quentity = (int)dataRow[2];
                        int Stock_Status;

                        if (CurrentStock <= 0)
                        {
                            Stock_Status = 0;
                        }
                        if (CurrentStock <= Min_Quentity)
                        {
                            Stock_Status = 1;
                        }
                        else
                        {
                            Stock_Status = 2;
                        }
                        changeStockCommand = new SqlCommand(@"UPDATE Item SET Current_Stock -= " + int.Parse(dataRow[1].ToString()) + ",Stock_Status = " + Stock_Status + "  WHERE Item_ID = " + int.Parse(dataRow[0].ToString()) + "", con);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        changeStockCommand.ExecuteNonQuery();
                        con.Close();
                        //---------------------------------------------------------

                    }

                    //Delete InboundOrderInItems Records
                    SqlCommand DeleteItemsCommand = new SqlCommand(@"DELETE FROM InboundOrderItems WHERE Stock_In_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                    con.Open();
                    DeleteItemsCommand.ExecuteNonQuery();
                    con.Close();
                    //-----------------------

                    //Delete InboundOrder record
                    SqlCommand DeleteInboundOrderCommand = new SqlCommand(@"DELETE FROM InboundOrderIn WHERE Stock_In_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                    con.Open();
                    DeleteInboundOrderCommand.ExecuteNonQuery();
                    con.Close();
                    //--------------------

                    //Delete stockIn record
                    SqlCommand DeleteStockInCommand = new SqlCommand(@"DELETE FROM StockInTable WHERE Stock_In_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                    con.Open();
                    DeleteStockInCommand.ExecuteNonQuery();
                    con.Close();
                    //---------------------

                    MessageBox.Show("Record Deleted");
                    setInitials();
                }
            }
        }

        private void AddNewInboundOrderButton_Click(object sender, EventArgs e)
        {

            //Auto generate ID
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(cast (Stock_In_ID as int)),0)+1 FROM StockInTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.BatchIDTextBox.Text = dt.Rows[0][0].ToString();
            //--------------------
            this.DateInDateTimePicker.Enabled = true;
            this.DateInDateTimePicker.Value = DateTime.Today;

            this.SupplierComboBox.Enabled = true;
            this.SupplierComboBox.SelectedIndex = 1;
            this.SupplierComboBox.SelectedIndex = 0;

            //set items table
            InboundOrderInItems.Columns.Clear();
            InboundOrderInItems.Clear();
            InboundOrderInItems.Columns.Add("Stock_In_Id", typeof(int));
            InboundOrderInItems.Columns.Add("Item_ID", typeof(int));
            InboundOrderInItems.Columns.Add("amount", typeof(int));
            InboundOrderInItems.Columns.Add("unit_Cost", typeof(float));
            InboundOrderInItems.Columns.Add("Total_Cost", typeof(float));
            //-------------------

            //set item datagrid
            InboundOrderItemsDataGridView.DataSource = null;
            InboundOrderItemsDataGridView.Columns.Clear();
            InboundOrderItemsDataGridView.Rows.Clear();
            InboundOrderItemsDataGridView.Columns.Add("Item","Item");
            InboundOrderItemsDataGridView.Columns.Add("Quantity", "Quantity");
            InboundOrderItemsDataGridView.Columns.Add("Unit_Cost", "Unit_Cost");
            InboundOrderItemsDataGridView.Columns.Add("Total_Cost", "Total_Cost");
            //---------------------


            this.ItemLabel.Visible = true;
            this.ItemNameComboBox.Enabled = true;
            this.ItemNameComboBox.Visible = true;
            this.ItemNameComboBox.SelectedIndex = 1;
            this.ItemNameComboBox.SelectedIndex = 0;

            this.QuantityLabel.Visible = true;
            this.QuantityNumericUpDown.Enabled = true;
            this.QuantityNumericUpDown.Visible = true;
            this.QuantityNumericUpDown.Value = 0;
            this.UnitLable.Visible = true;

            this.UnitCostLabel.Visible = true;
            this.UnitCostNumericUpDown.Enabled = true;
            this.UnitCostNumericUpDown.Visible = true;
            this.UnitCostNumericUpDown.Value = 0;

            this.AddItemButton.Enabled = true;
            this.AddItemButton.Visible = true;

            this.TotalCostTextBox.Text = "";

            this.PeidAmountNumericUpDown.Enabled = true;
            this.PeidAmountNumericUpDown.Value = 0;

            this.PeidAmountNumericUpDown.Value = 0;

            this.DeleteInboundOrderButton.Enabled = false;
            this.DeleteInboundOrderButton.Visible = false;

            this.ReturntoSupplierButton.Enabled = false;
            this.ReturntoSupplierButton.Visible = false;

            this.InboundOrderDataGridView.Enabled = false;

            this.SaveNewInboundOrderButton.Enabled = true;
            this.SaveNewInboundOrderButton.Visible = true;

            this.ResetButton.Enabled = true;
            this.ResetButton.Visible = true;

            this.AddNewInboundOrderButton.Enabled = false;
            this.AddNewInboundOrderButton.Visible = false;


        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //Validate same item repitition
            int repeat = -1;

            if (InboundOrderItemsDataGridView.Rows.Count > 0)
            {
                string searchItem = this.ItemNameComboBox.Text;

                foreach (DataGridViewRow row in InboundOrderItemsDataGridView.Rows)
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




            //validate amount is>0
            if ((QuantityNumericUpDown.Value > 0) && (repeat == -1))
            {
                float total_Item_Cost = (float.Parse(this.UnitCostNumericUpDown.Text)) * (float.Parse(this.QuantityNumericUpDown.Text));
                this.InboundOrderItemsDataGridView.Rows.Add(this.ItemNameComboBox.Text, this.QuantityNumericUpDown.Text, this.UnitCostNumericUpDown.Text, total_Item_Cost.ToString("0.00"));
                TotalCost += total_Item_Cost;
                TotalCostTextBox.Text = TotalCost.ToString("0.00");
                pendingPaynemts = TotalCost - (float)this.PeidAmountNumericUpDown.Value;
                PendingPaymentsTextBox.Text = pendingPaynemts.ToString("0.00");

                //Add data to table
                InboundOrderInItems.Rows.Add(new object[] { int.Parse(BatchIDTextBox.Text), ItemNameComboBox.SelectedValue, QuantityNumericUpDown.Value, (float)UnitCostNumericUpDown.Value, total_Item_Cost });

                //---------------------------

                //clear add item data input options
                this.ItemNameComboBox.SelectedIndex = 0;
                this.QuantityNumericUpDown.Value = 0;
                this.UnitCostNumericUpDown.Value = 0;
                //-------------


            }

            else if ((QuantityNumericUpDown.Value <= 0) && (repeat == -1))
            {
                MessageBox.Show("Please Enter Amount");
            }

        }


        private void SaveNewInboundOrderButton_Click(object sender, EventArgs e)
        {
            //set payment status
            int paymrntStatus = 4;
            if (TotalCost == 0)
            {
                paymrntStatus = 3;
            }
            else if ((pendingPaynemts == 0) && (TotalCost != 0))
            {
                paymrntStatus = 0;
            }
            else if ((pendingPaynemts == TotalCost) && (TotalCost != 0))
            {
                paymrntStatus = 1;
            }
            else if (pendingPaynemts < TotalCost)
            {
                paymrntStatus = 2;
            }
            //---------------------------------------------------------------

            //save new inbound order to database

            //validate items added
            if (InboundOrderInItems.Rows.Count > 0)
            {
                SqlCommand command;

                //Save to StockIn table
                SqlDataAdapter stockInDataAdupter = new SqlDataAdapter();
                command = new SqlCommand(@"INSERT INTO StockInTable
VALUES(" + int.Parse(this.BatchIDTextBox.Text) + ", 1, '" + this.DateInDateTimePicker.Value + "')", con);
                stockInDataAdupter.InsertCommand = command;
                con.Open();
                stockInDataAdupter.InsertCommand.ExecuteNonQuery();
                con.Close();

                //-----------------

                //Save to inboundOrderIn table
                SqlDataAdapter InboundOrderInDataAdupter = new SqlDataAdapter();
                command = new SqlCommand(@"INSERT INTO InboundOrderIn (Stock_In_Id,Supplier_ID,Payment_Status,Cost,Paid_Amount,Pending_Payment)
VALUES(" + int.Parse(this.BatchIDTextBox.Text) + "," + this.SupplierComboBox.SelectedValue + "," + paymrntStatus + "," + float.Parse(this.TotalCostTextBox.Text) + "," + (float)this.PeidAmountNumericUpDown.Value + "," + float.Parse(this.PendingPaymentsTextBox.Text) + ")", con);
                InboundOrderInDataAdupter.InsertCommand = command;
                con.Open();
                InboundOrderInDataAdupter.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Inbound Order Added");
                //----------------------------

                //Save to inboundOrderInItems table & Update Item current stock
                SqlDataAdapter InboundOrderItemsAdupter = new SqlDataAdapter();

                for (int i = 0; i < InboundOrderInItems.Rows.Count; i++)
                {
                    //update inboundOrderInItems table
                    int StockInId = (int)InboundOrderInItems.Rows[i][0];
                    int ItemID = (int)InboundOrderInItems.Rows[i][1];
                    int amount = (int)InboundOrderInItems.Rows[i][2];
                    float unit_Cost = (float)InboundOrderInItems.Rows[i][3];
                    float Total_Cost = (float)InboundOrderInItems.Rows[i][4];

                    command = new SqlCommand(@"INSERT INTO InboundOrderItems(Stock_In_Id,Item_ID,amount,unit_Cost,Total_Cost)
VALUES (" + StockInId + "," + ItemID + "," + amount + "," + unit_Cost + "," + Total_Cost + ")", con);
                    InboundOrderItemsAdupter.InsertCommand = command;
                    con.Open();
                    InboundOrderItemsAdupter.InsertCommand.ExecuteNonQuery();
                    con.Close();
                    //-------------------------

                    //update item table current stock & stock satatus
                    SqlDataAdapter ItemAdupter = new SqlDataAdapter(@"SELECT Current_Stock,Min_Quentity FROM[Item] WHERE Item_ID = " + ItemID + ";", con);
                    DataTable dataTable = new DataTable();
                    dataTable.Clear();

                    ItemAdupter.Fill(dataTable);
                    int CurrentStock = (int)dataTable.Rows[0][0] + amount;
                    int Min_Quentity = (int)dataTable.Rows[0][1];
                    int Stock_Status;

                    if (CurrentStock > Min_Quentity)
                    {
                        Stock_Status = 2;
                    }
                    else
                    {
                        Stock_Status = 1;
                    }


                    SqlCommand com = new SqlCommand(@"UPDATE Item SET Current_Stock = " + CurrentStock + ", Stock_Status = " + Stock_Status + " WHERE Item_ID = " + ItemID + "; ", con);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    //-----------------------------------------



                }

                //------------------------------------




                setInitials();

            }
            else
            {
                MessageBox.Show("Please add items !");
            }
            //----------------------------------

        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show Relevent Measuring Unit
            if (ItemNameComboBox.SelectedValue != null)
            {
                SqlCommand unitCommand = new SqlCommand(@"SELECT i.Mesuring_Unit
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    this.UnitLable.Text = unitCommand.ExecuteScalar().ToString();
                }
                catch
                {
                    this.UnitLable.Text = "";
                }
                
                con.Close();
                
            }
            //-----------------------------------
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturntoSupplierButton_Click(object sender, EventArgs e)
        {
            //check if selected inboundorder already had a return
            
            if (returnFlag ==false)
            {
                
                this.Hide();
                ReturnToSupplierForm.ShowForm();
            }
            else
            {
              
                MessageBox.Show("Selectes inbound Order alrady has a return record !");
            }


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you realy want to Exit? \nChangers may not be saved!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void EditPaymentButton_Click(object sender, EventArgs e)
        {
            this.PeidAmountNumericUpDown.Enabled = true;
            this.UpdateButton.Enabled = true;
            this.UpdateButton.Visible = true;
            

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //set payment status
            int paymentStatus = 4;
            if (float.Parse(TotalCostTextBox.Text) == 0)
            {
                paymentStatus = 3;
            }
            else if ((pendingPaynemts == 0) && (float.Parse(TotalCostTextBox.Text) != 0))
            {
                paymentStatus = 0;
            }
            else if ((pendingPaynemts == float.Parse(TotalCostTextBox.Text)) && (float.Parse(TotalCostTextBox.Text) != 0))
            {
                paymentStatus = 1;
            }
            else if (pendingPaynemts < float.Parse(TotalCostTextBox.Text))
            {
                paymentStatus = 2;
            }
            //---------------------------------------------------------------

            //update to inboundOrderIn table
            SqlCommand UpdateCommand = new SqlCommand(@"UPDATE InboundOrderIn 
SET Payment_Status = "+paymentStatus+" , Paid_Amount = "+ (float)this.PeidAmountNumericUpDown.Value +", Pending_Payment = "+ float.Parse(this.PendingPaymentsTextBox.Text) +" WHERE Stock_In_Id = 1", con);
            con.Open();
            UpdateCommand.ExecuteNonQuery();
            con.Close();
            //------------------------------

            MessageBox.Show("Updated record");
            setInitials();
            //----------------------------
        }
    }
}
