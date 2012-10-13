using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileDateCopy
{
    public partial class FormMain : Form
    {
        private string base_path_src;
        private string base_path_dst;

        public FormMain()
        {
            InitializeComponent();

            this.textBoxPathSrc.Text = @"F:\Temp\pdk-Wudi";
            this.textBoxPathDst.Text = @"F:\Temp\pdk-Wudi-2";
        }

        private void buttonBrowseSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please select the source path";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxPathSrc.Text = dialog.SelectedPath;
            }
        }

        private void buttonBrowseDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please select the destination path";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxPathDst.Text = dialog.SelectedPath;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            this.buttonProcess.Enabled = false;

            this.listViewLog.Items.Clear();

            string path_src = this.textBoxPathSrc.Text;
            string path_dst = this.textBoxPathDst.Text;

            if (!Directory.Exists(path_src))
            {
                MessageBox.Show("Source path is not a directory.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonProcess.Enabled = true;
                return;
            }

            if (!Directory.Exists(path_dst))
            {
                MessageBox.Show("Destination path is not a directory.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonProcess.Enabled = true;
                return;
            }

            this.base_path_src = Path.GetFullPath(path_src);
            this.base_path_dst = Path.GetFullPath(path_dst);

            this.ProcessDirectory(this.base_path_src);

            this.buttonProcess.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ProcessDirectory(string path_src)
        {
            ListViewItem lvi;

            string[] dirs = System.IO.Directory.GetDirectories(path_src);
            DirectoryInfo dirinfo;
            foreach (string dir in dirs)
            {
                dirinfo = new DirectoryInfo(dir);
                if (dirinfo.Name == "RECYCLER" || dirinfo.Name == "System Volume Information")
                {
                    continue;
                }
                ProcessDirectory(dirinfo.FullName);
            }

            string[] files = System.IO.Directory.GetFiles(path_src);
            foreach (string file in files)
            {
                ProcessFile(file);
            }

            DateTime src_creation_time = Directory.GetCreationTime(path_src);
            DateTime src_last_write_time = Directory.GetLastWriteTime(path_src);

            string path_dst = path_src.Replace(this.base_path_src, this.base_path_dst);

            if (!Directory.Exists(path_dst))
            {
                lvi = new ListViewItem(new string[] {
                    path_src,
                    path_dst,
                    String.Format("{0}", src_creation_time),
                    String.Format("{0}", src_last_write_time),
                    "-"
                });
                lvi.BackColor = Color.LightYellow;
                lvi.ForeColor = Color.Red;
                this.listViewLog.Items.Add(lvi);
                return;
            }

            DateTime dst_creation_time = Directory.GetCreationTime(path_dst);
            DateTime dst_last_write_time = Directory.GetLastWriteTime(path_dst);

            bool changed_ctime = false;
            bool changed_mtime = false;

            try
            {
                if (this.checkBoxDirCTime.Checked && (dst_creation_time != src_creation_time))
                {
                    Directory.SetCreationTime(path_dst, src_creation_time);
                    changed_ctime = true;
                }
                if (this.checkBoxDirMTime.Checked && (dst_last_write_time != src_last_write_time))
                {
                    Directory.SetLastWriteTime(path_dst, src_last_write_time);
                    changed_mtime = true;
                }
            }
            catch (Exception e)
            {
                lvi = new ListViewItem(new string[] {
                    path_src,
                    path_dst,
                    e.Message,
                    "-",
                    "-"
                });
                lvi.BackColor = Color.LightYellow;
                lvi.ForeColor = Color.Red;
                this.listViewLog.Items.Add(lvi);
                return;
            }

            lvi = new ListViewItem(new string[] {
                path_src,
                path_dst,
                String.Format("{0}{1}", (changed_ctime ? "[+] " : "[.] "), src_creation_time),
                String.Format("{0}{1}", (changed_mtime ? "[+] " : "[.] "), src_last_write_time),
                "-"
            });
            lvi.BackColor = Color.LightYellow;
            if (!changed_ctime && !changed_mtime)
            {
                lvi.ForeColor = Color.Gray;
            }
            this.listViewLog.Items.Add(lvi);
        }

        private void ProcessFile(string path_src)
        {
            ListViewItem lvi;

            DateTime src_creation_time = File.GetCreationTime(path_src);
            DateTime src_last_write_time = File.GetLastWriteTime(path_src);
            DateTime src_last_access_time = File.GetLastAccessTime(path_src);

            string path_dst = path_src.Replace(this.base_path_src, this.base_path_dst);

            if (!File.Exists(path_dst))
            {
                lvi = new ListViewItem(new string[] {
                    path_src,
                    path_dst,
                    String.Format("{0}", src_creation_time),
                    String.Format("{0}", src_last_write_time),
                    String.Format("{0}", src_last_access_time)
                });
                lvi.ForeColor = Color.Red;
                this.listViewLog.Items.Add(lvi);
                return;
            }

            DateTime dst_creation_time = File.GetCreationTime(path_dst);
            DateTime dst_last_write_time = File.GetLastWriteTime(path_dst);
            DateTime dst_last_access_time = File.GetLastAccessTime(path_dst);

            bool changed_ctime = false;
            bool changed_mtime = false;
            bool changed_atime = false;

            try
            {
                if (this.checkBoxFileCTime.Checked && (dst_creation_time != src_creation_time))
                {
                    File.SetCreationTime(path_dst, src_creation_time);
                    changed_ctime = true;
                }
                if (this.checkBoxFileMTime.Checked && (dst_last_write_time != src_last_write_time))
                {
                    File.SetLastWriteTime(path_dst, src_last_write_time);
                    changed_mtime = true;
                }
                if (this.checkBoxFileATime.Checked && (dst_last_access_time != src_last_access_time))
                {
                    File.SetLastAccessTime(path_dst, src_last_access_time);
                    changed_atime = true;
                }
            }
            catch (Exception e)
            {
                lvi = new ListViewItem(new string[] {
                    path_src,
                    path_dst,
                    e.Message,
                    "-",
                    "-"
                });
                lvi.ForeColor = Color.Red;
                this.listViewLog.Items.Add(lvi);
                return;
            }

            lvi = new ListViewItem(new string[] {
                StringHelper.PadRight(UriHelper.Compact(path_src, 50), 50, ' '),
                path_dst,
                String.Format("{0}{1}", (changed_ctime ? "[+] " : "[.] "), src_creation_time),
                String.Format("{0}{1}", (changed_mtime ? "[+] " : "[.] "), src_last_write_time),
                String.Format("{0}{1}", (changed_atime ? "[+] " : "[.] "), src_last_access_time)
            });
            if (!changed_ctime && !changed_mtime && !changed_atime)
            {
                lvi.ForeColor = Color.Gray;
            }
            this.listViewLog.Items.Add(lvi);
        }
    }
}
