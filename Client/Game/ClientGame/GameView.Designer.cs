namespace Game
{
    partial class GameView
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
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(891, 523);
            this.field.TabIndex = 0;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // viewTimer
            // 
            this.viewTimer.Interval = 20;
            this.viewTimer.Tick += new System.EventHandler(this.viewTimer_Tick);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 523);
            this.Controls.Add(this.field);
            this.Name = "GameView";
            this.Text = "Ping";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel field;
        private System.Windows.Forms.Timer viewTimer;
    }
}

