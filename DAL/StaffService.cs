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
            string sql = "select IDENT_CURRENT('{0}')+1";
            sql = string.Format(sql, "Staffs");
            
            return SQLHelper.GetSingleResult(sql).ToString();
        }

        //添加员工信息

        public int AddStaff(Staff objStaff)
        {
            //【1】编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Staffs(SfAttCardNo,SfDepartment,SfWorkGroup,SfJobName,SfName,SfGender,SfAge,SfSeniority,SfMarriage,SfEducation,SfMajor,");
            sqlBuilder.Append("SfNativeplace,SfEntryDate,SfBirthDate,SfDomicile,SfResidence,SfIntroducer,SfFriend,SfRelation,SfFriendsPhone)");
            sqlBuilder.Append("  values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}',{9},'{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}','{19}')");
            //【2】解析对象
            string sql = string.Format(sqlBuilder.ToString(),
               objStaff.SfAttCardNo, objStaff.SfDepartmentName, objStaff.SfGroupName, objStaff.SfJobName, objStaff.SfName,
               objStaff.SfGender, objStaff.SfAge, objStaff.SfSeniority, objStaff.SfMarriage, objStaff.SfEducation, objStaff.SfMajor,
               objStaff.SfNativePlace, objStaff.SfEntryDate, objStaff.SfBirthDate, objStaff.SfDomicile, objStaff.SfResidence,
               objStaff.SfIntroducer, objStaff.SfFriend, objStaff.SfRelation, objStaff.SfFriendsPhone);
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
