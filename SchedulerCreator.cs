using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class SchedulerCreator : UserControl
    {
        public SchedulerCreator()
        {
            InitializeComponent();

            CreatePlaceholder(titleInput, "Scheduler Title");
            CreatePlaceholder(detailsInput, "Scheduler Details");

            detailsInput.TextChanged += (sender, e) => {
                lengthLabel.Text = detailsInput.Text.Length + "/" + detailsInput.MaxLength;
            };
        }

        private void SchedulerCreator_Load(object sender, EventArgs e)
        {
            dPicker.MinDate = DateTime.Now;
            tPicker.MinDate = DateTime.Now;
            tPicker.Value = DateTime.Now;
            dPicker.Value = DateTime.Now;
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorPicker.Color;

                pickColorButton.FlatAppearance.BorderColor = colorPicker.Color;
                createButton.FlatAppearance.BorderColor = colorPicker.Color;
                cancelButton.FlatAppearance.BorderColor = colorPicker.Color;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Parent = null;
            DestroyHandle();

            App.Instance.OnCreatorClosed(this);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var dv = dPicker.Value;
            var tv = tPicker.Value;
            var dt = new DateTime(dv.Year, dv.Month, dv.Day, tv.Hour, tv.Minute, 0);

            App.Instance.RegisterScheduler(titleInput.Text, detailsInput.Text, dt, colorPicker.Color);
            cancelButton_Click(sender, e);
        }

        private void CreatePlaceholder(TextBox box, string placeholder)
        {
            box.Text = placeholder;

            box.Enter += (sender, e) => {
                if (box.Text == placeholder)
                    box.Text = string.Empty;
            };

            box.Leave += (sender, e) => {
                if (string.IsNullOrEmpty(box.Text))
                    box.Text = placeholder;
            };
        }
    }
}
