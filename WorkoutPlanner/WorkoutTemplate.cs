using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace WorkoutPlanner
{
    [Serializable]
    public class WorkoutTemplate
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(WorkoutTemplate));

        public string Name { get; set; }

        public List<WorkoutTemplatePart> WorkoutTemplateParts { get; set; }
        public List<WorkoutTemplateGroup> WorkoutTemplateGroups { get; set; }

        public WorkoutTemplate()
        {
            WorkoutTemplateParts = new List<WorkoutTemplatePart>();
            WorkoutTemplateGroups = new List<WorkoutTemplateGroup>();
        }

        public static List<WorkoutTemplate> GetTemplates()
        {
            List<WorkoutTemplate> result = new List<WorkoutTemplate>();
            string templatePath = Path.Combine(Environment.CurrentDirectory, "Templates");

            if (Directory.Exists(templatePath))
            {
                string[] files = Directory.GetFiles(templatePath, "*.xml");

                foreach (string file in files)
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        try
                        {
                            result.Add((WorkoutTemplate)serializer.Deserialize(reader));
                        }
                        catch (Exception exc)
                        {
                            System.Windows.Forms.MessageBox.Show(exc.ToString());
                        }
                    }
                }
            }

            return result;
        }
    }

    public class WorkoutTemplatePart
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? GroupId { get; set; }
    }

    public class WorkoutTemplateGroup
    {
        [XmlAttribute]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
