using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkoutPlanner
{
    public class WorkoutSong
    {
        public int Track { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int? Bpm1 { get; set; }
        public int? Bpm2 { get; set; }

        public int Seconds { get; set; }

        //From the second where the song will start
        public int? FromSecond { get; set; }

        //To the second where the song will end
        public int? ToSecond { get; set; }

        public string BPM
        {
            get
            {
                string temp = Bpm1.HasValue ? Bpm1.Value.ToString() : string.Empty;

                if (temp.Length > 0 && Bpm2.HasValue)
                    temp += "_";

                temp += Bpm2.HasValue ? Bpm2.Value.ToString() : string.Empty;

                return temp;
            }
        }

        public int LengthInSeconds
        {
            get
            {
                int tempFromSecond = FromSecond.HasValue ? FromSecond.Value > Seconds ? Seconds : FromSecond.Value : 0;

                //If no to second is set then use the total length
                int tempToSecond = ToSecond.HasValue ? ToSecond.Value > Seconds ? Seconds : ToSecond.Value : Seconds;

                return tempToSecond - tempFromSecond;
            }

        }

        public string Length 
        {
            get
            {
                int tempFromSecond = FromSecond.HasValue ? FromSecond.Value > Seconds ? Seconds : FromSecond.Value : 0;

                //If no to second is set then use the total length
                int tempToSecond = ToSecond.HasValue ? ToSecond.Value > Seconds ? Seconds : ToSecond.Value : Seconds;

                TimeSpan ts = new TimeSpan(0,0, tempToSecond - tempFromSecond);

                return string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            }
        }

        public string ToShortString()
        {
            return string.Format("{0} - {1} ({2})", Title, Artist, Length);
        }

        public override string ToString()
        {
            return string.Format("{0, -3} {1, -40} {2, -38} {3, 6} {4, 8}", string.Format("{0:00}", Track), Title, Artist, Length, BPM);
        }
    }
}
