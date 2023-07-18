/*********************************************
担当者:Yutaro TANAKA

概要:画像を保存する機能
*********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MultipleTextEditor
{
    class Utility
    {
        public static void SaveAsImages(List<Bitmap> images)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int count = 1;
                    foreach (Bitmap img in images)
                    {
                        img.Save(dialog.SelectedPath + "\\Snap_" + (count++) + ".bmp");
                    }
                }
            }
        }
    }
}
