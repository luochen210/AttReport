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
            string.Format(sql);

            return SQLHelper.GetDataSet(sql);
        }





    }
}
