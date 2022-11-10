using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RangaHardwareStock
{
    public static class Globles
    {
        public static Boolean loginIndex = false;

        //Email Validation
        public static void validateEmail(string email, TextBox t)
        {
            if (t.Text != "")
            {
                bool valid = false;
                try
                {
                    MailAddress m = new MailAddress(email);
                    valid = true;
                }
                catch (FormatException)
                {
                    valid = false;
                }
                if (valid != true)
                {
                    MessageBox.Show("Invalid Email !");
                    t.Text = "";
                }
            }

        }

        //Mobile Validation
        public static void validateMobileNumber(string m, TextBox textbox)
        {
            if (textbox.Text != "")
            {
                string mobile = m;
                mobile = mobile.Replace(" ", string.Empty);
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

        }

    }
}
