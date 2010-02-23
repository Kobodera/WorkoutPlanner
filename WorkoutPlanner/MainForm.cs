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
    public partial class MainForm : Form
    {
        Workout workout;

        public MainForm()
        {
            InitializeComponent();

            LoadTemplates();

            WorkoutSong song = new WorkoutSong()
            {
                Track = 1,
                Artist = "Iron Maiden",
                Album = "A Real Dead One",
                Seconds = 180,
                Title = "Number of the beast",
                //FromSecond = 15,
                //ToSecond = 180,
                Bpm1 = 100,
                Bpm2 = 200
            };

            Label label1 = new Label();
            label1.Font = new Font(FontFamily.GenericMonospace, 8);
            label1.AutoSize = true;
            label1.Text = song.ToString();

            WorkoutSong song2 = new WorkoutSong()
            {
                Track = 20,
                Artist = "Avril Lavinge",
                Album = "This is my life",
                Seconds = 180,
                Title = "Shoot me up stranger",
                FromSecond = 10,
                //ToSecond = 180,
            };

            Label label2 = new Label();
            label2.Font = new Font(FontFamily.GenericMonospace, 8);
            label2.AutoSize = true;
            label2.Text = song2.ToString();

            WorkoutPart part = new WorkoutPart()
            {
                Name = "Uppvärmning"
            };

            part.Songs.Add(song);
            part.Songs.Add(song2);

            Label label3 = new Label();
            label3.Font = new Font(FontFamily.GenericMonospace, 8);
            label3.AutoSize = true;
            label3.Text = part.ToString();

            workoutFlowLayoutPanel.Controls.AddRange(new Control[] { label3, label1, label2 });
        }

        private void LoadTemplates()
        {
            List<WorkoutTemplate> templates = WorkoutTemplate.GetTemplates();

            foreach (WorkoutTemplate template in templates)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(template.Name);
                item.Tag = template;
                item.Click += new EventHandler(item_Click);

                newWorkoutToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            WorkoutTemplate template = (WorkoutTemplate)((ToolStripMenuItem)sender).Tag;
            workout = new Workout(template.Name);
            foreach (WorkoutTemplatePart part in template.WorkoutTemplateParts)
            {
                if (part.GroupId.HasValue)
                    workout.AddPart(part.Name, part.Description, part.GroupId.Value);
                else
                    workout.AddPart(part.Name, part.Description);
            }

            RefreshAll();
        }

        private void jympaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //workout = new Workout(WorkoutType.Workout);
            //workout.AddPart(WorkoutResources.Warmup);
            //workout.AddPart(string.Format(WorkoutResources.Mobility, 1));
            //workout.AddPart(string.Format(WorkoutResources.Strength, 1));
            //workout.AddPart(string.Format(WorkoutResources.Fittnes, 1));
            //workout.AddPart(string.Format(WorkoutResources.Crossover, ""));
            //workout.AddPart(string.Format(WorkoutResources.Strength, 2));
            //workout.AddPart(string.Format(WorkoutResources.Fittnes, 2));
            //workout.AddPart(WorkoutResources.Calmdown);
            //workout.AddPart(string.Format(WorkoutResources.Mobility, 2));
            //workout.AddPart(WorkoutResources.Relaxation);

            //RefreshAll();
        }

        private void RefreshAll()
        {
            int index = 1;
            workoutFlowLayoutPanel.Controls.Clear();
            workoutTreeView.Nodes.Clear();

            List<Control> ctrls = new List<Control>();

            TreeNode node = new TreeNode(workout.Name);
            node.Tag = workout;
            node.ContextMenuStrip = workoutContextMenuStrip;
            ctrls.Add(CreateLabel(workout.ToString(), workout));
            ctrls.Add(CreateLabel("", null));

            foreach (var part in workout.Parts)
            {
                var partNode = AddNode(ref node, part.Name, part);
                partNode.ContextMenuStrip = workoutPartContextMenuStrip;
                ctrls.Add(CreateLabel(part.ToString(), part));

                foreach (var song in part.Songs)
                {
                    song.Track = index;
                    index++;

                    ctrls.Add(CreateLabel(song.ToString(), song));
                    var songNode = AddNode(ref partNode, song.ToShortString(), song);
                    songNode.ContextMenuStrip = workoutSongContextMenuStrip;
                }
                ctrls.Add(CreateLabel("", null));
            }

            workoutTreeView.Nodes.Add(node);
            workoutTreeView.ExpandAll();

            //List<string> workoutText = workout.GetWorkoutAsText();
            //foreach (string str in workoutText)
            //{
            //    Label lbl = new Label();
            //    lbl.Font = new Font(FontFamily.GenericMonospace, 8);
            //    lbl.AutoSize = true;
            //    lbl.Text = str;

            //    ctrls.Add(lbl);
            //}

            workoutFlowLayoutPanel.Controls.AddRange(ctrls.ToArray());
        }

        private Label CreateLabel(string text, object tag)
        {
            Label lbl = new Label();
            lbl.Font = new Font(FontFamily.GenericMonospace, 8);
            lbl.AutoSize = true;
            lbl.Text = text;
            lbl.Tag = tag;
            lbl.DoubleClick += new EventHandler(lbl_DoubleClick);
            return lbl;
        }

        void lbl_DoubleClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Tag is WorkoutSong)
            {
                MessageBox.Show(((WorkoutSong)lbl.Tag).ToShortString());
            }
        }

        private TreeNode AddNode(ref TreeNode parent, string title, object tag)
        {
            TreeNode node = new TreeNode(title);
            node.Tag = tag;
            parent.Nodes.Add(node);

            return node;
        }

        private void kiboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //workout = new Workout(WorkoutType.KiBox);
            //workout.AddPart(WorkoutResources.Breathing);
            //workout.AddPart(WorkoutResources.BasicInstructions);
            //workout.AddPart(WorkoutResources.Warmup);
            //workout.AddPart(string.Format(WorkoutResources.Mobility, 1));
            //workout.AddPart(string.Format(WorkoutResources.Strength, ""));
            //workout.AddPart(WorkoutResources.FormPairs);
            //workout.AddPart(WorkoutResources.Instructions);
            //workout.AddPart(WorkoutResources.Switch);
            //workout.AddPart(string.Format(WorkoutResources.KiBox));
            //workout.AddPart(WorkoutResources.Calmdown);
            //workout.AddPart(WorkoutResources.ChiGong);
            //workout.AddPart(string.Format(WorkoutResources.Mobility, 2));

            //RefreshAll();
        }

        private void workoutTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = workoutTreeView.GetNodeAt(e.X, e.Y);

            if (node != null)
            {
                workoutTreeView.SelectedNode = node;

                if (node.Tag is WorkoutPart)
                {
                    infoTextBox.Text = ((WorkoutPart)node.Tag).Description;
                }
                else
                    infoTextBox.Text = string.Empty;
            }
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new WorkoutSongForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TreeNode temp = workoutTreeView.SelectedNode;

                    ((WorkoutPart)temp.Tag).AddSong(form.Song);
                    AddNode(ref temp, form.Song.ToShortString(), form.Song);
                    temp.Expand();
                }
            }

            RefreshAll();
        }
    }
}
