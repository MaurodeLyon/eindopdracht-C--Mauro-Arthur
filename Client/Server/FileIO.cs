using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class FileIO
    {
        public static void save(String d)
        {
            String path = Path.Combine(Environment.CurrentDirectory, "Scoreboard.yolo");

            FileStream fifo = File.Open(path, FileMode.Append, FileAccess.Write);
            using (StreamWriter w = new StreamWriter(fifo))
            {
                w.WriteLine(d);
            }
        }

        public static List<String> read()
        {
            String path = Path.Combine(Environment.CurrentDirectory, "Scoreboard.yolo");
            List<String> temp = new List<String>();
            using (StreamReader r = File.OpenText(path))
            {
                string current;
                while ((current = r.ReadLine()) != null)
                {
                    temp.Add(current);
                }
            }

            return temp;
        }
    }
}
