using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class AttRecord
    {
        public int MachineId { get; set; }
        public int ClockId { set; get; }
        public int VerifyMode { set; get; }
        public int InOutMode { set; get; }
        public string ClockRecord { get; set; }
    }
}
