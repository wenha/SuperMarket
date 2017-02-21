using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SuperMarket
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int all = 0;
        int all_in = 0;
        int all_out = 0;
        int award = 10;
        int fineLate = 10;
        int fineAbsent = 10;
        int fineLeave = 10;
        //Random random = new Random();

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“employeeNameDataSet.Z_Employee”中。您可以根据需要移动或删除它。
            this.z_EmployeeTableAdapter1.Fill(this.employeeNameDataSet.Z_Employee);
            // TODO: 这行代码将数据加载到表“employeeIDDataSet.Z_Employee”中。您可以根据需要移动或删除它。
            this.z_EmployeeTableAdapter.Fill(this.employeeIDDataSet.Z_Employee);
            main_employee_gridview_employee_ShowInfo();
            main_apartment_gridView_apartment_showInfo();
            main_leave_gridview_leave_showInfo();
            main_salary_gridView_salary_showInfo();
            main_attend_gridView_showInfo();
        }

        //显示员工信息表中数据
        public void main_employee_gridview_employee_ShowInfo()
        {
            DB db = new DB();
            string strSelect = "select employee_id as 员工编号, employee_name as 姓名, employee_sex as 性别, employee_age as 年龄, employee_in_time as 入职时间, apartment_name as 部门, apartment_title as 职称, employee_tel as 联系电话, employee_home as 家庭住址,employee_info as 备注"
                                        +" from Z_Employee, Z_apartment"
                                        + " where Z_Employee.employee_apartment_id=Z_Apartment.apartment_id";
            main_employee_gridview_employee.DataSource = db.GetDataTable(strSelect);

            string strSum = "select count(*) from Z_Employee";
            all=(int)db.GetDataTable(strSum).Rows[0][0];
            main_attend_label_sum.Text = all+"";
        }

        //显示考勤表中的数据
        public void main_attend_gridView_showInfo()
        {
            DB db = new DB();
            string strSelect = "select Z_Employee.employee_id as 员工编号, employee_name as 姓名, employee_attend_state as 出勤状况, employee_date as 考勤日期"
                                        +" from Z_Attend, Z_Employee"
                                        + " where Z_Employee.employee_id=Z_Attend.employee_id";
            main_attend_gridView.DataSource = db.GetDataTable(strSelect);
        }

        //显示部门表中数据
        public void main_apartment_gridView_apartment_showInfo()
        {
            DB db = new DB();
            string strSelect = "select apartment_id as 职工编号, apartment_name as 部门, apartment_title as 职称,apartment_salary as 工资 from Z_Apartment";
            main_apartment_grideView_apartment.DataSource = db.GetDataTable(strSelect);
        }

        //显示请假表中信息
        public void main_leave_gridview_leave_showInfo()
        {
            DB db = new DB();
            string strSelect = "select Z_Employee.employee_id as 员工编号, employee_name as 姓名,leave_begin as 开始时间,leave_end as 结束时间,leave_reason as 请假事由 "
                                    + " from Z_Leave,Z_Employee"
                                    +" where Z_Leave.employee_id=Z_Employee.employee_id";
            main_leave_gridview_leave.DataSource = db.GetDataTable(strSelect);
        }

        //显示工资表中信息
        public void main_salary_gridView_salary_showInfo()
        {
            DB db = new DB();
            string strSelect = "select Z_Employee.employee_id as 员工编号, employee_name as 姓名,salary_base as 基本工资 ,salary_award as 奖金,salary_fine as 罚金,salary_sum as 总工资, employee_in_time as 日期"
                                    + " from Z_Employee,Z_Salary"
                                    + " where Z_Employee.employee_id=Z_Salary.employee_id";
            
            main_salary_gridView_salary.DataSource = db.GetDataTable(strSelect);    
        }

        //员工信息页面添加员工信息按钮
        private void main_employee_btn_add_Click(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.Show();
        }

        //员工信息页面删除员工信息按钮
        private void main_employee_btn_delete_Click(object sender, EventArgs e)
        {
            EmployeeDelete delete = new EmployeeDelete();
            delete.Show(); ;
        }

        //员工信息页面修改员工信息按钮
        private void main_employee_btn_modify_Click(object sender, EventArgs e)
        {
            EmployeeModify modify = new EmployeeModify();
            modify.Show();
        }

        //部门管理界面添加按钮事件
        private void main_apartment_btn_add_Click(object sender, EventArgs e)
        {
             string apartmentName=main_apartment_tb_apart.Text;
             string apartmentTitle=main_apartment_tb_title.Text;
             string apartmentSalary=main_apartment_tb_salary.Text;
            string apartmentSearch=main_apartment_tb_search.Text;
            DB db = new DB();

            if (apartmentName == "")
            {
                MessageBox.Show("请输入部门名称！");
                return;
            }

            if (apartmentTitle == "")
            {
                MessageBox.Show("请输入部门职称！");
                return;
            }
            
            if (apartmentSalary == "")
            {
                MessageBox.Show("请输入工资!");
                return;
            }

            Regex obj = new Regex("[1-9][0-9]{0,}");
            if (!obj.IsMatch(apartmentSalary))
            {
                MessageBox.Show("输入金额有误！");
                main_apartment_tb_salary.SelectAll();
                return;
            }

            string sqlInsert = "insert into Z_Apartment(apartment_name, apartment_title, apartment_salary)"
                                        +"values('"+apartmentName+"','"+apartmentTitle+"','"+apartmentSalary+"')";
            int result = db.ExecuteSQLNonQuery(sqlInsert);
            if (result == 0)
            {
                MessageBox.Show("添加出错，请重新添加!");
            }
            main_apartment_gridView_apartment_showInfo();
                main_apartment_tb_apart.Text = "";
                main_apartment_tb_title.Text = "";
                main_apartment_tb_salary.Text = "";
                main_apartment_tb_apart.Focus();
        }
       
        //添加请假信息
        private void main_leave_btn_add_Click(object sender, EventArgs e)
        {
            string leaveName = main_leave_cb_leaveName.Text;
            string leaveBegin = main_leave_dtp_leaveBegin.Text;
            string leaveEnd = main_leave_dtp_leaveEnd.Text;
            string leaveReason = main_leave_rtb_leaveReason.Text;
            DB db=new DB();
            if (leaveName == "")
            {
                MessageBox.Show("请输入请假人姓名！");
                return;
            }
            
            if (leaveReason == "")
            {
                MessageBox.Show("请添加请假事由！");
                return;
            }
            string strSelect = "select employee_id from Z_Employee where employee_name='" + leaveName + "'";
            string leaveID = db.GetDataTable(strSelect).Rows[0][0].ToString();
            //MessageBox.Show(leaveID + "====" + leaveBegin + "=====" + leaveEnd + "======" + leaveReason);
            string strInsert = "insert into Z_Leave(employee_id, leave_begin, leave_end,leave_reason)"
                                    +" values('"+leaveID+"','"+leaveBegin+"','"+leaveEnd+"','"+leaveReason+"')";
            int result = db.ExecuteSQLNonQuery(strInsert);
            if (result < 1)
            {
                MessageBox.Show("添加失败！");
            }
            main_leave_gridview_leave_showInfo();

            main_leave_cb_leaveName.Text = "";
            main_leave_dtp_leaveBegin.Text = DateTime.Now.ToString();
            main_leave_dtp_leaveEnd.Text = DateTime.Now.ToString();
            main_leave_rtb_leaveReason.Text = "";
            main_leave_cb_leaveName.Focus();
        }

        //根据员工号显示员工姓名
        private void main_attend_cb_employeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db=new DB();         
            string attendID=main_attend_cb_employeeID.Text;            
            string sqlSelect = "select employee_name from Z_Employee where employee_id='"+attendID+"'";
            main_attend_tb_name.Text = db.GetDataTable(sqlSelect).Rows[0][0].ToString();
        }

        //考勤
        private void main_attend_btn_submit_Click(object sender, EventArgs e)
        {
            string attendDate = main_attend_dtp_time.Text;
            string attendID = main_attend_cb_employeeID.Text;
            string attendState = main_attend_cb_attendState.Text;
            string attendName=main_attend_tb_name.Text;
            //MessageBox.Show("========" + attendDate + "========");
            DB db = new DB();
            if (attendName == "")
            {
                MessageBox.Show("请选择员工！");
                return;
            }
            if (attendState == "")
            {
                MessageBox.Show("请选择员工出勤状况！");
                return;
            }

                string strSelect = "select * from Z_Attend where employee_id='" + attendID + "' and employee_date='" + attendDate + "'";
                DataRow dt = db.GetDataRow(strSelect);
                if (dt != null)
                {
                    MessageBox.Show("该员工已考勤！");
                    return;
                }
                string strInsert = "insert into Z_Attend(employee_id,employee_attend_state,employee_date)"
                                    + " values('" + attendID + "','" + attendState + "','" + attendDate + "')";
                int result = db.ExecuteSQLNonQuery(strInsert);
                if (result < 1)
                {
                    MessageBox.Show("考勤失败，请重新考勤！");
                }

                string sql = "";
                if (attendState == "出差")
                {
                    sql = "update Z_Salary set salary_award=salary_award+" + award + "  where employee_id='" + attendID + "'";
                }
                if (attendState == "请假" )
                {
                    sql = "update Z_Salary set salary_fine=salary_fine- " + fineLeave + " where employee_id='" + attendID + "'";
                }
                if (attendState == "旷工")
                {
                    sql = "update Z_Salary set salary_fine=salary_fine- " + fineAbsent + "  where employee_id='" + attendID + "'";
                }
                if (attendState == "迟到")
                {
                    sql = "update Z_Salary set salary_fine=salary_fine- " + fineLate + " where employee_id='" + attendID + "'";
                }
                result = db.ExecuteSQLNonQuery(sql);
                sql = "update Z_Salary set salary_sum=salary_base+salary_award+salary_fine";
                db.ExecuteSQLNonQuery(sql);
            
            main_attend_gridView_showInfo();
            main_attend_dtp_time.Text = "";
            main_attend_cb_employeeID.Text="";
            main_attend_cb_attendState.Text = "";
            main_attend_tb_name.Text = "";
        }

        //显示时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
            time1.Text = DateTime.Now.ToString();
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

        //根据需要查询部门信息
        private void main_apartment_btn_search_Click(object sender, EventArgs e)
        {
            string searchMethod=main_apartment_cb_search.Text;
            string searchInfo=main_apartment_tb_search.Text;
            string strSelect = "";
            DB db=new DB();

            if(searchMethod=="")
            {
                MessageBox.Show("请选择查询方式！");
                return;
            }
            if(searchMethod=="按部门查询")
            {
                strSelect = "select apartment_id as 职位编号,apartment_name as 部门名称, apartment_title as 职称, apartment_salary as 工资 from Z_Apartment where apartment_name='" + searchInfo + "'";          
            }
            if(searchMethod=="按职称查询")
            {
                strSelect = "select apartment_id as 职位编号,apartment_name as 部门名称, apartment_title as 职称, apartment_salary as 工资 from Z_Apartment where apartment_title='" + searchInfo + "'";
            }
            if(searchInfo=="")
            {
                MessageBox.Show("请选择查询内容！");
                return;
            }
 
            DataTable dt=db.GetDataTable(strSelect);
            if(dt==null)
            {
                MessageBox.Show("查无此项！");
            }
            else
            {
                main_apartment_grideView_apartment.DataSource=dt;
            }
            main_apartment_cb_search.Text = "";
            main_apartment_tb_search.Text = "";
        }

        //更新数据后刷新
        private void main_employee_btn_reflash_Click(object sender, EventArgs e)
        {
            main_employee_gridview_employee_ShowInfo();
            main_apartment_gridView_apartment_showInfo();
            main_leave_gridview_leave_showInfo();
            main_salary_gridView_salary_showInfo();
            main_attend_gridView_showInfo();
        }

        //根据时间显示出勤人数
        private void main_attend_dtp_time_ValueChanged(object sender, EventArgs e)
        {
            string datetime = main_attend_dtp_time.Text;
            DB db = new DB();
            string strSelect = "select count(*) from Z_Attend where employee_date='"+datetime+"'";
            all_in = (int)db.GetDataTable(strSelect).Rows[0][0];
            all_out = all - all_in;
            main_attend_label_in.Text = all_in + "";
            main_attend_label_out.Text = all_out + "";
        }

        //设置工资
        private void button3_Click(object sender, EventArgs e)
        {
            SetSalarycs setSalary = new SetSalarycs();
            setSalary.Show();
        }

        //修改个人工资
        private void button1_Click(object sender, EventArgs e)
        {
            salaryModify salaryModi = new salaryModify();
            salaryModi.Show();
        }
     }
}
