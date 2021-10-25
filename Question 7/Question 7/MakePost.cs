using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Question_7
{
    public partial class MakePost : Form
    {
        public delegate void SendTitle(string title2);
        public SendTitle SendMessage;

        public delegate void SendDescription(string description2);
        public SendDescription SendMessage2;
        public MakePost()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please add a title and description before posting");
            }
            else
            {
                string title = txtTitle.Text;
                SendMessage(title);

                string description = txtDescription.Text;
                SendMessage2(description);

                this.Close();
            }
        }
    }
}
