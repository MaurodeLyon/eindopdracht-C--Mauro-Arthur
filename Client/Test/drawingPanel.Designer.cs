﻿namespace Test
{
    partial class drawingPanel
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
            this.field = new System.Windows.Forms.Panel();
            this.ViewTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.AutoScroll = true;
            this.field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field.Location = new System.Drawing.Point(0, 0);
            this.field.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(1065, 516);
            this.field.TabIndex = 0;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // ViewTimer
            // 
            this.ViewTimer.Interval = 10;
            this.ViewTimer.Tick += new System.EventHandler(this.ViewTimer_Tick);
            // 
            // drawingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 516);
            this.Controls.Add(this.field);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "drawingPanel";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.drawingPanel_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel field;
        private System.Windows.Forms.Timer ViewTimer;
    }
}

