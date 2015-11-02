﻿namespace Game.EndScreen
{
    partial class EndScreenView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreP1 = new System.Windows.Forms.Label();
            this.scoreP2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(199, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(209, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(209, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 2:";
            // 
            // scoreP1
            // 
            this.scoreP1.AutoSize = true;
            this.scoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.scoreP1.Location = new System.Drawing.Point(462, 240);
            this.scoreP1.Name = "scoreP1";
            this.scoreP1.Size = new System.Drawing.Size(159, 44);
            this.scoreP1.TabIndex = 3;
            this.scoreP1.Text = "SCORE";
            // 
            // scoreP2
            // 
            this.scoreP2.AutoSize = true;
            this.scoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.scoreP2.Location = new System.Drawing.Point(462, 320);
            this.scoreP2.Name = "scoreP2";
            this.scoreP2.Size = new System.Drawing.Size(159, 44);
            this.scoreP2.TabIndex = 4;
            this.scoreP2.Text = "SCORE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(375, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "Scoreboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EndScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scoreP2);
            this.Controls.Add(this.scoreP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EndScreenView";
            this.Text = "EndScreenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreP1;
        private System.Windows.Forms.Label scoreP2;
        private System.Windows.Forms.Button button1;
    }
}