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
        private void OverWriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pageData.ContainsValue(text_memo.Text))
            {
                if (pageData.ContainsKey(currentPageNum))
                {
                    pageData.Remove(currentPageNum);
                }
                pageData.Add(currentPageNum, text_memo.Text);
            }

            sd.SavePage(path, pageData);

        }

    }
}