using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkoutPlanner
{
    public class Workout
    {
        public string Name { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public List<WorkoutPart> Parts { get; set; }

        public Workout()
        {
            Parts = new List<WorkoutPart>();
        }

        public Workout(string name)
            : this()
        {
            this.Name = name;
        }

        public Workout(WorkoutType workoutType)
            : this()
        {
            WorkoutType = workoutType;

            switch (workoutType)
            {
                case WorkoutType.KiBox:
                    Name = string.Format(WorkoutResources.KiBoxTitle, DateTime.Now.Month >= 6 ? WorkoutResources.Spring : WorkoutResources.Autumn, DateTime.Now.Year);
                    break;
                case WorkoutType.Workout:
                    Name = string.Format(WorkoutResources.WorkoutTitle, DateTime.Now.Month >= 6 ? WorkoutResources.Spring : WorkoutResources.Autumn, DateTime.Now.Year);
                    break;
            }
        }

        public WorkoutPart AddPart(string name)
        {
            WorkoutPart part = new WorkoutPart(name);
            Parts.Add(part);

            return part;
        }

        public void MovePart(int fromIndex, int toIndex)
        {
            WorkoutPart part = Parts[fromIndex];
            Parts.Remove(part);
            Parts.Insert(toIndex, part);
        }

        public void DeletePart(WorkoutPart part)
        {
            Parts.Remove(part);
        }

        public List<object> GetWorkoutObjectList()
        {
            List<object> result = new List<object>();
            result.Add(this);
            foreach (var part in Parts)
            {
                result.Add(part);

                foreach (var song in part.Songs)
                {
                    result.Add(song);
                }
            }

            return result;
        }

        public List<string> GetWorkoutAsText()
        {
            int trackIndex = 1;
            List<string> result = new List<string>();

            result.Add(Name);
            result.Add("".PadLeft(99, '-'));

            foreach (var part in Parts)
            {
                result.Add(part.ToString());

                foreach (var song in part.Songs)
                {
                    song.Track = trackIndex;
                    trackIndex++;
                    result.Add(song.ToString());
                }

                result.Add(string.Empty);
            }

            return result;
        }
    }
}
