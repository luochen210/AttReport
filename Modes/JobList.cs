using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 组织架构实体类
    /// </summary>
    public class JobList
    {
        //公司
        public int CompanyId { get; set; }//公司ID
        public string CompanyName { get; set; }//公司名称

        //部门
        public int DepartmentId { get; set; }//部门ID
        public string DepartmentName { get; set; }//部门名称
        public int CyId { get; set; }//关联公司ID

        //组别
        public int DtGroupId { get; set; }//工作组ID
        public string DtGroupName { get; set; }//工作组名称
        public int DtId { get; set; }//关联部门ID
        
        //职位
        public int JobId { get; set; }//职位ID
        public string JobName { get; set; }//职位名称
        public int DpId { get; set; }//关联组别ID

    }
}
