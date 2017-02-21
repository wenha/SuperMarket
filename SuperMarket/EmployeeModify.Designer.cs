namespace SuperMarket
{
    partial class EmployeeModify
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
            this.components = new System.ComponentModel.Container();
            this.employeeModify_cb_apart = new System.Windows.Forms.ComboBox();
            this.employeeModify_cb_title = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.employeeModify_btn_modify = new System.Windows.Forms.Button();
            this.employeeModify_tb_info = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeModify_tb_home = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeModify_tb_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeModify_dtp_inTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeModify_cb_age = new System.Windows.Forms.ComboBox();
            this.employeeModify_cb_sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeModify_tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeModify_tb_modifyID = new System.Windows.Forms.ComboBox();
            this.employeeIDDataSet = new SuperMarket.employeeIDDataSet();
            this.employeeIDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.z_EmployeeTableAdapter = new SuperMarket.employeeIDDataSetTableAdapters.Z_EmployeeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeModify_cb_apart
            // 
            this.employeeModify_cb_apart.FormattingEnabled = true;
            this.employeeModify_cb_apart.Location = new System.Drawing.Point(114, 147);
            this.employeeModify_cb_apart.Name = "employeeModify_cb_apart";
            this.employeeModify_cb_apart.Size = new System.Drawing.Size(126, 23);
            this.employeeModify_cb_apart.TabIndex = 42;
            // 
            // employeeModify_cb_title
            // 
            this.employeeModify_cb_title.FormattingEnabled = true;
            this.employeeModify_cb_title.Items.AddRange(new object[] {
            "部门经理",
            "主管",
            "员工"});
            this.employeeModify_cb_title.Location = new System.Drawing.Point(376, 147);
            this.employeeModify_cb_title.Name = "employeeModify_cb_title";
            this.employeeModify_cb_title.Size = new System.Drawing.Size(121, 23);
            this.employeeModify_cb_title.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "职称：";
            // 
            // employeeModify_btn_modify
            // 
            this.employeeModify_btn_modify.Location = new System.Drawing.Point(254, 408);
            this.employeeModify_btn_modify.Name = "employeeModify_btn_modify";
            this.employeeModify_btn_modify.Size = new System.Drawing.Size(75, 23);
            this.employeeModify_btn_modify.TabIndex = 39;
            this.employeeModify_btn_modify.Text = "修改";
            this.employeeModify_btn_modify.UseVisualStyleBackColor = true;
            this.employeeModify_btn_modify.Click += new System.EventHandler(this.employeeModify_btn_modify_Click);
            // 
            // employeeModify_tb_info
            // 
            this.employeeModify_tb_info.Location = new System.Drawing.Point(112, 257);
            this.employeeModify_tb_info.Multiline = true;
            this.employeeModify_tb_info.Name = "employeeModify_tb_info";
            this.employeeModify_tb_info.Size = new System.Drawing.Size(365, 115);
            this.employeeModify_tb_info.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "备注：";
            // 
            // employeeModify_tb_home
            // 
            this.employeeModify_tb_home.Location = new System.Drawing.Point(376, 194);
            this.employeeModify_tb_home.Name = "employeeModify_tb_home";
            this.employeeModify_tb_home.Size = new System.Drawing.Size(200, 25);
            this.employeeModify_tb_home.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "家庭住址：";
            // 
            // employeeModify_tb_tel
            // 
            this.employeeModify_tb_tel.Location = new System.Drawing.Point(112, 195);
            this.employeeModify_tb_tel.Name = "employeeModify_tb_tel";
            this.employeeModify_tb_tel.Size = new System.Drawing.Size(128, 25);
            this.employeeModify_tb_tel.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "部门：";
            // 
            // employeeModify_dtp_inTime
            // 
            this.employeeModify_dtp_inTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.employeeModify_dtp_inTime.Location = new System.Drawing.Point(376, 87);
            this.employeeModify_dtp_inTime.Name = "employeeModify_dtp_inTime";
            this.employeeModify_dtp_inTime.Size = new System.Drawing.Size(121, 25);
            this.employeeModify_dtp_inTime.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "入职时间：";
            // 
            // employeeModify_cb_age
            // 
            this.employeeModify_cb_age.FormattingEnabled = true;
            this.employeeModify_cb_age.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.employeeModify_cb_age.Location = new System.Drawing.Point(114, 85);
            this.employeeModify_cb_age.Name = "employeeModify_cb_age";
            this.employeeModify_cb_age.Size = new System.Drawing.Size(126, 23);
            this.employeeModify_cb_age.TabIndex = 29;
            // 
            // employeeModify_cb_sex
            // 
            this.employeeModify_cb_sex.FormattingEnabled = true;
            this.employeeModify_cb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.employeeModify_cb_sex.Location = new System.Drawing.Point(376, 32);
            this.employeeModify_cb_sex.Name = "employeeModify_cb_sex";
            this.employeeModify_cb_sex.Size = new System.Drawing.Size(121, 23);
            this.employeeModify_cb_sex.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "性别：";
            // 
            // employeeModify_tb_name
            // 
            this.employeeModify_tb_name.Location = new System.Drawing.Point(114, 32);
            this.employeeModify_tb_name.Name = "employeeModify_tb_name";
            this.employeeModify_tb_name.Size = new System.Drawing.Size(126, 25);
            this.employeeModify_tb_name.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "修改员工信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "要修改的员工编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeeModify_tb_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.employeeModify_cb_apart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.employeeModify_cb_title);
            this.groupBox1.Controls.Add(this.employeeModify_cb_sex);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.employeeModify_cb_age);
            this.groupBox1.Controls.Add(this.employeeModify_btn_modify);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.employeeModify_tb_info);
            this.groupBox1.Controls.Add(this.employeeModify_dtp_inTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.employeeModify_tb_home);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.employeeModify_tb_tel);
            this.groupBox1.Location = new System.Drawing.Point(41, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 452);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // employeeModify_tb_modifyID
            // 
            this.employeeModify_tb_modifyID.DataSource = this.zEmployeeBindingSource;
            this.employeeModify_tb_modifyID.DisplayMember = "employee_id";
            this.employeeModify_tb_modifyID.FormattingEnabled = true;
            this.employeeModify_tb_modifyID.Location = new System.Drawing.Point(186, 58);
            this.employeeModify_tb_modifyID.Name = "employeeModify_tb_modifyID";
            this.employeeModify_tb_modifyID.Size = new System.Drawing.Size(121, 23);
            this.employeeModify_tb_modifyID.TabIndex = 46;
            this.employeeModify_tb_modifyID.ValueMember = "employee_id";
            this.employeeModify_tb_modifyID.SelectedIndexChanged += new System.EventHandler(this.employeeModify_tb_modifyID_SelectedIndexChanged);
            // 
            // employeeIDDataSet
            // 
            this.employeeIDDataSet.DataSetName = "employeeIDDataSet";
            this.employeeIDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeIDDataSetBindingSource
            // 
            this.employeeIDDataSetBindingSource.DataSource = this.employeeIDDataSet;
            this.employeeIDDataSetBindingSource.Position = 0;
            // 
            // zEmployeeBindingSource
            // 
            this.zEmployeeBindingSource.DataMember = "Z_Employee";
            this.zEmployeeBindingSource.DataSource = this.employeeIDDataSet;
            // 
            // z_EmployeeTableAdapter
            // 
            this.z_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 569);
            this.Controls.Add(this.employeeModify_tb_modifyID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeModify";
            this.Text = "修改员工信息";
            this.Load += new System.EventHandler(this.EmployeeModify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeModify_cb_apart;
        private System.Windows.Forms.ComboBox employeeModify_cb_title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button employeeModify_btn_modify;
        private System.Windows.Forms.TextBox employeeModify_tb_info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employeeModify_tb_home;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeModify_tb_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker employeeModify_dtp_inTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox employeeModify_cb_age;
        private System.Windows.Forms.ComboBox employeeModify_cb_sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeModify_tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox employeeModify_tb_modifyID;
        private employeeIDDataSet employeeIDDataSet;
        private System.Windows.Forms.BindingSource employeeIDDataSetBindingSource;
        private System.Windows.Forms.BindingSource zEmployeeBindingSource;
        private employeeIDDataSetTableAdapters.Z_EmployeeTableAdapter z_EmployeeTableAdapter;
    }
}