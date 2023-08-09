using System;
using System.Windows.Forms;

namespace Code_Editor
{
    public partial class NewFile : Form
    {
        Form1 main;

        public NewFile(Form1 main)
        {
            InitializeComponent();
            
            this.main = main;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            main.CreateFile(projectNameTxt.Texts);
            Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
