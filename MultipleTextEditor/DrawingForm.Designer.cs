/*********************************************
担当者:VSによる自動生成（一部Yutaro TANAKAが編集）

概要:DrawingFormのUI
*********************************************/

using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace MultipleTextEditor
{
    partial class DrawingForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "DrawingForm";
            pictureBox = new PictureBox();
            btnPenColor = new Button();
            btnPenSize = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(800, 450);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // btnPenColor
            // 
            btnPenColor.Location = new Point(12, 12);
            btnPenColor.Name = "btnPenColor";
            btnPenColor.Size = new Size(150, 46);
            btnPenColor.TabIndex = 1;
            btnPenColor.UseVisualStyleBackColor = true;
            btnPenColor.Click += btnPenColor_Click;
            btnPenColor.BackColor = Color.Black;
            // 
            // btnPenSize
            // 
            btnPenSize.Location = new Point(168, 12);
            btnPenSize.Name = "btnPenSize";
            btnPenSize.Size = new Size(150, 46);
            btnPenSize.TabIndex = 2;
            btnPenSize.Text = "太さ";
            btnPenSize.UseVisualStyleBackColor = true;
            btnPenSize.Click += btnPenSize_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(324, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 3;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnPenSize);
            Controls.Add(btnPenColor);
            Controls.Add(pictureBox);
            FormClosing += DrawingForm_FormClosing;
            ResizeEnd += DrawingForm_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox;
        private Button btnPenColor;
        private Button btnPenSize;
        private Button btnSave;
    }
}
