﻿namespace SuperMarket
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Login_btn_reset = new System.Windows.Forms.Button();
            this.Login_btn_submit = new System.Windows.Forms.Button();
            this.Login_tb_userPwd = new System.Windows.Forms.TextBox();
            this.Login_tb_userId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Login_btn_reset);
            this.groupBox1.Controls.Add(this.Login_btn_submit);
            this.groupBox1.Controls.Add(this.Login_tb_userPwd);
            this.groupBox1.Controls.Add(this.Login_tb_userId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(99, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // Login_btn_reset
            // 
            this.Login_btn_reset.Location = new System.Drawing.Point(185, 113);
            this.Login_btn_reset.Name = "Login_btn_reset";
            this.Login_btn_reset.Size = new System.Drawing.Size(75, 23);
            this.Login_btn_reset.TabIndex = 5;
            this.Login_btn_reset.Text = "重置";
            this.Login_btn_reset.UseVisualStyleBackColor = true;
            this.Login_btn_reset.Click += new System.EventHandler(this.Login_btn_reset_Click);
            // 
            // Login_btn_submit
            // 
            this.Login_btn_submit.Location = new System.Drawing.Point(47, 114);
            this.Login_btn_submit.Name = "Login_btn_submit";
            this.Login_btn_submit.Size = new System.Drawing.Size(75, 23);
            this.Login_btn_submit.TabIndex = 4;
            this.Login_btn_submit.Text = "登录";
            this.Login_btn_submit.UseVisualStyleBackColor = true;
            this.Login_btn_submit.Click += new System.EventHandler(this.Login_btn_submit_Click);
            // 
            // Login_tb_userPwd
            // 
            this.Login_tb_userPwd.Location = new System.Drawing.Point(127, 69);
            this.Login_tb_userPwd.Name = "Login_tb_userPwd";
            this.Login_tb_userPwd.PasswordChar = '*';
            this.Login_tb_userPwd.Size = new System.Drawing.Size(175, 25);
            this.Login_tb_userPwd.TabIndex = 3;
            // 
            // Login_tb_userId
            // 
            this.Login_tb_userId.Location = new System.Drawing.Point(127, 33);
            this.Login_tb_userId.Name = "Login_tb_userId";
            this.Login_tb_userId.Size = new System.Drawing.Size(175, 25);
            this.Login_tb_userId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 41);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(354, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "超市人事管理系统";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "超市人事管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Login_btn_reset;
        private System.Windows.Forms.Button Login_btn_submit;
        private System.Windows.Forms.TextBox Login_tb_userPwd;
        private System.Windows.Forms.TextBox Login_tb_userId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}