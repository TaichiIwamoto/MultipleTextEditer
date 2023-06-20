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
            // �t�H���g�_�C�A���O��\�����ă��[�U�[�Ƀt�H���g�T�C�Y��I��������
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // �I�����ꂽ�t�H���g�T�C�Y��K�p����
                text_memo.Font = fontDialog.Font;
            }
        }
        
        private void StartupToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            // �X�^�[�g�A�b�v�̃L�[���擾
            RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // �A�v���P�[�V�����̎��s�t�@�C���̃p�X���擾
            string appPath = Application.ExecutablePath;

            // �X�^�[�g�A�b�v�ɓo�^����Ă��邩�`�F�b�N
            bool isStartupEnabled = startupKey.GetValue("MultipleTextEditor") != null;

            if (isStartupEnabled)
            {
                // �X�^�[�g�A�b�v����폜
                startupKey.DeleteValue("MultipleTextEditor");
                MessageBox.Show("�X�^�[�g�A�b�v�@�\�𖳌��ɂ��܂����B");
                // �t���b�V�����b�Z�[�W��\��
                ShowFlashMessage("�X�^�[�g�A�b�v�@�\�𖳌��ɂ��܂����B");
            }
            else
            {
                // �X�^�[�g�A�b�v�ɒǉ�
                startupKey.SetValue("MultipleTextEditor", appPath);
                MessageBox.Show("�X�^�[�g�A�b�v�@�\��L���ɂ��܂����B");
                // �t���b�V�����b�Z�[�W��\��
                ShowFlashMessage("�X�^�[�g�A�b�v�@�\��L���ɂ��܂����B");
            }
        }

    }
    private void ShowFlashMessage(string message)
    {
        // �t���b�V�����b�Z�[�W��\�����邽�߂̒ʒm�A�C�R�����쐬
        NotifyIcon notifyIcon = new NotifyIcon();
        notifyIcon.Visible = true;
        notifyIcon.Icon = SystemIcons.Information;

        // �t���b�V�����b�Z�[�W��\��
        notifyIcon.ShowBalloonTip(2000, "���", message, ToolTipIcon.Info);

        // �A�C�R����j�����ă��\�[�X�����
        notifyIcon.Dispose();
    }
}
