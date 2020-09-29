using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Inertia;
using Microsoft.Win32;

namespace MReminder
{
    public partial class Main : Form
    {
        public static Main Instance { get; private set; }

        private bool m_forceQuit;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Instance = this;

            FormClosing += Main_FormClosing;
            Resize += Main_Resize;

            var rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValue("MReminder") == null)
                rkApp.SetValue("MReminder", Application.ExecutablePath);

            MReminderManager.Initialize();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = !m_forceQuit;
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
            }
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            var data = MReminderManager.CreateEmptyData();
            MReminderManager.Add(data);
        }

        private void quitoolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_forceQuit = true;
            Close();
        }

        //Add or remove reminder for Container and refresh
        public void DestroyReminder(ReminderData data)
        {
            for (var i = 0; i < reminderContainer.Controls.Count; i++) {
                var reminder = reminderContainer.Controls[i] as ReminderObject;

                if (reminder.Data.Id == data.Id)
                    reminderContainer.Controls.RemoveAt(i);
            }

            //reorganize childs
            var location = new Point(0, 0);
            for (var i = 0; i < reminderContainer.Controls.Count; i++) {
                var reminder = reminderContainer.Controls[i] as ReminderObject;

                reminder.Location = location;
                location.Y += reminder.Size.Height;
            }
        }
        public void CreateReminder(ReminderData data)
        {
            var lastReminder = (Control)null;
            if (reminderContainer.Controls.Count > 0)
                lastReminder = reminderContainer.Controls[reminderContainer.Controls.Count - 1];
            
            var reminder = new ReminderObject(data);

            reminderContainer.Controls.Add(reminder);
            reminder.Location = new Point(0, lastReminder == null ? 0 : lastReminder.Location.Y + reminder.Size.Height);
        }

        //Create notification from reminder
        public void NotifyReminder(ReminderData data)
        {
            var notification = new ReminderNotification();

            notification.BackColor = data.Color;
            notification.titleLabel.Text = data.Title;
            notification.descriptionLabel.Text = data.Description;
            notification.timeLabel.Text = data.Time[0] + "H" + data.Time[1] + "M";

            new Thread(() => Application.Run(notification)).Start();

            if (!data.Repeat) {
                foreach (var control in reminderContainer.Controls)
                {
                    var reminder = control as ReminderObject;
                    if (reminder.Data.Id == data.Id) {
                        reminder.RemoveThisDay();
                        break;
                    }
                }
            }
        }

        //Access Instance from other threads
        public static void SendMessage(BasicAction<Main> action)
        {
            if (Instance == null)
                return;

            Instance.Invoke(new Action(() => action(Instance)));
        }
    }
}
