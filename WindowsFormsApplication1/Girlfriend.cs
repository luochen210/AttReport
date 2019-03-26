using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Girlfriend
    {
        public int GfId { get; set; } //id
        public string GfName { get; set; }//员工姓名
        public string GfGender { get; set; }//员工性别
        public double GfSeniority { get; set; }//员工工龄
        public string GfMarriage { get; set; }//婚姻状态
        public int GfAge { get; set; }//员工年龄
        public string GfEducation { get; set; }//学历
        public string GfMajor { get; set; }//专业
        public string GfNativePlace { get; set; }//籍贯
        public string GfNation { get; set; }//民族
        public string GfAttCardNo { get; set; }//卡号
        public string GfMobilePhone { get; set; }//员工手机号码
        public string GfIntroducer { get; set; }//介绍人
        public DateTime GfEntryDate { get; set; }//入职日期
        public DateTime GfBirthDate { get; set; }//出生日期
        public string GfDomicile { get; set; }//户籍地址        
        public string GfResidence { get; set; }//现居住地
        public string GfIdCard { get; set; }//身份证号
        public string GfFriend { get; set; }//紧急联络人
        public string GfRelation { get; set; }//与紧急联络人的关系
        public string GfFriendsPhone { get; set; }//紧急联络人的电话
        public string GfStatus { get; set; }//在职状态
        public string WorkShift { get; set; }//轮班班次
        public int GfShift { get; set; }//轮班标记

        public int SfCompanyId { get; set; }//公司ID
        public string SfCompanyName { get; set; }//公司名称

        public int SfDepartmentId { get; set; }//部门ID
        public string SfDepartmentName { get; set; }//部门名称
        public int SfCyId { get; set; }//关联公司ID

        public int SfDtGroupId { get; set; }//工作组ID
        public string SfDtGroupName { get; set; }//工作组名称
        public int SfDtId { get; set; }//关联部门ID

        public int SfJobId { get; set; }//职位ID
        public string SfJobName { get; set; }//职位名称
        public int SfDpId { get; set; }//关联组别ID
    }
}
