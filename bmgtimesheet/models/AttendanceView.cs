using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmgtimesheet.models
{
   class AttendanceView
    {
        public string date;
        public string startTime;
        public string endTime;
        public string regular;
        public string overTime;
        public string holidayHours;

        public AttendanceView(string date, string startTime, string endTime, string regular, string overTime, string holidayHours)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.regular = regular;
            this.overTime = overTime;
            this.holidayHours = holidayHours;
        }
    }
}
