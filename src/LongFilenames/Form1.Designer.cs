namespace LongFilenames
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.lstFiles = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopTortoiseGitCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setupFileAndFolderContextMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.removeFileAndFolderContextMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Files/Directories";
			// 
			// lstFiles
			// 
			this.lstFiles.AllowDrop = true;
			this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.Location = new System.Drawing.Point(0, 20);
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new System.Drawing.Size(636, 173);
			this.lstFiles.TabIndex = 1;
			this.lstFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragDrop);
			this.lstFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragEnter);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.extrasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(666, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clearListToolStripMenuItem
			// 
			this.clearListToolStripMenuItem.Image = global::LongFilenames.Properties.Resources.cancel;
			this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
			this.clearListToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.clearListToolStripMenuItem.Text = "Clear List";
			this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::LongFilenames.Properties.Resources.delete;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// extrasToolStripMenuItem
			// 
			this.extrasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopTortoiseGitCacheToolStripMenuItem,
            this.toolStripSeparator1,
            this.setupFileAndFolderContextMenuToolStripMenuItem,
            this.removeFileAndFolderContextMenuToolStripMenuItem});
			this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
			this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.extrasToolStripMenuItem.Text = "Extras";
			// 
			// stopTortoiseGitCacheToolStripMenuItem
			// 
			this.stopTortoiseGitCacheToolStripMenuItem.Name = "stopTortoiseGitCacheToolStripMenuItem";
			this.stopTortoiseGitCacheToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.stopTortoiseGitCacheToolStripMenuItem.Text = "Stop TortoiseGit Cache";
			this.stopTortoiseGitCacheToolStripMenuItem.Click += new System.EventHandler(this.stopTortoiseGitCacheToolStripMenuItem_Click);
			// 
			// setupFileAndFolderContextMenuToolStripMenuItem
			// 
			this.setupFileAndFolderContextMenuToolStripMenuItem.Name = "setupFileAndFolderContextMenuToolStripMenuItem";
			this.setupFileAndFolderContextMenuToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.setupFileAndFolderContextMenuToolStripMenuItem.Text = "Setup File and Folder Context Menu";
			this.setupFileAndFolderContextMenuToolStripMenuItem.Click += new System.EventHandler(this.setupFileAndFolderContextMenuToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(666, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar1.Visible = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 27);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lstFiles);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtLog);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Size = new System.Drawing.Size(642, 398);
			this.splitContainer1.SplitterDistance = 199;
			this.splitContainer1.TabIndex = 4;
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.Location = new System.Drawing.Point(3, 18);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(636, 174);
			this.txtLog.TabIndex = 3;
			this.txtLog.WordWrap = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Log";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
			// 
			// removeFileAndFolderContextMenuToolStripMenuItem
			// 
			this.removeFileAndFolderContextMenuToolStripMenuItem.Name = "removeFileAndFolderContextMenuToolStripMenuItem";
			this.removeFileAndFolderContextMenuToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.removeFileAndFolderContextMenuToolStripMenuItem.Text = "Remove File and Folder Context Menu";
			this.removeFileAndFolderContextMenuToolStripMenuItem.Click += new System.EventHandler(this.removeFileAndFolderContextMenuToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 450);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Long Filenames";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopTortoiseGitCacheToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setupFileAndFolderContextMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem removeFileAndFolderContextMenuToolStripMenuItem;
	}
}

