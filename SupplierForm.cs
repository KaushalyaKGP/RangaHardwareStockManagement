using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangaHardwareStock
{
    public partial class SupplierForm : Form
    {
        private static SupplierForm _supplierFoem = new SupplierForm();

        public static void ShowForm()
        {

            if (_supplierFoem.IsDisposed)
            {
                _supplierFoem = new SupplierForm();
            }
            _supplierFoem.Show();
            // _supplierFoem.SetInitioalStage();

        }

        public static void HideForm()
        {
            _supplierFoem.Hide();
        }

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void validateMobileNumber(string m,TextBox textbox)
        {
            string mobile = m;
            mobile = mobile.Replace(" ",string.Empty);
            string[] pattern = { "^[0][0-9]{9}$", "^[0-9]{9}$", "^[+][0-9]{11}$" };
            Regex regex;
            bool match = false;
            for (int i = 0; i < pattern.Length; i++)
            {
                regex = new Regex(pattern[i]);
                if (regex.IsMatch(mobile))
                {
                    match = true;

                }
            }

            if (match != true)
            {
                MessageBox.Show("Invalid Mobile Number!");
                textbox.Text = "";
            }
        }

        private void ContactNoTextBox_Leave(object sender, EventArgs e)
        {
            validateMobileNumber(ContactNoTextBox.Text,ContactNoTextBox);

        }

        private void ContactablePersonTPNTextBox_Leave(object sender, EventArgs e)
        {
            validateMobileNumber(ContactablePersonTPNTextBox.Text, ContactablePersonTPNTextBox);
        }
    }
}
