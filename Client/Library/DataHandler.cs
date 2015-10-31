using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Library
{
    public class DataHandler
    {
        public static void writeData(TcpClient client, string d)
        {
            if (d.Length > 1)
            {
                string[] messages = { d };
                new BinaryFormatter().Serialize(client.GetStream(), messages);
            }
        }

        //Generic list used. Should replace the contents with what we will save for the scoreboard
        public static void writeData(TcpClient client, List<string> list)
        {
            new BinaryFormatter().Serialize(client.GetStream(), list);
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
            string[] lines = (string[])new BinaryFormatter().Deserialize(client.GetStream());
            string line = "";
            if (lines.Length == 1)
            {
                line = lines[0];
            }
            return line;
        }
    }
}
