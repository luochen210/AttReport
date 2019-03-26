using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class SfShiftSetService
    {
        /// <summary>
        /// 获取在职员工
        /// </summary>
        /// <returns></returns>
        public DataSet GetSfShiftSet(string SfDepartment)
        {
            string sql = "select SfId,SfDepartment,SfGroup,SfJobName,SfName,SfGender,SfStatus,WorkShift,SfShift from Staffs where SfStatus='在职' and SfDepartment={0}";
            string.Format(sql,SfDepartment);
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 获得部门列表
        /// </summary>
        /// <returns></returns>
        public List<SfShiftSet> GetALLDepartment()
        {
            string sql = "select DepartmentId,DepartmentName from Department";
            string.Format(sql);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<SfShiftSet> list = new List<SfShiftSet>();
            while (objReader.Read())
            {
                list.Add(new SfShiftSet()
                {
                    DepartmentId = Convert.ToInt32(objReader["DepartmentId"]),
                    DepartmentName = objReader["CompanyId"].ToString()
                });
            }
            objReader.Close();
            return list;            
        }

    }
}
