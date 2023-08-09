using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor
{
    public partial class NewProject : Form
    {
        Form1 main;

        public NewProject(Form1 main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectNameTxt.Texts) || 
                string.IsNullOrEmpty(projectPathTxt.Texts))
            {
                Errors.BlankFields("Create New Project");
                return;
            }

            string path = Path.Combine(projectPathTxt.Texts, projectNameTxt.Texts);
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(Path.Combine(path, "Configuration"));

            File.WriteAllText(Path.Combine(path, ".ignoreFiles"), 
                ".ignoreFiles\n.ignoreDirs");
            File.WriteAllText(Path.Combine(path, ".ignoreDirs"), string.Empty);
            File.WriteAllText(Path.Combine(path, "Main.hjm"), string.Empty);
            File.WriteAllText(Path.Combine(path, "Configuration", 
                "Console Title.cfg"), "Console Title");

            main.name = projectNameTxt.Texts;
            main.path = path;
            main.projectOpen = true;
            main.UpdateTree();

            main.Finished();

            Process.Start(path);
            Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Browse for a folder to contain your project folder.";
            dlg.ShowNewFolderButton = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                projectPathTxt.SetText(dlg.SelectedPath);
            }
        }
    }
}
