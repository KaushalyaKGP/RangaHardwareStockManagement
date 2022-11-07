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
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void validateMobileNumber(string m)
        {
            string mobile = m;
            string mobileRegex = @"(^[0][]0-9]{9}$";
            Regex Regex = new Regex(mobileRegex);
        }


     
    }
}
