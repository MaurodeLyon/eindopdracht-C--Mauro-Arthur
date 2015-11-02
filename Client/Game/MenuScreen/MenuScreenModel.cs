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
        public ConnectionToServer connectionToServer;

        public MainMenuModel(MenuScreenView form)
        {
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

            TcpClient client;
            do { client = new TcpClient("127.0.0.1", 1338); }
            while (!client.Connected);
            connectionToServer = new ConnectionToServer(client);
            connectionToServer.menuModel = this;

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
    }
}
