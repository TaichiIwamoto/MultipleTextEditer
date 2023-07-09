
using System;

namespace MultipleTextEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OverWriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.自動保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_memo = new System.Windows.Forms.RichTextBox();
            this.autoSave = new System.Windows.Forms.Timer(this.components);
            this.bullet = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.RadioButton();
            this.memo = new System.Windows.Forms.RadioButton();
            this.screenshot = new System.Windows.Forms.RadioButton();
            this.image = new System.Windows.Forms.RadioButton();
            this.autoSaveDialog = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PageNum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.PageToolStripMenuItem,
            this.ConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(803, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.OverWriteToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.FileToolStripMenuItem.Text = "ファイル";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CreateToolStripMenuItem.Text = "新規";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.OpenToolStripMenuItem.Text = "開く";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OverWriteToolStripMenuItem
            // 
            this.OverWriteToolStripMenuItem.Enabled = false;
            this.OverWriteToolStripMenuItem.Name = "OverWriteToolStripMenuItem";
            this.OverWriteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.OverWriteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OverWriteToolStripMenuItem.Text = "上書き保存";
            this.OverWriteToolStripMenuItem.Click += new System.EventHandler(this.OverWriteToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.SaveToolStripMenuItem.Text = "名前を付けて保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ExitToolStripMenuItem.Text = "終了";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PageToolStripMenuItem
            // 
            this.PageToolStripMenuItem.Name = "PageToolStripMenuItem";
            this.PageToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.PageToolStripMenuItem.Text = "ページ";
            this.PageToolStripMenuItem.Click += new System.EventHandler(this.PageToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.StartupToolStripMenuItem,
            this.自動保存ToolStripMenuItem});
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.ConfigToolStripMenuItem.Text = "設定";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.FontToolStripMenuItem.Text = "フォント";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // StartupToolStripMenuItem
            // 
            this.StartupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.StartupToolStripMenuItem.Name = "StartupToolStripMenuItem";
            this.StartupToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.StartupToolStripMenuItem.Text = "スタートアップ";
            this.StartupToolStripMenuItem.Click += new System.EventHandler(this.StartupToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(92, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem1.Text = "ON";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(95, 22);
            this.toolStripMenuItem2.Text = "OFF";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 自動保存ToolStripMenuItem
            // 
            this.自動保存ToolStripMenuItem.Name = "自動保存ToolStripMenuItem";
            this.自動保存ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.自動保存ToolStripMenuItem.Text = "自動保存";
            this.自動保存ToolStripMenuItem.Click += new System.EventHandler(this.自動保存ToolStripMenuItem_Click);
            // 
            // text_memo
            // 
            this.text_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_memo.Location = new System.Drawing.Point(0, 25);
            this.text_memo.Name = "text_memo";
            this.text_memo.Size = new System.Drawing.Size(803, 425);
            this.text_memo.TabIndex = 2;
            this.text_memo.Text = "";
            this.text_memo.TextChanged += new System.EventHandler(this.text_memo_TextChanged);
            this.text_memo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_memo_KeyDown);
            // 
            // autoSave
            // 
            this.autoSave.Interval = 10000;
            this.autoSave.Tick += new System.EventHandler(this.autoSave_Tick);
            // 
            // bullet
            // 
            this.bullet.Appearance = System.Windows.Forms.Appearance.Button;
            this.bullet.Location = new System.Drawing.Point(152, 0);
            this.bullet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(70, 24);
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = true;
            this.bullet.Text = "バレット";
            this.bullet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bullet.UseVisualStyleBackColor = true;
            this.bullet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // list
            // 
            this.list.Appearance = System.Windows.Forms.Appearance.Button;
            this.list.Location = new System.Drawing.Point(232, 1);
            this.list.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(70, 24);
            this.list.TabIndex = 5;
            this.list.TabStop = true;
            this.list.Text = "リスト";
            this.list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.list.UseVisualStyleBackColor = true;
            this.list.CheckedChanged += new System.EventHandler(this.list_CheckedChanged);
            // 
            // memo
            // 
            this.memo.Appearance = System.Windows.Forms.Appearance.Button;
            this.memo.Location = new System.Drawing.Point(312, 1);
            this.memo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(70, 24);
            this.memo.TabIndex = 6;
            this.memo.TabStop = true;
            this.memo.Text = "メモ";
            this.memo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.memo.UseVisualStyleBackColor = true;
            this.memo.CheckedChanged += new System.EventHandler(this.memo_CheckedChanged);
            // 
            // screenshot
            // 
            this.screenshot.Appearance = System.Windows.Forms.Appearance.Button;
            this.screenshot.Location = new System.Drawing.Point(466, 0);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(70, 24);
            this.screenshot.TabIndex = 7;
            this.screenshot.TabStop = true;
            this.screenshot.Text = "スクショ";
            this.screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.CheckedChanged += new System.EventHandler(this.screenshot_CheckedChanged);
            // 
            // image
            // 
            this.image.Appearance = System.Windows.Forms.Appearance.Button;
            this.image.Location = new System.Drawing.Point(390, 1);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(70, 24);
            this.image.TabIndex = 8;
            this.image.TabStop = true;
            this.image.Text = "ペイント";
            this.image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.image.UseVisualStyleBackColor = true;
            this.image.CheckedChanged += new System.EventHandler(this.image_CheckedChanged);
            // 
            // autoSaveDialog
            // 
            this.autoSaveDialog.AutoSize = true;
            this.autoSaveDialog.Location = new System.Drawing.Point(743, 0);
            this.autoSaveDialog.Name = "autoSaveDialog";
            this.autoSaveDialog.Size = new System.Drawing.Size(59, 12);
            this.autoSaveDialog.TabIndex = 9;
            this.autoSaveDialog.Text = "Autosaved";
            this.autoSaveDialog.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.BackColor = System.Drawing.Color.White;
            this.PageNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PageNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.PageNum.Enabled = false;
            this.PageNum.ForeColor = System.Drawing.Color.Black;
            this.PageNum.Location = new System.Drawing.Point(765, 25);
            this.PageNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(38, 14);
            this.PageNum.TabIndex = 10;
            this.PageNum.Text = "Page1";
            this.PageNum.Click += new System.EventHandler(this.PageNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.text_memo);
            this.Controls.Add(this.autoSaveDialog);
            this.Controls.Add(this.image);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.list);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "多機能テキストエディタ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OverWriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartupToolStripMenuItem;
       
        private System.Windows.Forms.ToolStripMenuItem 自動保存ToolStripMenuItem;
        private System.Windows.Forms.Timer autoSave;
        private System.Windows.Forms.RadioButton bullet;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.RadioButton memo;
        private System.Windows.Forms.RadioButton screenshot;
        private System.Windows.Forms.RadioButton image;
        private System.Windows.Forms.Label autoSaveDialog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox text_memo;
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

