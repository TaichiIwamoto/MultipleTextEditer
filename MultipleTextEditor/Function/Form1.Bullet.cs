/***************************************
担当者：Manato OHBA

概要：「バレット」ボタンが押された時の処理(バレット機能の有効化)

*************************************/

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
        private int strcount;
        private bool bulletEnabled = false;
        private string tmpstr;

        private void insertBullet()
        {
            int selectionCount = text_memo.SelectionStart;
            Console.WriteLine(selectionCount);
            try
            {
                if (text_memo.Text.Length == 0)
                {
                    text_memo.Text = "・";
                    Console.WriteLine("文頭処理");
                }
                else if (selectionCount == text_memo.Text.Length)
                {
                    if (text_memo.Text.EndsWith("\n"))
                    {
                        text_memo.SelectedText = "・";
                    }
                    else
                    {
                        text_memo.SelectedText = "\n・";
                    }
                    Console.WriteLine("文末処理");

                }

                else if (text_memo.Text.Substring(selectionCount - 1, 2).Equals("\n\n"))
                {
                    text_memo.SelectionStart = selectionCount;
                    text_memo.SelectedText = "・";
                    Console.WriteLine("Add ・ same line");
                    Console.WriteLine("/nで囲まれている");

                }
                else
                {
                    if (text_memo.Text.Substring(selectionCount).IndexOf("\n") == -1)
                    {
                        strcount = selectionCount + text_memo.Text.Substring(selectionCount).Length;
                        text_memo.SelectionStart = strcount;
                        text_memo.SelectedText = "\n・";
                    }
                    else
                    {

                        int strcount = selectionCount + text_memo.Text.Substring(selectionCount).IndexOf("\n");
                        text_memo.SelectionStart = strcount;
                        text_memo.SelectedText = "\n・";



                    }
                    Console.WriteLine("それ以外");
                }
            }catch (ArgumentException)
            {
                
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("bulletTest");
            tmpstr = text_memo.Text;

            if (bullet.Checked)
            {
                int selectionCount = text_memo.SelectionStart;
                Console.WriteLine(selectionCount);

                if (text_memo.Text.Length == 0)
                {
                    text_memo.Text = "・";
                    Console.WriteLine("文頭処理");

                }
                else if (selectionCount == text_memo.Text.Length)
                {
                    if (text_memo.Text.EndsWith("\n"))
                    {
                        text_memo.SelectedText = "・";
                    }
                    else
                    {
                        text_memo.SelectedText = "\n・";
                    }
                    Console.WriteLine("文末処理");

                }
                else if (text_memo.Text.Substring(selectionCount - 1, 2).Equals("\n\n"))
                {
                    text_memo.SelectedText = "・";
                    Console.WriteLine("Add ・ same line");
                    Console.WriteLine("/nで囲まれている");

                }
                else
                {
                    
                    if (text_memo.Text.Substring(selectionCount).IndexOf("\n") == -1)
                    {
                        strcount = selectionCount + text_memo.Text.Substring(selectionCount).Length;
                        text_memo.SelectionStart = strcount;
                        text_memo.SelectedText = "\n・";
                    }
                    else
                    {
                        strcount = selectionCount + text_memo.Text.Substring(selectionCount).IndexOf("\n");
                        text_memo.SelectionStart = strcount;
                        text_memo.SelectedText = "\n・";
                    }
                    Console.WriteLine("Add ・ next line");
                    Console.WriteLine("それ以外");


                }

                bulletEnabled = true;
                text_memo.KeyPress += text_memo_KeyPress;

            }
            else
            {
                bulletEnabled = false;
                text_memo.KeyPress -= text_memo_KeyPress;
            }
        }

        private void text_memo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                e.Handled = true;
                /*text_memo.SelectionStart = text_memo.TextLength;
                text_memo.SelectedText = "・";*/
                insertBullet();
            }
        }
    }
}