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
        private ScoreboardView view;

        public ScoreboardModel(ScoreboardView view,TcpClient client)
        {
            this.view = view;
            this.client = client;

            Thread task = new Thread(new ThreadStart(handleConnection));
            task.Start();

        }

        public void handleConnection()
        {
            DataHandler.writeData(client,"07");

            String[] data = DataHandler.readList(client);


            foreach(string e in data)
            {
                view.appendText(e);
            }


        }

    }
}
