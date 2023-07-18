/*********************************************
担当者:Yutaro TANAKA

概要:ペイント機能のメインフォーム

Ver:Release_1.1

修正済みのバグ
T4-7    修正完了
T4-8    そのような仕様ではない
T4-9    修正完了
T4-10   複数のウィンドウを開くことができる仕様
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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;



namespace MultipleTextEditor
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing;
        private Point previousPoint;
        private Pen currentPen;
        private Bitmap canvas;
        public DrawingForm()
        {
            InitializeComponent();
            isDrawing = false;
            previousPoint = Point.Empty;
            currentPen = new Pen(Color.Black, 2);
            canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = canvas;
            Cursor myCursor = new Cursor(@"Pencil01_White.cur");
            this.Cursor = myCursor;
        }


        private void DrawingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentPen.Dispose();
            canvas.Dispose();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(currentPen, previousPoint, e.Location);
                }
                pictureBox.Refresh();
                previousPoint = e.Location;
            }
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        private void btnPenColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentPen.Color; // 現在のペンの色を初期選択色として設定

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentPen.Color = colorDialog.Color;
                    btnPenColor.BackColor = currentPen.Color; // ボタンの背景色をペンの色に設定
                }
            }
        }
        private void btnPenSize_Click(object sender, EventArgs e)
        {
            using (PenSizeForm penSizeForm = new PenSizeForm(currentPen.Width))
            {
                if (penSizeForm.ShowDialog() == DialogResult.OK)
                {
                    currentPen.Width = penSizeForm.PenSize;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string defaultFileName = "drawing_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNGファイル (*.png)|*.png";
                saveFileDialog.FileName = defaultFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    canvas.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show($"画像を保存しました: {fileName}");
                }
            }
        }

        private void DrawingForm_ResizeEnd(object sender, EventArgs e)
        {
            // pictureBox の大きさをフォームのクライアント領域に合わせる
            pictureBox.Size = new Size(ClientSize.Width, ClientSize.Height);
            // キャンバスを再作成してサイズを合わせる
            Bitmap newCanvas;
            try
            {
                newCanvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            }
            catch (System.ArgumentException)
            {
                newCanvas = new Bitmap(1, 1);
            }
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                g.DrawImage(canvas, Point.Empty);
            }
            canvas.Dispose();
            canvas = newCanvas;
            pictureBox.Image = canvas;
        }
    }
}
