using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor
{
    public class Errors
    {
        public static void NoOpenProject(string sender)
        {
            MessageBox.Show("Must have an open project.", sender, MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        public static void BlankFields(string sender)
        {
            MessageBox.Show("One or more fields were left blank.", sender, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
