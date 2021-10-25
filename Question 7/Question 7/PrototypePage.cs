using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Question_7
{
    public partial class PrototypePage : Form
    {
        public PrototypePage(string username)
        {
            InitializeComponent();
            UserName = username;

        }
        string UserName;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void recieveTitle(string title)
        {
            this.protype11.SetTitle(title);
        }

        public void recieveDescription(string description)
        {
            this.protype11.SetDescription(description);
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            MakePost frm2 = new MakePost();
            frm2.SendMessage += recieveTitle;
            frm2.SendMessage2 += recieveDescription;
            frm2.ShowDialog();

            this.protype11.SetUsername(UserName);

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment.Text == "")
            {
                MessageBox.Show("Cannot make blank comments");
            }
            else
            {
                this.protype11.Comment(txtComment.Text, UserName);
            }      
        }
    }
}
