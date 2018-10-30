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
        #region 查询打卡记录

        /// <summary>
        /// 查询数据库的考勤记录
        /// </summary>
        /// <param name="DatatableName">数据表名</param>
        /// <returns>数据集</returns>
        public DataSet GetALLAttRecord(string DatatableName)
        {
            string sql = "select * from '{0}'";
            sql = string.Format(sql, DatatableName);

            return SQLHelper.GetDataSet(sql);
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

            return sql;
        }

        #endregion

        #region 下载考勤记录


        #endregion

    }
}
