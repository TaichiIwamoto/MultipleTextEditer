﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTextEditor
{
    public partial class DebugDialogue : Form
    {
        public String str;

        public void setStr(String str)
        {
            this.str = str;
        }
        public DebugDialogue()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = str;
        }

    }
}
