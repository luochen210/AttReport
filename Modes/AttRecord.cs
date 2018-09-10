using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modes
{
    public class AttRecord
    {
        public int MachineId { get; set; }
        public int ClockId { set; get; }
        public int VerifyMode { get; set; }
        public int InOutMode { get; set; }
        public string ClockTime { get; set; }

    }
}
