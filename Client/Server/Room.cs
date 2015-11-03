using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Library;
using System.Net.Sockets;

namespace Server
{
    class Room
    {
        public List<GameClient> clients { get; }
        public string roomname { get; }
        public int amountPlayers = 0;

        //Game Objects
        public Rectangle field;
        public Rectangle player_1;
        public Rectangle player_2;
        public Rectangle ball;

        private int ball_horizontal_speed = 4;
        private int ball_vertical_speed = 4;
        public int score_Player_1 = 5;
        public int score_Player_2 = 5;

        private System.Timers.Timer modelTimer;
        private System.Timers.Timer connectionTimer;

        private bool p1R = false, p2R = false;

        public Room(string roomname)
        {
            this.roomname = roomname;
            this.clients = new List<GameClient>();
            modelTimer = new System.Timers.Timer(5);
            connectionTimer = new System.Timers.Timer(5);
            connectionTimer.Elapsed += onConnectionEvent;
            modelTimer.Elapsed += onTimedEvent;

            field = new Rectangle(0, 0, 1024, 768);
            ball = new Rectangle(field.Width / 2 - 10, field.Height / 2 - 10, 20, 20);
            player_1 = new Rectangle(1024 / 20 - 25, 768 / 2, 25, 100);
            player_2 = new Rectangle(1024 - 1024 / 20, 768 / 2, 25, 100);
        }

        private void onConnectionEvent(object sender, ElapsedEventArgs e)
        {
            //send ball,position other player and score to clients
            DataHandler.SendString(clients[0].client, $"05 {ball.X}:{ball.Y}:{player_2.Y}:{score_Player_1}:{score_Player_2}");
            DataHandler.SendString(clients[1].client, $"05 {ball.X}:{ball.Y}:{player_1.Y}:{score_Player_2}:{score_Player_1}");
        }

        private void sendEnd()
        {
            DataHandler.SendString(clients[0].client, "06" + score_Player_1 + ":" + score_Player_2);
            DataHandler.SendString(clients[1].client, "06" + score_Player_1 + ":" + score_Player_2);
        }

        public void startGame()
        {
            new Thread(handleGame).Start();
        }

        //simulate game
        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            ball.X += ball_horizontal_speed;
            ball.Y += ball_vertical_speed;

            //if ball touches players
            if ((player_1.IntersectsWith(ball) && ball_horizontal_speed < 0) || (player_2.IntersectsWith(ball) && ball_horizontal_speed > 0))
                ball_horizontal_speed *= -1;


            //if ball toches top border
            if (ball.Top < field.Top)
                if (ball_vertical_speed < 0)
                    ball_vertical_speed = -ball_vertical_speed;

            //if ball touches bottom border
            if (ball.Bottom > field.Bottom)
                if (ball_vertical_speed > 0)
                    ball_vertical_speed = -ball_vertical_speed;

            //if vall touches left border
            if (ball.Left <= field.Left)
            {
                if (ball_horizontal_speed < 0)
                    ball_horizontal_speed = -ball_horizontal_speed;
                score_Player_2++;
                ball.Location = new Point(502, 374);
            }

            //if ball touches right border
            if (ball.Right >= field.Right)
            {
                if (ball_horizontal_speed > 0)
                    ball_horizontal_speed = -ball_horizontal_speed;
                score_Player_1++;
                ball.Location = new Point(502, 374);
            }

            if (score_Player_1 > 5 || score_Player_2 > 5)
            {
                //end game
                FileIO.save(clients[0].username + "-" + clients[1].username + ":" + score_Player_1 + " - " + score_Player_2);
                done = true;
                modelTimer.Stop();
                connectionTimer.Stop();
                new Thread(sendEnd).Start();
                t1.Abort();
                t2.Abort();
            }
        }
        string p1, p2;
        Thread t1;
        Thread t2;
        bool done;
        public void handleGame()
        {
            bool starting = false;
            done = false;
            Console.WriteLine("Starting games on client");
            while (!starting)
            {
                string command = DataHandler.ReadString(clients[0].client);

                Console.WriteLine(command);
                Console.WriteLine(command.Substring(0, 2));

                if (command.Substring(0, 2) == "04")
                    p1R = true;

                if (clients.Count > 1)
                {
                    string command2 = DataHandler.ReadString(clients[1].client);
                    Console.WriteLine(command2);
                    Console.WriteLine(command2.Substring(0, 2));
                    if (command2.Substring(0, 2) == "04")
                        p2R = true;
                }

                if (p1R == true && p2R == true)
                {
                    starting = true;
                    DataHandler.SendString(clients[0].client, "04");
                    DataHandler.SendString(clients[1].client, "04");
                    modelTimer.Start();
                    connectionTimer.Start();
                }
            }

            Console.WriteLine("starting game on server");

            //HANDLE UPDATING AND SENDING INFORMATION
            GameClient client_1 = clients[0];
            GameClient client_2 = clients[1];
            t1 = new Thread(ReadData1);
            t2 = new Thread(ReadData2);
            while (!done)
            {
                if (!t1.IsAlive)
                    t1.Start(client_1.client);
                if (!t2.IsAlive)
                    t2.Start(client_2.client);

                if (p1 != null)
                    p1 = p1.Replace("05", "");
                if (p2 != null)
                    p2 = p2.Replace("05", "");

                int y;
                if (p1 != null)
                {
                    int.TryParse(p1, out y);
                    player_1.Y = y;
                }

                if (p2 != null)
                {
                    int.TryParse(p2, out y);
                    player_2.Y = y;
                }
            }
        }

        private void ReadData1(object obj)
        {
            while (true)
            {
                TcpClient client = obj as TcpClient;
                p1 = DataHandler.ReadString(client);
                Console.WriteLine("p1" + p1);
            }
        }

        private void ReadData2(object obj)
        {
            while (true)
            {
                TcpClient client = obj as TcpClient;
                p2 = DataHandler.ReadString(client);
                Console.WriteLine("p2" + p2);
            }
        }
    }
}