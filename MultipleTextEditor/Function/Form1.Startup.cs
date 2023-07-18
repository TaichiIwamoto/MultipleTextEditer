/* 
 担当者　Kotaro Shirai (github name takuuo2)

 概要:C10 設定変更
 スタートアップ機能のオン、オフを設定する
 
 */
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
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/* 
 担当者　Kotaro Shirai (github name takuuo2)

 概要:C10 設定変更
 スタートアップ機能のオン、オフを設定する
 
 */
namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {


        private void StartupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // アプリケーションの実行パスを取得
            string appPath = System.Reflection.Assembly.GetEntryAssembly().Location;

            // レジストリキーを開く
            RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // キーが存在しない場合は作成
            if (startupKey == null)
            {
                startupKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            }

            // キーにアプリケーションの実行パスを設定
            startupKey.SetValue("MultipleTextEditor", appPath);

            // レジストリキーを閉じる
            startupKey.Close();
            MessageBox.Show("スタートアップ機能がオンになりました。");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // レジストリキーを開く
            RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // キーが存在する場合は削除
            if (startupKey != null)
            {
                startupKey.DeleteValue("MultipleTextEditor", false);
                startupKey.Close();
            }

            MessageBox.Show("スタートアップ機能がオフになりました。");
        }

        


    }
}
