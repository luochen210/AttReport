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
        #region 普通查写方法


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


        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="MachineId"></param>
        /// <param name="ClockId"></param>
        /// <param name="VerifyMode"></param>
        /// <param name="InOutMode"></param>
        /// <param name="ClockRecord"></param>
        /// <returns></returns>
        public string AddAttrecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.Update(sql);

            return ClockRecord;
        }

        #endregion



        #region DataSet查写方法

        //获取所有数据记录
        public DataSet GetAttData()
        {
            string sql = "select * from OriginalLog";

            return SQLHelper.GetDataSet(sql);
        }

        //public DataSet AddAttData(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        //{
        //    string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
        //    sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

        //    return SQLHelper.UpdateByTran(sql);
        //}
        #endregion

        #region 使用Bulk插入的实现方式
        public string SaveAttData()
        {
            Stopwatch sw = new Stopwatch();
            DataTable dt = GetTableSchema();

            SqlConnection conn = new SqlConnection(SQLHelper.connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            bulkCopy.DestinationTableName = "OriginalLog";
                bulkCopy.BatchSize = dt.Rows.Count;
                conn.Open();
                sw.Start();


                for (int i = 0; i < totalRow; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = Guid.NewGuid();
                    dr[1] = string.Format("商品", i);
                    dr[2] = (decimal)i;
                    dt.Rows.Add(dr);
                }
                if (dt != null && dt.Rows.Count != 0)
                {
                    bulkCopy.WriteToServer(dt);
                    sw.Stop();
                }
                Console.WriteLine(string.Format("插入{0}条记录共花费{1}毫秒，{2}分钟", totalRow, sw.ElapsedMilliseconds, GetMinute(sw.ElapsedMilliseconds)));
            }
            return SaveAttData;
        }

        public static DataTable GetTableSchema()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Id",typeof(Guid)),
                    new DataColumn("Name",typeof(string)),
                    new DataColumn("Price",typeof(decimal))});
            return dt;
        }
    }
    #endregion
}
}
