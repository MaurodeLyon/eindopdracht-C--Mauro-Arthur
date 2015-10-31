using System;
using System.Net.Sockets;

namespace Server
{
    class GameClient
    {
        public string username { get; }
        public TcpClient client { get; }

        public GameClient(string username, TcpClient client)
        {
            this.username = username;
            this.client = client;
        }
    }
}