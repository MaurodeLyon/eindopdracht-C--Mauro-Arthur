using Game.EndScreen;
using Library;
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
        public GameScreenView GameScreenView;
        public FakeServerTest fakeServerTest;
        public ConnectionToServer connectionToServer;

        public Rectangle player_1;
        public Rectangle player_2;
        public Rectangle ball;

        public string score_Player_1;
        public string score_Player_2;
        private TcpClient client;
        private System.Timers.Timer modelTimer;
        private System.Timers.Timer connectionTimer;

        public gameModel(GameScreenView GameScreenView, TcpClient client)
        {
            player_1 = new Rectangle(GameScreenView.gamesizeX / 20 - 25, GameScreenView.gamesizeY / 2 - 50, 25, 100);
            player_2 = new Rectangle(GameScreenView.gamesizeX - GameScreenView.gamesizeX / 20, GameScreenView.gamesizeY / 2 - 50, 25, 100);
            ball = new Rectangle(GameScreenView.gamesizeX / 2 - 10, GameScreenView.gamesizeY / 2 - 10, 20, 20);
            score_Player_1 = "0";
            score_Player_2 = "0";
            GameScreenView.Refresh();
            this.GameScreenView = GameScreenView;
            GameScreenView.gameModel = this;
            this.client = client;

            modelTimer = new System.Timers.Timer(100);
            modelTimer.Elapsed += onTimedEvent;

            connectionTimer = new System.Timers.Timer(100);
            connectionTimer.Elapsed += onConnectionEvent;
            Thread task = new Thread(new ThreadStart(handleConnection));
            task.Start();
        }

        public void startTimers()
        {
            modelTimer.Enabled = true;
            connectionTimer.Enabled = true;
        }

        private void onConnectionEvent(object sender, ElapsedEventArgs e)
        {
            DataHandler.SendString(client, "05" + player_1.Y);
        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            if (Cursor.Position.Y < 768)
                player_1.Y = Cursor.Position.Y - (player_1.Height / 2);
            else
                player_1.Y = 768;
        }

        public void handleConnection()
        {
            while (true)
            {
                string response = DataHandler.ReadString(client);
                Console.WriteLine(response);
                string code = response.Substring(0, 2);

                if (code == "05")
                {
                    response = response.Replace(code, "");
                    string[] param = response.Split(':');

                    int ballX;
                    int ballY;
                    int player2Y;

                    int.TryParse(param[0], out ballX);
                    ball.X = ballX;

                    int.TryParse(param[1], out ballY);
                    ball.Y = ballY;

                    int.TryParse(param[2], out player2Y);
                    player_2.Y = player2Y;

                    score_Player_1 = param[3];
                    score_Player_2 = param[4];
                }

                if (code == "06")
                {
                    EndScreenView endScreen = new EndScreenView(Int32.Parse(score_Player_1), Int32.Parse(score_Player_2));
                    Application.Run(endScreen);
                }
            }
        }



    }
}
