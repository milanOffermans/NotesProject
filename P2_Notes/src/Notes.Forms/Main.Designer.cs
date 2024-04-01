namespace Notes.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.topBarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.nodeOptionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNestedNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteDetails = new Notes.Forms.NoteDetails();
            this.topBarMenuStrip.SuspendLayout();
            this.nodeOptionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes";
            // 
            // topBarMenuStrip
            // 
            this.topBarMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.topBarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topBarMenuStrip.Name = "topBarMenuStrip";
            this.topBarMenuStrip.Size = new System.Drawing.Size(1208, 28);
            this.topBarMenuStrip.TabIndex = 3;
            this.topBarMenuStrip.Text = "menuStrip1";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(50, 24);
            this.newToolStripMenuItem1.Text = "new";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.addNoteToolStripMenuItem.Text = "add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem1.Text = "exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.nodeOptionsMenu;
            this.treeView.Cursor = System.Windows.Forms.Cursors.Cross;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(20, 69);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(252, 643);
            this.treeView.TabIndex = 4;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // nodeOptionsMenu
            // 
            this.nodeOptionsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nodeOptionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNestedNodeToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.nodeOptionsMenu.Name = "contextMenuStrip1";
            this.nodeOptionsMenu.Size = new System.Drawing.Size(199, 52);
            // 
            // addNestedNodeToolStripMenuItem
            // 
            this.addNestedNodeToolStripMenuItem.Name = "addNestedNodeToolStripMenuItem";
            this.addNestedNodeToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.addNestedNodeToolStripMenuItem.Text = "Add Nested Node";
            this.addNestedNodeToolStripMenuItem.Click += new System.EventHandler(this.AddNestedNodeToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // noteDetails
            // 
            this.noteDetails.Content = "";
            this.noteDetails.Location = new System.Drawing.Point(291, 49);
            this.noteDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteDetails.Name = "noteDetails";
            this.noteDetails.Size = new System.Drawing.Size(805, 725);
            this.noteDetails.TabIndex = 5;
            this.noteDetails.Title = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 824);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.noteDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topBarMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Notes";
            this.topBarMenuStrip.ResumeLayout(false);
            this.topBarMenuStrip.PerformLayout();
            this.nodeOptionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip topBarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView;
        private NoteDetails noteDetails;
        private System.Windows.Forms.ContextMenuStrip nodeOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNestedNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

