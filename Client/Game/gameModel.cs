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
    class gameModel
    {
        private GameView gameView;

        public Rectangle player_1;
        public Rectangle player_2;
        public Rectangle ball;

        public string score_Player_1;
        public string score_Player_2;

        public int direction;
        private System.Timers.Timer modelTimer;
 
        public gameModel(GameView gameView)
        {
            this.gameView = gameView;
            player_1 = new Rectangle(100, gameView.field.Height / 2 - 50, 25, 100);
            player_2 = new Rectangle(gameView.field.Width - 100, gameView.field.Height / 2 - 50, 25, 100);
            ball = new Rectangle(gameView.field.Width / 2 - 10, gameView.field.Height / 2 - 10, 20, 20);
            score_Player_1 = "0";
            score_Player_2 = "5";
            modelTimer = new System.Timers.Timer(10);
            modelTimer.Enabled = true;
            modelTimer.Elapsed += onTimedEvent;
        }


        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            switch (direction)
            {
                case 0: break;
                case 1: player_1.Y--; break;
                case 2: player_1.Y++; break;
                default:
                    break;
            }
            player_1.Y = Cursor.Position.Y - (player_1.Height / 2);
        }


    }
}
