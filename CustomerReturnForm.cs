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
    public partial class CustomerReturnForm : Form
    {
        int customerReturnSalesId;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable itemList = new DataTable();
        DataTable CRitemList = new DataTable();

        public CustomerReturnForm()
        {
            InitializeComponent();
        }

        private void CustomerReturnForm_Load(object sender, EventArgs e)
        {
            CRDateTimePicker.Value = DateTime.Today;
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.CustomerReturnReason' table. You can move, or remove it, as needed.
            this.customerReturnReasonTableAdapter.Fill(this.ranga_hardwareDataSet.CustomerReturnReason);
            customerReturnSalesId = SalesForm.SalesId;

            //Auto generate ID
            SqlCommand IDgenerateCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Stock_In_ID as int)),0)+1 FROM StockInTable", con);
            con.Open();
            this.CustomerReturnIDTextBox.Text = IDgenerateCommand.ExecuteScalar().ToString();
            con.Close();
            //--------------------

            //Get Item List
            SqlDataAdapter itemListAdupter = new SqlDataAdapter(@"SELECT i.Item_Name,i.Item_ID,i.Mesuring_Unit,si.Amount
FROM Item i,SalesItems si
WHERE si.Item_ID= i.Item_ID AND si.Stock_Out_Id = " + customerReturnSalesId + "", con);

            itemListAdupter.Fill(itemList);
            this.ItemNameComboBox.DataSource = itemList;
            this.ItemNameComboBox.DisplayMember = "Item_Name";
            this.ItemNameComboBox.ValueMember = "Item_ID";
            //---------------------------

            //set items table
            CRitemList.Columns.Clear();
            CRitemList.Rows.Clear();
            CRitemList.Columns.Add("Stock_In_Id", typeof(int));
            CRitemList.Columns.Add("Item_ID", typeof(int));
            CRitemList.Columns.Add("Amount", typeof(int));
            //-------------------
        }

        private void CustomerReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SalesForm.ShowForm();
        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get sold Quantity & Unit base on Stock Out ID
            if (ItemNameComboBox.SelectedIndex >= 0)
            {
                this.SoldQuantityCountLable.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][3].ToString();
                this.UnitLable.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][2].ToString();
                this.Unit2Label.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][2].ToString();
            }
            //---------------------------------------------------
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //Validate same item repitition
            int repeat = -1;


            if (CRItemsDataGridView.Rows.Count > 0)
            {
                string searchItem = this.ItemNameComboBox.Text;

                foreach (DataGridViewRow row in CRItemsDataGridView.Rows)
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
            //----------------------------------------------------------


            //validate amount is>0 & amount<current stock or customer return stock

            if ((QuantityNumericUpDown.Value > 0) && (repeat == -1))
            {
                if (this.QuantityNumericUpDown.Value > int.Parse(this.SoldQuantityCountLable.Text))
                {
                    MessageBox.Show("Invalid Quantity!");
                }
                else
                {
                    //Update data grid
                    this.CRItemsDataGridView.Rows.Add(this.ItemNameComboBox.Text, this.QuantityNumericUpDown.Text);
                    //-----------

                    //Add data to table
                    CRitemList.Rows.Add(new object[] { int.Parse(CustomerReturnIDTextBox.Text), ItemNameComboBox.SelectedValue, QuantityNumericUpDown.Value });
                    //---------------------------

                    //clear add item data input options
                    
                    this.ItemNameComboBox.SelectedIndex = 0;
                    this.QuantityNumericUpDown.Value = 0;
                    //-------------
                }
            }

            else if ((QuantityNumericUpDown.Value <= 0) && (repeat == -1))
            {
                MessageBox.Show("Please Enter Quantity");
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (itemList.Rows.Count > 0)
            {
                SqlCommand command;

                //Save to StockIn table
                command = new SqlCommand(@"INSERT INTO StockInTable
VALUES(" + int.Parse(this.CustomerReturnIDTextBox.Text) + ", 2, '" + this.CRDateTimePicker.Value + "')", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                //-----------------

                //Save to curstomer return tabale
                command = new SqlCommand(@"INSERT INTO CustomerReturn (Stock_In_ID,Stock_Out_ID,Reason,Reason_Discription)
VALUES(" + int.Parse(this.CustomerReturnIDTextBox.Text) + ", " + customerReturnSalesId + ", " + this.ReasonComboBox.SelectedValue + ",'" + this.DiscriptionRichTextBox.Text + "')", con);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                //-------------------------

                //insert to customer return item tabele & update iem table customer return stock
                for (int i = 0; i < CRitemList.Rows.Count; i++)
                {
                    //update CRItems table
                    int StockInId = (int)CRitemList.Rows[i][0];
                    int ItemID = (int)CRitemList.Rows[i][1];
                    int amount = (int)CRitemList.Rows[i][2];

                    command = new SqlCommand(@"INSERT INTO CustomerReturnItems(Stock_In_Id,Item_Id,amount)
VALUES (" + StockInId + "," + ItemID + "," + amount + ")", con);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    //-------------------------

                    //update items table
                    command = new SqlCommand(@"UPDATE Item SET Customer_Return_Stock += "+amount+" WHERE Item_ID = " + Item_ID + "", con);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    //--------------------
                }

                MessageBox.Show("Customer return record saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Add Items");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CustomerReturnForm.ActiveForm.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you realy want to Exit? \nChangers may not be saved!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
