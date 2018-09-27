using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string sql = "select IDENT_CURRENT('Staff')+1";
            
            return SQLHelper.GetSingleResult(sql).ToString();
        }

        #endregion
    }
}
