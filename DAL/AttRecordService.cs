using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;
using System.Diagnostics;

namespace DAL
{
    public class AttRecordService
    {

        /// <summary>
        /// 通用查询类
        /// </summary>
        /// <param name="SQLtableName">SQL数据表名</param>
        /// <returns>结果数据集</returns>
        public DataSet GetSQLTableDataSet(string SQLtableName)
        {
            string sql = "select * from '{0}'";
            sql = string.Format(sql, SQLtableName);

            return SQLHelper.GetDataSet(sql);
        }

        #region 普通方式写入数据
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="MachineId">机器号码</param>
        /// <param name="ClockId">考勤ID</param>
        /// <param name="VerifyMode">验证方式</param>
        /// <param name="InOutMode">考勤状态</param>
        /// <param name="ClockRecord">打卡时间</param>
        /// <returns>打卡时间</returns>
        public string AddAttrecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.Update(sql);

            return sql;
        }

        #endregion



        /// <summary>
        /// 获取所有打卡记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllOriginalLog()
        {
            string sql = "select * from OriginalLog";
            sql = string.Format(sql);
            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 获取月记录
        /// </summary>
        /// <param name="StartDate">起始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <returns>月记录数据集</returns>
        public DataSet GetReportDataSet(DateTime BeginDate, DateTime EndDate)
        {
            string sql = "select * from OriginalLog where ClockRecord >= '{0}' and ClockRecord <= '{1}'";
            sql = string.Format(sql, BeginDate, EndDate);

            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 获得所有在职员工
        /// </summary>
        /// <returns>所有在职员的数据集</returns>
        public DataSet GetAllStaffsDataSet()
        {
            string sql = "select * from Staffs where SfStatus='在职'";
            sql = string.Format(sql);

            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 获得所有时间段
        /// </summary>
        /// <returns></returns>
        public List<TimesManage> GetAllTimesList()
        {
            string sql = "select * from TimesManage";
            sql = string.Format(sql);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<TimesManage> list = new List<TimesManage>();
            while (objReader.Read())
            {
                list.Add(new TimesManage()
                {
                    TimesName = objReader["TimesName"].ToString(),
                    WorkTime = objReader["WorkTime"].ToString(),
                    OffDutyTime = objReader["OffDutyTime"].ToString(),
                    StartCheckIn = objReader["StartCheckIn"].ToString(),
                    EndCheckIn = objReader["EndCheckIn"].ToString(),
                    StartSignBack = objReader["StartSignBack"].ToString(),
                    EndSignBack = objReader["EndSignBack"].ToString(),
                    LateTime = Convert.ToInt32(objReader["LateTime"]),
                    LeftEarly = Convert.ToInt32(objReader["LeftEarly"]),
                });
            }
            return list;
        }


        /// <summary>
        /// 根据时段名称获取时段
        /// </summary>
        /// <param name="TimesName">时段名称</param>
        /// <returns>时段List</returns>
        public List<TimesManage> GetTimes(string TimesName)
        {
            string sql = "select * from TimesManage where TimesName={0}" + TimesName;
            sql = string.Format(sql);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<TimesManage> list = new List<TimesManage>();
            while (objReader.Read())
            {
                list.Add(new TimesManage()
                {
                    TimesName = objReader["TimesName"].ToString(),
                    WorkTime = objReader["WorkTime"].ToString(),
                    OffDutyTime = objReader["OffDutyTime"].ToString(),
                    StartCheckIn = objReader["StartCheckIn"].ToString(),
                    EndCheckIn = objReader["EndCheckIn"].ToString(),
                    StartSignBack = objReader["StartSignBack"].ToString(),
                    EndSignBack = objReader["EndSignBack"].ToString(),
                    LateTime = Convert.ToInt32(objReader["LateTime"]),
                    LeftEarly = Convert.ToInt32(objReader["LeftEarly"]),
                });
            }

            return list;

        }


        /// <summary>
        /// 获取员工姓名
        /// </summary>
        /// <param name="AttId">考勤Id</param>
        /// <returns>员工姓名</returns>
        public string GetStaffName(int AttId)
        {
            string sql = "select SfName from Staffs where SfId={0}";
            sql = string.Format(sql, AttId);

            return SQLHelper.GetSingleResult(sql).ToString();//返回员工姓名
        }


        /// <summary>
        /// 获取员工的组别名称
        /// </summary>
        /// <param name="SfId">员工Id</param>
        /// <returns>组别名称</returns>
        public string GetSfGroupName(int SfId)
        {
            string sql = "select SfGroup from staffs where SfId={0}" + SfId;
            sql = string.Format(sql);
            var result = SQLHelper.GetSingleResult(sql).ToString();

            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// 获取员工班次
        /// </summary>
        /// <param name="StaffId">考勤Id</param>
        /// <returns>员工班次名称</returns>
        public string GetClassesName(int StaffId)
        {
            string sql = "select SfShifts from Staffs where SfId={0}";
            sql = string.Format(sql, StaffId);

            var result = SQLHelper.GetSingleResult(sql);

            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取时段名称
        /// </summary>
        /// <param name="ClassesName">班次名称</param>
        /// <returns>时段名称List</returns>
        public List<ClassesTimes> GetTimesName(string ClassesName)
        {
            string sql = "select * from ClassesTimes where ClassesName='{0}'";
            sql = string.Format(sql, ClassesName);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<ClassesTimes> list = new List<ClassesTimes>();
            while (objReader.Read())
            {
                list.Add(new ClassesTimes()
                {
                    ClassesName = objReader["ClassesName"].ToString(),
                    TimesName1 = objReader["TimesName1"].ToString(),
                    TimesName2 = objReader["TimesName2"].ToString(),
                    TimesName3 = objReader["TimesName3"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 查询日报
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetDayReport(DateTime BeginDate,DateTime EndDate)
        {
            string sql = "select * from DayReport where AtDate>='{0}' and AtDate<='{1}'";
            sql = string.Format(sql,BeginDate,EndDate);
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 按考勤状态查询日报
        /// </summary>
        /// <param name="BeginDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="AtState">考勤状态</param>
        /// <returns>考勤日报</returns>
        public DataSet GetDayResult(DateTime BeginDate, DateTime EndDate, int AtState)
        {
            string sql = "select * from DayReport where AtDate >= '{0}' and AtDate <= '{1}' and AtState != {2}";
            sql = string.Format(sql,BeginDate,EndDate,AtState);
            return SQLHelper.GetDataSet(sql);
        }

    }
}
