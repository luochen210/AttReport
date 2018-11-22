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
    public class ClassesTimesService
    {
        /// <summary>
        /// 获取班次时段表
        /// </summary>
        /// <returns></returns>
        public DataSet GetClassesDataSet()
        {
            string sql = "select * from ClassesTimes";
            sql = string.Format(sql);

            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 验证班次名称是否重复
        /// </summary>
        /// <param name="ClassesName">班次名称</param>
        /// <returns>返回数量</returns>
        public bool IsClassesNameExisted(string ClassesName)
        {
            string sql = "select count(*) from ClassesTimes where ClassesName='{0}'";
            sql=string.Format(sql, ClassesName);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            return false;
        }




        /// <summary>
        /// 保存班次对象
        /// </summary>
        /// <param name="objClasses">班次对象</param>
        /// <returns>执行结果</returns>
        public int AddClasses(ClassesTimes objClasses)
        {
            string sql = "insert into ClassesTimes values('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},{10})";

            sql = string.Format(sql, objClasses.ClassesName, objClasses.TimesName1, objClasses.TimesName2, objClasses.TimesName3,
                objClasses.Monday, objClasses.Tuesday, objClasses.Wednesday, objClasses.Thursday, objClasses.Friday,
                objClasses.Saturday, objClasses.Sunday);

            return SQLHelper.Update(sql);
        }


        public int UpdateClasses(ClassesTimes objClasses,string AgoClassesName)
        {
            StringBuilder sqlBuilder = new StringBuilder();

            sqlBuilder.Append("update ClassesTimes set ClassesName ='{0}',TimesName1 ='{1}',TimesName2 ='{2}',TimesName3 ='{3}',");
            sqlBuilder.Append("Monday={4},Tuesday={5},Wednesday={6},Thursday={7},Friday={8},Saturday={9},Sunday={10}");
            sqlBuilder.Append(" where ClassesName='{11}'");

            string sql = string.Format(sqlBuilder.ToString(), objClasses.ClassesName, objClasses.TimesName1, objClasses.TimesName2, 
                objClasses.TimesName3,objClasses.Monday, objClasses.Tuesday, objClasses.Wednesday, objClasses.Thursday, objClasses.Friday,
                objClasses.Saturday, objClasses.Sunday, AgoClassesName);

            return SQLHelper.Update(sql);
        }


    }
}
