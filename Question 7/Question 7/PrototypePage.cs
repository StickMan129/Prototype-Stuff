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
            this.protype11.SetUsername(UserName);
            this.protype11.SetTitle(txtPost.Text);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            this.protype11.Comment(txtComment.Text, UserName);
        }
    }
}
