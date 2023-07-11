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
        private bool bulletEnabled = false;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (bullet.Checked)
            {   
                text_memo.SelectedText = Environment.NewLine + "・";
                bulletEnabled = true;
                text_memo.KeyPress += text_memo_KeyPress;
            }
            else
            {
                bulletEnabled = false;
                text_memo.KeyPress -= text_memo_KeyPress;
            }
        }

        private void text_memo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                text_memo.SelectionStart = text_memo.TextLength;
                text_memo.SelectedText = "・";
            }
        }
    }

}
