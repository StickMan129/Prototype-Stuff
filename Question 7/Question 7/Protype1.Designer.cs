
namespace Question_7
{
    partial class Protype1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUpVoteRating = new System.Windows.Forms.Label();
            this.rdbtnUpVote = new System.Windows.Forms.RadioButton();
            this.rdbtnDownVote = new System.Windows.Forms.RadioButton();
            this.lblPostedBy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstComment = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpVoteRating
            // 
            this.lblUpVoteRating.AutoSize = true;
            this.lblUpVoteRating.Location = new System.Drawing.Point(32, 39);
            this.lblUpVoteRating.Name = "lblUpVoteRating";
            this.lblUpVoteRating.Size = new System.Drawing.Size(13, 15);
            this.lblUpVoteRating.TabIndex = 0;
            this.lblUpVoteRating.Text = "0";
            // 
            // rdbtnUpVote
            // 
            this.rdbtnUpVote.AutoSize = true;
            this.rdbtnUpVote.Location = new System.Drawing.Point(32, 23);
            this.rdbtnUpVote.Name = "rdbtnUpVote";
            this.rdbtnUpVote.Size = new System.Drawing.Size(14, 13);
            this.rdbtnUpVote.TabIndex = 1;
            this.rdbtnUpVote.TabStop = true;
            this.rdbtnUpVote.UseVisualStyleBackColor = true;
            this.rdbtnUpVote.CheckedChanged += new System.EventHandler(this.rdbtnUpVote_CheckedChanged);
            // 
            // rdbtnDownVote
            // 
            this.rdbtnDownVote.AutoSize = true;
            this.rdbtnDownVote.Location = new System.Drawing.Point(32, 57);
            this.rdbtnDownVote.Name = "rdbtnDownVote";
            this.rdbtnDownVote.Size = new System.Drawing.Size(14, 13);
            this.rdbtnDownVote.TabIndex = 1;
            this.rdbtnDownVote.TabStop = true;
            this.rdbtnDownVote.UseVisualStyleBackColor = true;
            this.rdbtnDownVote.CheckedChanged += new System.EventHandler(this.rdbtnDownVote_CheckedChanged);
            // 
            // lblPostedBy
            // 
            this.lblPostedBy.AutoSize = true;
            this.lblPostedBy.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostedBy.Location = new System.Drawing.Point(227, 0);
            this.lblPostedBy.Name = "lblPostedBy";
            this.lblPostedBy.Size = new System.Drawing.Size(59, 14);
            this.lblPostedBy.TabIndex = 2;
            this.lblPostedBy.Text = "Posted By";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(204, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstComment
            // 
            this.lstComment.FormattingEnabled = true;
            this.lstComment.ItemHeight = 15;
            this.lstComment.Location = new System.Drawing.Point(11, 375);
            this.lstComment.Name = "lstComment";
            this.lstComment.Size = new System.Drawing.Size(462, 154);
            this.lstComment.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnUpVote);
            this.groupBox2.Controls.Add(this.lblUpVoteRating);
            this.groupBox2.Controls.Add(this.rdbtnDownVote);
            this.groupBox2.Location = new System.Drawing.Point(11, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(73, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Protype1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstComment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPostedBy);
            this.Name = "Protype1";
            this.Size = new System.Drawing.Size(476, 538);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpVoteRating;
        private System.Windows.Forms.RadioButton rdbtnUpVote;
        private System.Windows.Forms.RadioButton rdbtnDownVote;
        private System.Windows.Forms.Label lblPostedBy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstComment;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
