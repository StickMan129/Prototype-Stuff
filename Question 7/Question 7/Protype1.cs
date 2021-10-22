using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Question_7
{
    public partial class Protype1 : UserControl
    {
        public Protype1()
        {
            InitializeComponent();
        }

        int counter = 0;

        public void SetUsername(string username)
        {
            lblPostedBy.Text = "Posted by " + username + " at " + time;
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
    }
}
