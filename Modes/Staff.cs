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
        public int JobNo { get; set; } //员工工号
        public string StaffName { get; set; }//员工姓名
        public string Gender { get; set; }//员工性别
        public double Seniority { get; set; }//员工工龄
        public string Marriage { get; set; }//婚姻状态
        public int Age { get; set; }//员工年龄
        public string Education { get; set; }//学历
        public string Major { get; set; }//专业
        public string NativePlace { get; set; }//籍贯
        public string Nation { get; set; }//民族
        public string AttCardNo { get; set; }//卡号
        public string MobilePhone { get; set; }//员工手机号码
        public string Introducer { get; set; }//介绍人
        public DateTime EntryDate { get; set; }//入职日期
        public DateTime BirthDate { get; set; }//出生日期
        public string Domicile { get; set; }//户籍地址
        public string Residence { get; set; }//现居住地
        public string Friend { get; set; }//紧急联络人
        public string Relation { get; set; }//与紧急联络人的关系
        public string FriendsPhone { get; set; }//紧急联络人的电话

        public int CompanyId { get; set; }//公司ID
        public string CompanyName { get; set; }//公司名称

        public int DepartmentId { get; set; }//部门ID
        public string DepartmentName { get; set; }//部门名称
        public int CyId { get; set; }//关联公司ID

        public int DtGroupId { get; set; }//工作组ID
        public string DtGroupName { get; set; }//工作组名称
        public int DtId { get; set; }//关联部门ID

        public int JobId { get; set; }//职位ID
        public string JobName { get; set; }//职位名称
        public int DpId { get; set; }//关联组别ID

    }
}
