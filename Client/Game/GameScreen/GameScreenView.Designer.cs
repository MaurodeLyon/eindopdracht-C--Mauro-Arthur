﻿namespace Game
{
    partial class GameScreenView
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
            this.field = new System.Windows.Forms.FlowLayoutPanel();
            this.viewTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Black;
            this.field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field.ForeColor = System.Drawing.Color.White;
            this.field.Location = new System.Drawing.Point(0, 0);
            this.field.Margin = new System.Windows.Forms.Padding(2);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(1008, 729);
            this.field.TabIndex = 0;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // viewTimer
            // 
            this.viewTimer.Interval = 17;
            this.viewTimer.Tick += new System.EventHandler(this.viewTimer_Tick);
            // 
            // GameScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.field);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreenView";
            this.Text = "Ping";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreenView_KeyDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel field;
        private System.Windows.Forms.Timer viewTimer;
    }
}

