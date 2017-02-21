using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class salaryModify : Form
    {
        public salaryModify()
        {
            InitializeComponent();
        }

        DB db = new DB();

        private void salaryModify_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“employeeDataSet.Z_Employee”中。您可以根据需要移动或删除它。
            this.z_EmployeeTableAdapter.Fill(this.employeeDataSet.Z_Employee);

        }

        private void salaryModify_cb_employeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeID=salaryModify_cb_employeeID.Text;
            string sqlSelect = "select employee_name from Z_Employee where employee_id='" + employeeID + "'";
            salaryModify_tb_name.Text = db.GetDataTable(sqlSelect).Rows[0][0].ToString();
            string sql = "select salary_base,salary_award,salary_fine,salary_sum from Z_Salary where employee_id='" + employeeID + "'";
            salaryModify_tb_base.Text = db.GetDataTable(sql).Rows[0][0].ToString();
            salaryModify_tb_award.Text = db.GetDataTable(sql).Rows[0][1].ToString();
            salaryModify_tb_fine.Text = db.GetDataTable(sql).Rows[0][2].ToString();
            salaryModify_tb_sum.Text = db.GetDataTable(sql).Rows[0][3].ToString();
        }

        private void salaryModify_btn_submit_Click(object sender, EventArgs e)
        {
            if (salaryModify_cb_employeeID.Text == "")
            {
                MessageBox.Show("请先选择要修改的员工号！");
                return;
            }
            string salaryBase=salaryModify_tb_base.Text;
            string salaryFine = salaryModify_tb_fine.Text;
            string salaryAward = salaryModify_tb_award.Text;
            salaryModify_tb_sum.Text = (double.Parse(salaryBase) + double.Parse(salaryAward) + double.Parse(salaryFine)) + "";
            string salarySum = salaryModify_tb_sum.Text;
            
            string sql = "update Z_Salary set salary_base='" + salaryBase + "',salary_award='" + salaryAward + "',salary_fine='" + salaryFine + "',salary_sum='" + salarySum + "'";
            int result=db.ExecuteSQLNonQuery(sql);
            if (result < 1)
            {
                MessageBox.Show("修改失败！");
            }
            else
            {
                MessageBox.Show("修改成功！下次登录生效！");
            }
        }
    }
}
