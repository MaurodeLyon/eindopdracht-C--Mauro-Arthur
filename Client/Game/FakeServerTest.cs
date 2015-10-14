using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Game
{
    public class FakeServerTest
    {
        private GameView gameView;

        public Rectangle player_1;
        public Rectangle player_2;

        public Rectangle ball;
        private int ball_horizontal_speed = 10;
        private int ball_vertical_speed = 10;

        public int score_Player_1 = 0;
        public int score_Player_2 = 0;

        private System.Timers.Timer modelTimer;

        public FakeServerTest(GameView gameView)
        {
            this.gameView = gameView;
            this.gameView.gameModel.fakeServerTest = this;
            modelTimer = new System.Timers.Timer(10);
            modelTimer.Elapsed += onTimedEvent;
            modelTimer.Enabled = true;
            ball = new Rectangle(gameView.field.Width / 2 - 10, gameView.field.Height / 2 - 10, 20, 20);
        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            ball.X += ball_horizontal_speed;
            ball.Y += ball_vertical_speed;

            //if ball touches players
            if (player_1.Contains(ball) || player_2.Contains(ball))
                ball_horizontal_speed *= -1;

            if (ball.Top < gameView.field.Top || ball.Bottom > gameView.field.Bottom)
                ball_vertical_speed *= -1;

            if (ball.Left <= gameView.field.Left)
            {
                ball_horizontal_speed *= -1;
                score_Player_2++;
            }


            if (ball.Right >= gameView.field.Right)
            {
                ball_horizontal_speed *= -1;
                score_Player_1++;
            }

            gameView.gameModel.ball = ball;
            gameView.gameModel.score_Player_1 = score_Player_1.ToString();
            gameView.gameModel.score_Player_2 = score_Player_2.ToString();
        }
    }
}
