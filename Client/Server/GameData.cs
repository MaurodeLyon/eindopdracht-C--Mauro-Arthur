using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Server
{
    class GameData
    {

        public List<Room> rooms { get;}

        public GameData()
        {
            rooms = new List<Room>();
            

        }

        public void createRoom(String roomname)
        {
            rooms.Add(new Room(roomname));
        }

        public void joinRoom(String username, String roomName, TcpClient client)
        {
            foreach(Room e in rooms)
            {
                if(e.roomname == roomName)
                {
                    //Add new gameClient to room
                }
            }
        }
    }
}