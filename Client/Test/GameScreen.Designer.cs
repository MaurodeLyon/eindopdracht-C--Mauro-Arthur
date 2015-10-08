namespace Client
{
    partial class GameScreen
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
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.viewTimer = new System.Windows.Forms.Timer(this.components);
            this.field.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.Controls.Add(this.racket);
            this.field.Controls.Add(this.ball);
            this.field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field.Location = new System.Drawing.Point(0, 0);
            this.field.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(379, 321);
            this.field.TabIndex = 0;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(87, 288);
            this.racket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 18);
            this.racket.TabIndex = 2;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(176, 142);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 31);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // viewTimer
            // 
            this.viewTimer.Interval = 5;
            this.viewTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.field);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameScreen";
            this.Text = "GameScreeen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.field.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel field;
        public System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer viewTimer;
    }
}