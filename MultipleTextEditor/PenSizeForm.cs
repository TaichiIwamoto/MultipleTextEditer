/*********************************************
担当者:Yutaro TANAKA

概要:ペンサイズの変更処理
*********************************************/

using System;
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
    public partial class PenSizeForm : Form
    {
        private NumericUpDown numericUpDown;
        private Button btnOK;
        private Button btnCancel;

        public float PenSize { get; private set; }

        public PenSizeForm(float initialPenSize)
        {
            //InitializeComponent();
            this.Text = "ペンの太さ";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(370, 300);

            Label label = new Label();
            label.Text = "ペンの太さ:";
            label.Location = new Point(20, 20);
            label.AutoSize = true;
            this.Controls.Add(label);

            numericUpDown = new NumericUpDown();
            numericUpDown.Value = (decimal)initialPenSize;
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 10;
            numericUpDown.Location = new Point(120, 18);
            numericUpDown.TextAlign = HorizontalAlignment.Right;
            this.Controls.Add(numericUpDown);

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(20, 60);
            btnOK.Size = new Size(150, 46);
            this.Controls.Add(btnOK);

            btnCancel = new Button();
            btnCancel.Text = "キャンセル";
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(180, 60);
            btnCancel.Size = new Size(150, 46);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            PenSize = (float)numericUpDown.Value;
        }
    }
}
