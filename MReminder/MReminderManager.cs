using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Inertia;
using MReminder;
using System.Windows.Forms;
using Inertia.Realtime;

public static class MReminderManager
{
    public static int Count => m_datas.Count;

    private static Dictionary<uint, ReminderData> m_datas;
    private static bool m_initialized;
    private static Random m_random;
    private static ScriptCollection m_collection;
    
    //Initialize manager
    public static void Initialize()
    {
        if (m_initialized)
            return;

        m_datas = new Dictionary<uint, ReminderData>();
        m_random = new Random();
        m_collection = new ScriptCollection();

        var filePath = @"reminders.dat";

        if (!File.Exists(filePath))
            SaveFile(true);

        using (BasicReader reader = new BasicReader(File.ReadAllBytes(filePath))) {
            var count = reader.GetUInt();
            for (var i = 0; i < count; i++) {
                var data = new ReminderData(reader);
                m_datas.Add(data.Id, data);

                Main.SendMessage((main) => main.CreateReminder(data));
            }
        }

        var checker = m_collection.Add<ReminderChecker>();
        checker.OnListUpdated(m_datas.Values.ToArray());

        m_initialized = true;
    }
    
    //Create a new reminder data with empty datas
    public static ReminderData CreateEmptyData()
    {
        if (!m_initialized)
            Initialize();

        var min = 15000;
        var id = (uint)0;
        while (id == 0 || m_datas.ContainsKey(id)) {
            id = (uint)m_random.Next(min, int.MaxValue - min);
        }

        return new ReminderData(id);
    }

    //Add, update or delete reminders from memory
    public static void Add(ReminderData data)
    {
        if (!m_initialized)
            Initialize();

        if (m_datas.ContainsKey(data.Id))
            return;

        Main.SendMessage((main) => main.CreateReminder(data));

        m_datas.Add(data.Id, data);
        SaveFile();
    }
    public static void Update(ReminderObject reminder)
    {
        if (!m_initialized)
            Initialize();

        m_datas[reminder.Data.Id] = reminder.Data;
        SaveFile();
    }
    public static void Delete(ReminderObject reminder)
    {
        if (!m_initialized)
            Initialize();

        if (!m_datas.ContainsKey(reminder.Data.Id))
            return;

        Main.SendMessage((main) => main.DestroyReminder(reminder.Data));

        m_datas.Remove(reminder.Data.Id);
        SaveFile();
    }

    //Notify reminder on main form
    public static void Notify(ReminderData data)
    {
        Main.SendMessage((main) => main.NotifyReminder(data));

        if (!data.Repeat) {
            data.ActiveDays[DateTime.Now.DayOfWeek] = false;
            SaveFile();
        }
    }

    //Resave file with new data
    public static void SaveFile(bool firstTime = false)
    {
        var filePath = @"reminders.dat";

        if (!File.Exists(filePath) && !firstTime)
        {
            MessageBox.Show("File 'reminders.dat' don't exist, critical error", "Data file don't exist", MessageBoxButtons.OK);
            Main.SendMessage((main) => main.Close());
            return;
        }

        using (BasicWriter writer = new BasicWriter())
        {
            writer.SetUInt((uint)m_datas.Count);
            foreach (var data in m_datas.Values)
                data.Serialize(writer);

            File.WriteAllBytes(filePath, writer.ToArray());
        }

        if (ReminderChecker.Instance != null)
            ReminderChecker.Instance.OnListUpdated(m_datas.Values.ToArray());
    }
}