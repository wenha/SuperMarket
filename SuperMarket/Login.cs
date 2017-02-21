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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string userID;
        public static string userPwd;

        private void Login_btn_submit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataRow dr =null;
            userID = Login_tb_userId.Text;
            userPwd = Login_tb_userPwd.Text;
            string sqlStr="select user_id,user_pwd from Z_USER where user_id='"+userID+"' and user_pwd='"+userPwd+"'";
            dr = db.GetDataRow(sqlStr);
            Console.Write(dr);
            if (dr == null)
            {
                MessageBox.Show("用户名或者密码错误!");
                Login_tb_userId.Text = "";
                Login_tb_userPwd.Text = "";
                Login_tb_userId.Focus();
            }
            else
            {
                if (userID == "admin")
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    Main2 main2 = new Main2();
                    main2.Show();
                    this.Hide();
                }               
            }
        }

        private void Login_btn_reset_Click(object sender, EventArgs e)
        {
            Login_tb_userId.Text = "";
            Login_tb_userPwd.Text = "";
            Login_tb_userId.Focus();
        }
    }
}
