
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
            this.メモToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バレットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.イメージToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カメラToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントサイズToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートアップToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リストの型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_memo = new System.Windows.Forms.RichTextBox();
            this.自動保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ノートToolStripMenuItem,
            this.メモToolStripMenuItem,
            this.リストToolStripMenuItem,
            this.バレットToolStripMenuItem,
            this.イメージToolStripMenuItem,
            this.カメラToolStripMenuItem,
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
            // メモToolStripMenuItem
            // 
            this.メモToolStripMenuItem.Name = "メモToolStripMenuItem";
            this.メモToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.メモToolStripMenuItem.Text = "メモ";
            this.メモToolStripMenuItem.Click += new System.EventHandler(this.メモToolStripMenuItem_Click);
            // 
            // リストToolStripMenuItem
            // 
            this.リストToolStripMenuItem.Name = "リストToolStripMenuItem";
            this.リストToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.リストToolStripMenuItem.Text = "リスト";
            this.リストToolStripMenuItem.Click += new System.EventHandler(this.リストToolStripMenuItem_Click);
            // 
            // バレットToolStripMenuItem
            // 
            this.バレットToolStripMenuItem.Name = "バレットToolStripMenuItem";
            this.バレットToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.バレットToolStripMenuItem.Text = "バレット";
            this.バレットToolStripMenuItem.Click += new System.EventHandler(this.バレットToolStripMenuItem_Click);
            // 
            // イメージToolStripMenuItem
            // 
            this.イメージToolStripMenuItem.Name = "イメージToolStripMenuItem";
            this.イメージToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.イメージToolStripMenuItem.Text = "イメージ";
            this.イメージToolStripMenuItem.Click += new System.EventHandler(this.イメージToolStripMenuItem_Click);
            // 
            // カメラToolStripMenuItem
            // 
            this.カメラToolStripMenuItem.Name = "カメラToolStripMenuItem";
            this.カメラToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.カメラToolStripMenuItem.Text = "カメラ";
            this.カメラToolStripMenuItem.Click += new System.EventHandler(this.カメラToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントサイズToolStripMenuItem,
            this.フォントToolStripMenuItem,
            this.スタートアップToolStripMenuItem,
            this.リストの型ToolStripMenuItem,
            this.自動保存ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // フォントサイズToolStripMenuItem
            // 
            this.フォントサイズToolStripMenuItem.Name = "フォントサイズToolStripMenuItem";
            this.フォントサイズToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.フォントサイズToolStripMenuItem.Text = "フォントサイズ";
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            this.フォントToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.フォントToolStripMenuItem.Text = "フォント";
            // 
            // スタートアップToolStripMenuItem
            // 
            this.スタートアップToolStripMenuItem.Name = "スタートアップToolStripMenuItem";
            this.スタートアップToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.スタートアップToolStripMenuItem.Text = "スタートアップ";
            // 
            // リストの型ToolStripMenuItem
            // 
            this.リストの型ToolStripMenuItem.Name = "リストの型ToolStripMenuItem";
            this.リストの型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.リストの型ToolStripMenuItem.Text = "リストの型";
            // 
            // text_memo
            // 
            this.text_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_memo.Location = new System.Drawing.Point(0, 24);
            this.text_memo.Name = "text_memo";
            this.text_memo.Size = new System.Drawing.Size(800, 426);
            this.text_memo.TabIndex = 2;
            this.text_memo.Text = "";
            // 
            // 自動保存ToolStripMenuItem
            // 
            this.自動保存ToolStripMenuItem.Name = "自動保存ToolStripMenuItem";
            this.自動保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自動保存ToolStripMenuItem.Text = "自動保存";
            this.自動保存ToolStripMenuItem.Click += new System.EventHandler(this.自動保存ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_memo);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem メモToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リストToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バレットToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem イメージToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem カメラToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントサイズToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートアップToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リストの型ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox text_memo;
        private System.Windows.Forms.ToolStripMenuItem 自動保存ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

