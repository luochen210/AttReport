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
    public class ShiftTimes
    {
        /// <summary>
        /// 班次ID
        /// </summary>
        public int ShiftId { get; set; }

        /// <summary>
        /// 班次名称
        /// </summary>
        public string ShiftName { get; set; }

        /// <summary>
        /// 时段名称1
        /// </summary>
        public string TimesName1 { get; set; }

        /// <summary>
        /// 时段名称2
        /// </summary>
        public string TimesName2 { get; set; }

        /// <summary>
        /// 时段名称3
        /// </summary>
        public string TimesName3 { get; set; }

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
