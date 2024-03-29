﻿/***************************************
担当者：Manato OHBA

概要：「自動保存」ボタンが押された時の処理(自動保存機能のON,OFF)

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
        public bool isOverWrite = false;

        private void 自動保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem.Checked == true)
            {
                clickedItem.Checked = false;
                autoSave.Enabled = false;
            }
            else if (clickedItem.Checked == false && isOverWrite == true)
            {
                clickedItem.Checked = true;
                autoSave.Enabled = true;
            }
            else if (clickedItem.Checked == false && isOverWrite == false)
            {
                MessageBox.Show("ファイルを開くか保存してください");
            }
        }
    }
}