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
using MultipleTextEditor;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        public bool isOverWrite = false;

        private void 自動保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            if (clickedItem.Checked == true)
            {
                clickedItem.Checked = !clickedItem.Checked;
                autoSave.Enabled = false;
            }

            if (clickedItem.Checked == false && isOverWrite == true)
            {
                clickedItem.Checked = !clickedItem.Checked;
                autoSave.Enabled = true;

            }

            if (clickedItem.Checked == false && isOverWrite == false)
            {
                MessageBox.Show("ファイルを開くか保存してください");

            }
        }
    }
}