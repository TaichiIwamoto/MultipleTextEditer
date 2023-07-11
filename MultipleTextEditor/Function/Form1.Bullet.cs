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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            text_memo.SelectionBullet = true;
            
            if (bullet.Checked)
            {
                text_memo.KeyPress += text_memo_KeyPress;
            }
            else
            {
                text_memo.KeyPress -= text_memo_KeyPress;
            }
        }

        private void text_memo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                text_memo.SelectionBullet = true;
                e.Handled = true;
            }
        }
    }
}
