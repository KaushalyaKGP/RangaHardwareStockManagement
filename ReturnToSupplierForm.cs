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
    public partial class ReturnToSupplierForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        int StockInID = InboundOrderForm.StockInID;
        DataTable itemList = new DataTable();
        DataTable SRItemsTable = new DataTable();

        private static ReturnToSupplierForm _returnToSupplierForm = new ReturnToSupplierForm();

        public static void ShowForm()
        {

            if (_returnToSupplierForm.IsDisposed)
            {
                _returnToSupplierForm = new ReturnToSupplierForm();
            }
            _returnToSupplierForm.Show();
            _returnToSupplierForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _returnToSupplierForm.Hide();
        }
        public ReturnToSupplierForm()
        {
            InitializeComponent();
        }

        public void SetInitioalStage()
        {
            

            //Set Batch ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Stock_Out_ID as int)),0)+1 FROM StockOut", con);
            con.Open();
            this.ReturnIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            this.SRDateTimePicker.Value = DateTime.Today;

            //Get Item List
            
            SqlDataAdapter itemListAdupter = new SqlDataAdapter(@"SELECT i.Item_Name,i.Item_ID,i.Mesuring_Unit,ioi.Amount,i.Current_Stock,i.Customer_Return_Stock
FROM Item i,InboundOrderItems ioi
WHERE ioi.Item_ID= i.Item_ID AND ioi.Stock_In_Id = " + StockInID + "", con);

            itemList.Columns.Clear();
            itemList.Rows.Clear();
            itemListAdupter.Fill(itemList);
            this.ItemNameComboBox.DataSource = itemList;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.ValueMember = "Item_ID";
            //---------------------------

            //set Return to supplier items table
            SRItemsTable.Columns.Clear();
            SRItemsTable.Rows.Clear();
            SRItemsTable.Columns.Add("Stock_Out_Id", typeof(int));
            SRItemsTable.Columns.Add("Item_ID", typeof(int));
            SRItemsTable.Columns.Add("Amount", typeof(int));
            //-------------------

            this.QuantityNumericUpDown.Value = 0;
        }

        private void ReturnToSupplierForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.ReturnToSupplierReasons' table. You can move, or remove it, as needed.
            this.returnToSupplierReasonsTableAdapter.Fill(this.ranga_hardwareDataSet.ReturnToSupplierReasons);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockType' table. You can move, or remove it, as needed.
            this.stockTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockType);
            SetInitioalStage();
        }

        private void ReturnToSupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            InboundOrderForm.ShowForm();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemNameComboBox.SelectedValue != null)
            {
                this.InboundedQuantityCountLable.Text = this.itemList.Rows[ItemNameComboBox.SelectedIndex][3].ToString();

                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    this.AvailableQuantityLabel.Text = this.itemList.Rows[ItemNameComboBox.SelectedIndex][4].ToString();
                }
                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    this.AvailableQuantityLabel.Text = this.itemList.Rows[ItemNameComboBox.SelectedIndex][5].ToString();
                }
            }
        }

        private void FromStockTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromStockTypeComboBox.SelectedValue != null)
            {
                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    this.AvailableQuantityLabel.Text = this.itemList.Rows[ItemNameComboBox.SelectedIndex][4].ToString();
                }
                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    this.AvailableQuantityLabel.Text = this.itemList.Rows[ItemNameComboBox.SelectedIndex][5].ToString();
                }
            }
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(this.AvailableQuantityLabel.Text, out int avalable)) && int.TryParse(this.itemList.Rows[ItemNameComboBox.SelectedIndex][3].ToString(), out int outbound))
            {
                if ((QuantityNumericUpDown.Value > avalable) || (QuantityNumericUpDown.Value > outbound ))
                {
                    MessageBox.Show("Invalid Quantity");
                    this.QuantityNumericUpDown.Value = 0;
                }
            }
            
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if(QuantityNumericUpDown.Value>0)
            {
                //check repetition of same item
                int repeat = -1;

                if (SRItemsDataGridView.Rows.Count > 0)
                {
                    string searchItem = this.ItemNameComboBox.Text;

                    foreach (DataGridViewRow row in SRItemsDataGridView.Rows)
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
                //------------------------

                if(repeat!=1)
                {
                    //Update data grid
                    this.SRItemsDataGridView.Rows.Add(this.ItemNameComboBox.Text, this.QuantityNumericUpDown.Text);
                    //-----------

                    //Add data to table
                    SRItemsTable.Rows.Add(new object[] { int.Parse(ReturnIDTextBox.Text), ItemNameComboBox.SelectedValue, QuantityNumericUpDown.Value });
                    //---------------------------

                    this.ItemNameComboBox.SelectedIndex = 0;
                    this.QuantityNumericUpDown.Value = 0;

                }

            }
            else
            {
                MessageBox.Show("Please enter qantity");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SRItemsTable.Rows.Count > 0)
            {
                SqlCommand command;

                //Save to StockOut table
                command = new SqlCommand(@"INSERT INTO StockOut(Stock_Out_ID,Type,Out_Date,From_Stock_Type)
VALUES("+int.Parse(this.ReturnIDTextBox.Text)+",2,"+this.SRDateTimePicker.Value+","+this.FromStockTypeComboBox.SelectedValue+")", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                //-----------------

                //Save to return to supplier tabale
                command = new SqlCommand(@"INSERT INTO ReturnToSupplier(Stock_Out_ID,Stock_In_ID,Reason,Comment)
VALUES(" + int.Parse(this.ReturnIDTextBox.Text) + ","+StockInID+","+this.ReasonComboBox.SelectedValue+","+this.DiscriptionRichTextBox.Text+")", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                //-------------------------

                //insert to return to supplier item tabele & update item table customer return stock or current stock
                for (int i = 0; i < SRItemsTable.Rows.Count; i++)
                {
                    //update SRItems table
                    int StockOutId = (int)SRItemsTable.Rows[i][0];
                    int ItemID = (int)SRItemsTable.Rows[i][1];
                    int amount = (int)SRItemsTable.Rows[i][2];

                    command = new SqlCommand(@"INSERT INTO ReturnToSupplierItems(Stock_Out_ID,Item_ID,Amount)
VALUES (" + StockOutId + "," + ItemID + "," + amount + ")", con);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    //-------------------------

                    //Update stock level & stock status In item table********************************

                    if (this.FromStockTypeComboBox.Text == "CurrentStock")
                    {
                        int CurrentStock = (int)itemList.Rows[i][0] - Amount;
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
                }

                MessageBox.Show("Customer return record saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Add Items");
            }
        }
    }
}
