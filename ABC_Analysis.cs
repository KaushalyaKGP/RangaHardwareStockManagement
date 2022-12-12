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
    public partial class ABC_Analysis : Form
    {
        public ABC_Analysis()
        {
            InitializeComponent();
        }

        private static ABC_Analysis aBC_Analysis = new ABC_Analysis();

        public static void showForm()
        {
            if (aBC_Analysis.IsDisposed)
            {
                aBC_Analysis = new ABC_Analysis();
            }
            aBC_Analysis.Show();
        }

        public static void HideForm()
        { aBC_Analysis.Hide(); }

        private void ABC_Analysis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.ABC_Class' table. You can move, or remove it, as needed.
            this.aBC_ClassTableAdapter.Fill(this.ranga_hardwareDataSet.ABC_Class);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.ABC_Analysis' table. You can move, or remove it, as needed.
            FromDateLabel.Text = DateTime.Today.ToShortDateString();
            ToDateLabel.Text = DateTime.Today.AddYears(-1).ToShortDateString();

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
            SqlDataAdapter sda1 = new SqlDataAdapter(@"SELECT  Item_ID,Item_Name,ROUND(Sales,2) as [Sales (Rs.)],
ROUND(SUM(Sales) OVER (),2)AS [Total Sales of Class (Rs.)]
FROM ABC_Analysis 
WHERE Class = 'A'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            ClassADataGridView.DataSource = dt1;

            SqlDataAdapter sda2 = new SqlDataAdapter(@"SELECT  Item_ID,Item_Name,ROUND(Sales,2) as [Sales (Rs.)],
ROUND(SUM(Sales) OVER (),2)AS [Total Sales of Class (Rs.)]
FROM ABC_Analysis 
WHERE Class = 'B'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            ClassBDataGridView.DataSource = dt2;

            SqlDataAdapter sda3 = new SqlDataAdapter(@"SELECT  Item_ID,Item_Name,ROUND(Sales,2) as [Sales (Rs.)],
ROUND(SUM(Sales) OVER (),2)AS [Total Sales of Class (Rs.)]
FROM ABC_Analysis 
WHERE Class = 'C'", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            ClassCDataGridView.DataSource = dt3;

        }

        private void ABC_Analysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.showForm();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm.showForm();
        }
    }
}
