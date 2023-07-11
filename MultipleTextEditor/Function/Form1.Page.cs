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

        
        private int prePageNum = 1;
        private int currentPageNum = 1;
        private string page = "page1";
        private void PageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
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


            SaveData sd = new SaveData();
            string memo;
            string page = sender.ToString();
            PageNum.Text = page;
            page = page.Replace("Page", "");
            int ipage = int.Parse(page);
            currentPageNum = ipage;


            memo = text_memo.Text;
            if (pageOpen != true)
            {
                try
                {
                    if (pageData.ContainsKey(prePageNum) && text_memo.Text != "")
                    {
                        pageData.Remove(prePageNum);
                    }
                    pageData.Add(prePageNum, memo);
                }
                catch (ArgumentException)
                {
                    prePageNum = ipage;
                }

                sd.SavePage(path, pageData);
            }
            pageOpen = false;
            prePageNum = ipage;

            //Console.WriteLine("Save Start");
            if (pageData.ContainsKey(ipage))
            {
                text_memo.Text = pageData[ipage];
            }
            else
            {
            text_memo.Text = "";

            }
            UpdateButtonVisibility();
        }
    }
}
