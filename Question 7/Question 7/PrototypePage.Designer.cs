﻿
namespace Question_7
{
    partial class PrototypePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.protype11 = new Question_7.Protype1();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // protype11
            // 
            this.protype11.Location = new System.Drawing.Point(379, 12);
            this.protype11.Name = "protype11";
            this.protype11.Size = new System.Drawing.Size(768, 652);
            this.protype11.TabIndex = 1;
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(21, 12);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(132, 57);
            this.btnCreatePost.TabIndex = 2;
            this.btnCreatePost.Text = "Create a Post";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(194, 12);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(132, 57);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Comment on Post";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(21, 75);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(132, 23);
            this.txtPost.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(194, 75);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(132, 127);
            this.txtComment.TabIndex = 3;
            // 
            // PrototypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 667);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.protype11);
            this.Name = "PrototypePage";
            this.Text = "PrototypePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Protype1 protype11;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtComment;
    }
}