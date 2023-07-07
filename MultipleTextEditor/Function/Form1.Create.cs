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
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_memo.Text = "";
            Text = "無題 - メモ帳";
            OverWriteToolStripMenuItem.Enabled = false;
            autoSave.Enabled = false;
            PageToolStripMenuItem.DropDownItems.Clear();
            pageData.Clear();
            prePageNum = 1;
            PageNum.Text = "Page1";

            isOverWrite = false;
            自動保存ToolStripMenuItem.Checked = false;
        }
    }
}
