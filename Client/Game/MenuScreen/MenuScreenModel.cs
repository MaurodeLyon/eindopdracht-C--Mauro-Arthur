using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Game.MainMenuGame
{
    class MainMenuModel
    {
        private MenuScreenView form;

        public TcpClient client { get; }

        public MainMenuModel(MenuScreenView form)
        {
            this.form = form;
            //try to connect to server
            client = new TcpClient("127.0.0.1", 1338);
            form.ConnectionStatusLabel.Text = "Connected to Server";

        }
    }
}
