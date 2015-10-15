﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class DataHandler
    {
        public static void writeData(TcpClient client,String d)
        {
            if (d.Length > 1)
            {
                string[] messages = { d };
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(client.GetStream(), messages);
            }
        }

        //Generic list used. Should replace the contents with what we will save for the scoreboard
        public static void writeData(TcpClient client, List<String> list)
        {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(client.GetStream(), list);
            
        }

        //public static string readData(TcpClient client)
        //{
        //    String e = "";
        //    using (StreamReader sr = new StreamReader( client.GetStream()))
        //    {
        //        e = sr.ReadLine();
        //    }

        //    return e;


            
        //}

        public static string readData(TcpClient client)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string[] lines = (string[])formatter.Deserialize(client.GetStream());
            string line = "";
            if (lines.Length == 1)
            {
                line = lines[0];
            }


            return line;
        }
    }
}