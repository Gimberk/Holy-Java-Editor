using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Code_Editor
{
    public partial class Form1 : Form
    {
        public bool projectOpen = false;
        public string path;
        public string name;

        public string openFile = string.Empty;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), 
                "Reopen.cfg")))
            {
                DirectoryInfo info = new DirectoryInfo(File.ReadAllText
                    (Path.Combine(Directory.GetCurrentDirectory(), "Reopen.cfg")));
                projectOpen = true;
                path = info.FullName;
                name = info.Name;

                Finished();
            }

            label1.Hide();

            if (projectOpen)
            {
                string consoleTitle = File.ReadAllText(Path.Combine(path,
                    "Configuration", "Console Title.cfg"));
                if (consoleTitle != "Console Title")
                    consoleTitleTxt.Text = consoleTitle;
                UpdateTree();
            }
        }

        public void UpdateTree()
        {
            fileView.Nodes.Clear();

            if (!projectOpen)
            {
                return;
            }

            TreeNode root = new TreeNode();
            root.Text = name;
            root.Name = path;
            root.ForeColor = Color.Yellow;
            fileView.Nodes.Add(root);

            string[] blackListedDirs =
                File.ReadAllText(Path.Combine(path, ".ignoreDirs")).Split('\n');
            List<string> dirs = FileUtils.ProcessDirectory
                (path, blackListedDirs, false);

            foreach (string dir in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(dir);

                if (di.Parent.Name == name)
                {
                    TreeNode item = new TreeNode();
                    item.Text = di.Name;
                    item.Name = di.FullName;
                    item.ForeColor = Color.Yellow;
                    root.Nodes.Add(item);
                }
                else
                {
                    TreeNode parent = FileUtils.SearchNode(root, di.Parent.Name);
                    TreeNode item = new TreeNode();
                    item.ForeColor = Color.Yellow;
                    item.Text = di.Name;
                    item.Name = di.FullName;
                    parent.Nodes.Add(item);
                }
            }

            List<string> files = FileUtils.ProcessDirectory(path,
                blackListedDirs, true);
            string[] blackListedFiles =
                File.ReadAllText(Path.Combine(path, ".ignoreFiles")).Split('\n');

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);

                if (!blackListedFiles.Contains(fi.Name))
                {
                    TreeNode parent = FileUtils.SearchNode(root, fi.Directory.Name);

                    TreeNode item = new TreeNode();
                    item.Text = fi.Name;
                    item.Name = fi.FullName;
                    item.ForeColor = Color.MediumSlateBlue;
                    parent.Nodes.Add(item);
                }
            }
        }

        #region Menu Strip

        private void saveCurrentFileToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            if (openFile == string.Empty)
                return;

            label1.Font = new Font(label1.Font, FontStyle.Regular);
            label1.Text = new FileInfo(openFile).Name;
            File.WriteAllText(openFile, editorTxt.Text);
        }

        private void closeProjectToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            if (!projectOpen)
            {
                Errors.NoOpenProject(Text);
                return;
            }

            path = string.Empty;
            name = string.Empty;
            openFile = string.Empty;
            editorTxt.Text = string.Empty;
            projectOpen = false;
            UpdateTree();
        }

        private void removeStartupProjectToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), 
                "Reopen.cfg")))
            {
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(),
                    "Reopen.cfg"));
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewProject();
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Build();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Context Menu

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileView.SelectedNode.ForeColor != Color.MediumSlateBlue)
            {
                MessageBox.Show("Selected node was not a file.", 
                    "Holy Java Editor", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string filePath = fileView.SelectedNode.Name;
            string contents = File.ReadAllText(filePath);

            label1.Show();

            openFile = filePath;
            editorTxt.Text = contents;
            label1.Text = new FileInfo(filePath).Name;
            label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorTxt.Text = string.Empty;
            openFile = string.Empty;
            label1.Hide();
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] protectedDirsAndFiles = new string[3];
            protectedDirsAndFiles[0] = name;
            protectedDirsAndFiles[1] = "Configuration";
            protectedDirsAndFiles[2] = "Console Title.cfg";

            if (!protectedDirsAndFiles.Contains(fileView.SelectedNode.Text))
            {
                if (fileView.SelectedNode.ForeColor == Color.Yellow)
                {
                    Directory.Delete(fileView.SelectedNode.Name, true);
                }
                else
                {
                    File.Delete(fileView.SelectedNode.Name);
                }
            }
            else
            {
                MessageBox.Show("This folder/file is protected and " +
                    "cannot be deleted.", Text, MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            UpdateTree();
        }

        private void openFolderInFileExplorerToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            Process.Start(path);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!projectOpen)
            {
                Errors.NoOpenProject(Text);
                return;
            }

            NewFile form = new NewFile(this);
            form.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTree();
        }

        #endregion

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            CreateNewProject();
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
                DirectoryInfo info = new DirectoryInfo(path);
                name = info.Name;
                projectOpen = true;

                UpdateTree();
                Finished();
            }
        }

        #region

        public void Run()
        {
            if (!Build())
            {
                MessageBox.Show("Build Failed.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string runTimePath = Path.Combine(Directory.GetCurrentDirectory(),
                "Runtime", "Release", "net7.0");
            ProcessStartInfo info = new ProcessStartInfo();
            info.WorkingDirectory = runTimePath;
            info.FileName = Path.Combine(runTimePath, "ApplicationRuntime.exe");
            Process.Start(info);
        }

        public bool Build()
        {
            if (label1.Font.Bold == true)
            {
                if (MessageBox.Show("Would you like " +
                    "to save your file?", Text, MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label1.Text = new FileInfo(openFile).Name;
                    File.WriteAllText(openFile, editorTxt.Text);
                }
            }

            if (!projectOpen)
            {
                Errors.NoOpenProject(Text);
                return false;
            }

            string runTimePath = Path.Combine(Directory.GetCurrentDirectory(),
                "Runtime", "Release", "net7.0");
            string resPath = Path.Combine(Directory.GetCurrentDirectory(),
                "Resources", "Compiler", "Console");

            if (Directory.Exists(Path.Combine(runTimePath, "Application Data")))
            {
                Directory.Delete(Path.Combine(runTimePath, 
                    "Application Data"), true);
                Directory.Delete(Path.Combine(runTimePath, "Data"), true);
            }

            // Create all the directories needed for build
            Directory.CreateDirectory(Path.Combine(runTimePath, 
                "Application Data"));
            Directory.CreateDirectory(Path.Combine(runTimePath, "Data"));
            Directory.CreateDirectory(Path.Combine(runTimePath, "Data", 
                "Compiler", "Console"));
            Directory.CreateDirectory(Path.Combine(runTimePath, "Data",
                "Configuration"));

            //Set configurations
            string consoleTitle = consoleTitleTxt.Text == string.Empty 
                || consoleTitleTxt.Text == "Console Title" ? "Application Runtime"
                : consoleTitleTxt.Text;
            File.WriteAllText(Path.Combine(path, "Configuration",
                "Console Title.cfg"), consoleTitle);

            // Copy compiler over to the runtime data folder
            foreach (string file in Directory.GetFiles(resPath))
                File.Copy(file, Path.Combine(runTimePath, "Data", "Compiler",
                    "Console", new FileInfo(file).Name));

            //Copy all the configurations to the runtime data folder
            foreach (string config in Directory.GetFiles(Path.Combine(path,
                "Configuration")))
                File.Copy(config, Path.Combine(runTimePath, "Data", "Configuration",
                    new FileInfo(config).Name));

            //Copy all source files and directories
            //to the runtime application data folder
            int origPathLength = path.Split('\\').Length;
            int pathLength = origPathLength;

            string ignoreDirs = "Settings";

            List<string> dirs = FileUtils.ProcessDirectory
                (path, ignoreDirs.Split('\n'), false);
            foreach (string dir in dirs)
            {
                string[] splitPath = dir.Split('\\');

                int index = 0;
                while (pathLength > 0)
                {
                    splitPath[index] = string.Empty;

                    index++;
                    pathLength--;
                }

                pathLength = origPathLength;

                string fullPath = string.Empty;

                foreach (string piece in splitPath)
                {
                    if (piece == string.Empty) continue;

                    fullPath += piece + "\\";
                }

                Directory.CreateDirectory(Path.Combine(runTimePath, 
                    "Application Data", fullPath));
            }

            List<string> files = FileUtils.ProcessDirectory(path, 
                ignoreDirs.Split('\n'));
            foreach (string file in files)
            {
                string[] splitPath = file.Split('\\');

                int index = 0;
                while (pathLength > 0)
                {
                    splitPath[index] = string.Empty;

                    index++;
                    pathLength--;
                }

                pathLength = origPathLength;

                string fullPath = string.Empty;

                foreach (string piece in splitPath)
                {
                    if (piece == string.Empty) continue;

                    fullPath += piece + "\\";
                }

                char[] trimedChars = new char[2];
                trimedChars[0] = '.';
                trimedChars[1] = '\\';

                File.Copy(file, Path.Combine(runTimePath, 
                    "Application Data", 
                    fullPath.TrimEnd(trimedChars)));
            }
            MessageBox.Show("Build Succeeded.", Text, MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            return true;
        }

        void CreateNewProject()
        {
            NewProject newProject = new NewProject(this);
            newProject.Show();
        }

        public void CreateFile(string fileName)
        {
            if (fileView.SelectedNode == null)
            {
                File.WriteAllText(Path.Combine(path, fileName), string.Empty);
            }
            else
            {
                if (fileView.SelectedNode.ForeColor != Color.Yellow)
                    File.WriteAllText(Path.Combine(path, fileName), string.Empty);

                File.WriteAllText(Path.Combine(fileView.SelectedNode.Name, fileName), string.Empty);
            }

            UpdateTree();
        }

        public void Finished()
        {
            newProjectBtn.Hide();
            openProjectBtn.Hide();
            newProjectLbl.Hide();
            openProjectLbl.Hide();

            infoLbl.Hide();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (projectOpen && !File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Reopen.cfg")))
            {
                if (MessageBox.Show("Would you like to reopen this " +
                    "project on next startup?", "Holy Java Editor", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "Reopen.cfg"), path);
                }
            }
        }

        private void editorTxt_TextChanged(object sender, EventArgs e)
        {
            label1.Text = new FileInfo(openFile).Name + " *";
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }
    }
}
