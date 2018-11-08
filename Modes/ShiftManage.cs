using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 班次实体类
    /// </summary>
    public class ShiftManage
    {
        /// <summary>
        /// 班次ID
        /// </summary>
        public int ClassesId { get; set; }

        /// <summary>
        /// 班次名称
        /// </summary>
        public string ClassesName { get; set; }

        /// <summary>
        /// 时段名称
        /// </summary>
        public string TimesName { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        public DateTime WorkTime { get; set; }

        /// <summary>
        /// 下班时间
        /// </summary>
        public DateTime OffDutyTime { get; set; }

        /// <summary>
        /// 开始签到时间
        /// </summary>
        public DateTime StartCheckIn { get; set; }

        /// <summary>
        /// 结束签到时间
        /// </summary>
        public DateTime EndCheckIn { get; set; }

        /// <summary>
        /// 天始签退时间
        /// </summary>
        public DateTime StartSignBack { get; set; }

        /// <summary>
        /// 结束签退时间
        /// </summary>
        public DateTime EndSignBack { get; set; }

        /// <summary>
        /// 迟到时间
        /// </summary>
        public int LateTime { get; set; }

        /// <summary>
        /// 早退时间
        /// </summary>
        public int LeftEarly { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        public int DayNumber { get; set; }

        /// <summary>
        /// 星期一
        /// </summary>
        public int Monday { get; set; }

        /// <summary>
        /// 星期二
        /// </summary>
        public int Tuesday { get; set; }

        /// <summary>
        /// 星期三
        /// </summary>
        public int Wednesday { get; set; }

        /// <summary>
        /// 星期四
        /// </summary>
        public int Thursday { get; set; }

        /// <summary>
        /// 星期五
        /// </summary>
        public int Friday { get; set; }

        /// <summary>
        /// 星期六
        /// </summary>
        public int Saturday { get; set; }

        /// <summary>
        /// 星期日
        /// </summary>
        public int Sunday { get; set; }

    }
}
