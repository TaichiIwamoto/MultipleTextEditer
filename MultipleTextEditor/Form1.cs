/**************************************
担当者：Manato OHBA

概要：メイン機能の処理
      ボタンを押した際の処理など
**************************************/

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);
        string FileName = ""; //現在開いているファイル名

        
        

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
            memo.Checked = true;

        }
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
        }

 
        

        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
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
            timer1.Interval = 3000; // 30秒
            timer1.Enabled = true;

            if (!pageData.ContainsValue(text_memo.Text))
            {
                if (pageData.ContainsKey(currentPageNum))
                {
                    pageData.Remove(currentPageNum);
                }
                pageData.Add(currentPageNum, text_memo.Text);
            }

            sd.SavePage(path, pageData);

        }
        
        private void memo_CheckedChanged(object sender, EventArgs e)
        {
            text_memo.SelectionBullet = false;
        }

        private void screenshot_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void image_Click(object sender, EventArgs e)
        {
            
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.Show();
            
        }

        private void PageNum_Click(object sender, EventArgs e)
        {
        }


    }
}
