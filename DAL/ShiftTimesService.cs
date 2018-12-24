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
    /// <summary>
    /// 班次时段业务逻辑类
    /// </summary>
    public class ShiftTimesService
    {
        /// <summary>
        /// 获取班次时段表
        /// </summary>
        /// <returns></returns>
        public DataSet GetShiftTimesDataSet()
        {
            string sql = "select * from ShiftTimes";
            sql = string.Format(sql);

            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 验证班次名称是否重复
        /// </summary>
        /// <param name="ShiftName">班次名称</param>
        /// <returns>返回数量</returns>
        public bool IsShiftNameExisted(string ShiftName)
        {
            string sql = "select count(*) from ShiftTimes where ShiftName='{0}'";
            sql=string.Format(sql, ShiftName);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            return false;
        }




        /// <summary>
        /// 保存班次对象
        /// </summary>
        /// <param name="objShiftTimes">班次对象</param>
        /// <returns>执行结果</returns>
        public int AddShift(ShiftTimes objShiftTimes)
        {
            string sql = "insert into ShiftTimes values('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},{10})";

            sql = string.Format(sql, objShiftTimes.ShiftName, objShiftTimes.TimesName1, objShiftTimes.TimesName2, objShiftTimes.TimesName3,
                objShiftTimes.Monday, objShiftTimes.Tuesday, objShiftTimes.Wednesday, objShiftTimes.Thursday, objShiftTimes.Friday,
                objShiftTimes.Saturday, objShiftTimes.Sunday);

            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 修改班次对象
        /// </summary>
        /// <param name="objShift">班次对象</param>
        /// <param name="AgoShiftName">原始名称</param>
        /// <returns></returns>
        public int UpdateShift(ShiftTimes objShift, string AgoShiftName)
        {
            StringBuilder sqlBuilder = new StringBuilder();

            sqlBuilder.Append("update ShiftTimes set ShiftName ='{0}',TimesName1 ='{1}',TimesName2 ='{2}',TimesName3 ='{3}',");
            sqlBuilder.Append("Monday={4},Tuesday={5},Wednesday={6},Thursday={7},Friday={8},Saturday={9},Sunday={10}");
            sqlBuilder.Append(" where ShiftName='{11}'");

            string sql = string.Format(sqlBuilder.ToString(), objShift.ShiftName, objShift.TimesName1, objShift.TimesName2,
                objShift.TimesName3, objShift.Monday, objShift.Tuesday, objShift.Wednesday, objShift.Thursday, objShift.Friday,
                objShift.Saturday, objShift.Sunday, AgoShiftName);

            return SQLHelper.Update(sql);
        }


    }
}
