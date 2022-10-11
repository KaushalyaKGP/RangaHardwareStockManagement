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
    public partial class CustomerReturnForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable itemList = new DataTable();
        public CustomerReturnForm()
        {
            InitializeComponent();
        }

        private void CustomerReturnForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.CustomerReturnReason' table. You can move, or remove it, as needed.
            this.customerReturnReasonTableAdapter.Fill(this.ranga_hardwareDataSet.CustomerReturnReason);
            int customerReturnSalesId = SalesForm.SalesId;

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
        }

        private void CustomerReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SalesForm.ShowForm();
        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get sold Quantity & Unit base on Stock Out ID
            if (ItemNameComboBox.SelectedIndex >=0)
            {
                this.SoldQuantityCountLable.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][3].ToString();
                this.UnitLable.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][2].ToString();
                this.Unit2Label.Text = itemList.Rows[ItemNameComboBox.SelectedIndex][2].ToString();
            }
            //---------------------------------------------------
        }
    }
}
