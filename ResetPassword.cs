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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }


        //direct to index form when this closed
        private void ResetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IndexForm.showForm();
        }

        //Handle text box watermark visibility
        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "Username";
                UsernameTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void currentPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text == "Current Password")
            {
                currentPasswordTextBox.Text = "";
                currentPasswordTextBox.ForeColor = Color.Black;
                currentPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void currentPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text == "")
            {
                currentPasswordTextBox.Text = "Current Password";
                currentPasswordTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void newPasswordTextBox1_Enter(object sender, EventArgs e)
        {
            if (newPasswordTextBox1.Text == "New Password")
            {
                newPasswordTextBox1.Text = "";
                newPasswordTextBox1.ForeColor = Color.Black;
                newPasswordTextBox1.UseSystemPasswordChar = true;
            }
        }

        private void newPasswordTextBox1_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox1.Text == "")
            {
                newPasswordTextBox1.Text = "New Password";
                newPasswordTextBox1.ForeColor = Color.DarkGray;
            }
        }

        private void newPasswordTextBox2_Enter(object sender, EventArgs e)
        {
            if (newPasswordTextBox2.Text == "Re Enter New Password")
            {
                newPasswordTextBox2.Text = "";
                newPasswordTextBox2.ForeColor = Color.Black;
                newPasswordTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void newPasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox2.Text == "")
            {
                newPasswordTextBox2.Text = "Re Enter New Password";
                newPasswordTextBox2.ForeColor = Color.DarkGray;
            }
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = resetPasswordButton;
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            //validate username & password
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[Login] WHERE Username = '" + UsernameTextBox.Text + "' AND Password = '" + currentPasswordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if(newPasswordTextBox1.Text==newPasswordTextBox2.Text)
                {   
                    //Update New Password
                    con.Open();
                    SqlCommand com = new SqlCommand(@"UPDATE Login SET Password = '"+newPasswordTextBox1.Text+"' WHERE Username = '"+UsernameTextBox.Text+"'", con);
                    //sda2.Update(con)
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Updated", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Re-Entered Password does not same !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Username & Password does not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
