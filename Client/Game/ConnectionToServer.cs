using Game.EndScreen;
using Game.MainMenuGame;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Game
{
    class ConnectionToServer
    {
        public TcpClient client;
        public MainMenuModel menuModel;
        public gameModel gameModel;
        public EndScreenModel endModel;

        private System.Timers.Timer modelTimer;
        private System.Timers.Timer connectionTimer;
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public ConnectionToServer(TcpClient client)
        {
            AllocConsole();
            this.client = client;
            new Thread(HandleResponse).Start();

            modelTimer = new System.Timers.Timer(10);
            modelTimer.Elapsed += onTimedEvent;

            connectionTimer = new System.Timers.Timer(50);
            connectionTimer.Elapsed += onConnectionEvent;
        }

        private void onConnectionEvent(object sender, ElapsedEventArgs e)
        {
            DataHandler.writeData(client, "05" + gameModel.player_1.X + ":" + gameModel.player_1.Y);
        }

        private void HandleResponse()
        {
            while (true)
            {
                while (client.GetStream().DataAvailable)
                {
                    string response = DataHandler.readData(client);
                    Console.WriteLine(response);
                    string code = response.Substring(0, 2);
                    response = response.Replace(code, "");
                    string[] param = response.Split(':');

                    switch (code)
                    {
                        case "03":  //player ready 3:"amount"
                            if (menuModel.form.AmountConnectedLabel.InvokeRequired)
                            {
                                Action act = () => menuModel.form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
                                menuModel.form.AmountConnectedLabel.Invoke(act);
                            }
                            else
                            {
                                menuModel.form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
                            }

                            if (menuModel.form.gameButton.InvokeRequired)
                            {
                                Action act = () => menuModel.form.gameButton.Enabled = true;
                                menuModel.form.gameButton.Invoke(act);
                            }
                            else
                            {
                                menuModel.form.gameButton.Enabled = true;
                            }

                            if (menuModel.form.gameButton.InvokeRequired)
                            {
                                Action act = () => menuModel.form.gameButton.Text = "Start game";
                                menuModel.form.gameButton.Invoke(act);
                            }
                            else
                            {
                                menuModel.form.gameButton.Text = "Start game";
                            }
                            break;
                        case "04":  //start the game
                            gameModel = new gameModel(new GameScreenView());
                            if (menuModel.form.InvokeRequired)
                            {
                                Action act = () => menuModel.form.Hide();
                                menuModel.form.Invoke(act);
                            }
                            else
                            {
                                menuModel.form.Hide();
                            }
                            if (gameModel.GameScreenView.InvokeRequired)
                            {
                                Action act = () => gameModel.GameScreenView.Show();
                                gameModel.GameScreenView.Invoke(act);
                            }
                            else
                            {
                                gameModel.GameScreenView.Show();
                            }
                            modelTimer.Enabled = true;
                            connectionTimer.Enabled = true;
                            break;
                        case "05":
                            int x;
                            int y;

                            int.TryParse(param[0], out x);
                            gameModel.ball.X = x;

                            int.TryParse(param[1], out y);
                            gameModel.ball.Y = y;

                            int.TryParse(param[2], out x);
                            gameModel.player_2.X = x;

                            int.TryParse(param[3], out y);
                            gameModel.player_2.Y = y;

                            gameModel.score_Player_1 = param[4];
                            gameModel.score_Player_2 = param[5];
                            break;
                        default: break;
                    }
                }
            }
        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            gameModel.player_1.Y = Cursor.Position.Y - (gameModel.player_1.Height / 2);
            
        }
    }
}
