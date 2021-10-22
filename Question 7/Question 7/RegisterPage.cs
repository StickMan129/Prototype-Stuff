using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Question_7
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string RegisteredUsername;

            RegisteredUsername = txtUserName.Text;

            PrototypePage page = new PrototypePage(RegisteredUsername);
            page.Show();
        }
    }
}
