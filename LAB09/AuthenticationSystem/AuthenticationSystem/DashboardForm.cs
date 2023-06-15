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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            string greeting = LabelGreetUser.Text;
            LabelGreetUser.Text = greeting.Replace("UserName", Authenticator.CurrentUser.UserName);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Authenticator.Logout();
            Hide();
            new LoginForm().Show();
            
        }
    }
}
