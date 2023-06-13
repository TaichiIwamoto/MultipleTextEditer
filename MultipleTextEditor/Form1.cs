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
using System.Runtime.InteropServices;


namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, out Rect rect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, out Rect rect, int cbAttribute);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hdc);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);
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
            autoSave.Enabled = true;


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
            autoSave.Enabled = true;


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
            autoSave.Enabled = false;


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

        

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
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


       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            autoSaveDialog.Visible = false;
            timer1.Enabled = false;
        }

        private void autoSave_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, text_memo.Text);

          
            autoSaveDialog.Visible = true;
            timer1.Interval = 3000; // 3秒
            timer1.Enabled = true;

        }


      




        private const int SRCCOPY = 13369376;
        private const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;

        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }



        





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //箇条書き機能の有効化
            text_memo.SelectionBullet = true;
        }

        private void list_CheckedChanged(object sender, EventArgs e)
        {
            Console.Write("Hello");
        }

        private void memo_CheckedChanged(object sender, EventArgs e)
        {
            text_memo.SelectionBullet = false;
        }

        private void screenshot_CheckedChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void image_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
