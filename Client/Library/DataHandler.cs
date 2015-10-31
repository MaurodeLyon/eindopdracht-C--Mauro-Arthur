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

        /******************
        voor het versturen van een serialized message
        ******************/
        public static void writeData(TcpClient client, string d)
        {
            if (d.Length > 1)
            {
                string[] messages = { d };
                new BinaryFormatter().Serialize(client.GetStream(), messages);
            }
        }

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

        /******************
        voor het versturen van een string
        ******************/
        public static void SendString(TcpClient client, string message)
        {
            StreamWriter stream = new StreamWriter(client.GetStream(), Encoding.Unicode);
            stream.WriteLine(message);
            stream.Flush();
        }

        public static string ReadString(TcpClient client)
        {
            StreamReader stream = new StreamReader(client.GetStream(), Encoding.Unicode);
            return stream.ReadLine();
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

    }
}
