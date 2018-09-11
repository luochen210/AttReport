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

        public bool SaveAttData(List<AttRecord> attList)
        {
            //string insertSql = "";
            //string updateSql = "";
            //string deleteSql = "";

            //添加的sql
            StringBuilder insertSql = new StringBuilder();
            insertSql.Append("insert into  OriginalLog values");
            insertSql.Append(" (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord)");
            insertSql.Append(" values ({0},{1},{2},{3},'{4}')");

            //循环集合，生成对应的sql
            List<string> sqlList = new List<string>();
            foreach (AttRecord item in attList)
            {
                if (item.ClockRecord == ObjectStatus.Inserted)
                {
                    string sql = string.Format(insertSql.ToString(), item.StudentName,
                                         item.Gender, item.Birthday.ToString("yyyy-MM-dd"),
                                         item.StudentIdNo, item.Age,
                                         item.PhoneNumber, item.StudentAddress, item.CardNo,
                                         item.ClassId, item.StuImage);
                    sqlList.Add(sql);
                }
                else if (item.OperationStatus == ObjectStatus.Updated)
                {
                    string sql = string.Format(updateSql.ToString(), item.StudentName,
                                        item.Gender, item.Birthday.ToString("yyyy-MM-dd"),
                                        item.StudentIdNo, item.Age,
                                        item.PhoneNumber, item.StudentAddress, item.CardNo,
                                        item.ClassId, item.StuImage, item.StudentId);
                    sqlList.Add(sql);
                }
                else if (item.OperationStatus == ObjectStatus.Deleted)
                {
                    string sql = string.Format(deleteSql, item.StudentId);
                    sqlList.Add(sql);
                }
            }
            //基于事务提交多条SQL语句
            return SQLHelper.UpdateByTran(sqlList);
        }



        #endregion
    }
}
