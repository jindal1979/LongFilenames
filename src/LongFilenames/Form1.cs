using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongFilenames
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lstFiles_DragDrop(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			if (data is string[])
			{
				foreach (string file in ((string[])data).OrderBy(f => f))
				{
					if (!lstFiles.Items.Contains(file))
					{
						lstFiles.Items.Add(file);
					}
				}
			}
		}

		private void lstFiles_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will delete all listed files and directories. Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			toolStripStatusLabel1.Text = "Scanning all paths...";
			Application.DoEvents();

			scan();
			if (formClosing) return;

			toolStripStatusLabel1.Text = string.Format("{0} item{1} to be deleted", scannedFiles, scannedFiles == 1 ? "" : "s");
			Application.DoEvents();

			toolStripProgressBar1.Maximum = scannedFiles;
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Visible = true;
			Application.DoEvents();

			delete();
			if (formClosing) return;

			toolStripProgressBar1.Visible = false;
			toolStripStatusLabel1.Text = string.Format("Deleted {0} item{1}", scannedFiles, scannedFiles == 1 ? "" : "s");
			lstFiles.Items.Clear();

		}

		private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lstFiles.Items.Clear();
		}

		private int scannedFiles;

		private void scan()
		{
			scannedFiles = 0;
			string[] files = lstFiles.Items.Cast<string>().ToArray();
			foreach (string file in files)
			{
				if (formClosing) break;
				scan(file);
			}
		}

		private void scan(string path)
		{
			if (LongDirectory.Exists(path))
			{
				scannedFiles++;
				foreach (string sub in LongDirectory.GetDirectories(path))
				{
					if (formClosing) break;
					scan(sub);
				}
				foreach (string file in LongDirectory.GetFiles(path))
				{
					if (formClosing) break;
					scan(file);
				}
			}
			else if (LongFile.Exists(path))
			{
				scannedFiles++;
			}
			Application.DoEvents();
		}

		private void delete()
		{
			string[] files = lstFiles.Items.Cast<string>().ToArray();
			foreach (string file in files)
			{
				if (formClosing) break;
				delete(file);
			}
		}

		private void delete(string path)
		{
			if (LongDirectory.Exists(path))
			{
				foreach (string sub in LongDirectory.GetDirectories(path))
				{
					if (formClosing) break;
					delete(sub);
				}
				foreach (string file in LongDirectory.GetFiles(path))
				{
					if (formClosing) break;
					delete(file);
				}
				try
				{
					LongDirectory.Delete(path);
				}
				catch (Exception ex)
				{
					if (ex.HResult == -2147024751 || ex.HResult == -2147467259)
					{
						txtLog.AppendText(string.Format("Directory is not empty: {0}\r\n", path));
					}
					else
					{
						txtLog.AppendText(string.Format("{0}\r\n", ex.Message));
					}
				}
				toolStripProgressBar1.Value++;
				Application.DoEvents();
			}
			else if (LongFile.Exists(path))
			{
				try
				{
					LongFile.Delete(path);
				}
				catch (Exception ex)
				{
					txtLog.AppendText(string.Format("{0}: {1}\r\n", ex.Message, path));
				}
				toolStripProgressBar1.Value++;
				Application.DoEvents();
			}
		}

		bool formClosing = false;
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			formClosing = true;
		}
	}
}
