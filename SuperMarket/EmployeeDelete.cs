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
    public partial class EmployeeDelete : Form
    {
        public EmployeeDelete()
        {
            InitializeComponent();
        }

        private void employeeDelete_btn_delete_Click(object sender, EventArgs e)
        {
            string employeeName = employeeDelete_tb_employeeName.Text;
            DB db=new DB();
            if (employeeName == "")
            {
                MessageBox.Show("请输入要删除的员工姓名!");
                employeeDelete_tb_employeeName.Focus();
                return;
            }
            string strDelete = "select employee_id from Z_Employee where employee_name='" + employeeName + "'";
            string employeeID = db.GetDataTable(strDelete).Rows[0][0].ToString();

            string strDelete1 = "delete from Z_Employee where employee_name='" + employeeName + "'";
            int result1 = db.ExecuteSQLNonQuery(strDelete1);
            if (result1 < 1)
            {
                MessageBox.Show("删除出错！请重新删除！");
            }

            string strDelete2 = "delete from Z_Leave where employee_id='" + employeeID + "'";
            int result2 = db.ExecuteSQLNonQuery(strDelete2);

            string strDelete3 = "delete from Z_Salary where employee_id='" + employeeID + "'";
            int result3 = db.ExecuteSQLNonQuery(strDelete3);

            string strDelete4 = "delete from Z_Attend where employee_id='" + employeeID + "'";
            int result4 = db.ExecuteSQLNonQuery(strDelete4);
            
            employeeDelete_tb_employeeName.Text = "";
        }
    }
}
