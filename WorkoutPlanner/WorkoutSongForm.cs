using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkoutPlanner
{
    public partial class WorkoutSongForm : Form
    {
        public WorkoutSongForm()
        {
            InitializeComponent();
        }

        private WorkoutSong song;
        public WorkoutSong Song
        {
            get
            {
                if (song == null)
                {
                    song = new WorkoutSong();
                }
                song.Title = titleTextBox.Text;
                song.Album = albumTextBox.Text;
                song.Artist = artistTextBox.Text;

                int temp = 0;

                if (int.TryParse(bpm1TextBox.Text, out temp))
                {
                    song.Bpm1 = temp;
                }
                if (int.TryParse(bpm2TextBox.Text, out temp))
                {
                    song.Bpm2 = temp;
                }

                song.Seconds = GetLenghtInSeconds(lengthTextBox.Text);
                song.FromSecond = GetLenghtInSeconds(fromTextBox.Text);
                song.ToSecond = GetLenghtInSeconds(toTextBox.Text);

                if (song.FromSecond == 0)
                    song.FromSecond = null;
                if (song.ToSecond == 0)
                    song.ToSecond = null;

                return song;
            }
            set
            {
                song = value;

                titleTextBox.Text = song.Title;
                artistTextBox.Text = song.Artist;
                albumTextBox.Text = song.Album;
                bpm1TextBox.Text = song.Bpm1.HasValue ? song.Bpm1.ToString() : string.Empty;
                bpm2TextBox.Text = song.Bpm2.HasValue ? song.Bpm2.ToString() : string.Empty;
                lengthTextBox.Text = GetLengthString(song.Seconds);
                fromTextBox.Text = GetLengthString(song.FromSecond);
                toTextBox.Text = GetLengthString(song.ToSecond);
            }
        }

        private string GetLengthString(int? seconds)
        {
            if (!seconds.HasValue)
                return string.Empty;

            TimeSpan ts = new TimeSpan(0, 0, seconds.Value);

            return string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }

        private int GetLenghtInSeconds(string length)
        {
            int temp = 0;
            string[] lenghtStrings = length.Split(':', ',', '.');

            int minutes = 0;
            int seconds = 0;

            if (lenghtStrings.Length == 2)
            {
                if (int.TryParse(lenghtStrings[0], out temp))
                    minutes = temp;

                if (int.TryParse(lenghtStrings[1], out temp))
                    seconds = temp;
            }

            return minutes * 60 + seconds;
        }

    }
}
