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
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“superMarketDataSet1.Z_Apartment”中。您可以根据需要移动或删除它。
            this.z_ApartmentTableAdapter1.Fill(this.superMarketDataSet1.Z_Apartment);
            // TODO: 这行代码将数据加载到表“superMarketDataSet.Z_Apartment”中。您可以根据需要移动或删除它。
            this.z_ApartmentTableAdapter.Fill(this.superMarketDataSet.Z_Apartment);

        }

        private void employeeAdd_btn_add_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string employeeName = employeeAdd_tb_name.Text;
            string employeeSex = employeeAdd_cb_sex.Text;
            string employeeAge = employeeAdd_cb_age.Text;
            string employeeInTime = employeeAdd_dtp_inTime.Text;
            string employeeApart = employeeAdd_cb_apartment.Text;
            string employeeTitle = employeeAdd_cb_title.Text;
            string employeeTel = employeeAdd_tb_tel.Text;
            string employeeHome = employeeAdd_tb_home.Text;
            string employeeInfo=employeeAdd_tb_info.Text;

            if (employeeName == "")
            {
                MessageBox.Show("请输入员工姓名！");
                return;
            }
            if (employeeSex == "")
            {
                MessageBox.Show("请输入员工性别！");
                return;
            }
            if (employeeAge == "")
            {
                MessageBox.Show("请输入员工年龄！");
                return;
            }
            if (employeeTel == "")
            {
                MessageBox.Show("请输入员工联系电话！");
                return;
            }
            if (employeeHome == "")
            {
                MessageBox.Show("请输入员工家庭住址！");
                return;
            }
           
            string strSelect = "select apartment_id from Z_Apartment where apartment_name='"+employeeApart+"' and apartment_title='"+employeeTitle+"'";
            string employeeApartID = db.GetDataTable(strSelect).Rows[0][0].ToString();

            //MessageBox.Show( employeeName + "+++++" + employeeSex + "+++" + employeeAge + "+++" + employeeInTime + "+++" + employeeApartID + "+++" + employeeTel + "++++" + employeeHome + "++++" + employeeInfo );

            string strInsert = "insert into Z_Employee(employee_name,employee_sex,employee_age,employee_in_time,employee_apartment_id,employee_tel,employee_home,employee_info)"
                                    + " values('" + employeeName + "','" + employeeSex + "','" + employeeAge + "','" + employeeInTime + "','" + employeeApartID + "','" + employeeTel + "','" + employeeHome + "','" + employeeInfo + "')";                                
            int result = db.ExecuteSQLNonQuery(strInsert);
            if (result < 1)
            {
                MessageBox.Show("员工信息添加失败!");
            }
           
            //将用员工信息添加到用户表中
            string str="select employee_id from Z_Employee where employee_name='"+employeeName+"'";
            string userID=db.GetDataTable(str).Rows[0][0].ToString();
            strInsert = " insert into Z_USER(user_id,user_pwd) values('" + userID + "','" + userID + "')";
            result = db.ExecuteSQLNonQuery(strInsert);
            if (result < 1)
            {
                MessageBox.Show("员工信息添加到用户表失败!");
            }
            string strSelectSalary="select apartment_salary from Z_Apartment where apartment_id='"+employeeApartID+"'";
            string salary=db.GetDataTable(strSelectSalary).Rows[0][0].ToString();
             //将员工信息添加到工资表中
            string strInsertSalary = "insert into Z_Salary(employee_id,salary_base,salary_award,salary_fine,salary_sum,salary_date) values('" + userID + "','" + salary + "','0','0','0','" + employeeInTime + "')";
            result = db.ExecuteSQLNonQuery(strInsertSalary);
            
            employeeAdd_tb_name.Text = "";
            employeeAdd_cb_sex.Text = "";
            employeeAdd_cb_age.Text = "";
            employeeAdd_dtp_inTime.Text = DateTime.Now.ToString();
            employeeAdd_tb_tel.Text = "";
            employeeAdd_tb_home.Text = "";
            employeeAdd_tb_info.Text = "";
            employeeAdd_tb_name.Focus();

        }
    }
}
