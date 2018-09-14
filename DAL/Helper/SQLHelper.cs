using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace DAL
{
    /// <summary>
    ///  通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        #region 连接字符串



        // private static readonly string connString = "Server=.;DataBase=StudentManageDB;Uid=sa;Pwd=password01!";

        private static readonly string connString =
            ConfigurationManager.ConnectionStrings["connString"].ToString();

        //private static readonly string connString =
        //    Common.StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["connString"].ToString());
        #endregion

        public static bool Conlink(bool clink)
        {
            SqlConnection conn = new SqlConnection(connString);
            if (clink != true)
            {
                conn.Close();
                clink = false;
            }
            return clink;
        }

        #region 执行增、删、改（insert/update/delete）
        /// <summary>
        /// 执行增、删、改（insert/update/delete）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 执行单一结果查询（select）        

        /// <summary>
        /// 执行单一结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 执行多结果查询（select） 
        /// <summary>
        /// 执行多结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader objReader =
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return objReader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        #endregion

        #region 执行返回数据集的查询
        /// <summary>
        /// 执行返回数据集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd); //创建数据适配器对象
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds);  //使用数据适配器填充数据集
                return ds;  //返回数据集
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 带参数的SQL语句

        public static int PRUpdate(string sql, SqlParameter[] parameter)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(parameter);//为Command对象添加参数
                //foreach (SqlParameter  item in parameter)
                //{
                //    cmd.Parameters.Add(item);
                //}
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region 调用存储过程

        public static int UpdateByProcedure(string procedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;//声明当前要执行的是存储过程
                cmd.CommandText = procedureName;//commandText只需要赋值存储过程名称即可
                cmd.Parameters.AddRange(param);//添加存储过程的参数
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行多结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReaderByProcedure(string procedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                cmd.Parameters.AddRange(param);
                SqlDataReader objReader =
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return objReader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }

        #endregion

        #region 启用事务执行多条SQL语句
        /// <summary>
        /// 启用事务执行多条SQL语句
        /// </summary>      
        /// <param name="sqlList">SQL语句列表</param>      
        /// <returns></returns>
        public static bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();   //开启事务
                foreach (string itemSql in sqlList)//循环提交SQL语句
                {
                    cmd.CommandText = itemSql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();  //提交事务(同时自动清除事务)
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                    cmd.Transaction.Rollback();//回滚事务(同时自动清除事务)
                throw new Exception("调用事务方法UpdateByTran(List<string> sqlList)时出现错误：" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction != null)
                    cmd.Transaction = null;
                conn.Close();
            }
        }
        #endregion

        #region 使用SQLByBulk批量写入数据
        public static bool UpdataByBulk(DataTable dt, string sqlTableName)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlTransaction sqlBulkTransaction = conn.BeginTransaction();//打开事务
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.CheckConstraints, sqlBulkTransaction);//开启约束检查和事务             
            foreach (DataColumn item in dt.Columns)
            {
                bulkCopy.ColumnMappings.Add(item.ColumnName, item.ColumnName);
            }
            bulkCopy.DestinationTableName = sqlTableName;
            bulkCopy.BatchSize = dt.Rows.Count;
            try
            {
                if (dt != null && dt.Rows.Count != 0)
                {
                    bulkCopy.WriteToServer(dt);
                    sqlBulkTransaction.Commit();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (sqlBulkTransaction != null)
                    sqlBulkTransaction.Rollback();
                throw ex;
            }
            finally
            {
                if (sqlBulkTransaction != null)
                    sqlBulkTransaction = null;
                if (bulkCopy != null)
                    bulkCopy.Close();
            }
        }
        #endregion

        #region 获取服务器时间
        /// <summary>
        /// 获取服务器的时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerTime()
        {
            return Convert.ToDateTime(GetSingleResult("select getdate()"));
        }
        #endregion
    }
}