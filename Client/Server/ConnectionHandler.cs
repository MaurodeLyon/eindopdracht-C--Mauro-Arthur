using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class ConnectionHandler
    {
        private TcpListener listener;
        private GameData gamedata;

        public ConnectionHandler()
        {
            IPAddress localhost;
            IPAddress.TryParse("127.0.0.1", out localhost);

            listener = new TcpListener(localhost, 1338);
            listener.Start();

            gamedata = new GameData();

            while (true)
            {
                Console.WriteLine("waiting for connection");
                TcpClient client = listener.AcceptTcpClient();
                new Thread(HandleNewConnection).Start(client);
            }
        }

        private void HandleNewConnection(object obj)
        {
            bool done = false;
            while (!done)
            {
                TcpClient client = obj as TcpClient;
                string data = DataHandler.ReadString(client);     //EXAMPLE 01 username:roomname
                Console.WriteLine($"Received data : {data}");
                string[] param;
                string command = data.Substring(0, 2);
                switch (command)
                {
                    case "01": //CREATE "username":"roomname"
                        data = data.Replace("01", "");
                        param = data.Split(':');
                        gamedata.createRoom(param[1]);
                        gamedata.joinRoom(param[0], param[1], client);
                        foreach (Room room in gamedata.rooms)
                        {
                            if (room.roomname == param[1])
                            {
                                DataHandler.SendString(room.clients[0].client, "03" + room.clients.Count);
                                Console.WriteLine("room " + param[1] + " created");
                                room.startGame();
                            }
                        }

                        done = true;
                        break;
                    case "02": //JOIN "username":"roomname"
                        data = data.Replace("02", "");
                        param = data.Split(':');
                        gamedata.joinRoom(param[0], param[1], client);
                        foreach (Room room in gamedata.rooms)
                        {
                            if (room.roomname == param[1])
                            {
                                DataHandler.SendString(room.clients[0].client, "03" + room.clients.Count);
                                DataHandler.SendString(room.clients[1].client, "03" + room.clients.Count);
                                Console.WriteLine("joined room " + param[1]);
                            }
                        }
                        done = true;
                        break;
                    case "07":
                        List<String> contents = FileIO.read();
                        foreach (String e in contents)
                            DataHandler.SendString(client, "07" + e);
                        DataHandler.SendString(client, "07 END");
                        break;
                }
            }
        }
    }
}
