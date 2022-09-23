using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RangaHardwareStock
{

    public partial class LoginForm : Form

    {
        //private string username = "admin";
        //private string password = "admin";
        

        
        
        public LoginForm()
        {
            InitializeComponent();
        }


        //start-handle username text visibility changers
        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "Username";
                UsernameTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
            
        }
        //end-handle username text visibility changers

        //show index page when this closed
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IndexForm.showForm();
        }
        //end show
        
        //start-handle password labele visibility changers
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.DarkGray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.ForeColor = Color.Black;
            }
        }
        //end-handle password labele visibility changers

        //make active control to password
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = loginButton;
        }
        //end set active control

        private void loginButton_Click(object sender, EventArgs e)
        {
            //validate username & Password then derect to home page

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\3rd Year Project\DEVELOPMENT PROJECT  - software\RangaHardwareStock\Ranga hardware.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM[Login] WHERE Username = '"+UsernameTextBox.Text+"' AND Password = '"+passwordTextBox.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {   
                if((dt.Rows[0].Field<string>("Username")==this.UsernameTextBox.Text) && (dt.Rows[0].Field<string>("Password") == this.passwordTextBox.Text))
                {
                    Globles.loginIndex = true;
                    this.Hide();
                    HomeForm home = new HomeForm();

                    home.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Check Spellings !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }


            }
            else
            {
                MessageBox.Show("Username & Password does not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {


            //derect to reset password page
            this.Hide();
            ResetPasswordForm resetPassword = new ResetPasswordForm();
            resetPassword.Show();
        }
    }
}
