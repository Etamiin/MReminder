using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inertia;

public class ReminderData
{
    public uint Id { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Repeat { get; set; } = true;
    public byte[] Time { get; set; }
    public Color Color { get; set; }
    public Dictionary<DayOfWeek, bool> ActiveDays { get; set; }

    public byte Hours => Time[0];
    public byte Minutes => Time[1];

    //Constructors with empty data or from deserializing data
    public ReminderData(uint id)
    {
        Id = id;
        Title = "No title";
        Description = "No description";
        Time = new byte[2];
        Color = Color.FromArgb(246, 71, 64);
        ActiveDays = new Dictionary<DayOfWeek, bool>()
        {
            { DayOfWeek.Monday, false },
            { DayOfWeek.Tuesday, false },
            { DayOfWeek.Wednesday, false },
            { DayOfWeek.Thursday, false },
            { DayOfWeek.Friday, false },
            { DayOfWeek.Saturday, false },
            { DayOfWeek.Sunday, false }
        };
    }
    public ReminderData(BasicReader reader)
    {
        ActiveDays = new Dictionary<DayOfWeek, bool>();
        Deserialize(reader);
    }

    //Serialize and deserialize methods for data structure
    public void Serialize(BasicWriter writer)
    {
        writer
            .SetUInt(Id)
            .SetString(Title)
            .SetString(Description)
            .SetBool(Repeat)
            .SetBytes(Time)
            .SetBytes(new byte[] { Color.R, Color.G, Color.B });

        writer.SetByte((byte)ActiveDays.Count);
        foreach (var pair in ActiveDays) {
            writer
                .SetByte((byte)pair.Key)
                .SetBool(pair.Value);
        }
    }
    public void Deserialize(BasicReader reader)
    {
        Id = reader.GetUInt();
        Title = reader.GetString();
        Description = reader.GetString();
        Repeat = reader.GetBool();
        Time = reader.GetBytes();

        var colorBytes = reader.GetBytes();
        Color = Color.FromArgb(colorBytes[0], colorBytes[1], colorBytes[2]);

        var daysCount = reader.GetByte();
        for (var i = 0; i < daysCount; i++) {
            ActiveDays.Add((DayOfWeek)reader.GetByte(), reader.GetBool());
        }
    }
}