/*********************************************
担当者:Yutaro TANAKA

概要:ペイント機能のメイン処理
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
    public partial class Canvas : Form
    {
        Point startPosition;     //開始位置
        Point currentPosition;   //現在位置
        Point canvasStartPosition;
        bool drawing;
        public Canvas()
        {
            Screen[] screens = Screen.AllScreens;       //複数画面がある場合に1つの大きな画面として扱うために使用
            int left = 0;
            int top = 0;
            int right = 0;
            int bottom = 0;
            foreach (Screen screen in screens)
            {
                if (left > screen.Bounds.Left)
                {
                    left = screen.Bounds.Left;
                }
                if (top > screen.Bounds.Top)
                {
                    top = screen.Bounds.Top;
                }
                if (right < screen.Bounds.Right)
                {
                    right = screen.Bounds.Right;
                }
                if (bottom < screen.Bounds.Bottom)
                {
                    bottom = screen.Bounds.Bottom;
                }
            }

            canvasStartPosition = new Point(left, top);
            this.Location = canvasStartPosition;        //フォームの開始地点をモニタの左下に設定
            this.Size = new System.Drawing.Size(Math.Abs(left - right), Math.Abs(top - bottom));
            this.StartPosition = FormStartPosition.Manual;
            //this.WindowState = FormWindowState.Maximized;     //起動しても何も表示されない場合はここのコメントアウトを外してチェック
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Opacity = 0.75;
            this.Cursor = Cursors.Cross;
            this.MouseDown += Canvas_MouseDown;
            this.MouseMove += Canvas_MouseMove;
            this.MouseUp += Canvas_MouseUp;
            this.Paint += Canvas_Paint;
            this.KeyDown += Canvas_KeyDown;
            this.DoubleBuffered = true;
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(
                Math.Min(startPosition.X, currentPosition.X),
                Math.Min(startPosition.Y, currentPosition.Y),
                Math.Abs((startPosition.X - currentPosition.X)),
                Math.Abs((startPosition.Y - currentPosition.Y)));
        }

        public Rectangle DrawRectangle()     //マウスで指定した範囲を返す
        {
            return new Rectangle(
                (int)Math.Min((startPosition.X - canvasStartPosition.X), (currentPosition.X - canvasStartPosition.X)),
                (int)Math.Min((startPosition.Y - canvasStartPosition.Y), (currentPosition.Y - canvasStartPosition.Y)),
                (int)Math.Abs((startPosition.X - currentPosition.X)),
                (int)Math.Abs((startPosition.Y - currentPosition.Y)));
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                Pen pen = new Pen(Color.Red, 4);
                e.Graphics.DrawRectangle(pen, DrawRectangle());
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = e.Location + new Size(canvasStartPosition.X, canvasStartPosition.Y);
            if (drawing)
            {
                this.Invalidate();
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            currentPosition = startPosition = e.Location + new Size(canvasStartPosition.X, canvasStartPosition.Y);
            drawing = true;
        }
    }
}
