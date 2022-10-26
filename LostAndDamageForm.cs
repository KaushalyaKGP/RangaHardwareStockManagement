using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangaHardwareStock
{
    public partial class LostAndDamageForm : Form
    {
        private static LostAndDamageForm _lostAndDamageForm = new LostAndDamageForm();

        public static void ShowForm()
        {

            if (_lostAndDamageForm.IsDisposed)
            {
                _lostAndDamageForm = new LostAndDamageForm();
            }
            _lostAndDamageForm.Show();
            //_stockOutManagementForm.SetInitioalStage();

        }

        public static void HideForm()
        {
            _lostAndDamageForm.Hide();
        }
        public LostAndDamageForm()
        {
            InitializeComponent();
        }
    }
}
