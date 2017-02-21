using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SuperMarket
{
    class DB
    {
        private SqlConnection con = null;
        private string strConn;

        public DB()
        {
            strConn = "Data Source=ywh-pc\\sqlserver;Initial Catalog=SuperMarket;Integrated Security=True";
        }
        //打开数据库连接
        public void open()
        {
            if (con == null)
                con = new SqlConnection(strConn);
            if (con.State.Equals(ConnectionState.Closed))
                con.Open();
        }
        //关闭数据库
        public void close()
        {
            if (con == null)
                return;
            if (con.State.Equals(ConnectionState.Open))
            {
                con.Close();
                con.Dispose();
                con = null;
            }
            else
            {
                con.Dispose();
                con = null;
            }
        }
        //执行SQL语句
        public int ExecuteSQLNonQuery(string sqlStr)
        {
            try
            {
                this.open();//打开连接
                SqlCommand cmd = new SqlCommand(sqlStr, con);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                close();
            }
        }
       
        //执行SQL语句,传递参数给SqlCommand
        public int ExecuteSQLNonQueryWithParam(string sqlStr, List<SqlParameter> sqlParams)
        {
            try
            {
                this.open();//打开连接
                SqlCommand cmd = new SqlCommand(sqlStr, con);
                foreach (SqlParameter p in sqlParams)
                    cmd.Parameters.Add(p);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                close();
            }
        }

        //执行SQL语句,返回查询的表
        public DataTable GetDataTable(string sqlStr)
        {
            DataTable dt;
            try
            {
                open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                close();
            }
            return dt;
        }
        //执行SQL语句,返回DataRow
        public DataRow GetDataRow(string sqlStr)
        {
            DataRow dr;
            try
            {
                //调用该类GetDataTable方法
                dr = GetDataTable(sqlStr).Rows[0];
            }
            catch
            {
                dr = null;
            }
            finally
            {
                close();
            }
            return dr;
        }
    }
}
