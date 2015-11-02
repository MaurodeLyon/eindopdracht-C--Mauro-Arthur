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
    public class ConnectionToServer
    {
        //public TcpClient client;
        //public MainMenuModel menuModel;
        //public gameModel gameModel;
        //public EndScreenModel endModel;

        //private System.Timers.Timer modelTimer;
        //private System.Timers.Timer connectionTimer;
        //[System.Runtime.InteropServices.DllImport("kernel32.dll")]
        //private static extern bool AllocConsole();

        //public ConnectionToServer()
        //{
        //    AllocConsole();
            
        //}

        //public void StartConnection(TcpClient client)
        //{
        //    this.client = client;
        //    new Thread(HandleResponse).Start();

        //    modelTimer = new System.Timers.Timer(10);
        //    modelTimer.Elapsed += onTimedEvent;

        //    connectionTimer = new System.Timers.Timer(50);
        //    connectionTimer.Elapsed += onConnectionEvent;
        //}




        //private void HandleResponse()
        //{

        //    bool done = false;
        //    while (!done)
        //    {
        //        Console.WriteLine("Starting");
        //        string response = DataHandler.readData(client);
        //        Console.WriteLine(response);
        //        string code = response.Substring(0, 2);
        //        response = response.Replace(code, "");
        //        string[] param = response.Split(':');

        //        switch (code)
        //        {
        //            case "03":  //player ready 3:"amount"
        //                if (menuModel.form.AmountConnectedLabel.InvokeRequired)
        //                {
        //                    Action act = () => menuModel.form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
        //                    menuModel.form.AmountConnectedLabel.Invoke(act);
        //                }
        //                else
        //                {
        //                    menuModel.form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
        //                }

        //                if (menuModel.form.gameButton.InvokeRequired)
        //                {
        //                    Action act = () => menuModel.form.gameButton.Enabled = true;
        //                    menuModel.form.gameButton.Invoke(act);
        //                }
        //                else
        //                {
        //                    menuModel.form.gameButton.Enabled = true;
        //                }

        //                if (menuModel.form.gameButton.InvokeRequired)
        //                {
        //                    Action act = () => menuModel.form.gameButton.Text = "Start game";
        //                    menuModel.form.gameButton.Invoke(act);
        //                }
        //                else
        //                {
        //                    menuModel.form.gameButton.Text = "Start game";
        //                }
        //                break;
        //            case "04":  //start the game
        //                gameModel = new gameModel(new GameScreenView(),client);

        //                if (menuModel.form.InvokeRequired)
        //                {
        //                    Action hide = () => menuModel.form.Hide();
        //                    Action close = () => menuModel.form.Close();
        //                    menuModel.form.Invoke(hide);
        //                    menuModel.form.Invoke(close);
        //                }
        //                else
        //                {
        //                    menuModel.form.Hide();
        //                }
        //                if (gameModel.GameScreenView.InvokeRequired)
        //                {
        //                    Action sho = () => gameModel.GameScreenView.Show();
        //                    Action act = () => gameModel.GameScreenView.Activate();
        //                    Action foc = () => gameModel.GameScreenView.Focus();
        //                    Action inv = () => gameModel.GameScreenView.Invalidate();
        //                    Action upd = () => gameModel.GameScreenView.Update();
        //                    gameModel.GameScreenView.Invoke(sho);
        //                    gameModel.GameScreenView.Invoke(act);
        //                    gameModel.GameScreenView.Invoke(foc);
        //                    gameModel.GameScreenView.Invoke(inv);
        //                    gameModel.GameScreenView.Invoke(upd);
        //                }
        //                else
        //                {
        //                    gameModel.GameScreenView.Show();
        //                }
        //                modelTimer.Enabled = true;
        //                connectionTimer.Enabled = true;
        //                gameModel.connectionToServer = this;
        //                done = true;
        //                Application.Run(gameModel.GameScreenView);
        //                break;
        //            case "05": // informatie over ball
        //                Console.WriteLine(response);
        //                int ballX;
        //                int ballY;
        //                int player2Y;

        //                int.TryParse(param[0], out ballX);
        //                gameModel.ball.X = ballX;

        //                int.TryParse(param[1], out ballY);
        //                gameModel.ball.Y = ballY;

        //                int.TryParse(param[2], out player2Y);
        //                gameModel.player_2.Y = player2Y;

        //                gameModel.score_Player_1 = param[2];
        //                gameModel.score_Player_2 = param[3];
        //                break;
        //            default: break;
        //        }
        //    }
        //}

        //private void onConnectionEvent(object sender, ElapsedEventArgs e)
        //{
        //    DataHandler.writeData(client, "05" + gameModel.player_1.Y);
        //}

        //private void onTimedEvent(object obj, ElapsedEventArgs e)
        //{
        //    gameModel.player_1.Y = Cursor.Position.Y - (gameModel.player_1.Height / 2);
        //}
    }
}
