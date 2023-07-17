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
using MultipleTextEditor.PageSave;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> pageData = new Dictionary<int, string>();
        private int pageCount = 0;
        private bool pageOpen = false;

        public void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "多機能テキストエディタ(*.mte)|*.mte";
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
            string loadName = Text.Replace(".mte", "");
            path = "Data/" + loadName;

            if (path != "Data/")
            {

                LoadData ld = new LoadData();
                pageData = ld.LoadPage(path);
                if (pageData[1].Equals("#データが存在しませんでした.")){
                    Directory.CreateDirectory(path);
                    File.Create(path + "/PageData.txt").Close();
                }

                pageCount = pageData.Count();
                text_memo.Text = pageData[1];

                PageToolStripMenuItem.DropDownItems.Clear();
                foreach (var entry in pageData)
                {
                    Console.WriteLine(entry.Key + " " + entry.Value);
                }
                for (int i = 0; i <= pageCount - 1; i++)
                {
                    ToolStripMenuItem tsmi2 = new ToolStripMenuItem();
                    tsmi2.Text = String.Concat("Page", (i + 1).ToString());
                    PageToolStripMenuItem.DropDownItems.Add(tsmi2.Text, null, Page_Click);
                    Console.WriteLine("Page Added");
                }
                PageToolStripMenuItem.DropDownItems.Add("新規ページ", null, NewPage_Click);
                pageOpen = true;
            }
        }
    }
}
