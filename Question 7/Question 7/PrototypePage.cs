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

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            if (txtPost.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill out the title and description before making a post");
            }
            else
            {
                this.protype11.SetUsername(UserName);
                this.protype11.SetTitle(txtPost.Text);

                this.protype11.SetDescription(txtDescription.Text);
            }
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
