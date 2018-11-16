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
        /// 获取班次列表
        /// </summary>
        /// <returns>班次列表</returns>
        public List<ClassesTimes> GetClassList()
        {
            string sql = "select ClassesName from ClassesTimes";
            sql = string.Format(sql);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<ClassesTimes> list = new List<ClassesTimes>();
            while (objReader.Read())
            {
                list.Add(new ClassesTimes()
                {
                    ClassesName = objReader["ClassesName"].ToString(),
                    //ClassesId=Convert.ToInt32(objReader["ClassesId"])

                });

            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 获得时段1
        /// </summary>
        /// <returns></returns>
        public List<ClassesTimes> GetTimesList()
        {
            string sql = "select TimesName1 from ClassesTimes";
            sql = string.Format(sql);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<ClassesTimes> list = new List<ClassesTimes>();
            while (objReader.Read())
            {
                list.Add(new ClassesTimes()
                {
                    TimesName1=objReader["TimesName1"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }





    }
}
