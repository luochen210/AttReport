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
    public class OrganizationService
    {
        //获取公司名
        public string GetCompany()
        {
            string sql = "select CompanyName from Company";
            try
            {
                string result = SQLHelper.GetSingleResult(sql).ToString();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //获取所有公司集合
        public List<Organization> GetAllCompany()
        {
            string sql = "select * from Company";

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Organization> list = new List<Organization>();
            while (objReader.Read())
            {
                list.Add(new Organization()
                {
                    CompanyName = objReader["CompanyName"].ToString(),
                    CompanyId = Convert.ToInt32(objReader["CompanyId"]),
                });
            }
            objReader.Close();
            return list;
        }

        //获取公司数据集
        public DataSet GetCompanyDs()
        {
            string sql = "select * from Company";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据公司名获得部门列表
        /// </summary>
        /// <param name="CompanyName"></param>
        /// <returns></returns>
        public List<Organization> GetDepartmentList(String CompanyName)
        {
            string sql = "select DepartmentName,DepartmentId from Department where CyId=(select CompanyId from Company where CompanyName='{0}')";
            sql = string.Format(sql, CompanyName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Organization> list = new List<Organization>();
            while (objReader.Read())
            {
                list.Add(new Organization()
                {
                    DepartmentName = objReader["DepartmentName"].ToString(),
                    DepartmentId = Convert.ToInt32(objReader["DepartmentId"]),
                });
            }
            objReader.Close();
            return list;
        }

        public DataSet GetDepartmentDs(String CompanyName)
        {
            string sql = "select DepartmentName,DepartmentId from Department where CyId=(select CompanyId from Company where CompanyName='{0}')";
            sql = string.Format(sql, CompanyName);
            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 根据部门获取组别名称
        /// </summary>
        /// <param name="DepartmentName">部门名称</param>
        /// <returns>返回属于部门的组别名称集合</returns>
        public List<Organization> GetAllGroupList(string DepartmentName)
        {
            string sql = "select DtGroupId,DtGroupName from DtGroup where DtId = (select DepartmentId from Department where DepartmentName = '{0}')";
            sql = string.Format(sql, DepartmentName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Organization> list = new List<Organization>();
            while (objReader.Read())
            {
                list.Add(new Organization()
                {
                    DtGroupName = objReader["DtGroupName"].ToString(),
                    DtGroupId = Convert.ToInt32(objReader["DtGroupId"])
                });
            }
            objReader.Close();
            return list;
        }

        public DataSet GetGroupListDs(string DepartmentName)
        {
            string sql = "select DtGroupId,DtGroupName from DtGroup where DtId = (select DepartmentId from Department where DepartmentName = '{0}')";
            sql = string.Format(sql, DepartmentName);
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据组别读取职位列表，保存进集合
        /// </summary>
        /// <param name="DtGroupName">组别名称</param>
        /// <returns>返回属于组别的职位列表集合</returns>
        public List<Organization> GetAllJobList(string DtGroupName)
        {
            string sql = "select JobId,JobName from JobList where DpId = (select DtGroupId from DtGroup where DtGroupName = '{0}')";
            sql = string.Format(sql, DtGroupName);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Organization> list = new List<Organization>();
            while (objReader.Read())
            {
                list.Add(new Organization()
                {
                    JobName = objReader["JobName"].ToString(),
                    JobId = Convert.ToInt32(objReader["JobId"])
                });
            }
            objReader.Close();
            return list;
        }

        //查询公司是否存在
        public string GetCompanyName(string CompanyName)
        {
            string result = string.Empty;
            string sql = "select CompanyName from Company where CompanyName='{0}'";
            sql = string.Format(sql, CompanyName);
            try
            {
                var objSqlStr = SQLHelper.GetSingleResult(sql);
                if (objSqlStr!=null)
                {
                    result = objSqlStr.ToString();
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //查询部门是否存在
        public string GetDepartmentName(string DepartmentName)
        {
            string result = string.Empty;
            string sql = "select DepartmentName from Department where DepartmentName='{0}'";
            sql = string.Format(sql, DepartmentName);
            try
            {
                var objSqlStr = SQLHelper.GetSingleResult(sql);
                if (objSqlStr != null)
                {
                    result = objSqlStr.ToString();
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //查询组别是否存在
        public string GetDtGroupName(string DtGroupName)
        {
            string result = string.Empty;
            string sql = "select DtGroupName from DtGroup where DtGroupName='{0}'";
            sql = string.Format(sql, DtGroupName);
            try
            {
                var objSqlStr = SQLHelper.GetSingleResult(sql);
                if (objSqlStr!=null)
                {
                    result = objSqlStr.ToString();
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 获得公司ID
        /// </summary>
        /// <param name="CompanyName">公司名</param>
        /// <returns>返回公司ID</returns>
        public string GetCompanyId(string CompanyName)
        {
            string result = string.Empty;
            string sql = "select CompanyID from Company where CompanyName='{0}'";
            sql = string.Format(sql, CompanyName);
            try
            {
                var objSqlStr = SQLHelper.GetSingleResult(sql);
                if (objSqlStr != null)
                {
                    result = objSqlStr.ToString();
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 获得部门ID
        /// </summary>
        /// <param name="DepartmentName">部门名称</param>
        /// <returns>返回部门ID</returns>
        public string GetDepartmentId(string DepartmentName)
        {
            string result = string.Empty;
            string sql = "select DepartmentId from Department where DepartmentName='{0}'";
            sql = string.Format(sql, DepartmentName);
            try
            {
                var objSqlStr = SQLHelper.GetSingleResult(sql);
                if (objSqlStr != null)
                {
                    result = objSqlStr.ToString();
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 修改公司名
        /// </summary>
        /// <param name="newCompanyName">新公司名</param>
        /// <param name="agoCompanyName">旧公司名</param>
        /// <returns>修改结果</returns>
        public int UpdateCompany(string newCompanyName, string agoCompanyName)
        {
            StringBuilder sqlBuilder = new StringBuilder();

            sqlBuilder.Append("Update Company Set CompanyName='{0}' where CompanyName='{1}'");
            string sql = string.Format(sqlBuilder.ToString(), newCompanyName, agoCompanyName);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 插入公司
        /// </summary>
        /// <param name="objOrganization">公司</param>
        /// <returns>执行结果</returns>
        public int InsertCompany(Organization objOrganization)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Company(CompanyName)");
            sqlBuilder.Append(" values('{0}')");
            string sql = string.Format(sqlBuilder.ToString(),
                objOrganization.CompanyName);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="newDepartmentName">新部门名称</param>
        /// <param name="agoDepartmentName">旧部门名称</param>
        /// <returns>修改结果</returns>
        public int UpdateDepartment(string newDepartmentName, string agoDepartmentName)
        {
            StringBuilder objBuilder = new StringBuilder();
            objBuilder.Append("Update Department Set DepartmentName='{0}' where DepartmentName='{1}'");
            string sql = string.Format(objBuilder.ToString(), newDepartmentName, agoDepartmentName);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 插入部门
        /// </summary>
        /// <param name="objOrganization">部门对象</param>
        /// <returns>插入结果</returns>
        public int InsertDepartment(Organization objOrganization)
        {
            StringBuilder objBuilder = new StringBuilder();
            objBuilder.Append("insert into Department(DepartmentName,CyId)");
            objBuilder.Append(" values('{0}',{1})");
            string sql = string.Format(objBuilder.ToString(), objOrganization.DepartmentName, objOrganization.CyId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 修改组别名称
        /// </summary>
        /// <param name="newDtGroupName">新组别名称</param>
        /// <param name="agoDtGroupName">旧组别名称</param>
        /// <returns>修改结果</returns>
        public int UpdateDtGroup(string newDtGroupName, string agoDtGroupName)
        {
            StringBuilder objBuilder = new StringBuilder();
            objBuilder.Append("update DtGroup set DtGroupName='{0}' where DtGroupName='{1}'");
            string sql = string.Format(objBuilder.ToString(), newDtGroupName, agoDtGroupName);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 插入组别
        /// </summary>
        /// <param name="objOrganization">组别对象</param>
        /// <returns>执行结果</returns>
        public int InsertDtGroup(Organization objOrganization)
        {
            StringBuilder objBuilder = new StringBuilder();
            objBuilder.Append("insert into DtGroup (DtGroupName,DtId)");
            objBuilder.Append(" values('{0}',{1})");
            string sql = string.Format(objBuilder.ToString(), objOrganization.DtGroupName, objOrganization.DtId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="fromName">表名</param>
        /// <param name="columnName">列名</param>
        /// <param name="nodeName">节点名</param>
        /// <returns>执行结果</returns>
        public int DeleteData(string fromName, string columnName, string nodeName)
        {
            string sql = "delete from {0} where {1}='{2}'";
            sql = string.Format(sql, fromName, columnName, nodeName);

            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 获得自增列的新索引数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>新索引数</returns>
        public int GetIncNumber(string tableName)
        {
            string sql = "select IDENT_CURRENT('{0}') + 1";
            sql = string.Format(sql, tableName);
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }

    }
}
