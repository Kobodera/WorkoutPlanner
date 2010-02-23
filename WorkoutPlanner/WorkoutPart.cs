using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkoutPlanner
{
    public class WorkoutPart
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }

        public List<WorkoutSong> Songs;

        public WorkoutPart()
        {
            Songs = new List<WorkoutSong>();
        }

        public WorkoutPart(string name)
            : this()
        {
            this.Name = name;
        }

        public WorkoutPart(string name, string description)
            : this(name)
        {
            Description = description;
        }

        public string Length
        {
            get
            {
                int temp = 0;

                foreach (WorkoutSong song in Songs)
                {
                    temp += song.LengthInSeconds;
                }

                TimeSpan ts = new TimeSpan(0, 0, temp);

                return string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} ({1})", Name, Length));
            sb.Append("".PadLeft(99, '-'));

            return sb.ToString();
        }

        public void AddSong(WorkoutSong song)
        {
            Songs.Add(song);
        }
    }
}
