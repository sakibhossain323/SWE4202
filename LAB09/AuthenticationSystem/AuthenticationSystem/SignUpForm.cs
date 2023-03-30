using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthenticationSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string uname = TextBoxUserName.Text;
            string pass = TextBoxPass.Text;
            string repass = TextBoxRePass.Text;

            try
            {
                AuthHandler.SignUp(name, uname, pass, repass);
                var loginPanel = new LoginForm();
                loginPanel.Show();
                this.Hide();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginPanel = new LoginForm();
            loginPanel.Show();
            this.Hide();
        }
    }
}
