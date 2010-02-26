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

                    var songNode = AddNode(ref partNode, song.ToShortString(), song);
                    songNode.ContextMenuStrip = workoutSongContextMenuStrip;
                    ctrls.Add(CreateLabel(song.ToString(), workoutSongContextMenuStrip, songNode));
                }
                ctrls.Add(CreateLabel("", null));
            }

            workoutTreeView.Nodes.Add(node);
            workoutTreeView.ExpandAll();

            workoutFlowLayoutPanel.Controls.AddRange(ctrls.ToArray());
        }

        private Label CreateLabel(string text, ContextMenuStrip strip, object tag)
        {
            Label result = CreateLabel(text, tag);
            result.ContextMenuStrip = strip;
            return result;
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
            if (lbl.Tag is TreeNode)
            {
                EditWorkoutSong((WorkoutSong)((TreeNode)lbl.Tag).Tag);
            }
        }

        private TreeNode AddNode(ref TreeNode parent, string title, object tag)
        {
            TreeNode node = new TreeNode(title);
            node.Tag = tag;
            parent.Nodes.Add(node);

            return node;
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

        private void EditWorkoutSong(WorkoutSong song)
        {
            using (WorkoutSongForm form = new WorkoutSongForm())
            {
                form.Song = song;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //Updates song
                    var updateSong = form.Song;

                    RefreshAll();
                }
            }
        }

        private void editSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditWorkoutSong(GetWorkoutSong((ToolStripMenuItem)sender));
        }

        private void deleteSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workout.DeleteSong(GetWorkoutSong((ToolStripMenuItem)sender));
            RefreshAll();
        }

        private WorkoutSong GetWorkoutSong(ToolStripMenuItem item)
        {
            var temp = GetParentObject(item);
            if (temp is Label)
            {
                return (WorkoutSong)((TreeNode)((Label)temp).Tag).Tag;
            }
            else if (temp is TreeView)
            {
                return (WorkoutSong)((TreeView)temp).SelectedNode.Tag;
            }

            MessageBox.Show(((TreeView)temp).Nodes[0].Text);

            return null;
        }

        private object GetParentObject(ToolStripMenuItem item)
        {
            return ((ContextMenuStrip)item.Owner).SourceControl;
        }
    }
}
