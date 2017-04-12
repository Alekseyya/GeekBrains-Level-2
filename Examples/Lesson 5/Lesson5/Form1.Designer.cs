namespace Lesson5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileSelectorDialog_Button = new System.Windows.Forms.Button();
            this.Roles_ComboBox = new System.Windows.Forms.ComboBox();
            this.OpenDirectoryDialog_Button = new System.Windows.Forms.Button();
            this.DirectoryFiles_ComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedDirectory_ListView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSelector_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Choose_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.FileSelectorDialog_Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Roles_ComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenDirectoryDialog_Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DirectoryFiles_ComboBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SelectedDirectory_ListView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // FileSelectorDialog_Button
            // 
            resources.ApplyResources(this.FileSelectorDialog_Button, "FileSelectorDialog_Button");
            this.FileSelectorDialog_Button.Name = "FileSelectorDialog_Button";
            this.FileSelectorDialog_Button.UseVisualStyleBackColor = true;
            this.FileSelectorDialog_Button.Click += new System.EventHandler(this.FileSelectorDialog_Button_Click);
            // 
            // Roles_ComboBox
            // 
            resources.ApplyResources(this.Roles_ComboBox, "Roles_ComboBox");
            this.Roles_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roles_ComboBox.FormattingEnabled = true;
            this.Roles_ComboBox.Name = "Roles_ComboBox";
            // 
            // OpenDirectoryDialog_Button
            // 
            resources.ApplyResources(this.OpenDirectoryDialog_Button, "OpenDirectoryDialog_Button");
            this.OpenDirectoryDialog_Button.Name = "OpenDirectoryDialog_Button";
            this.OpenDirectoryDialog_Button.UseVisualStyleBackColor = true;
            this.OpenDirectoryDialog_Button.Click += new System.EventHandler(this.OpenDirectoryDialog_Button_Click);
            // 
            // DirectoryFiles_ComboBox
            // 
            resources.ApplyResources(this.DirectoryFiles_ComboBox, "DirectoryFiles_ComboBox");
            this.DirectoryFiles_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectoryFiles_ComboBox.FormattingEnabled = true;
            this.DirectoryFiles_ComboBox.Name = "DirectoryFiles_ComboBox";
            // 
            // SelectedDirectory_ListView
            // 
            this.SelectedDirectory_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FilePath,
            this.FileCreation});
            resources.ApplyResources(this.SelectedDirectory_ListView, "SelectedDirectory_ListView");
            this.SelectedDirectory_ListView.GridLines = true;
            this.SelectedDirectory_ListView.Name = "SelectedDirectory_ListView";
            this.tableLayoutPanel1.SetRowSpan(this.SelectedDirectory_ListView, 2);
            this.SelectedDirectory_ListView.UseCompatibleStateImageBehavior = false;
            this.SelectedDirectory_ListView.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            resources.ApplyResources(this.FileName, "FileName");
            // 
            // FilePath
            // 
            resources.ApplyResources(this.FilePath, "FilePath");
            // 
            // FileCreation
            // 
            resources.ApplyResources(this.FileCreation, "FileCreation");
            // 
            // FileSelector_OpenFileDialog
            // 
            this.FileSelector_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // bg
            // 
            this.bg.WorkerReportsProgress = true;
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            this.bg.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_ProgressChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FileSelectorDialog_Button;
        private System.Windows.Forms.Button OpenDirectoryDialog_Button;
        private System.Windows.Forms.ComboBox Roles_ComboBox;
        private System.Windows.Forms.OpenFileDialog FileSelector_OpenFileDialog;
        private System.Windows.Forms.ComboBox DirectoryFiles_ComboBox;
        private System.Windows.Forms.FolderBrowserDialog Choose_FolderBrowserDialog;
        private System.Windows.Forms.ListView SelectedDirectory_ListView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.ColumnHeader FileCreation;
        private System.ComponentModel.BackgroundWorker bg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

