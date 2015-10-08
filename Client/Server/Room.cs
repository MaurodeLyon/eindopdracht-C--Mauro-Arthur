using System;
using System.Collections.Generic;

namespace Server
{
    class Room
    {
        private List<Tuple<String,GameClient>> test;
        public String roomname { get; }

        private Game game;

        public Room(string roomname)
        {
            this.roomname = roomname;
            game = new Game();
        }
    }
}