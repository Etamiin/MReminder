using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inertia.Realtime;

public class ReminderChecker : Script
{
    public static ReminderChecker Instance { get; private set; }

    private ReminderData[] m_dataList;
    private DateTime m_lastRecheck;
    private float m_time;

    protected override void OnAwake(ScriptArgumentsCollection args)
    {
        m_dataList = new ReminderData[0];
        m_lastRecheck = DateTime.Now;
        Instance = this;
    }

    protected override void OnUpdate()
    {
        if (m_dataList.Length == 0)
            return;

        m_time += DeltaTime;
        if (m_time >= 1) {
            var now = DateTime.Now;

            if (now.Minute != m_lastRecheck.Minute)
                CheckReminders(now);

            m_lastRecheck = now;
            m_time--;
        }

        void CheckReminders(DateTime now)
        {
            foreach (var data in m_dataList) {
                if (data.ActiveDays[now.DayOfWeek]) {
                    if (data.Hours == now.Hour && data.Minutes == now.Minute) {
                        MReminderManager.Notify(data);
                    }
                }
            }
        }
    }

    public void OnListUpdated(ReminderData[] dataList)
    {
        lock (m_dataList)
            m_dataList = dataList;
    }
}