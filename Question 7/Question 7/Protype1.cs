﻿using System;
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
            rdbtnUpVote.Checked = false;
            rdbtnDownVote.Checked = false;
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
            lstComment.Items.Add($"{name} {comment}");
        }

        DateTime time = DateTime.Now;

        private void rdbtnUpVote_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            lblUpVoteRating.Text = counter.ToString();
        }

        private void rdbtnDownVote_CheckedChanged(object sender, EventArgs e)
        {
            counter--;
            lblUpVoteRating.Text = counter.ToString();
        }
    }
}