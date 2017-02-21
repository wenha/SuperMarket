namespace SuperMarket
{
    partial class EmployeeDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeDelete_tb_employeeName = new System.Windows.Forms.TextBox();
            this.employeeDelete_btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // employeeDelete_tb_employeeName
            // 
            this.employeeDelete_tb_employeeName.Location = new System.Drawing.Point(136, 48);
            this.employeeDelete_tb_employeeName.Name = "employeeDelete_tb_employeeName";
            this.employeeDelete_tb_employeeName.Size = new System.Drawing.Size(151, 25);
            this.employeeDelete_tb_employeeName.TabIndex = 1;
            // 
            // employeeDelete_btn_delete
            // 
            this.employeeDelete_btn_delete.Location = new System.Drawing.Point(126, 150);
            this.employeeDelete_btn_delete.Name = "employeeDelete_btn_delete";
            this.employeeDelete_btn_delete.Size = new System.Drawing.Size(75, 23);
            this.employeeDelete_btn_delete.TabIndex = 2;
            this.employeeDelete_btn_delete.Text = "删除";
            this.employeeDelete_btn_delete.UseVisualStyleBackColor = true;
            this.employeeDelete_btn_delete.Click += new System.EventHandler(this.employeeDelete_btn_delete_Click);
            // 
            // EmployeeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(420, 241);
            this.Controls.Add(this.employeeDelete_btn_delete);
            this.Controls.Add(this.employeeDelete_tb_employeeName);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDelete";
            this.Text = "删除员工信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeDelete_tb_employeeName;
        private System.Windows.Forms.Button employeeDelete_btn_delete;
    }
}