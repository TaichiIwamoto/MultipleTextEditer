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
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, text_memo.Text);
            }

            //上書き保存を有効化
            FileName = dialog.FileName;
            OverWriteToolStripMenuItem.Enabled = true;
            autoSave.Enabled = true;
            isOverWrite = true;
            自動保存ToolStripMenuItem.Checked = true;


            //ウィンドウ名の変更
            Text = Path.GetFileName(FileName);
        }
    }
}
