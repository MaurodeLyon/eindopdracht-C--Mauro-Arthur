namespace Game.MainMenuGame
{
    partial class MainMenuView
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
            this.titelLabel = new System.Windows.Forms.Label();
            this.gameButton = new System.Windows.Forms.Button();
            this.scoreboardButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JoinButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RoomnameBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.AmountConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titelLabel
            // 
            this.titelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.ForeColor = System.Drawing.Color.White;
            this.titelLabel.Location = new System.Drawing.Point(270, 54);
            this.titelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(240, 108);
            this.titelLabel.TabIndex = 0;
            this.titelLabel.Text = "Ping";
            // 
            // gameButton
            // 
            this.gameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameButton.BackColor = System.Drawing.Color.Transparent;
            this.gameButton.Enabled = false;
            this.gameButton.Location = new System.Drawing.Point(253, 178);
            this.gameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(262, 81);
            this.gameButton.TabIndex = 1;
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // scoreboardButton
            // 
            this.scoreboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreboardButton.BackColor = System.Drawing.Color.Transparent;
            this.scoreboardButton.Location = new System.Drawing.Point(253, 264);
            this.scoreboardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreboardButton.Name = "scoreboardButton";
            this.scoreboardButton.Size = new System.Drawing.Size(262, 81);
            this.scoreboardButton.TabIndex = 2;
            this.scoreboardButton.Text = "Scoreboard";
            this.scoreboardButton.UseVisualStyleBackColor = false;
            this.scoreboardButton.Click += new System.EventHandler(this.scoreboardButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitGameButton.Location = new System.Drawing.Point(253, 350);
            this.exitGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(262, 81);
            this.exitGameButton.TabIndex = 3;
            this.exitGameButton.Text = "Exit";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.JoinButton);
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.RoomnameBox);
            this.groupBox1.Controls.Add(this.UsernameBox);
            this.groupBox1.Controls.Add(this.AmountConnectedLabel);
            this.groupBox1.Controls.Add(this.ConnectionStatusLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(598, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(147, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection status";
            // 
            // JoinButton
            // 
            this.JoinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JoinButton.ForeColor = System.Drawing.Color.Black;
            this.JoinButton.Location = new System.Drawing.Point(76, 90);
            this.JoinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(56, 19);
            this.JoinButton.TabIndex = 5;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(16, 90);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(56, 19);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RoomnameBox
            // 
            this.RoomnameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomnameBox.Location = new System.Drawing.Point(16, 67);
            this.RoomnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomnameBox.Name = "RoomnameBox";
            this.RoomnameBox.Size = new System.Drawing.Size(117, 20);
            this.RoomnameBox.TabIndex = 3;
            this.RoomnameBox.Text = "Roomname";
            this.RoomnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameBox.Location = new System.Drawing.Point(16, 45);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(117, 20);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.Tag = "";
            this.UsernameBox.Text = "Username";
            this.UsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmountConnectedLabel
            // 
            this.AmountConnectedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountConnectedLabel.AutoSize = true;
            this.AmountConnectedLabel.Location = new System.Drawing.Point(32, 28);
            this.AmountConnectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountConnectedLabel.Name = "AmountConnectedLabel";
            this.AmountConnectedLabel.Size = new System.Drawing.Size(89, 13);
            this.AmountConnectedLabel.TabIndex = 1;
            this.AmountConnectedLabel.Text = "0/2 players ready";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(14, 15);
            this.ConnectionStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(120, 13);
            this.ConnectionStatusLabel.TabIndex = 0;
            this.ConnectionStatusLabel.Text = "not connected to server";
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.scoreboardButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.titelLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuView";
            this.Text = "MainMenuView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titelLabel;
        public System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button scoreboardButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UsernameBox;
        public System.Windows.Forms.Label AmountConnectedLabel;
        public System.Windows.Forms.Label ConnectionStatusLabel;
        internal System.Windows.Forms.TextBox RoomnameBox;
        private System.Windows.Forms.Button CreateButton;
        public System.Windows.Forms.Button JoinButton;
    }
}