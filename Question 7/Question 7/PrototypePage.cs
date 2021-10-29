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
        List<Protype1> proList = new List<Protype1>();
        Protype1 pro = new Protype1();
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
            pro.SetTitle(title);
        }

        public void recieveDescription(string description)
        {
            pro.SetDescription(description);
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            pro = new Protype1();

            MakePost frm2 = new MakePost();
            frm2.SendMessage += recieveTitle;
            frm2.SendMessage2 += recieveDescription;
            frm2.ShowDialog();

            pro.SetUsername(UserName);

            proList.Add(pro);
            foreach(Protype1 x in proList)
                flowLayoutPanel1.Controls.Add(x);

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            //if (txtComment.Text == "")
            //{
            //    MessageBox.Show("Cannot make blank comments");
            //}
            //else
            //{
            //    pro.Comment(txtComment.Text, UserName);
            //}      
        }
    }
}
