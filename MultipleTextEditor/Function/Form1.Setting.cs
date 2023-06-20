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

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        private void FontToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ChangeToolStripMenuItemBackgroundColors();
            // フォントダイアログを表示してユーザーにフォントサイズを選択させる
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択されたフォントサイズを適用する
                text_memo.Font = fontDialog.Font;
            }
        }
        
        private void StartupToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            // スタートアップのキーを取得
            RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // アプリケーションの実行ファイルのパスを取得
            string appPath = Application.ExecutablePath;

            // スタートアップに登録されているかチェック
            bool isStartupEnabled = startupKey.GetValue("MultipleTextEditor") != null;

            if (isStartupEnabled)
            {
                // スタートアップから削除
                startupKey.DeleteValue("MultipleTextEditor");
                MessageBox.Show("スタートアップ機能を無効にしました。");
                // フラッシュメッセージを表示
                ShowFlashMessage("スタートアップ機能を無効にしました。");
            }
            else
            {
                // スタートアップに追加
                startupKey.SetValue("MultipleTextEditor", appPath);
                MessageBox.Show("スタートアップ機能を有効にしました。");
                // フラッシュメッセージを表示
                ShowFlashMessage("スタートアップ機能を有効にしました。");
            }
        }

    }
    private void ShowFlashMessage(string message)
    {
        // フラッシュメッセージを表示するための通知アイコンを作成
        NotifyIcon notifyIcon = new NotifyIcon();
        notifyIcon.Visible = true;
        notifyIcon.Icon = SystemIcons.Information;

        // フラッシュメッセージを表示
        notifyIcon.ShowBalloonTip(2000, "情報", message, ToolTipIcon.Info);

        // アイコンを破棄してリソースを解放
        notifyIcon.Dispose();
    }
}
