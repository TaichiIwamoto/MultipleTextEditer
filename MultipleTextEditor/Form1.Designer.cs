
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
            this.リストの型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.PageToolStripMenuItem,
            this.ConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
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
            this.OverWriteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
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
            this.PageToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.PageToolStripMenuItem.Text = "ページ";
            this.PageToolStripMenuItem.Click += new System.EventHandler(this.PageToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.StartupToolStripMenuItem,
            this.リストの型ToolStripMenuItem,
            this.自動保存ToolStripMenuItem});
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ConfigToolStripMenuItem.Text = "設定";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FontToolStripMenuItem.Text = "フォント";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // スタートアップToolStripMenuItem
            // 
            this.StartupToolStripMenuItem.Name = "スタートアップToolStripMenuItem";
            this.StartupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartupToolStripMenuItem.Text = "スタートアップ";
            // 
            // リストの型ToolStripMenuItem
            // 
            this.リストの型ToolStripMenuItem.Name = "リストの型ToolStripMenuItem";
            this.リストの型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.リストの型ToolStripMenuItem.Text = "リストの型";
            // 
            // 自動保存ToolStripMenuItem
            // 
            this.自動保存ToolStripMenuItem.Name = "自動保存ToolStripMenuItem";
            this.自動保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自動保存ToolStripMenuItem.Text = "自動保存";
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
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_memo);
            this.Controls.Add(this.autoSaveDialog);
            this.Controls.Add(this.image);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.list);
            this.Controls.Add(this.bullet);
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
        private System.Windows.Forms.ToolStripMenuItem リストの型ToolStripMenuItem;
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
    }
}

