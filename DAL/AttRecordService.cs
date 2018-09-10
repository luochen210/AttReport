using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Modes;

namespace DAL
{
    public class AttRecordService
    {
        public AttRecord GetAttRecord(AttRecord objAttRecord)
        {
            string sql = "select {0},{1},{2},{3},{4} from AttRecord where ClockTime";
            sql = string.Format(sql, objAttRecord.MachineId, objAttRecord.ClockId, objAttRecord.VerifyMode, objAttRecord.InOutMode, objAttRecord.ClockTime);

            return objAttRecord;
        }


        public AttRecord AddAttRecord(AttRecord objAttRecord)
        {
            string sql = "insert into OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockTime) values ('{0}','{1}', '{2}', '{3}', '{4}')";
            sql = string.Format(sql, objAttRecord.MachineId, objAttRecord.ClockId, objAttRecord.VerifyMode, objAttRecord.InOutMode, objAttRecord.ClockTime);

            SQLHelper.Update(sql);

            return objAttRecord;
        }
    }
}
