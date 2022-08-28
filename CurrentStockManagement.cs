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
            HomeForm.showForm();
        }

        
        private void SetInitioalStage()
        {
            this.item_NameComboBox.Text = "All";
            this.item_IDComboBox.Text = "All";
            this.supplier_NameComboBox.Text = "All";
            this.StockLevelComboBox.Text = "All";

            
            CurrentStockDataGridView.DataSource = dt;
        }

        private void CurrentStockManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.StockLevel' table. You can move, or remove it, as needed.
            this.stockLevelTableAdapter.Fill(this.ranga_hardwareDataSet.StockLevel);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.ranga_hardwareDataSet.Supplier);
            // TODO: This line of code loads data into the 'ranga_hardwareDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.ranga_hardwareDataSet.Item);

            //fill data view
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name 
FROM Item i , Supplier s , StockLevel l
WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode
ORDER BY i.Item_Name", con);
            sda.Fill(dt);
            SetInitioalStage();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CurrentStockManagementForm.ActiveForm.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetInitioalStage();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //check if initial stage changed
            if(!(this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All"))
            { 
                // give data matched to search
                DataTable dtSearch = new DataTable();

                if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID, i.Item_Name, l.Value AS Stock_Status, i.Current_Stock, i.Mesuring_Unit, s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' AND i.Item_Name = '" + item_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' AND i.Item_Name = '" + item_NameComboBox.Text + "'   ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "'  AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND  s.Name = '" + supplier_NameComboBox.Text + "' AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_Name = '" + item_NameComboBox.Text + "'  AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode  AND i.Item_Name = '" + item_NameComboBox.Text + "' AND s.Name = '" + supplier_NameComboBox.Text + "'   ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "'  AND s.Name = '" + supplier_NameComboBox.Text + "'   ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                else if (this.item_IDComboBox.Text != "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND i.Item_ID = '" + item_IDComboBox.Text + "' ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text != "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode  AND i.Item_Name = '" + item_NameComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text != "All" && this.StockLevelComboBox.Text == "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND s.Name = '" + supplier_NameComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }
                else if (this.item_IDComboBox.Text == "All" && this.item_NameComboBox.Text == "All" && this.supplier_NameComboBox.Text == "All" && this.StockLevelComboBox.Text != "All")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"SELECT i.Item_ID,i.Item_Name,l.Value AS Stock_Status,i.Current_Stock,i.Mesuring_Unit,s.Name FROM Item i , Supplier s , StockLevel l WHERE i.Supplier_ID = s.Supplier_ID AND i.Stock_Status = l.LevelCode AND l.Value = '" + StockLevelComboBox.Text + "'  ORDER BY i.Item_Name", con);
                    sda.Fill(dtSearch);
                }

                CurrentStockDataGridView.DataSource = dtSearch;
                //-------------------------------------------------------------------------------------
            }
        }

        }
}
