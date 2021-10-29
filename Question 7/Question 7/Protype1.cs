using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Question_7
{
    public partial class Protype1 : UserControl
    {
        public Protype1()
        {
            InitializeComponent();
        }

        int counter = 0;
        string username1;

        public string SetUsername(string username)
        {
            string post = "Posted by " + username + " at " + time;
            lblPostedBy.Text = post;
            username1 = username;
            return username1;
        }
        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }
        public void Comment(string comment, string name)
        {
            txtComment.Text += $"{name}: {comment}" + Environment.NewLine;
        }

        public void SetDescription(string description)
        {
            txtDescription.Text = description;
        }

        DateTime time = DateTime.Now;

        private void rdbtnUpVote_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            lblUpVoteRating.Text = counter.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void rdbtnDownVote_CheckedChanged(object sender, EventArgs e)
        {
            counter--;
            lblUpVoteRating.Text = counter.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment2.Text == "")
            {
                MessageBox.Show("Cannot make blank comments");
            }
            else
            {
                
                txtComment.Text += username1 + ": " + txtComment2.Text + Environment.NewLine;
            }
        }
    }
}
