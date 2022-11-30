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
    public partial class ItemForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        int ItemID = -1;
        private static ItemForm _itemForm = new ItemForm();

        public static void ShowForm()
        {

            if (_itemForm.IsDisposed)
            {
                _itemForm = new ItemForm();
            }
            _itemForm.Show();
            _itemForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _itemForm.Hide();
        }

        public ItemForm()
        {
            InitializeComponent();
        }

        private void SetInitioalStage()
        {
            ItemID = -1;
            this.ItemIDTextBox.Text = "";
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled = false;
            this.DiscriptionRichTextBox.Text = "";
            this.DiscriptionRichTextBox.Enabled = false;
            this.StockStatusLabel.Visible = false;
            this.StockStatusTextBox.Visible = false;
            this.StockStatusTextBox.Text = "";
            this.CurrentStockLabel.Visible = false;
            this.CurrentStockTextBox.Visible = false;
            this.CurrentStockTextBox.Text = "";
            this.CustomerReturnStockLabel.Visible = false;
            this.CustomerReturnStockTextBox.Visible = false;
            this.CustomerReturnStockTextBox.Text = "";
            this.MinQuantityNumericUpDown.Value = 0;
            this.MinQuantityNumericUpDown.Enabled = false;
            this.MeasuringUnitTextBox.Text = "";
            this.MeasuringUnitTextBox.Enabled = false;
            this.UnitPriceNumericUpDown.Value = 0;
            this.UnitPriceNumericUpDown.Enabled = false;
            this.SupplierComboBox.Text = "";
            this.SupplierComboBox.Enabled = false;

            this.SaveButton.Visible = false;
            this.SaveButton.Enabled = false;

            this.AddNew.Visible = true;
            this.AddNew.Enabled = true;

            this.SaveUpdateButton.Visible = false;
            this.SaveUpdateButton.Enabled = false;

            this.UpdateButton.Visible = false;
            this.UpdateButton.Enabled = false;

            this.ItemDataGridView.Enabled = true;

            //fill data grid
            DataTable supplierData = new DataTable();
            SqlDataAdapter supplierAdupter = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,i.Discription,sl.Value AS [Stock Status], i.Current_Stock,i.Customer_Return_Stock,i.Min_Quentity AS [Min Requred Quantity],i.Mesuring_Unit,i.Unit_Price,s.Name
From Item i
LEFT JOIN StockLevel sl
ON i.Stock_Status = sl.LevelCode
LEFT JOIN Supplier s
ON i.Supplier_ID = s.Supplier_ID ", con);
            supplierAdupter.Fill(supplierData);
            this.ItemDataGridView.DataSource = supplierData;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);

        }

        private int StockStatus = -1;
        private void MinQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(this.StockStatusTextBox.Text !="" && this.CurrentStockTextBox.Text!="")
            {
                int currentStock = int.Parse(this.CurrentStockTextBox.Text);
                if(currentStock<MinQuantityNumericUpDown.Value)
                {
                    this.StockStatus = 1;
                    this.StockStatusTextBox.Text = "Stock Low";
                }
                else if (currentStock >= MinQuantityNumericUpDown.Value)
                {
                    this.StockStatus = 2;
                    this.StockStatusTextBox.Text = "Stock Satisfied";
                }
            }
        }

        private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetInitioalStage();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill form
            ItemID = (int)this.ItemDataGridView.Rows[e.RowIndex].Cells[0].Value;
            this.ItemDataGridView.CurrentRow.Selected = true;
            this.ItemIDTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.NameTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.DiscriptionRichTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.StockStatusTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.CurrentStockTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.CustomerReturnStockTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.MinQuantityNumericUpDown.Value = int.Parse(this.ItemDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            this.MeasuringUnitTextBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.UnitPriceNumericUpDown.Value = int.Parse(this.ItemDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());
            this.SupplierComboBox.Text = this.ItemDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            //---------------------

            //show delete button & Updtade Button
            this.StockStatusLabel.Visible = true;
            this.StockStatusTextBox.Visible = true;
            this.CurrentStockLabel.Visible = true;
            this.CurrentStockTextBox.Visible = true;
            this.CustomerReturnStockLabel.Visible = true;
            this.CustomerReturnStockTextBox.Visible = true;
            this.UpdateButton.Enabled = true;
            this.UpdateButton.Visible = true;
            //---------
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            //Set Item ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Item_ID as int)),0)+1 FROM Item", con);
            con.Open();
            this.ItemIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            //enable conteollers
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled = true;
            this.DiscriptionRichTextBox.Text = "";
            this.DiscriptionRichTextBox.Enabled = true;
            this.StockStatusLabel.Visible = false;
            this.StockStatusTextBox.Visible = false;
            this.CurrentStockLabel.Visible = false;
            this.CurrentStockTextBox.Visible = false;
            this.CustomerReturnStockLabel.Visible = false;
            this.CustomerReturnStockTextBox.Visible = false;
            this.MinQuantityNumericUpDown.Value = 0;
            this.MinQuantityNumericUpDown.Enabled = true;
            this.MeasuringUnitTextBox.Text = "";
            this.MeasuringUnitTextBox.Enabled = true;
            this.UnitPriceNumericUpDown.Value = 0;
            this.UnitPriceNumericUpDown.Enabled = true;
            this.SupplierComboBox.SelectedIndex = 0;
            this.SupplierComboBox.Enabled = true;

            this.SaveButton.Visible = true;
            this.SaveButton.Enabled = true;

            
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Visible = false;

            this.ItemDataGridView.Enabled = false;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                //Save to Item table
                SqlCommand ItemTableInsertCommand = new SqlCommand(@"INSERT INTO Item (Item_ID,Item_Name,Discription,Stock_Status,Current_Stock,Customer_Return_Stock,Min_Quentity,Mesuring_Unit,Unit_Price,Supplier_ID)
VALUES("+int.Parse(this.ItemIDTextBox.Text)+",'"+this.NameTextBox.Text+"','"+this.DiscriptionRichTextBox.Text+"',0,0,0,"+this.MinQuantityNumericUpDown.Value+",'"+this.MeasuringUnitTextBox.Text+"',"+this.UnitPriceNumericUpDown.Value+","+this.SupplierComboBox.SelectedValue+")", con);

                con.Open();
                ItemTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //----------------------
                SetInitioalStage();
            }
            else
            {
                MessageBox.Show("Please Enter Item Name !");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.NameTextBox.Enabled = true;
            this.DiscriptionRichTextBox.Enabled = true;
            this.MinQuantityNumericUpDown.Enabled = true;
            this.MeasuringUnitTextBox.Enabled = true;
            this.UnitPriceNumericUpDown.Enabled = true;
            this.SupplierComboBox.Enabled = true;

            this.AddNew.Visible = false;
            this.AddNew.Enabled = false;

            this.SaveUpdateButton.Visible = true;
            this.SaveUpdateButton.Enabled = true;

            this.ItemDataGridView.Enabled = false;
        }

        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            //Update ITEM
            SqlCommand UpdateCommand = new SqlCommand(@"UPDATE Item 
SET Item_Name = '"+this.NameTextBox.Text+"',Discription = '"+this.DiscriptionRichTextBox.Text+"',Stock_Status = "+this.StockStatus+",Min_Quentity = "+this.MinQuantityNumericUpDown.Value+",Mesuring_Unit='"+this.MeasuringUnitTextBox.Text+"',Unit_Price = "+this.UnitPriceNumericUpDown.Value+",Supplier_ID = "+this.SupplierComboBox.SelectedValue+" WHERE Item_ID = "+int.Parse(this.ItemIDTextBox.Text)+"", con);
            con.Open();
            UpdateCommand.ExecuteNonQuery();
            con.Close();
            //------------------------------

            MessageBox.Show("Updated record");
            SetInitioalStage();
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
