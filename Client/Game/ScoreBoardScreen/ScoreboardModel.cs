using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.ScoreBoardScreen
{
    class ScoreboardModel
    {
        private TcpClient client;
        public ScoreboardView view;

        public ScoreboardModel(ScoreboardView view, TcpClient client)
        {
            this.view = view;
            this.client = client;

            Thread task = new Thread(new ThreadStart(handleConnection));
            task.Start();
        }

        public void handleConnection()
        {
            DataHandler.SendString(client, "07");
            bool done = false;
            List<String> temp = new List<String>();
            while (!done)
            {
                String response = DataHandler.ReadString(client);
                if (response.Contains("END"))
                    done = true;


                if (response.Substring(0, 2) == "07" && !response.Contains("END"))
                {
                    response = response.Replace("07", "");
                    temp.Add(response);
                }
            }
            view.appendText("-------------------------");
            foreach (String e in temp)
            {
                Console.WriteLine(e);
                view.appendText(e);
            }
        }
    }
}
