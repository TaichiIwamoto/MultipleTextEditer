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
        private string font;
        private void FontToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            // フォントダイアログを表示してユーザーにフォントサイズを選択させる
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択されたフォントサイズを適用する
                text_memo.Font = fontDialog.Font;
                font = text_memo.Font.ToString();
                sd.SaveFont(path, font);
            }
        }

    }
}
