using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Inertia;

namespace Scheduler
{
    public class SchedulerElementData : ISerializableObject
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Details { get; private set; }
        public DateTime Time { get; private set; }
        public Color Color { get; private set; }

        public SchedulerElementData(int id, string title, string details, DateTime time, Color color)
        {
            Id = id;
            Title = title;
            Details = details;
            Time = time;
            Color = color;
        }

        public void Deserialize(BasicReader reader)
        {
            Id = reader.GetInt();
            Title = reader.GetString();
            Details = reader.GetString();
            Time = new DateTime(reader.GetLong());
            Color = ColorTranslator.FromWin32(reader.GetInt());
        }
        public void Serialize(BasicWriter writer)
        {
            writer
                .SetInt(Id)
                .SetString(Title)
                .SetString(Details)
                .SetLong(Time.Ticks)
                .SetInt(ColorTranslator.ToWin32(Color));
        }
    }
}
