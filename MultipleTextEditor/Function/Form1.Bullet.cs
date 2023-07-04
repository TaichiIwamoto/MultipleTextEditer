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
            //箇条書き機能の有効化
            text_memo.SelectionBullet = true;
        }
    }
}
