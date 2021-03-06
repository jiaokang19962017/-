﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Common
{
    /// <summary>
    /// 静态类:sql帮助类
    /// </summary>
    public static class SqlHelper
    {
        /// <summary>
        /// 设置连接字符串
        /// </summary>
        private static readonly string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        /// <summary>
        /// 生命一个sqltransaction对象
        /// </summary>
        private static SqlTransaction tran;
        /// <summary>
        /// 声明一个sqlcnnection对象
        /// </summary>
        private static SqlConnection conn;
        /// <summary>
        /// 返回连接对象
        /// </summary>
        public static SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                return conn;
            }
        }

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="cmdType">命令类型(Text或者Proc)</param>
        /// <param name="cmdText">命令文本(SQL语句或者储存过程名)</param>
        /// <param name="param">传递的参数</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecutrNonQuery(CommandType cmdType, string strSql, params SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(strConn);//创建一个连接对象,指定连接数据源
            try
            {

                SqlCommand cmd = new SqlCommand(strSql, con);//创建一个命令对象,执行sql语句
                cmd.CommandType = cmdType;//设置命令类型
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);//添加参数
                }
                con.Open();//打开连接,最晚打开,最早关闭
                int count = cmd.ExecuteNonQuery();

                return count;//返回受影响行数
            }
            catch (Exception ex)
            {
              //  con.Close();
                //throw;
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();

            }
        }

        /// <summary>
        /// 返回单个值(第一行第一列)
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="strSql">sql语句</param>
        /// <param name="param">传递的参数</param>
        /// <returns>返回自定义类型的单个值</returns>
        public static T ExecuteScalar<T>(CommandType cmdType, string strSql, params SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(strConn);
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                con.Open();
                object result = cmd.ExecuteScalar();//返回单个结果
                T t = default(T);
                t = (T)Convert.ChangeType(result, typeof(object));
                return t;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
                
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// 返回多条数据
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="strsql">sql语句</param>
        /// <param name="param">传递的对象</param>
        /// <returns>返回sqldatareader对象</returns>
        public static SqlDataReader ExecuteReader(CommandType cmdType,string strsql,params SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(strConn);

            try
            {
                SqlCommand cmd = new SqlCommand(strsql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                con.Open();

                //CommandBehavior.CloseConnection当读取完dr的数据时,则dr所依赖的所有对象都会关闭
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//
                return dr;
            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex.Message);
                return null;
                
            }
          
        }
        /// <summary>
        /// 返回结果集
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="strsql">sql语句</param>
        /// <param name="param">传递的参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataSet(CommandType cmdType, string strsql, params SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(strConn);

            try
            {
                SqlCommand cmd = new SqlCommand(strsql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);//创建一个数据适配器对象
                DataSet ds = new DataSet();//创建一个dataSet的实例,用于存放数据
                da.Fill(ds);//填充数据集ds
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

        }
        /// <summary>
        /// 查询dataTable
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="strsql">sql语句</param>
        /// <param name="param">传递的参数</param>
        /// <returns>返回datatable</returns>
        public static DataTable ExecuteDataTable(CommandType cmdType, string strsql, params SqlParameter[] param)
        {
            DataSet ds = ExecuteDataSet(cmdType, strsql, param);
            return ds.Tables[0];
        }

     /// <summary>
     /// 事务操作
     /// </summary>
     /// <param name="cmdType">命令类型</param>
     /// <param name="strsql">sql语句</param>
     /// <param name="param">传递的参数</param>
        public static void ExecuteTransaction(CommandType cmdType, string strsql, params SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(strsql, conn);
            cmd.CommandType = cmdType;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);//添加参数
            }
            if (tran != null)
            {
                cmd.Transaction = tran;//设置事务
            }
        }
        /// <summary>
        /// 打开事务
        /// </summary>
        public static void BeginTransaction()
        {
            Conn.Open();
            tran = conn.BeginTransaction();//开启事务
        }
        /// <summary>
        /// 提交事务
        /// </summary>
        public static void CommitTransaction()
        {
            tran.Commit();//提交事务
            Conn.Close();//关闭连接
        }

        /// <summary>
        /// 回滚事务
        /// </summary>
        public static void RollBackTransaction()
        {
            tran.Rollback();//回滚事务
            Conn.Close();
        }

       
        }
    }
