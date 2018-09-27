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
        /// 用于新员工入职选择
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
                    DepartmentId = Convert.ToInt32(objReader["DepartmentID"]),
                    DepartmentName = objReader["DepartmentName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 获取所有部门保存到数据集
        ///-------------暂没使用-------------
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
        /// <returns>返回属于部门的职位列表集合</returns>
        public List<JobList> GetAllJobList(string DepartmentName)
        {
            string Groupsql = "select ";
            string sql = "select JobName,JobID from JobList where DepartmentName='{0}'";
            sql = string.Format(sql, DepartmentName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<JobList> list = new List<JobList>();
            while (objReader.Read())
            {
                list.Add(new JobList()
                {
                    JobName = objReader["JobName"].ToString(),
                    JobId = Convert.ToInt32(objReader["JobID"])
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据部门获取组别名称
        /// </summary>
        /// <param name="GroupName">组别名称</param>
        /// <returns>返回属于部门的组别名称集合</returns>
        public List<JobList> GetAllGroupList(string GroupName)
        {
            string sql = "select DtGroupName,DtGroupID from DtGroup where DtGroupName='{0}'";
            sql = string.Format(sql, GroupName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<JobList> list = new List<JobList>();
            while (objReader.Read())
            {
                list.Add(new JobList()
                {
                    WorkGroupName = objReader["DtGroupName"].ToString(),
                    WorkGroupId = Convert.ToInt32(objReader["DtGroupID"])
                });
            }
            objReader.Close();
            return list;
        }
    }
}
