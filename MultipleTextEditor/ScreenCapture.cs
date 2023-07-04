using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MultipleTextEditor
{
    class ScreenCapture
    {
        private Rectangle canvasBounds = Screen.GetBounds(Point.Empty);
        private int minArea = 1000;     //この値を変更すると選択範囲の許容最小面積を変更することができる

        public ScreenCapture()
        {
            SetCanvas();
        }

        public Bitmap GetSnapShot()
        {
            while (canvasBounds.Width * canvasBounds.Height <= minArea)
            {
                SetCanvas();
            }
            using (Image image = new Bitmap(canvasBounds.Width, canvasBounds.Height))
            {
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(new Point
                    (canvasBounds.Left, canvasBounds.Top), Point.Empty, canvasBounds.Size);
                }
                return new Bitmap(SetBorder(image, Color.Black, 1));
            }
        }

        private Image SetBorder(Image srcImg, Color color, int width)
        {
            // Create a copy of the image and graphics context
            Image dstImg = srcImg.Clone() as Image;
            Graphics g = Graphics.FromImage(image: dstImg);

            // Create the pen
            Pen pBorder = new Pen(color, width) {
                //Alignment = PenAlignment.Center
            };

            // Draw
            g.DrawRectangle(pBorder, 0, 0, dstImg.Width - 1, dstImg.Height - 1);

            // Clean up
            pBorder.Dispose();
            g.Save();
            g.Dispose();

            // Return
            return dstImg;
        }

        public void SetCanvas()
        {
            using (Canvas canvas = new Canvas())
            {
                if (canvas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.canvasBounds = canvas.GetRectangle();
                }
            }
        }
    }
}
