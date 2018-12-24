using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 时段管理业务逻辑类
    /// </summary>
    public class SfWorkTimeService
    {

        /// <summary>
        /// 获取时段数据集
        /// </summary>
        /// <returns>时段数据集</returns>
        public DataSet GetTimesDataSet()
        {
            string sql = "select * from SfWorkTime";
            sql = string.Format(sql);
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 验证时段名称
        /// </summary>
        /// <param name="TimesName">时段名称</param>
        /// <returns></returns>
        public bool IsTimesNameExisted(string TimesName)
        {
            string sql = "select count(*) from SfWorkTime where TimesName='{0}'";//count(*)代表计算返回的行数
            sql = string.Format(sql, TimesName);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));//条目数转换为int

            if (result == 1) return true;//如果结果等于1则返回true
            return false;//如果结果不等于1则返回false

        }

        /// <summary>
        /// 获得时段名
        /// </summary>
        /// <returns>时段名集合</returns>
        public List<SfWorkTime> GetTimesNameList()
        {
            string sql = "select TimesName from SfWorkTime";
            sql = string.Format(sql);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<SfWorkTime> list = new List<SfWorkTime>();
            while (objReader.Read())
            {
                list.Add(new SfWorkTime()
                {
                    TimesName = objReader["TimesName"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 添加时间段数据
        /// </summary>
        /// <param name="objSfWorkTime">班次时段对象</param>
        /// <returns>返回执行结果</returns>
        public int AddTimes(SfWorkTime objSfWorkTime)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into SfWorkTime(TimesName,WorkTime,OffDutyTime,StartCheckIn,EndCheckIn,");
            sqlBuilder.Append("StartSignBack,EndSignBack,LateTime,LeftEarly)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})");

            string sql = string.Format(sqlBuilder.ToString(), objSfWorkTime.TimesName, objSfWorkTime.WorkTime,
                objSfWorkTime.OffDutyTime, objSfWorkTime.StartCheckIn, objSfWorkTime.EndCheckIn, objSfWorkTime.StartSignBack, objSfWorkTime.EndSignBack,
                objSfWorkTime.LateTime, objSfWorkTime.LeftEarly);

            try
            {

                return SQLHelper.Update(sql);

            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
