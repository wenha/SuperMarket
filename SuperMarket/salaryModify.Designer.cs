namespace SuperMarket
{
    partial class salaryModify
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
            this.salaryModify_cb_employeeID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salaryModify_tb_name = new System.Windows.Forms.TextBox();
            this.salaryModify_tb_award = new System.Windows.Forms.TextBox();
            this.salaryModify_tb_fine = new System.Windows.Forms.TextBox();
            this.salaryModify_tb_base = new System.Windows.Forms.TextBox();
            this.salaryModify_tb_sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryModify_btn_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeDataSet = new SuperMarket.employeeDataSet();
            this.zEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.z_EmployeeTableAdapter = new SuperMarket.employeeDataSetTableAdapters.Z_EmployeeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工号：";
            // 
            // salaryModify_cb_employeeID
            // 
            this.salaryModify_cb_employeeID.DataSource = this.zEmployeeBindingSource;
            this.salaryModify_cb_employeeID.DisplayMember = "employee_id";
            this.salaryModify_cb_employeeID.FormattingEnabled = true;
            this.salaryModify_cb_employeeID.Location = new System.Drawing.Point(117, 39);
            this.salaryModify_cb_employeeID.Name = "salaryModify_cb_employeeID";
            this.salaryModify_cb_employeeID.Size = new System.Drawing.Size(121, 23);
            this.salaryModify_cb_employeeID.TabIndex = 1;
            this.salaryModify_cb_employeeID.ValueMember = "employee_id";
            this.salaryModify_cb_employeeID.SelectedIndexChanged += new System.EventHandler(this.salaryModify_cb_employeeID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "奖金：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "罚金：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "基本工资：";
            // 
            // salaryModify_tb_name
            // 
            this.salaryModify_tb_name.Location = new System.Drawing.Point(273, 37);
            this.salaryModify_tb_name.Name = "salaryModify_tb_name";
            this.salaryModify_tb_name.Size = new System.Drawing.Size(100, 25);
            this.salaryModify_tb_name.TabIndex = 7;
            // 
            // salaryModify_tb_award
            // 
            this.salaryModify_tb_award.Location = new System.Drawing.Point(123, 25);
            this.salaryModify_tb_award.Name = "salaryModify_tb_award";
            this.salaryModify_tb_award.Size = new System.Drawing.Size(100, 25);
            this.salaryModify_tb_award.TabIndex = 8;
            // 
            // salaryModify_tb_fine
            // 
            this.salaryModify_tb_fine.Location = new System.Drawing.Point(123, 75);
            this.salaryModify_tb_fine.Name = "salaryModify_tb_fine";
            this.salaryModify_tb_fine.Size = new System.Drawing.Size(100, 25);
            this.salaryModify_tb_fine.TabIndex = 9;
            // 
            // salaryModify_tb_base
            // 
            this.salaryModify_tb_base.Location = new System.Drawing.Point(123, 125);
            this.salaryModify_tb_base.Name = "salaryModify_tb_base";
            this.salaryModify_tb_base.Size = new System.Drawing.Size(100, 25);
            this.salaryModify_tb_base.TabIndex = 10;
            // 
            // salaryModify_tb_sum
            // 
            this.salaryModify_tb_sum.Location = new System.Drawing.Point(123, 182);
            this.salaryModify_tb_sum.Name = "salaryModify_tb_sum";
            this.salaryModify_tb_sum.Size = new System.Drawing.Size(100, 25);
            this.salaryModify_tb_sum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "总工资：";
            // 
            // salaryModify_btn_submit
            // 
            this.salaryModify_btn_submit.Location = new System.Drawing.Point(140, 359);
            this.salaryModify_btn_submit.Name = "salaryModify_btn_submit";
            this.salaryModify_btn_submit.Size = new System.Drawing.Size(75, 23);
            this.salaryModify_btn_submit.TabIndex = 13;
            this.salaryModify_btn_submit.Text = "确定";
            this.salaryModify_btn_submit.UseVisualStyleBackColor = true;
            this.salaryModify_btn_submit.Click += new System.EventHandler(this.salaryModify_btn_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salaryModify_tb_award);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.salaryModify_tb_sum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.salaryModify_tb_base);
            this.groupBox1.Controls.Add(this.salaryModify_tb_fine);
            this.groupBox1.Location = new System.Drawing.Point(48, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 226);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改";
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "employeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zEmployeeBindingSource
            // 
            this.zEmployeeBindingSource.DataMember = "Z_Employee";
            this.zEmployeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // z_EmployeeTableAdapter
            // 
            this.z_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // salaryModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(430, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salaryModify_btn_submit);
            this.Controls.Add(this.salaryModify_tb_name);
            this.Controls.Add(this.salaryModify_cb_employeeID);
            this.Controls.Add(this.label1);
            this.Name = "salaryModify";
            this.ShowIcon = false;
            this.Text = "工资修正";
            this.Load += new System.EventHandler(this.salaryModify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox salaryModify_cb_employeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salaryModify_tb_name;
        private System.Windows.Forms.TextBox salaryModify_tb_award;
        private System.Windows.Forms.TextBox salaryModify_tb_fine;
        private System.Windows.Forms.TextBox salaryModify_tb_base;
        private System.Windows.Forms.TextBox salaryModify_tb_sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salaryModify_btn_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private employeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource zEmployeeBindingSource;
        private employeeDataSetTableAdapters.Z_EmployeeTableAdapter z_EmployeeTableAdapter;
    }
}