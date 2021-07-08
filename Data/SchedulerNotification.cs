using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler
{
    public class SchedulerNotification
    {
        public readonly SchedulerElementData SchedulerData;
        public bool Notified { get; set; }

        public SchedulerNotification(SchedulerElementData data)
        {
            SchedulerData = data;
            Notified = false;
        }

        public double GetMinuteToWait()
        {
            return (SchedulerData.Time - DateTime.Now).TotalMinutes;
        }
    }
}
