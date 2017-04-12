using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class Form1 : Form
    {
        private List<string> files;
        private Dictionary<string, string> directoryFiles;
        public event EventHandler FilesAdded;
        public event EventHandler DirectoryFilesAdded;

        public Form1()
        {
            InitializeComponent();
            Text = "Hello world";
            files = new List<string>();

            FilesAdded += Form_FilesAdded;
            DirectoryFilesAdded += FormDirectory_FilesAdded;
        }

        private void Form_FilesAdded(object sender, EventArgs e)
        {
            Roles_ComboBox.Items.Clear();
            Roles_ComboBox.Items.AddRange(files.OrderBy(x=>x.Trim().ToLower()).ToArray());
        }

        private void FormDirectory_FilesAdded(object sender, EventArgs e)
        {
            DirectoryFiles_ComboBox.Items.Clear();
            DirectoryFiles_ComboBox.Items.AddRange(directoryFiles.Keys.ToArray());

            SelectedDirectory_ListView.Items.Clear();
            foreach (var s in directoryFiles)
            {
                var l = new ListViewItem(s.Key);

                l.SubItems.Add(s.Value);
                l.SubItems.Add(new FileInfo(s.Value).CreationTime.ToString("dd.MM.yyyy HH:mm:ss"));
                SelectedDirectory_ListView.Items.Add(l);
            }
        }


        private void FileSelectorDialog_Button_Click(object sender, EventArgs e)
        {
            FileSelector_OpenFileDialog.RestoreDirectory = false;
            FileSelector_OpenFileDialog.Multiselect = false;
            FileSelector_OpenFileDialog.InitialDirectory = @"C:\";
            FileSelector_OpenFileDialog.FileName = "";
            FileSelector_OpenFileDialog.CheckFileExists = true;
            FileSelector_OpenFileDialog.CheckPathExists = true;
            FileSelector_OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            FileSelector_OpenFileDialog.Title = "Choose file";

            if(FileSelector_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = FileSelector_OpenFileDialog.FileName;
                if(!files.Contains(path.Trim().ToLower()))
                {
                    files.Add(path);
                    FilesAdded(Roles_ComboBox, new EventArgs());
                }
            } 
        }

        private void OpenDirectoryDialog_Button_Click(object sender, EventArgs e)
        {
            Choose_FolderBrowserDialog.SelectedPath = "";

            if(Choose_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var path = Choose_FolderBrowserDialog.SelectedPath;
                var di = new DirectoryInfo(path);

                if (!di.Exists)
                {
                    MessageBox.Show("Wrong path");
                }

                var files = di.GetFiles("*.*", SearchOption.AllDirectories);
                directoryFiles = files.Select(f=>new KeyValuePair<string,string>(f.Name, f.FullName)).ToDictionary(k=>k.Key, v=>v.Value);

                DirectoryFilesAdded(DirectoryFiles_ComboBox, new EventArgs());
            }
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;

            while (i++ < 500)
            {
                if (bg.CancellationPending)
                    break;

                Thread.Sleep(10);
                bg.ReportProgress(i);
            }
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;

            bg.RunWorkerAsync();
        }
    }
}
