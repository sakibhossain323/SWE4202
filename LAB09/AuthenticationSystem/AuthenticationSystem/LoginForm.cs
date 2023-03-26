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

            foreach (var user in AuthHandler.Users) Console.WriteLine($"{user.UserName} {user.Password} {user.Name}");
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
    }
}
