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
    public class ShiftManageService
    {
        /// <summary>
        /// 获得班次数据集
        /// </summary>
        /// <returns>班次数据集</returns>
        public DataSet GetClassDataSet()
        {
            string sql = "select * from ClassesTime";
            sql = string.Format(sql);
            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 获取时段数据集
        /// </summary>
        /// <returns>时段数据集</returns>
        public DataSet GetTimesDataSet()
        {
            string sql = "select * from TimesManage ";
            sql = string.Format(sql);
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 验证结果
        /// </summary>
        /// <param name="TimesName">时段名称</param>
        /// <returns></returns>
        public string getTimesName(string TimesName)
        {
            string sql = "select '[0]' from TimesManage";
            sql = string.Format(sql, TimesName);
            SQLHelper.GetSingleResult(sql);
            return TimesName;
        }


        /// <summary>
        /// 获取班次列表
        /// </summary>
        /// <returns>班次列表</returns>
        public List<ShiftManage> GetGetClassList()
        {
            string sql = "select ClassesName from ClassesTime";
            sql = string.Format(sql);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<ShiftManage> list = new List<ShiftManage>();
            while (objReader.Read())
            {
                list.Add(new ShiftManage()
                {
                    ClassesName = objReader["ClassesName"].ToString(),
                    //ClassesId=Convert.ToInt32(objReader["ClassesId"])

                });                

            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 添加时间段数据
        /// </summary>
        /// <param name="objTimes">时间段对象</param>
        /// <returns>返回执行结果</returns>
        public int AddTimes(ShiftManage objTimes)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into TimesManage(TimesName,WorkTime,OffDutyTime,StartCheckIn,EndCheckIn,");
            sqlBuilder.Append("StartSignBack,EndSignBack,LateTime,LeftEarly)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})");

            string sql = string.Format(sqlBuilder.ToString(), objTimes.TimesName, objTimes.WorkTime,
                objTimes.OffDutyTime, objTimes.StartCheckIn, objTimes.EndCheckIn, objTimes.StartSignBack, objTimes.EndSignBack,
                objTimes.LateTime, objTimes.LeftEarly);

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
