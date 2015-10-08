using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GameScreen : Form
    {
        public int speed_Left = 4;  //speed of the ball
        public int speed_Top = 4;
        public int point = 0;   //scored points

        public GameScreen()
        {
            InitializeComponent();
            Cursor.Hide(); // hide cursor
            viewTimer.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;    //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //set fullscreen

            racket.Top = field.Bottom - (field.Bottom / 10); // set position of racket
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_Left;
            ball.Top += speed_Top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Right <= racket.Right && ball.Left >= racket.Left)
            {
                speed_Top += 2;
                speed_Left += 2;
                speed_Top = -speed_Top; // change direction
                point += 1;
            }
            if (ball.Left <= field.Left)
            {
                speed_Left = -speed_Left;
            }
            if (ball.Right >= field.Right)
            {
                speed_Left = -speed_Left;
            }
            if (ball.Top <= field.Top)
            {
                viewTimer.Enabled = false;
            }
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
