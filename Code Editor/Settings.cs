using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor
{
    public partial class Settings : Form
    {
        Form1 main;

        public Settings(Form1 main)
        {
            InitializeComponent();

            this.main = main;
        }
    }
}
