using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username;

            Username = txtUsername.Text;
            if (txtUsername.Text != "")
            {
                if(txtPassword.Text != "")
                {
                    PrototypePage page = new PrototypePage(Username);
                    page.Show();
                }
            }else
                MessageBox.Show("Please fill out the Username/Password text before attempting to log-in");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPage page = new RegisterPage();
            page.Show();
        }
    }
}
