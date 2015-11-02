namespace Game.EndScreen
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(199, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game over";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(240, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreP1
            // 
            this.scoreP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreP1.AutoSize = true;
            this.scoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.scoreP1.Location = new System.Drawing.Point(493, 241);
            this.scoreP1.Name = "scoreP1";
            this.scoreP1.Size = new System.Drawing.Size(159, 44);
            this.scoreP1.TabIndex = 3;
            this.scoreP1.Text = "SCORE";
            this.scoreP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreP2
            // 
            this.scoreP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreP2.AutoSize = true;
            this.scoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.scoreP2.Location = new System.Drawing.Point(493, 321);
            this.scoreP2.Name = "scoreP2";
            this.scoreP2.Size = new System.Drawing.Size(159, 44);
            this.scoreP2.TabIndex = 4;
            this.scoreP2.Text = "SCORE";
            this.scoreP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainMenuButton.ForeColor = System.Drawing.Color.Black;
            this.MainMenuButton.Location = new System.Drawing.Point(375, 391);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(167, 73);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 550);
            this.Controls.Add(this.MainMenuButton);
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
        private System.Windows.Forms.Button MainMenuButton;
        public System.Windows.Forms.Label scoreP1;
        public System.Windows.Forms.Label scoreP2;
    }
}