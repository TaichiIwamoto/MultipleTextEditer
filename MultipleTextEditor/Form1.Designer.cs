
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
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ノートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メモToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バレットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.イメージToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カメラToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントサイズToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートアップToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.言語変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リストの型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_memo = new System.Windows.Forms.RichTextBox();
            this.autoSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.ノートToolStripMenuItem,
            this.メモToolStripMenuItem,
            this.リストToolStripMenuItem,
            this.バレットToolStripMenuItem,
            this.イメージToolStripMenuItem,
            this.カメラToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1733, 44);
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
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            this.ファイルToolStripMenuItem.Click += new System.EventHandler(this.ファイルToolStripMenuItem_Click);
            // 
            // 新規ToolStripMenuItem
            // 
            this.新規ToolStripMenuItem.Name = "新規ToolStripMenuItem";
            this.新規ToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.新規ToolStripMenuItem.Text = "新規";
            this.新規ToolStripMenuItem.Click += new System.EventHandler(this.新規ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Enabled = false;
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存";
            this.上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.上書き保存ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(324, 44);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Click += new System.EventHandler(this.編集ToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.表示ToolStripMenuItem.Text = "表示";
            this.表示ToolStripMenuItem.Click += new System.EventHandler(this.表示ToolStripMenuItem_Click);
            // 
            // ノートToolStripMenuItem
            // 
            this.ノートToolStripMenuItem.Name = "ノートToolStripMenuItem";
            this.ノートToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.ノートToolStripMenuItem.Text = "ノート";
            this.ノートToolStripMenuItem.Click += new System.EventHandler(this.ノートToolStripMenuItem_Click);
            // 
            // メモToolStripMenuItem
            // 
            this.メモToolStripMenuItem.Name = "メモToolStripMenuItem";
            this.メモToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.メモToolStripMenuItem.Text = "メモ";
            this.メモToolStripMenuItem.Click += new System.EventHandler(this.メモToolStripMenuItem_Click);
            // 
            // リストToolStripMenuItem
            // 
            this.リストToolStripMenuItem.Name = "リストToolStripMenuItem";
            this.リストToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.リストToolStripMenuItem.Text = "リスト";
            this.リストToolStripMenuItem.Click += new System.EventHandler(this.リストToolStripMenuItem_Click);
            // 
            // バレットToolStripMenuItem
            // 
            this.バレットToolStripMenuItem.Name = "バレットToolStripMenuItem";
            this.バレットToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.バレットToolStripMenuItem.Text = "バレット";
            this.バレットToolStripMenuItem.Click += new System.EventHandler(this.バレットToolStripMenuItem_Click);
            // 
            // イメージToolStripMenuItem
            // 
            this.イメージToolStripMenuItem.Name = "イメージToolStripMenuItem";
            this.イメージToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.イメージToolStripMenuItem.Text = "イメージ";
            this.イメージToolStripMenuItem.Click += new System.EventHandler(this.イメージToolStripMenuItem_Click);
            // 
            // カメラToolStripMenuItem
            // 
            this.カメラToolStripMenuItem.Name = "カメラToolStripMenuItem";
            this.カメラToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.カメラToolStripMenuItem.Text = "カメラ";
            this.カメラToolStripMenuItem.Click += new System.EventHandler(this.カメラToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントサイズToolStripMenuItem,
            this.フォントToolStripMenuItem,
            this.スタートアップToolStripMenuItem,
            this.言語変更ToolStripMenuItem,
            this.リストの型ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // フォントサイズToolStripMenuItem
            // 
            this.フォントサイズToolStripMenuItem.Name = "フォントサイズToolStripMenuItem";
            this.フォントサイズToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.フォントサイズToolStripMenuItem.Text = "フォントサイズ";
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            this.フォントToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.フォントToolStripMenuItem.Text = "フォント";
            // 
            // スタートアップToolStripMenuItem
            // 
            this.スタートアップToolStripMenuItem.Name = "スタートアップToolStripMenuItem";
            this.スタートアップToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.スタートアップToolStripMenuItem.Text = "スタートアップ";
            // 
            // 言語変更ToolStripMenuItem
            // 
            this.言語変更ToolStripMenuItem.Name = "言語変更ToolStripMenuItem";
            this.言語変更ToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.言語変更ToolStripMenuItem.Text = "言語変更";
            // 
            // リストの型ToolStripMenuItem
            // 
            this.リストの型ToolStripMenuItem.Name = "リストの型ToolStripMenuItem";
            this.リストの型ToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.リストの型ToolStripMenuItem.Text = "リストの型";
            // 
            // text_memo
            // 
            this.text_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_memo.Location = new System.Drawing.Point(0, 44);
            this.text_memo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_memo.Name = "text_memo";
            this.text_memo.Size = new System.Drawing.Size(1733, 856);
            this.text_memo.TabIndex = 2;
            this.text_memo.Text = "";
            // 
            // autoSave
            // 
            this.autoSave.Interval = 10000;
            this.autoSave.Tick += new System.EventHandler(this.autoSave_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.text_memo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ノートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メモToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バレットToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem イメージToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カメラToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントサイズToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートアップToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 言語変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リストの型ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox text_memo;
        private System.Windows.Forms.Timer autoSave;
    }
}

