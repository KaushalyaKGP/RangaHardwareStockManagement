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
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");

        public InboundOrderIn()
        {
            InitializeComponent();
        }

        private void InboundOrderIn_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);

            //Auto generate ID
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(cast (Stock_In_ID as int)),0)+1 FROM StockInTable",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.BatchIDTextBox.Text = dt.Rows[0][0].ToString();
            //--------------------

        }
    }
}
