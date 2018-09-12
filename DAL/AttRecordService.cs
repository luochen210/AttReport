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
        #region 查询数据库的考勤记录
        /// <summary>
        /// 查询数据库的考勤记录
        /// </summary>
        /// <param name="MachineId"></param>
        /// <param name="ClockId"></param>
        /// <param name="VerifyMode"></param>
        /// <param name="InOutMode"></param>
        /// <param name="ClockRecord"></param>
        /// <returns></returns>
        public string GetAttRecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "select * from OriginalLog where MachineId={0} and ClockId={1} and VerifyMode={2} and InOutMode={3} and ClockRecord='{4}'";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.GetSingleResult(sql);
            return sql;
        }
        #endregion

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

            return ClockRecord;
        }

        #endregion

        #region 查询OriginalLog表的ClockRecord
        /// <summary>
        /// 查询打卡时间
        /// </summary>
        /// <param name="ClockRecord">打卡时间</param>
        /// <returns>打卡时间</returns>
        public string GetClockRecord(string ClockRecord)
        {
            string sql = "select * from OriginalLog where ClockRecord='{0}'";
            sql = string.Format(sql, ClockRecord);

            SQLHelper.GetSingleResult(sql);
            return ClockRecord;
        }
        #endregion

        //public List<AttRecord> GetStuByDate(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        //{
        //    string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
        //    sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);
        //    SqlDataReader objReader = SQLHelper.GetReader(sql);
        //    List<AttRecord> list = new List<AttRecord>();
        //    while (objReader.Read())
        //    {
        //        list.Add(new AttRecord()
        //        {
        //            MachineId = Convert.ToInt32(objReader["MachineId"]),
        //            ClockId = Convert.ToInt32(objReader["ClockId"]),
        //            VerifyMode = Convert.ToInt32(objReader["VerifyMode"]),
        //            InOutMode = Convert.ToInt32(objReader[" InOutMode"]),
        //            ClockRecord = objReader["ClockRecord"].ToString()
        //            //DTime = Convert.ToDateTime(objReader["DTime"])
        //        });
        //    }
        //    return list;

        //}
    }
}
