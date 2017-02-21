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
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            main2_search_gridView_showInfo();
        }

        //显示个人工资信息
        public void main2_search_gridView_showInfo()
        {
            DB db = new DB();
            string strSelect = "select Z_Employee.employee_id as 员工编号, employee_name as 姓名,apartment_name as 部门 ,apartment_title as 职称,salary_base as 基本工资 ,salary_award as 奖金,salary_fine as 罚金,salary_sum as 总工资, employee_in_time as 日期"
                                    + " from Z_Employee,Z_Salary,Z_Apartment"
                                    + " where Z_Employee.employee_id=Z_Salary.employee_id and Z_Employee.employee_apartment_id=Z_Apartment.apartment_id";
            main2_search_gridView.DataSource = db.GetDataTable(strSelect);
        }

        private void main2_modify_btn_modify_Click(object sender, EventArgs e)
        {
            string oldPwd = main2_modify_oldpwd.Text;
            string newPwd = main2_modify_newPwd.Text;
            string rePwd = main2_modify_RePwd.Text;
            DB db = new DB();

            if (oldPwd == "")
            {
                MessageBox.Show("请输入原始密码！");
                return;
            }
            if (newPwd == "")
            {
                MessageBox.Show("请输入新密码！");
                return;
            }
            if (rePwd == "")
            {
                MessageBox.Show("请输入确认密码！");
                return;
            }
            if(oldPwd != Login.userPwd)
            {
                MessageBox.Show("原始密码输入有误！");
                return;
            }
            if (newPwd != rePwd)
            {
                MessageBox.Show("两次密码输入不一致！");
                main2_modify_RePwd.SelectAll();
                return;
            }
            
            string strUpdate = "updata Z_USER set user_pwd='" + newPwd + "' where user_id='" + Login.userID + "'";
            int result = db.ExecuteSQLNonQuery(strUpdate);
            if (result < 1)
            {
                MessageBox.Show("密码更改失败！");
            }
            main2_modify_oldpwd.Text = "";
            main2_modify_newPwd.Text = "";
            main2_modify_RePwd.Text = "";
        }

        //退出询问选择
        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
