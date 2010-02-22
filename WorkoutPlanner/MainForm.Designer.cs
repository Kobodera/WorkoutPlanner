﻿namespace WorkoutPlanner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jympaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.workoutFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.workoutContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workoutPartContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workoutSongContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.workoutTreeView = new System.Windows.Forms.TreeView();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.workoutContextMenuStrip.SuspendLayout();
            this.workoutPartContextMenuStrip.SuspendLayout();
            this.workoutSongContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWorkoutToolStripMenuItem
            // 
            this.newWorkoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jympaToolStripMenuItem,
            this.kiboxToolStripMenuItem});
            this.newWorkoutToolStripMenuItem.Name = "newWorkoutToolStripMenuItem";
            this.newWorkoutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newWorkoutToolStripMenuItem.Text = "New Workout";
            // 
            // jympaToolStripMenuItem
            // 
            this.jympaToolStripMenuItem.Name = "jympaToolStripMenuItem";
            this.jympaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.jympaToolStripMenuItem.Text = "Jympa";
            this.jympaToolStripMenuItem.Click += new System.EventHandler(this.jympaToolStripMenuItem_Click);
            // 
            // kiboxToolStripMenuItem
            // 
            this.kiboxToolStripMenuItem.Name = "kiboxToolStripMenuItem";
            this.kiboxToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kiboxToolStripMenuItem.Text = "Ki-box";
            this.kiboxToolStripMenuItem.Click += new System.EventHandler(this.kiboxToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.workoutTreeView);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.workoutFlowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(997, 552);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 1;
            // 
            // workoutFlowLayoutPanel
            // 
            this.workoutFlowLayoutPanel.AutoScroll = true;
            this.workoutFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.workoutFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workoutFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.workoutFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.workoutFlowLayoutPanel.Name = "workoutFlowLayoutPanel";
            this.workoutFlowLayoutPanel.Size = new System.Drawing.Size(710, 552);
            this.workoutFlowLayoutPanel.TabIndex = 0;
            // 
            // workoutContextMenuStrip
            // 
            this.workoutContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem});
            this.workoutContextMenuStrip.Name = "workoutContextMenuStrip";
            this.workoutContextMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // workoutPartContextMenuStrip
            // 
            this.workoutPartContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem});
            this.workoutPartContextMenuStrip.Name = "contextMenuStrip1";
            this.workoutPartContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // workoutSongContextMenuStrip
            // 
            this.workoutSongContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSongToolStripMenuItem,
            this.insertSongToolStripMenuItem});
            this.workoutSongContextMenuStrip.Name = "contextMenuStrip1";
            this.workoutSongContextMenuStrip.Size = new System.Drawing.Size(133, 48);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 463);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 89);
            this.textBox1.TabIndex = 0;
            // 
            // workoutTreeView
            // 
            this.workoutTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workoutTreeView.Location = new System.Drawing.Point(0, 0);
            this.workoutTreeView.Name = "workoutTreeView";
            this.workoutTreeView.Size = new System.Drawing.Size(283, 463);
            this.workoutTreeView.TabIndex = 1;
            this.workoutTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workoutTreeView_MouseDown);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addSongToolStripMenuItem.Text = "Add song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.addSongToolStripMenuItem_Click);
            // 
            // editSongToolStripMenuItem
            // 
            this.editSongToolStripMenuItem.Name = "editSongToolStripMenuItem";
            this.editSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editSongToolStripMenuItem.Text = "Edit song";
            // 
            // insertSongToolStripMenuItem
            // 
            this.insertSongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beforeToolStripMenuItem,
            this.afterToolStripMenuItem});
            this.insertSongToolStripMenuItem.Name = "insertSongToolStripMenuItem";
            this.insertSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertSongToolStripMenuItem.Text = "Insert song";
            // 
            // beforeToolStripMenuItem
            // 
            this.beforeToolStripMenuItem.Name = "beforeToolStripMenuItem";
            this.beforeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beforeToolStripMenuItem.Text = "Before";
            // 
            // afterToolStripMenuItem
            // 
            this.afterToolStripMenuItem.Name = "afterToolStripMenuItem";
            this.afterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afterToolStripMenuItem.Text = "After";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 576);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Workout planner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.workoutContextMenuStrip.ResumeLayout(false);
            this.workoutPartContextMenuStrip.ResumeLayout(false);
            this.workoutSongContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel workoutFlowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jympaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiboxToolStripMenuItem;
        private System.Windows.Forms.TreeView workoutTreeView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip workoutContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip workoutPartContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip workoutSongContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afterToolStripMenuItem;

    }
}
