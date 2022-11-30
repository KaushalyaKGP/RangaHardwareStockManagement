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
    public partial class CustomerForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        int CustomerID = -1;
        private static CustomerForm _customerForm = new CustomerForm();

        public static void ShowForm()
        {

            if (_customerForm.IsDisposed)
            {
                _customerForm = new CustomerForm();
            }
            _customerForm.Show();
            _customerForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _customerForm.Hide();
        }


        public CustomerForm()
        {
            InitializeComponent();
        }

        //set initial stage of form
        private void SetInitioalStage()
        {
            CustomerID = -1;
            this.CustomerIDTextBox.Text = "";
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled = false;
            this.AddressRichTextBox.Text = "";
            this.AddressRichTextBox.Enabled = false;
            this.ContactNoTextBox.Text = "";
            this.ContactNoTextBox.Enabled = false;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.Enabled = false;

            this.SaveButton.Visible = false;
            this.SaveButton.Enabled = false;

            this.AddNew.Visible = true;
            this.AddNew.Enabled = true;

            this.DeleteSelectedRecordButton.Visible = false;
            this.DeleteSelectedRecordButton.Enabled = false;

            this.SaveUpdateButton.Visible = false;
            this.SaveUpdateButton.Enabled = false;

            this.UpdateButton.Visible = false;
            this.UpdateButton.Enabled = false;

            this.CustomerDataGridView.Enabled = true;

            //fill data grid
            DataTable supplierData = new DataTable();
            SqlDataAdapter supplierAdupter = new SqlDataAdapter(@"SELECT Customer_ID, Name, Address,[Contact No] , Email_Address
From Customer ", con);
            supplierAdupter.Fill(supplierData);
            this.CustomerDataGridView.DataSource = supplierData;
        }

        //contact number validation
        private void ContactNoTextBox_Leave(object sender, EventArgs e)
        {
            Globles.validateMobileNumber(ContactNoTextBox.Text, ContactNoTextBox);

        }

        //email validation
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            Globles.validateEmail(EmailTextBox.Text, EmailTextBox);

        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill form
            CustomerID = (int)this.CustomerDataGridView.Rows[e.RowIndex].Cells[0].Value;
            this.CustomerDataGridView.CurrentRow.Selected = true;
            this.CustomerIDTextBox.Text = this.CustomerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.NameTextBox.Text = this.CustomerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.AddressRichTextBox.Text = this.CustomerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.ContactNoTextBox.Text = this.CustomerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.EmailTextBox.Text = this.CustomerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            //---------------------

            //show delete button & Updtade Button
            this.DeleteSelectedRecordButton.Enabled = true;
            this.DeleteSelectedRecordButton.Visible = true;
            this.UpdateButton.Enabled = true;
            this.UpdateButton.Visible = true;
            //---------
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            //Set Customer ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Customer_ID as int)),0)+1 FROM Customer", con);
            con.Open();
            this.CustomerIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            //enable conteollers
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled = true;
            this.AddressRichTextBox.Text = "";
            this.AddressRichTextBox.Enabled = true;
            this.ContactNoTextBox.Text = "";
            this.ContactNoTextBox.Enabled = true;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.Enabled = true;

            this.SaveButton.Visible = true;
            this.SaveButton.Enabled = true;

            this.DeleteSelectedRecordButton.Visible = false;
            this.DeleteSelectedRecordButton.Enabled = false;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Visible = false;

            this.CustomerDataGridView.Enabled = false;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                //Save to Customer table
                SqlCommand CustomerTableInsertCommand = new SqlCommand(@"INSERT INTO Customer(Customer_ID,Name,Address,[Contact No],Email_Address)
VALUES(" + int.Parse(this.CustomerIDTextBox.Text) + ",'" + this.NameTextBox.Text + "','" + this.AddressRichTextBox.Text + "','" + this.ContactNoTextBox.Text + "','" + this.EmailTextBox.Text + "')", con);

                con.Open();
                CustomerTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //----------------------
                SetInitioalStage();
            }
            else
            {
                MessageBox.Show("Please Enter Customer Name !");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //enable conteollers

            this.NameTextBox.Enabled = true;
            this.AddressRichTextBox.Enabled = true;
            this.ContactNoTextBox.Enabled = true;
            this.EmailTextBox.Enabled = true;

            this.DeleteSelectedRecordButton.Visible = false;
            this.DeleteSelectedRecordButton.Enabled = false;

            this.SaveUpdateButton.Visible = true;
            this.SaveUpdateButton.Enabled = true;
        }

        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            //Update Customer
            SqlCommand UpdateCommand = new SqlCommand(@"UPDATE Customer 
SET Name = '" + this.NameTextBox.Text + "',Address = '" + this.AddressRichTextBox.Text + "', [Contact No]= '" + this.ContactNoTextBox.Text + "', Email_Address = '" + this.EmailTextBox.Text + "'  WHERE Customer_ID = " + this.CustomerID + "", con);
            con.Open();
            UpdateCommand.ExecuteNonQuery();
            con.Close();
            //------------------------------

            MessageBox.Show("Updated record");
            SetInitioalStage();
        }

        private void DeleteSelectedRecordButton_Click(object sender, EventArgs e)
        {
            //check id user realy want to delete
            DialogResult result = MessageBox.Show("Do you realy want to delete the record? \ndeleted records will not be abeled to recovered!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                //Delete Customer
                SqlCommand DeleteCustomerCommand = new SqlCommand(@"DELETE FROM Customer WHERE Customer_ID = " + this.CustomerID + "", con);
                con.Open();
                DeleteCustomerCommand.ExecuteNonQuery();
                con.Close();
                //-----------------------

                MessageBox.Show("Record Deleted");
                SetInitioalStage();
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
    }
}
