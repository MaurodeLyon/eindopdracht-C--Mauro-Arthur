using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Game
{
    public class gameModel
    {
        private GameScreenView GameScreenView;
        public FakeServerTest fakeServerTest;

        public Rectangle player_1;
        public Rectangle player_2;
        public Rectangle ball;

        public string score_Player_1;
        public string score_Player_2;

        private System.Timers.Timer modelTimer;

        public gameModel(GameScreenView GameScreenView)
        {
            this.GameScreenView = GameScreenView;
            player_1 = new Rectangle(GameScreenView.field.Width / 20, GameScreenView.field.Height / 2 - 50, 25, 100);
            player_2 = new Rectangle(GameScreenView.field.Width - GameScreenView.field.Width / 20, GameScreenView.field.Height / 2 - 50, 25, 100);
            ball = new Rectangle(GameScreenView.field.Width / 2 - 10, GameScreenView.field.Height / 2 - 10, 20, 20);
            score_Player_1 = "0";
            score_Player_2 = "0";
            modelTimer = new System.Timers.Timer(10);
            modelTimer.Enabled = true;
            modelTimer.Elapsed += onTimedEvent;

            Thread thread = new Thread(new ThreadStart(HandleUpdates));
            thread.Start();
        }

        private void HandleUpdates()
        {
            String data = DataHandler.readData(GameScreenView.client);

            if (data.Substring(0, 2) == "05")
            {
                data.Replace("05", "");
                String[] lines = data.Split(':');


                int x;
                int y;

                int.TryParse(lines[0], out x);
                ball.X = x;


                int.TryParse(lines[1], out y);
                ball.Y = y;


                int.TryParse(lines[2], out x);
                player_2.X = x;


                int.TryParse(lines[3], out y);
                player_2.Y = y;

                score_Player_1 = lines[4];
                score_Player_2 = lines[5];







            }

        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            player_1.Y = Cursor.Position.Y - (player_1.Height / 2);
            DataHandler.writeData(GameScreenView.client, "05" + player_1.X + ":" + player_1.Y);
        }
    }
}
