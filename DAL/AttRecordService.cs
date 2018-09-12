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

            return ClockRecord;
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

        #region 调用存储过程保存数据

        //public string SaveAttrecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        //{
        //    string proc = "ToOriginalLog";

        //    string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
        //    sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

        //    SQLHelper.ProcUpdate(proc,sql);

        //    return sql;
        //}

        #endregion

        #region 复制表
        //public string bulkCopy(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        //{

        //    SqlBulkCopy BulkCopy = new SqlBulkCopy();
        //    BulkCopy.DestinationTableName = "OriginalLog";//要插入的表的表名
        //    BulkCopy.BatchSize = dt.Rows.Count;
        //    BulkCopy.ColumnMappings.Add("iMachineNumber", MachineId);//表中的字段名 第一个“id”是dt中的字段名，第二个“id”表中的字段名
        //    BulkCopy.ColumnMappings.Add("idwEnrollNumber", ClockId);
        //    BulkCopy.ColumnMappings.Add("idwVerifyMode", VerifyMode);
        //    BulkCopy.ColumnMappings.Add("idwInOutMode", InOutMode);
        //    BulkCopy.ColumnMappings.Add("sTime", ClockRecord);
        //    BulkCopy.WriteToServer(dt);
        //    MessageBox.Show("插入成功：" + dt.Rows.Count + "行");

        //    return ClockRecord;
        //}


        #endregion
    }
}
