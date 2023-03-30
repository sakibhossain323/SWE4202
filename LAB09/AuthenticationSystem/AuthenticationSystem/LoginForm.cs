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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = TextBoxUserName.Text, pass = TextBoxPass.Text;
                User u = AuthHandler.Login(uname, pass);
                var dashboard = new DashboardForm(u);
                dashboard.Show();
                this.Hide();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUpPanel = new SignUpForm();
            signUpPanel.Show();
            this.Hide();
        }
    }
}
