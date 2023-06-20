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
using MultipleTextEditor.Json;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        

        private void PageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            PageToolStripMenuItem.BackColor = Color.Gray;
            int page = 1;

            if (PageToolStripMenuItem.DropDownItems.Count == 0)
            {  
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = String.Concat("Page",page.ToString());
                PageToolStripMenuItem.DropDownItems.Add(tsmi.Text,null,Page_Click);
                PageToolStripMenuItem.DropDownItems.Add("新規ページ",null,NewPage_Click);
            }
        }
        private void NewPage_Click(object sender,EventArgs e)
        {
            int count = PageToolStripMenuItem.DropDownItems.Count;
            PageToolStripMenuItem.DropDownItems.RemoveAt(count-1);
            PageToolStripMenuItem.DropDownItems.Add("Page" + count.ToString(),null,Page_Click);
            PageToolStripMenuItem.DropDownItems.Add("新規ページ", null, NewPage_Click);
            Console.WriteLine("新規ページ作成");
        }
        private void Page_Click(Object sender,EventArgs e)
        {
            DataManager dm = new DataManager();
            string memo = "";
            string page = sender.ToString();
            page = page.Replace("Page", "");
            int ipage = int.Parse(page);
            memo = text_memo.Text;
            dm.SaveData(ipage, memo);


            Console.WriteLine(memo);
        }
    }
}
