using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 部门实体类
    /// </summary>
    public class JobList
    {
        public int DepartmentID { get; set; }//部门ID
        public string DepartmentName { get; set; }//部门名
        public int JobID { get; set; }//职位ID
        public string JobName { get; set; }//职位名称

    }
}
