using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Models;

namespace DAL
{
    /// <summary>
    /// 从Excel中导入数据
    /// </summary>
    public class ImportDataFromExcel
    {
        /// <summary>
        /// 从Excel文件中读取数据
        /// </summary>
        /// <returns></returns>
        public static List<Staff> GetStudentByExcel(string path)
        {
            List<Staff> list = new List<Staff>();
            DataSet ds = OleDbHelper.GetDataSet("select * from [Sheet1$] ", path);
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Staff()
                {
                    SfId = row["工号"].ToString(),
                    SfAttCardNo=row["卡号"].ToString(),
                    SfDepartmentName = row["部门"].ToString(),
                    SfDtGroupName = row["组别"].ToString(),
                    SfJobName = row["职位"].ToString(),
                    SfName = row["姓名"].ToString(),
                    SfGender = row["性别"].ToString(),
                    SfMarriage = row["婚姻"].ToString(),
                    SfEducation = row["学历"].ToString(),
                    SfMajor = row["专业"].ToString(),
                    SfNativePlace = row["籍贯"].ToString(),
                    SfNation = row["民族"].ToString(),
                    SfMobilePhone = row["手机"].ToString(),
                    SfIntroducer = row["介绍人"].ToString(),
                    SfEntryDate = Convert.ToDateTime(row["入职日期"]),
                    SfBirthDate = Convert.ToDateTime(row["出生日期"]),
                    SfDomicile = row["户籍地址"].ToString(),
                    SfResidence = row["现居住地"].ToString(),
                    SfIdCard = row["身份证"].ToString(),
                    SfFriend = row["紧急联络人"].ToString(),
                    SfRelation=row["联络关系"].ToString(),
                    SfFriendsPhone=row["联络电话"].ToString(),
                    SfStatus = row["在职状态"].ToString(),
                    WorkShift = row["轮班班次"].ToString(),
                    SfShift = Convert.ToInt32(row["轮班标记"])
                });
            }
            return list;
        }
        /// <summary>
        /// 将集合中的对象插入到数据库
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool Import(List<Staff> list)
        {
            List<string> sqlList = new List<string>();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Staffs(SfId,SfCardNo,SfDepartment,SfGroup,SfJobName,");
            sqlBuilder.Append("SfName,SfGender,SfMarriage,SfEducation,SfMajor,SfNativePlace,SfNation,");
            sqlBuilder.Append("SfPhone,SfEntryDate,SfBirthDate,SfDomicile,SfResidence,SfIdCard,SfIntroducer,");
            sqlBuilder.Append("SfFriend,SfRelation,SfFriendsPhone,SfStatus,WorkShift,SfShift)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',");
            sqlBuilder.Append("'{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}',{24})");
            foreach (Staff objStaff in list)
            {
                string sql = string.Format(sqlBuilder.ToString(), objStaff.SfId, objStaff.SfAttCardNo, objStaff.SfDepartmentName, 
                    objStaff.SfDtGroupName, objStaff.SfJobName, objStaff.SfName, objStaff.SfGender, objStaff.SfMarriage, 
                    objStaff.SfEducation, objStaff.SfMajor, objStaff.SfNativePlace, objStaff.SfNation, objStaff.SfMobilePhone,
                    objStaff.SfEntryDate, objStaff.SfBirthDate, objStaff.SfDomicile, objStaff.SfResidence, objStaff.SfIdCard, 
                    objStaff.SfIntroducer, objStaff.SfFriend, objStaff.SfRelation, objStaff.SfFriendsPhone, objStaff.SfStatus, 
                    objStaff.WorkShift, objStaff.SfShift);

                sqlList.Add(sql);
            }
            return SQLHelper.UpdateByTran(sqlList);
        }
    }
}