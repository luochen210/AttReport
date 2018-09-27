using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Staff
    {
        public string JobNo { get; set; } //员工工号

        public string StaffName { get; set; }//员工姓名      
        
        public bool Gender { get; set; }//员工性别

        public double Seniority { get; set; }//员工工龄

        public string Marriage { get; set; }//婚姻状态

        public int Age { get; set; }//员工年龄
        
        public string Education { get; set; }//学历
        
        public string Major { get; set; }//专业
        
        public string NativePlace { get; set; }//籍贯
        
        public string Nation { get; set; }//民族
        
        public string CardNo { get; set; }//卡号
                
        public string MobilePhone { get; set; }//员工手机号码

        public string Introducer { get; set; }//介绍人

        public DateTime EntryDate { get; set; }//入职日期

        public DateTime BirthDate { get; set; }//出生日期

        public string Address1 { get; set; }//户籍地址

        public string Address2 { get; set; }//现居住地

        public string Liaison { get; set; }//紧急联络人

        public string Relation { get; set; }//与紧急联络人的关系

        public string FriendsPhone { get; set; }//紧急联络人的电话

        public string Department { get; set; }//部门

        public string WorkGroup { get; set; }//组别

        public string Job { get; set; }//职位

    }
}
