using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Inertia;
using Microsoft.Win32;

namespace Scheduler
{
    public partial class App : Form
    {
        public static App Instance { get; private set; }

        private const int _scrollMargin = 25;
        private const string _dbPath = "schedulers.db";
        private Dictionary<int, SchedulerElementData> _dataDict;
        private Dictionary<int, SchedulerElement> _controlDict;
        private List<SchedulerNotification> _notifications;

        public App()
        {
            InitializeComponent();

            _dataDict = new Dictionary<int, SchedulerElementData>();
            _controlDict = new Dictionary<int, SchedulerElement>();
            _notifications = new List<SchedulerNotification>();

            var notifyMenu = new ContextMenuStrip();

            var quitItem = notifyMenu.Items.Add("Quit");
            quitItem.Click += (sender, e) => Close();

            notifyIcon.ContextMenuStrip = notifyMenu;

            notifyIcon.DoubleClick += (sender, e) =>
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            };
            notifyIcon.BalloonTipClicked += (sender, e) =>
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            };

            Resize += (sender, e) =>
            {
                if (WindowState == FormWindowState.Minimized)
                    ShowInTaskbar = false;
            };

            SetStartup();
            Instance = this;
        }

        private void App_Load(object sender, EventArgs e)
        {
            mainContainer.Location = new Point(0, newButton.Location.Y + newButton.Size.Height + 10);
            mainContainer.Size = new Size(Width - _scrollMargin, Height - mainContainer.Location.Y - _scrollMargin * 2);

            LoadDb();

            schedulerTimer.Start();
        }

        public void OnCreatorClosed(SchedulerCreator creator)
        {
            Controls.Remove(creator);
            newButton.Visible = true;
        }
        public void RegisterScheduler(string title, string details, DateTime datetime, Color color)
        {
            var data = new SchedulerElementData(RetrieveId(), title, details, datetime, color);
            _dataDict.Add(data.Id, data);

            CreateSchedulerElement(data);
            SaveDb();
        }
        public void DeleteScheduler(int id)
        {
            try
            {
                var ctrl = _controlDict[id];

                _dataDict.Remove(id);
                _controlDict.Remove(id);

                SaveDb();

                ctrl.Parent = null;
                Controls.Remove(ctrl);

                _notifications.RemoveAll((notif) => notif.SchedulerData.Id == id);

                if (_controlDict.Count < 4)
                {
                    foreach (var c in _controlDict.Values)
                        c.Size = new Size(mainContainer.Size.Width - 6, ctrl.Size.Height);
                }
            }
            catch
            {
                MessageBox.Show("An Error occured when trying to delete the Scheduler");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var creator = new SchedulerCreator();

            creator.Size = mainContainer.Size;
            creator.Location = mainContainer.Location;
            creator.Parent = this;

            Controls.Add(creator);
            creator.BringToFront();

            newButton.Visible = false;
        }

        private void CreateSchedulerElement(SchedulerElementData data)
        {
            var element = new SchedulerElement();

            element.Id = data.Id;
            element.titleLabel.Text = data.Title;
            element.detailsLabel.Text = data.Details;
            element.dateLabel.Text = data.Time.ToString("MM/dd/yyyy @ hh:mm");
            element.SetColor(data.Color);

            var margin = 6;
            if (_controlDict.Count >= 4)
                margin = _scrollMargin;

            element.Size = new Size(mainContainer.Size.Width - margin, element.Size.Height);
            var lastElement = (Control)null;
            if (mainContainer.Controls.Count > 0)
                lastElement = mainContainer.Controls[mainContainer.Controls.Count - 1];

            element.Parent = mainContainer;
            if (lastElement != null)
                element.Location = new Point(0, lastElement.Location.Y + lastElement.Size.Height);
            else
                element.Location = new Point();

            _controlDict.Add(data.Id, element);

            var notif = new SchedulerNotification(data);

            if (notif.GetMinuteToWait() <= 0)
            {
                notif.Notified = true;
                element.SetCompleted();
            }

            _notifications.Add(notif);

            if (_controlDict.Count >= 4)
            {
                foreach (var ctrl in _controlDict.Values)
                    ctrl.Size = new Size(mainContainer.Size.Width - _scrollMargin, element.Size.Height);
            }
        }
        private int RetrieveId()
        {
            var id = 1;

            while (true)
            {
                if (_dataDict.ContainsKey(id))
                {
                    id++;
                    continue;
                }

                return id;
            }
        }

        private void LoadDb()
        {
            if (!File.Exists(_dbPath))
                SaveDb();

            using (BasicReader reader = new BasicReader(File.ReadAllBytes(_dbPath)))
            {
                var count = reader.GetInt();
                for (var i = 0; i < count; i++)
                {
                    var elem = reader.DeserializeObject<SchedulerElementData>();
                    _dataDict.Add(elem.Id, elem);

                    CreateSchedulerElement(elem);
                }
            }
        }
        private void SaveDb()
        {
            using (BasicWriter writer = new BasicWriter())
            {
                writer
                    .SetInt(_dataDict.Count)
                    .SetSerializableObjects(_dataDict.Values);

                File.WriteAllBytes(_dbPath, writer.ToArray());
            }
        }

        private void schedulerTimer_Tick(object sender, EventArgs e)
        {
            var notifs = _notifications.ToArray();

            foreach (var notif in notifs)
            {
                if (notif.Notified)
                    continue;

                if (notif.GetMinuteToWait() <= 0)
                {
                    var data = notif.SchedulerData;
                    notif.Notified = true;

                    if (_controlDict.TryGetValue(data.Id, out SchedulerElement element))
                        element.SetCompleted();

                    notifyIcon.ShowBalloonTip(10, data.Title, data.Details, ToolTipIcon.Info);
                }
            }
        }

        private void SetStartup()
        {
            var rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk.GetValue("Scheduler") == null)
                rk.SetValue("Scheduler", Application.ExecutablePath);
        }
    }
}