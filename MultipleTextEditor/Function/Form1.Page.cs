using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        private void PageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            PageToolStripMenuItem.BackColor = Color.Gray;
        }

    }
}
