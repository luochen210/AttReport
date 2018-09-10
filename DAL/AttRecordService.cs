using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Modes;

namespace DAL
{
    class AttRecordService
    {
        public AttRecord GetAttRecord(AttRecord objAttRecord)
        {
            AttRecord l = new AttRecord();
            string sql = "insert into OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockTime) values ('{0}','{0}', '{0}', '{0}', '{0}')";
            sql = string.Format(sql, l.MachineId, l.ClockId, l.VerifyMode, l.InOutMode, l.ClockTime);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
        }
        return objAttRecord;
    }
}
