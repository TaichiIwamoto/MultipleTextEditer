﻿
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
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ノートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートアップToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リストの型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントサイズToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_memo = new System.Windows.Forms.RichTextBox();
            this.autoSave = new System.Windows.Forms.Timer(this.components);
            this.bullet = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.RadioButton();
            this.memo = new System.Windows.Forms.RadioButton();
            this.screenshot = new System.Windows.Forms.RadioButton();
            this.image = new System.Windows.Forms.RadioButton();
            this.autoSaveDialog = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ノートToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.上書き保存ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            this.ファイルToolStripMenuItem.Click += new System.EventHandler(this.ファイルToolStripMenuItem_Click);
            // 
            // 新規ToolStripMenuItem
            // 
            this.新規ToolStripMenuItem.Name = "新規ToolStripMenuItem";
            this.新規ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新規ToolStripMenuItem.Text = "新規";
            this.新規ToolStripMenuItem.Click += new System.EventHandler(this.新規ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Enabled = false;
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存";
            this.上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.上書き保存ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // ノートToolStripMenuItem
            // 
            this.ノートToolStripMenuItem.Name = "ノートToolStripMenuItem";
            this.ノートToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ノートToolStripMenuItem.Text = "ノート";
            this.ノートToolStripMenuItem.Click += new System.EventHandler(this.ノートToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントToolStripMenuItem,
            this.スタートアップToolStripMenuItem,
            this.リストの型ToolStripMenuItem,
            this.自動保存ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            this.フォントToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.フォントToolStripMenuItem.Text = "フォント";
            this.フォントToolStripMenuItem.Click += new System.EventHandler(this.フォントToolStripMenuItem_Click);
            // 
            // スタートアップToolStripMenuItem
            // 
            this.スタートアップToolStripMenuItem.Name = "スタートアップToolStripMenuItem";
            this.スタートアップToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.スタートアップToolStripMenuItem.Text = "スタートアップ";
            // 
            // リストの型ToolStripMenuItem
            // 
            this.リストの型ToolStripMenuItem.Name = "リストの型ToolStripMenuItem";
            this.リストの型ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.リストの型ToolStripMenuItem.Text = "リストの型";
            // 
            // 自動保存ToolStripMenuItem
            // 
            this.自動保存ToolStripMenuItem.Name = "自動保存ToolStripMenuItem";
            this.自動保存ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.自動保存ToolStripMenuItem.Text = "自動保存";
            // 
            // フォントサイズToolStripMenuItem
            // 
            this.フォントサイズToolStripMenuItem.Name = "フォントサイズToolStripMenuItem";
            this.フォントサイズToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // text_memo
            // 
            this.text_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_memo.Location = new System.Drawing.Point(0, 0);
            this.text_memo.Name = "text_memo";
            this.text_memo.Size = new System.Drawing.Size(800, 450);
            this.text_memo.TabIndex = 2;
            this.text_memo.Text = "";
            // 
            // autoSave
            // 
            this.autoSave.Interval = 10000;
            this.autoSave.Tick += new System.EventHandler(this.autoSave_Tick);
            // 
            // bullet
            // 
            this.bullet.Appearance = System.Windows.Forms.Appearance.Button;
            this.bullet.Location = new System.Drawing.Point(148, 0);
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
            this.list.Location = new System.Drawing.Point(224, 0);
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
            this.memo.Location = new System.Drawing.Point(300, 0);
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
            this.screenshot.Location = new System.Drawing.Point(376, 0);
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
            this.image.Location = new System.Drawing.Point(452, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(70, 24);
            this.image.TabIndex = 8;
            this.image.TabStop = true;
            this.image.Text = "イメージ";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoSaveDialog);
            this.Controls.Add(this.image);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.list);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.text_memo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "多機能テキストエディタ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ノートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントサイズToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートアップToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リストの型ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox text_memo;
        private System.Windows.Forms.ToolStripMenuItem 自動保存ToolStripMenuItem;
        private System.Windows.Forms.Timer autoSave;
        private System.Windows.Forms.RadioButton bullet;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.RadioButton memo;
        private System.Windows.Forms.RadioButton screenshot;
        private System.Windows.Forms.RadioButton image;
        private System.Windows.Forms.Label autoSaveDialog;
    }
}

