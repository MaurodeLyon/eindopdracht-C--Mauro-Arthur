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
        private GameScreenView GameScreenView;

        public Rectangle player_1;
        public Rectangle player_2;

        public Rectangle ball;
        private int ball_horizontal_speed = -5;
        private int ball_vertical_speed = 5;

        public int score_Player_1 = 0;
        public int score_Player_2 = 0;

        private System.Timers.Timer modelTimer;

        public FakeServerTest(GameScreenView GameScreenView)
        {
            this.GameScreenView = GameScreenView;
            this.GameScreenView.gameModel.fakeServerTest = this;
            modelTimer = new System.Timers.Timer(5);
            modelTimer.Elapsed += onTimedEvent;
            modelTimer.Enabled = true;
            ball = new Rectangle(GameScreenView.field.Width / 2 - 10, GameScreenView.field.Height / 2 - 10, 20, 20);
        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            ball.X += ball_horizontal_speed;
            ball.Y += ball_vertical_speed;

            //if ball touches players
            if (player_1.Contains(ball) || player_2.Contains(ball))
                ball_horizontal_speed *= -1;

            //if ball toches top border
            if (ball.Top < GameScreenView.field.Top)
                if (ball_vertical_speed < 0)
                    ball_vertical_speed = -ball_vertical_speed;

            //if ball touches bottom border
            if (ball.Bottom > GameScreenView.field.Bottom)
                if (ball_vertical_speed > 0)
                    ball_vertical_speed = -ball_vertical_speed;

            //if vall touches left border
            if (ball.Left <= GameScreenView.field.Left)
            {
                if (ball_horizontal_speed < 0)
                    ball_horizontal_speed = -ball_horizontal_speed;
                score_Player_2++;
            }

            //if ball touches right border
            if (ball.Right >= GameScreenView.field.Right)
            {
                if (ball_horizontal_speed > 0)
                    ball_horizontal_speed = -ball_horizontal_speed;
                score_Player_1++;
            }

            GameScreenView.gameModel.ball = ball;
            GameScreenView.gameModel.score_Player_1 = score_Player_1.ToString();
            GameScreenView.gameModel.score_Player_2 = score_Player_2.ToString();
        }
    }
}
