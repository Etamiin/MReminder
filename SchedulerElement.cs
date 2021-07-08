using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class SchedulerElement : UserControl
    {
        public int Id { get; set; }

        public SchedulerElement()
        {
            InitializeComponent();
        }

        private void SchedulerElement_Load(object sender, EventArgs e)
        {

        }

        public void SetColor(Color color)
        {
            colorBox.BackColor = color;
            deleteButton.FlatAppearance.BorderColor = color;
            completeButton.FlatAppearance.BorderColor = color;
        }
        public void SetCompleted()
        {
            completeButton.Visible = true;
            deleteButton.Visible = false;
            dateLabel.Text = dateLabel.Text + " (Time limit exceeded)";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            App.Instance.DeleteScheduler(Id);
            DestroyHandle();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you have completed this task?", "Task Completed ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                deleteButton_Click(sender, e);
        }
    }
}
