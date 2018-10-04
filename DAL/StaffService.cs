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
    public class StaffService
    {
        #region 保存员工信息

        /// <summary>
        /// 获得新增员工的工号
        /// </summary>
        /// <returns></returns>
        public string GetStaffId()
        {
            string sql = "select IDENT_CURRENT('Staffs')+1";
            
            return SQLHelper.GetSingleResult(sql).ToString();
        }

        //添加员工信息

        public int AddStaff(Staff objStaff)
        {
            //【1】编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Staffs(AttCardNo,Department,WorkGroup,Job,StaffName,Gender,Age,Seniority,Marriage,Education,Major,Nativeplace,EntryDate,BirthDate,Domicile,Residence,Introducer,Friend,Relation,FriendsPhone)");
            sqlBuilder.Append("  values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}',{9},'{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}','{19}')");
            //【2】解析对象
            string sql = string.Format(sqlBuilder.ToString(),
               objStaff.AttCardNo, objStaff.DepartmentName,objStaff.DtGroupName, objStaff.JobName, objStaff.StaffName,
               objStaff.Gender, objStaff.Age, objStaff.Seniority, objStaff.Marriage, objStaff.Education, objStaff.Major,
               objStaff.NativePlace, objStaff.EntryDate, objStaff.BirthDate, objStaff.Domicile, objStaff.Residence,
               objStaff.Introducer, objStaff.Friend, objStaff.Relation, objStaff.FriendsPhone);
            //【3】提交到数据库
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
