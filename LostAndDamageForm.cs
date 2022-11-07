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
    public partial class LostAndDamageForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        
        DataTable LostDataTable = new DataTable();

        public static int LostId = -1;
        private static LostAndDamageForm _lostAndDamageForm = new LostAndDamageForm();

        public static void ShowForm()
        {

            if (_lostAndDamageForm.IsDisposed)
            {
                _lostAndDamageForm = new LostAndDamageForm();
            }
            _lostAndDamageForm.Show();
            _lostAndDamageForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _lostAndDamageForm.Hide();
        }
        public LostAndDamageForm()
        {
            InitializeComponent();
        }

        public void SetInitioalStage()
        {
            LostId = -1; 

            //Set Batch ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Stock_Out_ID as int)),0)+1 FROM StockOut", con);
            con.Open();
            this.BatchIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            this.BatchIDTextBox.Text = "";

            this.DateTimePicker.Enabled = false;
            this.DateTimePicker.Value = DateTime.Today;

           
            this.FromStockTypeComboBox.Enabled = false;
            this.FromStockTypeComboBox.SelectedIndex = 0;

            this.ItemNameComboBox.Enabled = false;
            this.ItemNameComboBox.SelectedIndex = 0;

            this.QuantityNumericUpDown.Enabled = false;
            this.QuantityNumericUpDown.Value = 0;
            
            
            this.AvailableStockLabel.Visible = false;
            this.AvailableStockCountLable.Visible = false;
            this.Unit2Label.Visible = false;

           
            this.CommentRichTextBox.Enabled = false;
            this.CommentRichTextBox.Text = "";


            this.SaveButton.Enabled = false;
            this.SaveButton.Visible = false;

            this.DeleteSelectedRecordButton.Enabled = false;
            this.DeleteSelectedRecordButton.Visible = false;

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT l.Stock_Out_Id,s.Out_Date as [Date] , st.Stock_Type AS [From Stock Type],i.Item_Name,l.Amount AS Quentity, l.comment
From LostDamageStockOut l
LEFT JOIN StockOut s
ON s.Stock_Out_ID = l.Stock_Out_Id
LEFT JOIN Item i 
ON i.Item_ID = l.Item_ID
LEFT JOIN StockType st
ON st.Id = s.From_Stock_Type", con);
            LostDataTable.Rows.Clear();
            sda.Fill(LostDataTable);
            Lost_DamagedDataGridView.DataSource = LostDataTable;
            Lost_DamagedDataGridView.Enabled = true;




        }

        private void LostAndDamageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockType' table. You can move, or remove it, as needed.
            this.stockTypeTableAdapter.Fill(this.ranga_hardwareDataSet.StockType);
            SetInitioalStage();

        }

        private void getAvailableStock()
        {
            SqlCommand quantityCommand = new SqlCommand();
            //Get available Quantity base on stock type
            if (ItemNameComboBox.SelectedValue != null)
            {
                
                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    quantityCommand = new SqlCommand(@"SELECT i.Current_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "");
                    quantityCommand.Connection = con;
                }
                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    quantityCommand = new SqlCommand(@"SELECT i.Customer_Return_Stock
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "");
                    quantityCommand.Connection = con;

                }

                if(quantityCommand.Connection == con)
                {
                    con.Open();
                    this.AvailableStockCountLable.Text = quantityCommand.ExecuteScalar().ToString();
                    con.Close();
                }
                

                quantityCommand = new SqlCommand(@"SELECT i.Mesuring_Unit
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);

                con.Open();
                this.Unit2Label.Text = quantityCommand.ExecuteScalar().ToString();
                this.UnitLable.Text = Unit2Label.Text;
                con.Close();


            }


            //--------------------------------------
        }
        private void FromStockTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change available stock count
            getAvailableStock();

        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change available stock count
            getAvailableStock();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LostAndDamageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StockOutManagementForm.ShowForm();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //check entered quantity is valid
            if(int.TryParse(this.AvailableStockCountLable.Text,out int result) == true)
            {
                if (QuantityNumericUpDown.Value > int.Parse(this.AvailableStockCountLable.Text))
                {
                    MessageBox.Show("Invalid Quantity !");
                    this.QuantityNumericUpDown.Value = 0;
                }
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //check quantity entered
            if(this.QuantityNumericUpDown.Value>0)
            {
                //Save Lost

                //Save into stockOut Tabale
                SqlCommand stockOutTableInsertCommand = new SqlCommand(@"INSERT INTO StockOut (Stock_Out_ID,Type,Out_Date,From_Stock_Type )
VALUES(" + int.Parse(this.BatchIDTextBox.Text) + ",3,'" + this.DateTimePicker.Value + "'," + this.FromStockTypeComboBox.SelectedValue + ")", con);

                con.Open();
                stockOutTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //------------------------------------

                //Saving To Lost Table
                SqlCommand LostTableInsertCommand = new SqlCommand(@"INSERT INTO LostDamageStockOut (Stock_Out_Id, Item_ID,Amount,comment)
VALUES("+int.Parse(this.BatchIDTextBox.Text)+","+this.ItemNameComboBox.SelectedValue+","+this.QuantityNumericUpDown.Value+",'"+this.CommentRichTextBox.Text+"')", con);

                con.Open();
                LostTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //----------------------

                MessageBox.Show("Lost Record Saved.");
                SetInitioalStage();
            }
            else
            {
                MessageBox.Show("Please Enter the Quantity.");
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            //Set Batch ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Stock_Out_ID as int)),0)+1 FROM StockOut", con);
            con.Open();
            this.BatchIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            this.DateTimePicker.Enabled = true;
            this.DateTimePicker.Value = DateTime.Today;

            this.SaveButton.Visible = true;
            this.SaveButton.Enabled = true;

            this.ItemNameComboBox.Enabled = true;
            this.ItemNameComboBox.SelectedIndex = 0;

            this.QuantityNumericUpDown.Enabled = true;
            this.QuantityNumericUpDown.Value = 0;

            this.FromStockTypeComboBox.Enabled = true;
            this.FromStockTypeComboBox.SelectedIndex = 0;


            this.AvailableStockLabel.Visible = true;
            this.AvailableStockCountLable.Visible = true;
            this.Unit2Label.Visible = true;

            this.CommentRichTextBox.Enabled = true;
            this.CommentRichTextBox.Text = "";

            this.DeleteSelectedRecordButton.Enabled = false;
            this.DeleteSelectedRecordButton.Visible = false;

            this.Lost_DamagedDataGridView.Enabled = false;

            getAvailableStock();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetInitioalStage();
        }

        private void Lost_DamagedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Lost_DamagedDataGridView.CurrentRow.Selected = true;
            LostId = (int)this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[0].Value;
            
            this.BatchIDTextBox.Text = this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DateTimePicker.Value = DateTime.Parse(this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.FromStockTypeComboBox.Text = this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.ItemNameComboBox.Text = this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.QuantityNumericUpDown.Text = this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.CommentRichTextBox.Text = this.Lost_DamagedDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            this.DeleteSelectedRecordButton.Enabled = true;
            this.DeleteSelectedRecordButton.Visible = true;

        }

        private void DeleteSelectedRecordButton_Click(object sender, EventArgs e)
        {
            //check id user realy want to delete
            DialogResult result = MessageBox.Show("Do you realy want to delete the record? \ndeleted records will not be abeled to recovered!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                SqlCommand UpdateCommand = new SqlCommand();
                SqlDataAdapter GetDataAdupter = new SqlDataAdapter();

                //Update stock level & Stock Status
                if (this.FromStockTypeComboBox.Text == "CurrentStock")
                {
                    GetDataAdupter = new SqlDataAdapter(@"SELECT i.Current_Stock,i.Min_Quentity
FROM Item i
WHERE i.Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                    DataTable dt = new DataTable();

                    GetDataAdupter.Fill(dt);
                    

                    int CurrentStock = int.Parse(dt.Rows[0][0].ToString()) + (int)this.QuantityNumericUpDown.Value;
                    int Min_Quentity = int.Parse(dt.Rows[0][1].ToString());
                    int Stock_Status;

                    if (CurrentStock <= Min_Quentity)
                    {
                        Stock_Status = 2;
                    }
                    else
                    {
                        Stock_Status = 1;
                    }
                    UpdateCommand = new SqlCommand(@"UPDATE Item SET Current_Stock += " + (int)this.QuantityNumericUpDown.Value + ",Stock_Status = " + Stock_Status + "  WHERE Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                }
                else if (this.FromStockTypeComboBox.Text == "Customer Return Stock")
                {
                    UpdateCommand = new SqlCommand(@"UPDATE Item SET Customer_Return_Stock +=" + (int)this.QuantityNumericUpDown.Value + "  WHERE Item_ID = " + this.ItemNameComboBox.SelectedValue + "", con);
                }

                con.Open();
                UpdateCommand.ExecuteNonQuery();
                con.Close();
                //---------------------------------------------------------

                

                //Delete Lost Records
                SqlCommand DeleteItemsCommand = new SqlCommand(@"DELETE FROM LostDamageStockOut WHERE Stock_Out_Id =  " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                con.Open();
                DeleteItemsCommand.ExecuteNonQuery();
                con.Close();
                //-----------------------

                //Delete stockout record
                SqlCommand DeleteStockOutCommand = new SqlCommand(@"DELETE FROM StockOut WHERE Stock_Out_Id = " + int.Parse(this.BatchIDTextBox.Text) + "", con);
                con.Open();
                DeleteStockOutCommand.ExecuteNonQuery();
                con.Close();
                //---------------------

                MessageBox.Show("Record Deleted");
                SetInitioalStage();
            }
        }
    }
}
