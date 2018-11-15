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
        /// 添加数据
        /// </summary>
        /// <param name="objShift">班次对象</param>
        /// <returns>返回执行结果</returns>
        public int AddClass(ShiftManage objShift)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into ClassesTime(ClassesName,TimesName,WorkTime,OffDutyTime,StartCheckIn,EndCheckIn,");
            sqlBuilder.Append("StartSignBack,EndSignBack,LateTime,LeftEarly,DayNumber,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) ");

            string sql = string.Format(sqlBuilder.ToString(), objShift.ClassesName, objShift.TimesName, objShift.WorkTime,
                objShift.OffDutyTime, objShift.StartCheckIn, objShift.EndCheckIn, objShift.StartSignBack, objShift.EndSignBack,
                objShift.LateTime, objShift.LeftEarly, objShift.DayNumber, objShift.Monday, objShift.Thursday, objShift.Wednesday,
                objShift.Thursday, objShift.Friday, objShift.Saturday, objShift.Sunday);

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
