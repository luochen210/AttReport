using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 时段实体类
    /// </summary>
    public class TimesManage
    {

        /// <summary>
        /// 时段名称
        /// </summary>
        public string TimesName { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        public string WorkTime { get; set; }

        /// <summary>
        /// 下班时间
        /// </summary>
        public string OffDutyTime { get; set; }

        /// <summary>
        /// 开始签到时间
        /// </summary>
        public string StartCheckIn { get; set; }

        /// <summary>
        /// 结束签到时间
        /// </summary>
        public string EndCheckIn { get; set; }

        /// <summary>
        /// 开始签退时间
        /// </summary>
        public string StartSignBack { get; set; }

        /// <summary>
        /// 结束签退时间
        /// </summary>
        public string EndSignBack { get; set; }

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
        public double DayNumber { get; set; }

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
