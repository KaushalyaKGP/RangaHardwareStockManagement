using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RangaHardwareStock
{
    public partial class SupplierForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");

        private static SupplierForm _supplierFoem = new SupplierForm();

        public static void ShowForm()
        {

            if (_supplierFoem.IsDisposed)
            {
                _supplierFoem = new SupplierForm();
            }
            _supplierFoem.Show();
            _supplierFoem.SetInitioalStage();

        }

        public static void HideForm()
        {
            _supplierFoem.Hide();
        }

        public SupplierForm()
        {
            InitializeComponent();
        }

        
        //Set Initioal Stage
        private void SetInitioalStage()
        {
            this.SupplierIDTextBox.Text = "";
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled =false;
            this.CompanyTextBox.Text = "";
            this.CompanyTextBox.Enabled = false;
            this.AddressRichTextBox.Text = "";
            this.AddressRichTextBox.Enabled = false;
            this.ContactNoTextBox.Text = "";
            this.ContactNoTextBox.Enabled = false;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.Enabled = false;
            this.ContactablePersonNameTextBox.Text = "";
            this.ContactablePersonNameTextBox.Enabled = false;
            this.ContactablePersonTPNTextBox.Text = "";
            this.ContactablePersonTPNTextBox.Enabled = false;

            this.SaveButton.Visible = false;
            this.SaveButton.Enabled = false;

            this.AddNew.Visible = true;
            this.AddNew.Enabled = true;

            this.DeleteSelectedRecordButton.Visible = false;
            this.DeleteSelectedRecordButton.Enabled = false;

            this.SupplierDataGridView.Enabled = true;

            //fill data grid
            DataTable supplierData = new DataTable();
            SqlDataAdapter supplierAdupter = new SqlDataAdapter(@"SELECT s.Supplier_ID, s.Name, s.Company,s.Address,s.[Contact No],s.Contactable_Person_Name,s.Contactable_Person_Mobile,items.Items
From Supplier s
LEFT JOIN (SELECT s.Supplier_ID,Items = STUFF((SELECT DISTINCT ', ' +Items FROM (SELECT s.Supplier_ID , i.Item_Name as Items
FROM Supplier s
LEFT JOIN Item i
ON s.Supplier_ID = i.Supplier_ID) as a WHERE s.Supplier_ID = a.Supplier_ID FOR XML PATH('')), 1, 2, '') 
FROM Supplier s
LEFT JOIN Item i
ON s.Supplier_ID = i.Supplier_ID
GROUP BY s.Supplier_ID) as items
ON items.Supplier_ID = s.Supplier_ID",con);
            supplierAdupter.Fill(supplierData);
            this.SupplierDataGridView.DataSource = supplierData;

        }


        //Mobile number validation
        private void ContactNoTextBox_Leave(object sender, EventArgs e)
        {
            Globles.validateMobileNumber(ContactNoTextBox.Text,ContactNoTextBox);

        }

        private void ContactablePersonTPNTextBox_Leave(object sender, EventArgs e)
        {
            Globles.validateMobileNumber(ContactablePersonTPNTextBox.Text, ContactablePersonTPNTextBox);
        }

        //email validation
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            
            Globles.validateEmail(EmailTextBox.Text, EmailTextBox);
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            //Set Supplier ID
            SqlCommand idCommand = new SqlCommand("SELECT ISNULL(MAX(cast (Supplier_ID as int)),0)+1 FROM Supplier", con);
            con.Open();
            this.SupplierIDTextBox.Text = idCommand.ExecuteScalar().ToString();
            con.Close();
            //-----------------

            //enable conteollers
            this.NameTextBox.Text = "";
            this.NameTextBox.Enabled = true;
            this.CompanyTextBox.Text = "";
            this.CompanyTextBox.Enabled = true;
            this.AddressRichTextBox.Text = "";
            this.AddressRichTextBox.Enabled = true;
            this.ContactNoTextBox.Text = "";
            this.ContactNoTextBox.Enabled = true;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.Enabled = true;
            this.ContactablePersonNameTextBox.Text = "";
            this.ContactablePersonNameTextBox.Enabled = true;
            this.ContactablePersonTPNTextBox.Text = "";
            this.ContactablePersonTPNTextBox.Enabled = true;

            this.SaveButton.Visible = true;
            this.SaveButton.Enabled = true;

            this.DeleteSelectedRecordButton.Visible = false;
            this.DeleteSelectedRecordButton.Enabled = false;

            this.SupplierDataGridView.Enabled = false;


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text!="")
            {
                //Save to supplier table
                SqlCommand supplierTableInsertCommand = new SqlCommand(@"INSERT INTO Supplier (Supplier_ID,Name,Company,Address,[Contact No],Email_Address,Contactable_Person_Name,Contactable_Person_Mobile)
VALUES("+int.Parse(this.SupplierIDTextBox.Text)+",'"+this.NameTextBox.Text+"','"+this.CompanyTextBox.Text+"','"+this.AddressRichTextBox.Text+"','"+this.ContactNoTextBox.Text+"','"+this.EmailTextBox.Text+"','"+this.ContactablePersonNameTextBox.Text+"','"+this.ContactablePersonTPNTextBox.Text+"')", con);

                con.Open();
                supplierTableInsertCommand.ExecuteNonQuery();
                con.Close();
                //----------------------
            }
            else
            {
                MessageBox.Show("Please Enter Supplier Name !");
            }
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }
    }
}
