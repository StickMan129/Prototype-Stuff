
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
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.protype11 = new Question_7.Protype1();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // protype11
            // 
            this.protype11.BackColor = System.Drawing.SystemColors.Control;
            this.protype11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.protype11.Location = new System.Drawing.Point(3, 3);
            this.protype11.Name = "protype11";
            this.protype11.Size = new System.Drawing.Size(486, 415);
            this.protype11.TabIndex = 1;
            // 
=======
>>>>>>> 5e801c735cef6ed129820a7e9cdcdce93996c995
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(12, 12);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(173, 57);
            this.btnCreatePost.TabIndex = 2;
            this.btnCreatePost.Text = "Create a Post";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(12, 134);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(174, 57);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Comment on Post";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 197);
            this.txtComment.MaxLength = 3000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(174, 62);
            this.txtComment.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.protype11);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(498, 427);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // protype11
            // 
            this.protype11.BackColor = System.Drawing.SystemColors.Control;
            this.protype11.Location = new System.Drawing.Point(3, 3);
            this.protype11.Name = "protype11";
            this.protype11.Size = new System.Drawing.Size(476, 410);
            this.protype11.TabIndex = 5;
            // 
            // PrototypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(718, 445);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnCreatePost);
            this.Name = "PrototypePage";
            this.Text = "PrototypePage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Protype1 protype11;
    }
}