
namespace MultipleTextEditor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullScreen = new System.Windows.Forms.Button();
            this.activeWindow = new System.Windows.Forms.Button();
            this.customArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 255);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fullScreen
            // 
            this.fullScreen.Location = new System.Drawing.Point(125, 92);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(75, 23);
            this.fullScreen.TabIndex = 6;
            this.fullScreen.Text = "full";
            this.fullScreen.UseVisualStyleBackColor = true;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click);
            // 
            // activeWindow
            // 
            this.activeWindow.Location = new System.Drawing.Point(344, 92);
            this.activeWindow.Name = "activeWindow";
            this.activeWindow.Size = new System.Drawing.Size(75, 23);
            this.activeWindow.TabIndex = 7;
            this.activeWindow.Text = "window";
            this.activeWindow.UseVisualStyleBackColor = true;
            this.activeWindow.Click += new System.EventHandler(this.activeWindow_Click);
            // 
            // customArea
            // 
            this.customArea.Location = new System.Drawing.Point(559, 92);
            this.customArea.Name = "customArea";
            this.customArea.Size = new System.Drawing.Size(75, 23);
            this.customArea.TabIndex = 8;
            this.customArea.Text = "Area";
            this.customArea.UseVisualStyleBackColor = true;
            this.customArea.Click += new System.EventHandler(this.customArea_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customArea);
            this.Controls.Add(this.activeWindow);
            this.Controls.Add(this.fullScreen);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fullScreen;
        private System.Windows.Forms.Button activeWindow;
        private System.Windows.Forms.Button customArea;
    }
}