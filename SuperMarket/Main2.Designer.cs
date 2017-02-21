namespace SuperMarket
{
    partial class Main2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main2_search_gridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.main2_modify_btn_modify = new System.Windows.Forms.Button();
            this.main2_modify_RePwd = new System.Windows.Forms.TextBox();
            this.main2_modify_newPwd = new System.Windows.Forms.TextBox();
            this.main2_modify_oldpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main2_search_gridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询个人工资";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.main2_search_gridView);
            this.panel1.Location = new System.Drawing.Point(4, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 152);
            this.panel1.TabIndex = 0;
            // 
            // main2_search_gridView
            // 
            this.main2_search_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.main2_search_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main2_search_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main2_search_gridView.Location = new System.Drawing.Point(0, 0);
            this.main2_search_gridView.Name = "main2_search_gridView";
            this.main2_search_gridView.RowTemplate.Height = 27;
            this.main2_search_gridView.Size = new System.Drawing.Size(682, 152);
            this.main2_search_gridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.main2_modify_btn_modify);
            this.tabPage2.Controls.Add(this.main2_modify_RePwd);
            this.tabPage2.Controls.Add(this.main2_modify_newPwd);
            this.tabPage2.Controls.Add(this.main2_modify_oldpwd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改个人密码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // main2_modify_btn_modify
            // 
            this.main2_modify_btn_modify.Location = new System.Drawing.Point(465, 77);
            this.main2_modify_btn_modify.Name = "main2_modify_btn_modify";
            this.main2_modify_btn_modify.Size = new System.Drawing.Size(93, 33);
            this.main2_modify_btn_modify.TabIndex = 6;
            this.main2_modify_btn_modify.Text = "确认修改";
            this.main2_modify_btn_modify.UseVisualStyleBackColor = true;
            this.main2_modify_btn_modify.Click += new System.EventHandler(this.main2_modify_btn_modify_Click);
            // 
            // main2_modify_RePwd
            // 
            this.main2_modify_RePwd.Location = new System.Drawing.Point(130, 156);
            this.main2_modify_RePwd.Name = "main2_modify_RePwd";
            this.main2_modify_RePwd.Size = new System.Drawing.Size(192, 25);
            this.main2_modify_RePwd.TabIndex = 5;
            // 
            // main2_modify_newPwd
            // 
            this.main2_modify_newPwd.Location = new System.Drawing.Point(130, 92);
            this.main2_modify_newPwd.Name = "main2_modify_newPwd";
            this.main2_modify_newPwd.Size = new System.Drawing.Size(192, 25);
            this.main2_modify_newPwd.TabIndex = 4;
            // 
            // main2_modify_oldpwd
            // 
            this.main2_modify_oldpwd.Location = new System.Drawing.Point(130, 28);
            this.main2_modify_oldpwd.Name = "main2_modify_oldpwd";
            this.main2_modify_oldpwd.Size = new System.Drawing.Size(192, 25);
            this.main2_modify_oldpwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码：";
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(701, 246);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main2";
            this.Text = "超市管理系统--欢迎使用！";
            this.Load += new System.EventHandler(this.Main2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main2_search_gridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView main2_search_gridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button main2_modify_btn_modify;
        private System.Windows.Forms.TextBox main2_modify_RePwd;
        private System.Windows.Forms.TextBox main2_modify_newPwd;
        private System.Windows.Forms.TextBox main2_modify_oldpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}