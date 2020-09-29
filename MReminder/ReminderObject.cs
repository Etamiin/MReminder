using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MReminder
{
    public partial class ReminderObject : UserControl
    {
        public ReminderData Data { get; set; }

        private Color m_baseButtonColor;
        public Dictionary<DayOfWeek, bool> m_activeDays { get; set; }

        public ReminderObject() : this(MReminderManager.CreateEmptyData())
        {
        }
        public ReminderObject(ReminderData data)
        {
            Data = data;
            InitializeComponent();
        }

        public void RemoveThisDay()
        {
            var day = DateTime.Now.DayOfWeek;
            switch (day)
            {
                case DayOfWeek.Monday:
                    mondayButton_Click(this, null);
                    break;
                case DayOfWeek.Tuesday:
                    tuesdayButton_Click(this, null);
                    break;
                case DayOfWeek.Wednesday:
                    wednesdayButton_Click(this, null);
                    break;
                case DayOfWeek.Thursday:
                    thursdayButton_Click(this, null);
                    break;
                case DayOfWeek.Friday:
                    fridayButton_Click(this, null);
                    break;
                case DayOfWeek.Saturday:
                    saturdayButton_Click(this, null);
                    break;
                case DayOfWeek.Sunday:
                    sundayButton_Click(this, null);
                    break;
            }

            updateButton_Click(this, null);
        }

        private void ReminderObject_Load(object sender, EventArgs e)
        {
            m_baseButtonColor = mondayButton.BackColor;
            m_activeDays = new Dictionary<DayOfWeek, bool>();

            titleBox.Text = Data.Title;
            descriptionBox.Text = Data.Description;
            hourBox.Text = Data.Time[0].ToString();
            minBox.Text = Data.Time[1].ToString();
            colorDialog.Color = Data.Color;
            repeatCheck.Checked = Data.Repeat;

            RecreateLocalDays();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            var colorResult = colorDialog.ShowDialog();
            if (colorResult == DialogResult.OK) {
                BackColor = colorDialog.Color;
                colorButton.BackColor = colorDialog.Color;

                var subColor = CreateSubColor(colorDialog.Color);

                hourBox.BackColor = subColor;
                minBox.BackColor = subColor;
                descriptionBox.BackColor = subColor;
                titleBox.BackColor = subColor;

                OnCheckForUpdates();
            }
        }

        private void mondayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Monday, mondayButton);
        }
        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Tuesday, tuesdayButton);
        }
        private void wednesdayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Wednesday, wednesdayButton);
        }
        private void thursdayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Thursday, thursdayButton);
        }
        private void fridayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Friday, fridayButton);
        }
        private void saturdayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Saturday, saturdayButton);
        }
        private void sundayButton_Click(object sender, EventArgs e)
        {
            OnDayChange(DayOfWeek.Sunday, sundayButton);
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            OnCheckForUpdates();
        }
        private void hourBox_TextChanged(object sender, EventArgs e)
        {
            OnCheckForUpdates();
        }
        private void minBox_TextChanged(object sender, EventArgs e)
        {
            OnCheckForUpdates();
        }
        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            OnCheckForUpdates();
        }

        private void repeatCheck_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckForUpdates();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(hourBox.Text, out Data.Time[0]) || Data.Time[0] > 23) {
                MessageBox.Show("Invalid hours value (" + hourBox.Text + ") max is 23", "Hours error", MessageBoxButtons.OK);
                return;
            }
            else if (!byte.TryParse(minBox.Text, out Data.Time[1]) || Data.Time[1] > 59) {
                MessageBox.Show("Invalid minutes value (" + minBox.Text + ") max is 59", "Minutes error", MessageBoxButtons.OK);
                return;
            }

            Data.Title = titleBox.Text;
            Data.Description = descriptionBox.Text;
            Data.Repeat = repeatCheck.Checked;
            Data.ActiveDays = m_activeDays;
            Data.Color = colorDialog.Color;

            m_activeDays = new Dictionary<DayOfWeek, bool>();
            RecreateLocalDays();

            MReminderManager.Update(this);
            updateButton.Visible = false;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            MReminderManager.Delete(this);
        }

        //Refresh days data
        private void RecreateLocalDays()
        {
            var keys = Data.ActiveDays.Keys.ToArray();

            foreach (var key in keys)
            {
                m_activeDays.Add(key, Data.ActiveDays[key]);

                if (Data.ActiveDays[key])
                {
                    switch (key)
                    {
                        case DayOfWeek.Monday:
                            OnDayChange(key, mondayButton, false);
                            break;
                        case DayOfWeek.Tuesday:
                            OnDayChange(key, tuesdayButton, false);
                            break;
                        case DayOfWeek.Wednesday:
                            OnDayChange(key, wednesdayButton, false);
                            break;
                        case DayOfWeek.Thursday:
                            OnDayChange(key, thursdayButton, false);
                            break;
                        case DayOfWeek.Friday:
                            OnDayChange(key, fridayButton, false);
                            break;
                        case DayOfWeek.Saturday:
                            OnDayChange(key, saturdayButton, false);
                            break;
                        case DayOfWeek.Sunday:
                            OnDayChange(key, sundayButton, false);
                            break;
                    }
                }
            }
        }
        private void OnDayChange(DayOfWeek day, Button button, bool changeValue = true)
        {
            if (changeValue)
                m_activeDays[day] = !m_activeDays[day];
            button.BackColor = m_activeDays[day] ? CreateSubColor(button.BackColor) : m_baseButtonColor;

            OnCheckForUpdates();
        }
        //Check for activate Update button
        private void OnCheckForUpdates()
        {
            updateButton.Visible =
                titleBox.Text != Data.Title ||
                hourBox.Text != Data.Time[0].ToString() ||
                minBox.Text != Data.Time[1].ToString() ||
                descriptionBox.Text != Data.Description ||
                repeatCheck.Checked != Data.Repeat ||
                colorDialog.Color != Data.Color;

            if (!updateButton.Visible) {
                var dayChange = false;

                foreach (var pair in m_activeDays)
                {
                    if (m_activeDays[pair.Key] != Data.ActiveDays[pair.Key]) {
                        dayChange = true;
                        break;
                    }
                }

                updateButton.Visible = dayChange;
            }
        }

        private Color CreateSubColor(Color color, byte difference = 55)
        {
            var subColor = Color.FromArgb(
                color.R + (color.R > difference ? -difference : difference),
                color.G + (color.G > difference ? -difference : difference),
                color.B + (color.B > difference ? -difference : difference));

            return subColor;
        }
    }
}