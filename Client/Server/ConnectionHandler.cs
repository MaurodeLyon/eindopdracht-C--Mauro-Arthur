using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ConnectionHandler
    {
        private TcpListener listener;
        private GameData gamedata;

        public ConnectionHandler()
        {
            bool done = false;

            IPAddress localhost;
            IPAddress.TryParse("145.48.227.168", out localhost);
            gamedata = new GameData();
            listener = new TcpListener(localhost, 1338);
            listener.Start();

            while (!done)
            {
                TcpClient client = listener.AcceptTcpClient();
                //EXAMPLE 01 username:roomname
                String data = DataHandler.readData(client);
                String[] param;
                String command = data.Substring(0, 2);
                Console.WriteLine(data);
                switch (command)
                {
                    case "01": //CREATE
                        data = data.Replace("01", "");
                        param = data.Split(':');
                        gamedata.createRoom(param[1]);
                        gamedata.joinRoom(param[0], param[1], client);
                        foreach (Room room in gamedata.rooms)
                        {
                            if (room.roomname == param[1])
                            {
                                room.amountPlayers++;
                                DataHandler.writeData(room.clients[0].client, "03" + room.amountPlayers.ToString());
                                Console.WriteLine("room " + param[1] + " created");
                            }
                        }
                        break;

                    case "02": //JOIN
                        data = data.Replace("02", "");
                        param = data.Split(':');
                        gamedata.joinRoom(param[0], param[1], client);
                        foreach (Room room in gamedata.rooms)
                        {
                            if (room.roomname == param[1])
                            {
                                room.amountPlayers++;
                                DataHandler.writeData(room.clients[0].client, "03" + room.amountPlayers.ToString());
                                DataHandler.writeData(room.clients[1].client, "03" + room.amountPlayers.ToString());
                                Console.WriteLine("joined room " + param[1]);
                            }
                        }
                        break;
                    case "04": //START GAME
                        Console.WriteLine("code 04 received");
                        data = data.Replace("04", "");
                        Console.WriteLine(data);
                        param = data.Split(':');
                        Console.WriteLine(param);
                        foreach (Room room in gamedata.rooms)
                        {
                            if (room.roomname == param[0])
                            {
                                room.startGame();
                            }
                        }
                        break;
                }
            }
        }
    }
}
