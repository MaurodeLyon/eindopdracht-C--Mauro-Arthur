using System;
using System.Net.Sockets;

namespace Server
{
    class GameClient
    {
        public String username { get; }
        public TcpClient client { get; }

        public GameClient(string username, TcpClient c)
        {
            this.username = username;
            this.client = c;
        }
    }
}