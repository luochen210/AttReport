using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 员工实体类
    /// </summary>
    public class Staff
    {
        public string SfId { get; set; } //员工工号
        public string SfName { get; set; }//员工姓名
        public string SfGender { get; set; }//员工性别
        public double SfSeniority { get; set; }//员工工龄
        public string SfMarriage { get; set; }//婚姻状态
        public int SfAge { get; set; }//员工年龄
        public string SfEducation { get; set; }//学历
        public string SfMajor { get; set; }//专业
        public string SfNativePlace { get; set; }//籍贯
        public string SfNation { get; set; }//民族
        public string SfAttCardNo { get; set; }//卡号
        public string SfMobilePhone { get; set; }//员工手机号码
        public string SfIntroducer { get; set; }//介绍人
        public DateTime SfEntryDate { get; set; }//入职日期
        public DateTime SfBirthDate { get; set; }//出生日期
        public string SfDomicile { get; set; }//户籍地址        
        public string SfResidence { get; set; }//现居住地
        public string SfIdCard { get; set; }//身份证号
        public string SfFriend { get; set; }//紧急联络人
        public string SfRelation { get; set; }//与紧急联络人的关系
        public string SfFriendsPhone { get; set; }//紧急联络人的电话
        public string SfStatus { get; set; }//在职状态
        public string WorkShift { get; set; }//轮班班次
        public int SfShift { get; set; }//轮班标记

        //部门、职位实体类
        public int SfCompanyId { get; set; }//公司ID
        public string SfCompanyName { get; set; }//公司名称
        public int SfDepartmentId { get; set; }//部门ID
        public string SfDepartmentName { get; set; }//部门名称
        public int SfCyId { get; set; }//关联公司ID
        public int SfDtGroupId { get; set; }//工作组ID
        public string SfGroupName { get; set; }//工作组名称
        public int SfDtId { get; set; }//关联部门ID
        public int SfJobId { get; set; }//职位ID
        public string SfJobName { get; set; }//职位名称
        public int SfDpId { get; set; }//关联组别ID

    }
}
