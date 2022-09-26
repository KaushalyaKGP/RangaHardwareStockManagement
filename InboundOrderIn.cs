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
    public partial class InboundOrderIn : Form
    {

        float TotalCost = 0;
        float pendingPaynemts;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");

        //data of items
        DataTable items = new DataTable();
        //------------
        public InboundOrderIn()
        {
            InitializeComponent();
        }

        private void InboundOrderIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);

            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);

            //Auto generate ID
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(cast (Stock_In_ID as int)),0)+1 FROM StockInTable",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.BatchIDTextBox.Text = dt.Rows[0][0].ToString();
            //--------------------
            //View Item List Based on Selected Supplier
            SetItemList();
            //--------------------------

            

            



        }

        private void SetItemList()
        {
            //View Item List Based on Selected Supplier
            SqlDataAdapter sda2 = new SqlDataAdapter(@"SELECT Item_ID,Item_Name
FROM Item
WHERE Supplier_ID = "+this.SupplierComboBox.SelectedValue +"", con);

            
            DataTable dt2 = new DataTable();
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

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //Validate same item repitition
            int repeat = -1;
           
            if(InboundOrderItemsDataGridView.Rows.Count>0)
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
            if((AmountNumericUpDown.Value>0)&&(repeat==-1))
            {
                float total_Item_Cost = (float.Parse(this.UnitCostNumericUpDown.Text)) * (float.Parse(this.AmountNumericUpDown.Text));
                this.InboundOrderItemsDataGridView.Rows.Add(this.ItemNameComboBox.Text, this.AmountNumericUpDown.Text, this.UnitCostNumericUpDown.Text, total_Item_Cost.ToString("0.00"));
                TotalCost += total_Item_Cost;
                TotalCostTextBox.Text = TotalCost.ToString("0.00");
                pendingPaynemts = TotalCost - (float)this.PeidAmountNumericUpDown.Value;
                PendingPaymentsTextBox.Text = pendingPaynemts.ToString("0.00");

                //clear add item data input options
                this.ItemNameComboBox.SelectedIndex = 0;
                this.AmountNumericUpDown.Value = 0;
                this.UnitCostNumericUpDown.Value = 0;
                //-------------
            }

            else if((AmountNumericUpDown.Value >= 0) && (repeat == -1))
            {
                MessageBox.Show("Please Enter Amount");
            }

        }

        private void PeidAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if((float)PeidAmountNumericUpDown.Value > TotalCost)
            {
                MessageBox.Show("Invalid Paid Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                PeidAmountNumericUpDown.Value = 0;
            }
            else
            {
                pendingPaynemts = TotalCost - (float)this.PeidAmountNumericUpDown.Value;
                PendingPaymentsTextBox.Text = pendingPaynemts.ToString("0.00");
            }
            
        }

        private void AddNewInboundOrderButton_Click(object sender, EventArgs e)
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
            else if((pendingPaynemts == TotalCost) && (TotalCost != 0))
            {
                paymrntStatus = 1;
            }
            else if (pendingPaynemts < TotalCost)
            {
                paymrntStatus = 2;
            }
            //---------------------------------------------------------------
            
            
            
            
        }
    }
}
