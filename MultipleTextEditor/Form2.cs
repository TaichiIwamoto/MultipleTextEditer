/*********************************************
担当者:Yutaro TANAKA

Ver:Release_1.1

修正済みのバグ
T5-4    修正完了
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

namespace MultipleTextEditor
{
    public partial class Form2 : Form
    {
        private ScreenCapture objScreenCapture;
        private List<Bitmap> snaps;
        bool isFirst = true;
        public Form2()
        {
            InitializeComponent();
            snaps = new List<Bitmap>();
        }

        private void TakeSnap()
        {
            var snap = objScreenCapture.GetSnapShot();
            snaps.Add(snap);
            AddToPreview(snap);
        }

        private void AddToPreview(Bitmap snap)
        {
            DateTime now = DateTime.Now;
            imageList1.Images.Add(snap);
            listView1.Items.Add(new ListViewItem
            ("Snap_" + now.ToString("yyyyMMddHHmmss"), imageList1.Images.Count - 1)).EnsureVisible();
        }

        private const int SRCCOPY = 13369376;
        private const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;

        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, out Rect rect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, out Rect rect, int cbAttribute);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hdc);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);


        /*private void fullScreen_Click(object sender, EventArgs e)
        {
            //アプリを透過させる
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            //fullScreen.BackColor = Color.Transparent;
            this.Opacity = 0;

            //プライマリスクリーン全体の大きさを取得
            //Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);    //null参照の可能性があるので
            Bitmap bitmap_fullScreen = new Bitmap(Screen.PrimaryScreen?.Bounds.Width ?? 0, Screen.PrimaryScreen?.Bounds.Height ?? 0);
            Graphics g = Graphics.FromImage(bitmap_fullScreen);

            //画面を撮影
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bitmap_fullScreen.Size);

            //解放
            g.Dispose();

            //透過解除
            this.TransparencyKey = Color.Empty;
            //fullScreen.BackColor = Color.White;
            this.Opacity = 1.00;

            //表示
            pictureBox1.Image = bitmap_fullScreen;
        }

        private void activeWindow_Click(object sender, EventArgs e)
        {
            //アプリを最小化させる
            this.WindowState = FormWindowState.Minimized;

            Rect bounds, rect;

            //アクティブウィンドウを取得
            IntPtr hWnd = GetForegroundWindow();
            IntPtr winDC = GetWindowDC(hWnd);
            DwmGetWindowAttribute(hWnd, DWMWA_EXTENDED_FRAME_BOUNDS, out bounds, Marshal.SizeOf(typeof(Rect)));
            GetWindowRect(hWnd, out rect);

            var offsetX = bounds.left - rect.left;
            var offsetY = bounds.top - rect.top;

            //大きさを基に撮影
            int width = bounds.right - bounds.left, hight = bounds.bottom - bounds.top;
            //Console.WriteLine(width);
            //Console.WriteLine(hight);
            Bitmap bitmap_Window = new Bitmap(width, hight);
            Graphics g = Graphics.FromImage(bitmap_Window);
            IntPtr hDC = g.GetHdc();

            BitBlt(hDC, 0, 0, bitmap_Window.Width, bitmap_Window.Height, winDC, offsetX, offsetY, SRCCOPY);
            g.ReleaseHdc(hDC);
            g.Dispose();
            ReleaseDC(hWnd, winDC);

            //アプリを元の大きさに復元する
            this.WindowState = FormWindowState.Normal;

            //表示
            pictureBox1.Image = bitmap_Window;
        }

        private void customArea_Click(object sender, EventArgs e)
        {
            //範囲指定(引数としてもらう)
            int x = 200;
            int y = 200;
            int width = 800;
            int height = 500;

            //アプリを透過させる
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            //fullScreen.BackColor = Color.Transparent;
            this.Opacity = 0;

            //指定範囲のキャプチャ
            Rectangle rectangle = new Rectangle(x, y, width, height);
            Bitmap bitmap_CA = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics g = Graphics.FromImage(bitmap_CA);
            g.CopyFromScreen(new Point(rectangle.X, rectangle.Y), new Point(0, 0), bitmap_CA.Size);
            g.Dispose();

            //透過解除
            this.TransparencyKey = Color.Empty;
            //fullScreen.BackColor = Color.White;
            this.Opacity = 1.00;

            //表示
            pictureBox1.Image = bitmap_CA;

        }*/

        private void 全画面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリを透過させる
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            //fullScreen.BackColor = Color.Transparent;
            this.Opacity = 0;

            //プライマリスクリーン全体の大きさを取得
            //Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);    //null参照の可能性があるので
            Bitmap bitmap_fullScreen = new Bitmap(Screen.PrimaryScreen?.Bounds.Width ?? 0, Screen.PrimaryScreen?.Bounds.Height ?? 0);
            Graphics g_full = Graphics.FromImage(bitmap_fullScreen);

            //画面を撮影
            g_full.CopyFromScreen(new Point(0, 0), new Point(0, 0), bitmap_fullScreen.Size);

            //解放
            g_full.Dispose();

            //透過解除
            this.TransparencyKey = Color.Empty;
            //fullScreen.BackColor = Color.White;
            this.Opacity = 1.00;

            //表示
            pictureBox1.Image = bitmap_fullScreen;

            //保存
            snaps.Add(bitmap_fullScreen);
            AddToPreview(bitmap_fullScreen);
        }

        private void アクティブウィンドウToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリを最小化させる
            this.WindowState = FormWindowState.Minimized;

            Rect bounds, rect;

            //アクティブウィンドウを取得
            IntPtr hWnd = GetForegroundWindow();
            IntPtr winDC = GetWindowDC(hWnd);
            DwmGetWindowAttribute(hWnd, DWMWA_EXTENDED_FRAME_BOUNDS, out bounds, Marshal.SizeOf(typeof(Rect)));
            GetWindowRect(hWnd, out rect);

            var offsetX = bounds.left - rect.left;
            var offsetY = bounds.top - rect.top;

            //大きさを基に撮影
            int width = bounds.right - bounds.left, hight = bounds.bottom - bounds.top;
            //Console.WriteLine(width);
            //Console.WriteLine(hight);
            Bitmap bitmap_Window = new Bitmap(width, hight);
            Graphics g_active = Graphics.FromImage(bitmap_Window);
            IntPtr hDC = g_active.GetHdc();

            BitBlt(hDC, 0, 0, bitmap_Window.Width, bitmap_Window.Height, winDC, offsetX, offsetY, SRCCOPY);
            g_active.ReleaseHdc(hDC);
            g_active.Dispose();
            ReleaseDC(hWnd, winDC);

            //アプリを元の大きさに復元する
            this.WindowState = FormWindowState.Normal;

            //表示
            pictureBox1.Image = bitmap_Window;

            //保存
            snaps.Add(bitmap_Window);
            AddToPreview(bitmap_Window);

            //アプリを元の大きさに復元する
            this.WindowState = FormWindowState.Normal;
        }

        private void 選択範囲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFirst) {            
                objScreenCapture = new ScreenCapture();
                isFirst = false;
            }
            else {            
                objScreenCapture.SetCanvas();
            }
            TakeSnap();

            //表示
            pictureBox1.Image = snaps[snaps.Count - 1];
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snaps.Count < 1)
            {
                return;
            }
            else
            {
                string defaultFileName = "Screenshot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";


                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNGファイル (*.png)|*.png";
                    saveFileDialog.FileName = defaultFileName;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        snaps[snaps.Count - 1].Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show($"画像を保存しました: {fileName}");
                    }
                }
            }
        }

        private void すべて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.SaveAsImages(snaps);
        }
    }
}
