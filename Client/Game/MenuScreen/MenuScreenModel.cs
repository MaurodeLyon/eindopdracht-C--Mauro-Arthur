using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.MainMenuGame
{
    public class MainMenuModel
    {
        public MenuScreenView form;

        public TcpClient client;
        public bool done;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public MainMenuModel(MenuScreenView form)
        {
            AllocConsole();
            this.form = form;

            new Thread(connectToServer).Start();    //try to connect to server
        }

        private void connectToServer()
        {
            if (form.ConnectionStatusLabel.InvokeRequired)
            {
                Action act = () => form.ConnectionStatusLabel.Text = "Not connected to Server";
                form.ConnectionStatusLabel.Invoke(act);
            }
            else
            {
                form.ConnectionStatusLabel.Text = "Not connected to Server";
            }


            do { client = new TcpClient("127.0.0.1", 1338); }
            while (!client.Connected);
            //connectionToServer.StartConnection(client);
            //connectionToServer.menuModel = this;
            Thread taskMenu = new Thread(new ThreadStart(handleConnection));
            taskMenu.Start();



            if (form.ConnectionStatusLabel.InvokeRequired)
            {
                Action act = () => form.ConnectionStatusLabel.Text = "Connected to Server";
                form.ConnectionStatusLabel.Invoke(act);
            }
            else
            {
                form.ConnectionStatusLabel.Text = "Connected to Server";
            }
        }

        private void handleConnection()
        {
            done = false;
            while (!done)
            {


                string response = DataHandler.ReadString(client);
                Console.WriteLine(response);
                string code = response.Substring(0, 2);
                response = response.Replace(code, "");
                string[] param = response.Split(':');

                switch (code)
                {
                    case "03":  //player ready 3:"amount"
                        if (form.AmountConnectedLabel.InvokeRequired)
                        {
                            Action act = () => form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
                            form.AmountConnectedLabel.Invoke(act);
                        }
                        else
                        {
                            form.AmountConnectedLabel.Text = param[0] + "/2 players ready";
                        }

                        if (form.gameButton.InvokeRequired)
                        {
                            Action act = () => form.gameButton.Enabled = true;
                            form.gameButton.Invoke(act);
                        }
                        else
                        {
                            form.gameButton.Enabled = true;
                        }

                        if (form.gameButton.InvokeRequired)
                        {
                            Action act = () => form.gameButton.Text = "Start game";
                            form.gameButton.Invoke(act);
                        }
                        else
                        {
                            form.gameButton.Text = "Start game";
                        }
                        break;
                    case "04":  //start the game
                        gameModel gameModel = new gameModel(new GameScreenView(), client);

                        if (form.InvokeRequired)
                        {
                            Action hide = () => form.Hide();
                            Action close = () => form.Close();
                            form.Invoke(hide);
                            form.Invoke(close);
                        }
                        else
                        {
                            form.Hide();
                        }
                        if (gameModel.GameScreenView.InvokeRequired)
                        {
                            Action sho = () => gameModel.GameScreenView.Show();
                            gameModel.GameScreenView.Invoke(sho);
                        }
                        else
                        {
                            gameModel.GameScreenView.Show();
                        }

                        done = true;
                        gameModel.startTimers();
                        Application.Run(gameModel.GameScreenView);
                        break;

                }
            }
        }
    }
}
