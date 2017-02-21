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
    public partial class EmployeeModify : Form
    {
        public EmployeeModify()
        {
            InitializeComponent();
        }

        private void employeeModify_btn_modify_Click(object sender, EventArgs e)
        {    
            DB db=new DB();
            string modifyID = employeeModify_tb_modifyID.Text;

            if (modifyID == "")
            {
                MessageBox.Show("请先输入要修改的员工编号！");
                return;
            }

            string employeeName = employeeModify_tb_name.Text;
            string employeeSex = employeeModify_cb_sex.Text;
            string employeeAge = employeeModify_cb_age.Text;
            string employeeInTime = employeeModify_dtp_inTime.Text;
            string employeeApart = employeeModify_cb_apart.Text;
            string employeeTitle = employeeModify_cb_title.Text;
            string employeeTel = employeeModify_tb_tel.Text;
            string employeeHome = employeeModify_tb_home.Text;
            string employeeInfo = employeeModify_tb_info.Text;

            string sqlSelect = "select apartment_id from Z_Apartment where apartment_name='" + employeeApart + "' and apartment_title='" + employeeTitle + "'";
            string employeeApartID = db.GetDataTable(sqlSelect).Rows[0][0].ToString();

            string sqlUpdate = "update Z_Employee set "
                                        + " employee_name ='" + employeeName + "',"
                                        + " employee_sex='" + employeeSex + "',"
                                        + " employee_age='" + employeeAge + "',"
                                        + " employee_in_time='" + employeeInTime + "',"
                                        + " employee_apartment_id='" + employeeApartID + "',"
                                        + " employee_tel='" + employeeTel + "',"
                                        + " employee_home='" + employeeHome + "',"
                                        + " employee_info='" + employeeInfo + "'"
                                        + " where employee_id='" + modifyID + "'";
            int result = db.ExecuteSQLNonQuery(sqlUpdate);
            if (result < 1)
            {
                MessageBox.Show("修改失败！");
            }
            else
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void employeeModify_tb_modifyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modifyID = employeeModify_tb_modifyID.Text;
            DB db = new DB();
           
            string sqlSelect = "select employee_name,employee_sex,employee_age,employee_in_time,apartment_name,apartment_title,employee_tel,employee_home,employee_info"
                                        +" from Z_Employee,Z_Apartment"
                                        + " where employee_id='" + modifyID + "' and Z_Employee.employee_apartment_id = Z_Apartment.apartment_id";
            DataTable dt = db.GetDataTable(sqlSelect);
            if (dt == null)
            {
                MessageBox.Show("没有找到相关编号的员工！");
                employeeModify_tb_modifyID.SelectAll();
                return;
            }
            else
            {
                employeeModify_tb_name.Text = dt.Rows[0][0].ToString();
                employeeModify_cb_sex.Text = dt.Rows[0][1].ToString();
                employeeModify_cb_age.Text = dt.Rows[0][2].ToString();
                //employeeModify_dtp_inTime.Text = dt.Rows[0][3].ToString();
                employeeModify_cb_apart.Text = dt.Rows[0][4].ToString();
                employeeModify_cb_title.Text = dt.Rows[0][5].ToString();
                employeeModify_tb_tel.Text = dt.Rows[0][6].ToString();
                employeeModify_tb_home.Text = dt.Rows[0][7].ToString();
                employeeModify_tb_info.Text = dt.Rows[0][8].ToString();
            }
        }

        private void EmployeeModify_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“employeeIDDataSet.Z_Employee”中。您可以根据需要移动或删除它。
            this.z_EmployeeTableAdapter.Fill(this.employeeIDDataSet.Z_Employee);

        }
    }
}
