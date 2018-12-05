using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 打卡记录实体类
    /// </summary>
    public class AttRecord
    {        
        public int MachineId { get; set; }//机器ID

        public int ClockId { set; get; }//考勤ID

        public int VerifyMode { set; get; }//验证方式

        public int InOutMode { set; get; }//进出方式

        public string ClockRecord { get; set; }//打卡记录
    }
}
