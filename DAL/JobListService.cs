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
    public class JobListService
    {
        //获取部门对象
        public List<JobList> GetDepartmentList()
        {
            string sql = "select DepartmentName,DepartmentID from JobList";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<JobList> list = new List<JobList>();
            while (objReader.Read())
            {
                list.Add(new JobList()
                {
                    DepartmentID = Convert.ToInt32(objReader["DepartmentID"]),
                    DepartmentName = objReader["DepartmentName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        //获取部门数据集
        public DataSet GetAllDepartment()
        {
            string sql = "select DepartmentName,DepartmentID from JobList";
            return SQLHelper.GetDataSet(sql);
        }
    }
}
