using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SfShiftSet
    {
        public string SfId { get; set; } //员工工号
        public string SfName { get; set; }//员工姓名
        public string SfGender { get; set; }//员工性别
        public int SfAge { get; set; }//员工年龄       
        public string SfDtGroupName { get; set; }//工作组名称
        public string SfJobName { get; set; }//职位名称
        public string SfStatus { get; set; }//在职状态
        public string WorkShift { get; set; }//轮班班次
        public int SfShift { get; set; }//轮班标记

        public int DepartmentId { get; set; }//部门Id
        public string DepartmentName { get; set; }//部门名称
    }
}
