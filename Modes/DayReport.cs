using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 考勤日报实体类
    /// </summary>
    public class DayReport
    {
        public int SfId { get; set; }//员工Id
        public string SfName { get; set; }//员工姓名
        public string ShiftName { get; set; }//班次名称
        public DateTime WorkTime1 { get; set; }//上班时间1
        public DateTime OffDutyTime1 { get; set; }//下班时间1
        public DateTime WorkTime2 { get; set; }//上班时间2
        public DateTime OffDutyTime2 { get; set; }//下班时间2
        public DateTime WorkTime3 { get; set; }//上班时间3
        public DateTime OffDutyTime3 { get; set; }//下班时间3
        public double AttDay { get; set; }//考勤天数
        public int AtState { get; set; }//考勤状态
        public int AtSign { get; set; }//处理标记
    }
}
