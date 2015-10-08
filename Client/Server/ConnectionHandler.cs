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

            IPAddress localhost = IPAddress.Parse("127.0.0.1");

            listener = new TcpListener(localhost, 1338);

            listener.Start();

            while (!done)
            {
                TcpClient client = listener.AcceptTcpClient();
                //EXAMPLE 01 username:roomname
                String data = DataHandler.readData(client);
                String[] param;
                String command = data.Substring(0, 2);

                switch(command)
                {
                    case "01":
                        //CREATE
                        data = data.Replace("01", "");
                        param = data.Split(':');

                        gamedata.createRoom(param[0]);
                        gamedata.joinRoom(param[1], param[0], client);
                        break;
                    case "02":
                        //JOIN
                        data = data.Replace("02", "");
                        param = data.Split(':');
                        gamedata.joinRoom(param[1], param[0], client);
                        break;

                }




                



            }


        }

    }
}
