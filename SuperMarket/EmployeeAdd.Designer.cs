namespace SuperMarket
{
    partial class EmployeeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeAdd_tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeAdd_cb_sex = new System.Windows.Forms.ComboBox();
            this.employeeAdd_cb_age = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeAdd_dtp_inTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeAdd_tb_tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeAdd_tb_home = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeAdd_tb_info = new System.Windows.Forms.TextBox();
            this.employeeAdd_btn_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.employeeAdd_cb_title = new System.Windows.Forms.ComboBox();
            this.zApartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet1 = new SuperMarket.SuperMarketDataSet1();
            this.employeeAdd_cb_apartment = new System.Windows.Forms.ComboBox();
            this.zApartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.SuperMarketDataSet();
            this.z_ApartmentTableAdapter = new SuperMarket.SuperMarketDataSetTableAdapters.Z_ApartmentTableAdapter();
            this.z_ApartmentTableAdapter1 = new SuperMarket.SuperMarketDataSet1TableAdapters.Z_ApartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zApartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zApartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加员工信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // employeeAdd_tb_name
            // 
            this.employeeAdd_tb_name.Location = new System.Drawing.Point(116, 72);
            this.employeeAdd_tb_name.Name = "employeeAdd_tb_name";
            this.employeeAdd_tb_name.Size = new System.Drawing.Size(126, 25);
            this.employeeAdd_tb_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "年龄：";
            // 
            // employeeAdd_cb_sex
            // 
            this.employeeAdd_cb_sex.FormattingEnabled = true;
            this.employeeAdd_cb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.employeeAdd_cb_sex.Location = new System.Drawing.Point(378, 72);
            this.employeeAdd_cb_sex.Name = "employeeAdd_cb_sex";
            this.employeeAdd_cb_sex.Size = new System.Drawing.Size(121, 23);
            this.employeeAdd_cb_sex.TabIndex = 7;
            // 
            // employeeAdd_cb_age
            // 
            this.employeeAdd_cb_age.FormattingEnabled = true;
            this.employeeAdd_cb_age.Items.AddRange(new object[] {
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
            this.employeeAdd_cb_age.Location = new System.Drawing.Point(116, 125);
            this.employeeAdd_cb_age.Name = "employeeAdd_cb_age";
            this.employeeAdd_cb_age.Size = new System.Drawing.Size(126, 23);
            this.employeeAdd_cb_age.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "入职时间：";
            // 
            // employeeAdd_dtp_inTime
            // 
            this.employeeAdd_dtp_inTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.employeeAdd_dtp_inTime.Location = new System.Drawing.Point(378, 127);
            this.employeeAdd_dtp_inTime.Name = "employeeAdd_dtp_inTime";
            this.employeeAdd_dtp_inTime.Size = new System.Drawing.Size(121, 25);
            this.employeeAdd_dtp_inTime.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "部门：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "电话：";
            // 
            // employeeAdd_tb_tel
            // 
            this.employeeAdd_tb_tel.Location = new System.Drawing.Point(114, 235);
            this.employeeAdd_tb_tel.Name = "employeeAdd_tb_tel";
            this.employeeAdd_tb_tel.Size = new System.Drawing.Size(128, 25);
            this.employeeAdd_tb_tel.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "家庭住址：";
            // 
            // employeeAdd_tb_home
            // 
            this.employeeAdd_tb_home.Location = new System.Drawing.Point(378, 234);
            this.employeeAdd_tb_home.Name = "employeeAdd_tb_home";
            this.employeeAdd_tb_home.Size = new System.Drawing.Size(200, 25);
            this.employeeAdd_tb_home.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "备注：";
            // 
            // employeeAdd_tb_info
            // 
            this.employeeAdd_tb_info.Location = new System.Drawing.Point(114, 297);
            this.employeeAdd_tb_info.Multiline = true;
            this.employeeAdd_tb_info.Name = "employeeAdd_tb_info";
            this.employeeAdd_tb_info.Size = new System.Drawing.Size(365, 115);
            this.employeeAdd_tb_info.TabIndex = 18;
            // 
            // employeeAdd_btn_add
            // 
            this.employeeAdd_btn_add.Location = new System.Drawing.Point(256, 448);
            this.employeeAdd_btn_add.Name = "employeeAdd_btn_add";
            this.employeeAdd_btn_add.Size = new System.Drawing.Size(75, 23);
            this.employeeAdd_btn_add.TabIndex = 19;
            this.employeeAdd_btn_add.Text = "添加";
            this.employeeAdd_btn_add.UseVisualStyleBackColor = true;
            this.employeeAdd_btn_add.Click += new System.EventHandler(this.employeeAdd_btn_add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "职称：";
            // 
            // employeeAdd_cb_title
            // 
            this.employeeAdd_cb_title.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zApartmentBindingSource1, "apartment_title", true));
            this.employeeAdd_cb_title.DataSource = this.zApartmentBindingSource1;
            this.employeeAdd_cb_title.DisplayMember = "apartment_title";
            this.employeeAdd_cb_title.FormattingEnabled = true;
            this.employeeAdd_cb_title.Location = new System.Drawing.Point(378, 187);
            this.employeeAdd_cb_title.Name = "employeeAdd_cb_title";
            this.employeeAdd_cb_title.Size = new System.Drawing.Size(121, 23);
            this.employeeAdd_cb_title.TabIndex = 21;
            this.employeeAdd_cb_title.ValueMember = "apartment_title";
            // 
            // zApartmentBindingSource1
            // 
            this.zApartmentBindingSource1.DataMember = "Z_Apartment";
            this.zApartmentBindingSource1.DataSource = this.superMarketDataSet1;
            // 
            // superMarketDataSet1
            // 
            this.superMarketDataSet1.DataSetName = "SuperMarketDataSet1";
            this.superMarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeAdd_cb_apartment
            // 
            this.employeeAdd_cb_apartment.DataSource = this.zApartmentBindingSource;
            this.employeeAdd_cb_apartment.DisplayMember = "apartment_name";
            this.employeeAdd_cb_apartment.FormattingEnabled = true;
            this.employeeAdd_cb_apartment.Location = new System.Drawing.Point(116, 187);
            this.employeeAdd_cb_apartment.Name = "employeeAdd_cb_apartment";
            this.employeeAdd_cb_apartment.Size = new System.Drawing.Size(126, 23);
            this.employeeAdd_cb_apartment.TabIndex = 22;
            this.employeeAdd_cb_apartment.ValueMember = "apartment_name";
            // 
            // zApartmentBindingSource
            // 
            this.zApartmentBindingSource.DataMember = "Z_Apartment";
            this.zApartmentBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // z_ApartmentTableAdapter
            // 
            this.z_ApartmentTableAdapter.ClearBeforeFill = true;
            // 
            // z_ApartmentTableAdapter1
            // 
            this.z_ApartmentTableAdapter1.ClearBeforeFill = true;
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 501);
            this.Controls.Add(this.employeeAdd_cb_apartment);
            this.Controls.Add(this.employeeAdd_cb_title);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.employeeAdd_btn_add);
            this.Controls.Add(this.employeeAdd_tb_info);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.employeeAdd_tb_home);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeeAdd_tb_tel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employeeAdd_dtp_inTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeAdd_cb_age);
            this.Controls.Add(this.employeeAdd_cb_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeAdd_tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeAdd";
            this.Text = "添加员工信息";
            this.Load += new System.EventHandler(this.EmployeeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zApartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zApartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeAdd_tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeAdd_cb_sex;
        private System.Windows.Forms.ComboBox employeeAdd_cb_age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker employeeAdd_dtp_inTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox employeeAdd_tb_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeAdd_tb_home;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employeeAdd_tb_info;
        private System.Windows.Forms.Button employeeAdd_btn_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox employeeAdd_cb_title;
        private System.Windows.Forms.ComboBox employeeAdd_cb_apartment;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource zApartmentBindingSource;
        private SuperMarketDataSetTableAdapters.Z_ApartmentTableAdapter z_ApartmentTableAdapter;
        private SuperMarketDataSet1 superMarketDataSet1;
        private System.Windows.Forms.BindingSource zApartmentBindingSource1;
        private SuperMarketDataSet1TableAdapters.Z_ApartmentTableAdapter z_ApartmentTableAdapter1;
    }
}