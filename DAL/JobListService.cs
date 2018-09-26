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
    /// 职位访问类
    /// </summary>
    public class JobListService
    {
        /// <summary>
        /// 获取所有部门保存到集合
        /// </summary>
        /// <returns>所有部门的集合</returns>
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

        /// <summary>
        /// 获取所有部门保存到数据集
        /// </summary>
        /// <returns>所有部门的数据集</returns>
        public DataSet GetAllDepartment()
        {
            string sql = "select DepartmentName,DepartmentID from JobList";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据部门读取职位列表，保存进集合
        /// </summary>
        /// <param name="DepartmentName"></param>
        /// <returns>部门所属的职位列表集合</returns>
        public List<JobList> GetAllJobList(string DepartmentName)
        {
            string sql = "select JobName,JobID from JobList where DepartmentName='{0}'";
            sql = string.Format(sql, DepartmentName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<JobList> list = new List<JobList>();
            while (objReader.Read())
            {
                list.Add(new JobList()
                {
                    JobName = objReader["JobName"].ToString(),
                    JobID = Convert.ToInt32(objReader["JobID"])
                });
            }
            objReader.Close();
            return list;
        }
    }
}
