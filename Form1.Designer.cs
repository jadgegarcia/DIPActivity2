﻿namespace DIPActivity2
{
    partial class Form1
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
            this.loadImage = new System.Windows.Forms.PictureBox();
            this.loadBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImage
            // 
            this.loadImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadImage.Location = new System.Drawing.Point(30, 68);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(352, 240);
            this.loadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadImage.TabIndex = 0;
            this.loadImage.TabStop = false;
            // 
            // loadBackground
            // 
            this.loadBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadBackground.Location = new System.Drawing.Point(439, 68);
            this.loadBackground.Name = "loadBackground";
            this.loadBackground.Size = new System.Drawing.Size(352, 240);
            this.loadBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadBackground.TabIndex = 1;
            this.loadBackground.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(850, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(352, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "load image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "load background";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(966, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "subtract";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 613);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.loadBackground);
            this.Controls.Add(this.loadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loadImage;
        private System.Windows.Forms.PictureBox loadBackground;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

