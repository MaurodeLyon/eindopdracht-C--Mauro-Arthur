using System;
using System.Collections.Generic;
using System.Threading;

namespace Server
{
    class Room
    {
        public List<GameClient> clients { get; }
        public String roomname { get; }

        private Game game;

        public Room(string roomname)
        {
            this.roomname = roomname;
            game = new Game();
            this.clients = new List<GameClient>();

            Thread task = new Thread(handleGame);
            task.Start();

        }

        public void handleGame()
        {
            bool done = false;

            while(!done)
            {
                //HANDLE UPDATING AND SENDING INFORMATION

                foreach (GameClient e in clients)
                {

                }

            }

        }
    }
}