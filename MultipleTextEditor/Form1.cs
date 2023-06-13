using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        private string FileName = ""; //現在開いているファイル名

        //MenuStripの背景色をデフォルトカラーに戻す関数
        private void ChangeToolStripMenuItemBackgroundColors()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.WhiteSmoke ; 
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            text_memo.Text = File.ReadAllText(dialog.FileName);

            //上書き保存を有効化
            FileName = dialog.FileName;
            上書き保存ToolStripMenuItem.Enabled = true;

            //ウィンドウ名の変更
            Text = Path.GetFileName(FileName);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
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
            上書き保存ToolStripMenuItem.Enabled = true;

            //ウィンドウ名の変更
            Text = Path.GetFileName(FileName);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("メモ帳を終了します", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, text_memo.Text);
        }

        private void 新規ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_memo.Text = "";
            Text = "無題 - メモ帳";
            上書き保存ToolStripMenuItem.Enabled = false;
        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
        }


        private void ノートToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            ノートToolStripMenuItem.BackColor = Color.Gray;
        }

        private void メモToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            メモToolStripMenuItem.BackColor = Color.Gray;
        }

        private void リストToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            リストToolStripMenuItem.BackColor = Color.Gray;
        }

        private void バレットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            //バレットの背景色変更
            バレットToolStripMenuItem.BackColor = Color.Gray;

            //箇条書き機能の有効化
            text_memo.SelectionBullet = true;

            
        }

        private void イメージToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            イメージToolStripMenuItem.BackColor = Color.Gray;
        }

        private void カメラToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            カメラToolStripMenuItem.BackColor = Color.Gray;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
        }

        private void 自動保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void フォントToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            // フォントダイアログを表示してユーザーにフォントサイズを選択させる
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択されたフォントサイズを適用する
                text_memo.Font = fontDialog.Font;
            }
        }
    }
}
