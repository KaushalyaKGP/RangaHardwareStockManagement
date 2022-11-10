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
            this.CompanyTextBox.Text = "";
            this.CompanyTextBox.Enabled =false;
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
            this.SaveButton.Enabled = true;

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
    }
}
