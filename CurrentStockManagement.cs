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

    public partial class CurrentStockManagementForm : Form
    {
        

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
        DataTable dt = new DataTable();

        public CurrentStockManagementForm()
        {
            InitializeComponent();
        }


        private void CurrentStockManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Globles.loginIndex == false)
            {
                IndexForm.showForm();
            }
            else
            {
                HomeForm.showForm();
            }
        }

        
        private void SetInitioalStage()
        {
            this.item_NameComboBox.Text = "All";
            this.supplier_NameComboBox.Text = "All";
            this.StockLevelComboBox.Text = "All";

            
            CurrentStockDataGridView.DataSource = dt;
        }

        private void CurrentStockManagementForm_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sdaitem = new SqlDataAdapter(@"SELECT Item_ID,Item_Name
FROM Item", con);
            DataTable dtitem = new DataTable();



            this.item_NameComboBox.DataSource = null;
            item_NameComboBox.Items.Clear();
            try
            {
                sdaitem.Fill(dtitem);
                this.item_NameComboBox.DataSource = dtitem;
                this.item_NameComboBox.DisplayMember = dtitem.Columns["Item_Name"].ColumnName;
                this.item_NameComboBox.ValueMember = dtitem.Columns["Item_ID"].ColumnName;
            }
            catch
            {
            }


            SqlDataAdapter sdaSupplier = new SqlDataAdapter(@"SELECT Name,Supplier_ID
FROM Supplier", con);
            DataTable dtSupplier = new DataTable();



            this.supplier_NameComboBox.DataSource = null;
            supplier_NameComboBox.Items.Clear();
            try
            {
                sdaSupplier.Fill(dtSupplier);
                this.supplier_NameComboBox.DataSource = dtSupplier;
                this.supplier_NameComboBox.DisplayMember = dtSupplier.Columns["Name"].ColumnName;
                this.supplier_NameComboBox.ValueMember = dtSupplier.Columns["Supplier_ID"].ColumnName;
            }
            catch
            {
            }

            //fill data view
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l
WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode
ORDER BY i.Item_Name", con);
            sda.Fill(dt);
            
            SetInitioalStage();
            CurrentStockDataGridView.Columns[5].DefaultCellStyle.Format = "0.00##";


        }

        

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetInitioalStage();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //check if initial stage changed
            if(!(this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All"))
            { 
                // give data matched to search
                DataTable dtSearch = new DataTable();
                

                
                if (this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID, i.Item_Name, l.Value AS Stock_Status, i.Current_Stock,i.Customer_Return_Stock, i.Mesuring_Unit,i.Unit_Price, s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_Name = '" + item_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode  AND s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                else if (this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode  AND i.Item_Name = '" + item_NameComboBox.Text + "'   ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode  AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                
                else if (this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Customer_Return_Stock,i.Mesuring_Unit,i.Unit_Price,s.Name AS Supplier_Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND s.Name = '" + supplier_NameComboBox.Text + "'   ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                
               
               

                
                CurrentStockDataGridView.DataSource = dtSearch;
                CurrentStockDataGridView.Columns[6].DefaultCellStyle.Format = "0.00##";
                //-------------------------------------------------------------------------------------
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CurrentStockManagementForm.ActiveForm.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you realy want to Exit? \nChangers may not be saved!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
