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

        public void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
                text_memo.Text = File.ReadAllText(dialog.FileName);

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
