using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class AttRecordService
    {
        /// <summary>
        /// 查询原始考勤记录
        /// </summary>
        /// <param name="objAttrecord">封装了考勤ID和记录的对象</param>
        /// <returns>包含了考勤ID和记录的对象</returns>
        public string GetAttRecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "select * from OriginalLog where MachineId={0} and ClockId={1}  and VerifyMode={2}  and InOutMode={3}  and ClockRecord='{4}'";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.GetSingleResult(sql);

            return ClockRecord;
        }


        /// <summary>
        /// 写入考勤记录
        /// </summary>
        /// <param name="objAttrecord">原始考勤记录对象</param>
        /// <returns>原始考勤记录对象</returns>
        public string AddAttrecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.Update(sql);

            return ClockRecord;
        }
    }
}
