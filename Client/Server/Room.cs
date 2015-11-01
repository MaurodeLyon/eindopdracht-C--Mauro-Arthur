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
        private int ball_horizontal_speed = 10;
        private int ball_vertical_speed = 10;

        public int score_Player_1 = 0;
        public int score_Player_2 = 0;

        private System.Timers.Timer modelTimer;

        private System.Timers.Timer debugTimer;

        private Boolean p1R = false, p2R = false;


        public Room(string roomname)
        {
            this.roomname = roomname;
            this.clients = new List<GameClient>();

            modelTimer = new System.Timers.Timer(10);
            
            modelTimer.Elapsed += onTimedEvent;

            debugTimer = new System.Timers.Timer(1000);

            debugTimer.Elapsed += onDebugEvent;



            field = new Rectangle(0, 0, 1024, 768);
            ball = new Rectangle(field.Width / 2 - 10, field.Height / 2 - 10, 20, 20);
        }

        public void startGame()
        {
            new Thread(handleGame).Start();
        }

        private void onDebugEvent(object obj, ElapsedEventArgs a)
        {
            //Console.WriteLine(p1 + "," + p2 + "," + ball.Y);
        }

        //simulate game
        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            ball.X += ball_horizontal_speed;
            ball.Y += ball_vertical_speed;

            //if ball touches players
            if (player_1.Contains(ball) || player_2.Contains(ball))
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
            }

            //if ball touches right border
            if (ball.Right >= field.Right)
            {
                if (ball_horizontal_speed > 0)
                    ball_horizontal_speed = -ball_horizontal_speed;
                score_Player_1++;
            }
        }
        string p1, p2;
        Thread t1;
        Thread t2;

        public void handleGame()
        {
            bool starting = false;
            Console.WriteLine("Starting games on client");
            while (!starting)
            {
                string command = DataHandler.readData(clients[0].client);
               

                Console.WriteLine(command);
                Console.WriteLine(command.Substring(0, 2));

               
                if (command.Substring(0, 2) == "04")
                {
                    //DataHandler.writeData(clients[0].client, "04");
                    //DataHandler.writeData(clients[1].client, "04");
                    //starting = true;
                    p1R = true;

                }

                string command2 = DataHandler.readData(clients[1].client);

                Console.WriteLine(command2);
                Console.WriteLine(command2.Substring(0, 2));
                if (command2.Substring(0,2)=="04")
                {
                    p2R = true;
                }

                if(p1R==true && p2R ==true)
                {
                    starting = true;
                    DataHandler.writeData(clients[0].client, "04");
                    DataHandler.writeData(clients[1].client, "04");
                    modelTimer.Start();
                    debugTimer.Start();
                }
            }

            bool done = false;
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

                if(p1!=null)
                p1 = p1.Replace("05", "");
                if(p2!=null)
                p2 = p2.Replace("05", "");
                int x;
                int y;
                if (p1 != null)
                {


                    string[] p1Param = p1.Split(':');

                    int.TryParse(p1Param[0], out x);
                    int.TryParse(p1Param[1], out y);
                    player_1.X = x;
                    player_1.Y = y;
                }

                if (p2 != null)
                {


                    string[] p2Param = p2.Split(':');

                    int.TryParse(p2Param[0], out x);
                    int.TryParse(p2Param[1], out y);
                    player_2.X = x;
                    player_2.Y = y;
                }
                //send ball,position other player and score to client 1
                DataHandler.writeData(client_1.client, $"05 {ball.X}:{ball.Y}:{player_2.X}:{player_2.Y}:{score_Player_1}:{score_Player_2}");
                //send ball,position other player and score to client 2
                DataHandler.writeData(client_2.client, $"05 {ball.X}:{ball.Y}:{player_1.X}:{player_1.Y}:{score_Player_2}:{score_Player_1}");
                //Console.WriteLine($"05 {ball.X}:{ball.Y}:{player_2.X}:{player_2.Y}:{score_Player_1}:{score_Player_2}");
                //send ball,position other player and score to client 2
               // Console.WriteLine($"05 {ball.X}:{ball.Y}:{player_1.X}:{player_1.Y}:{score_Player_2}:{score_Player_1}");
            }
        
        }

        private void ReadData1(object obj)
        {
            while (true)
            {


                TcpClient client = obj as TcpClient;
                p1 = DataHandler.readData(client);
                Console.WriteLine("p1" + p1);
            }
        }

        private void ReadData2(object obj)
        {
            while (true)
            {


                TcpClient client = obj as TcpClient;
                p2 = DataHandler.readData(client);
                Console.WriteLine("p2" + p2);
            }
        }
    }
}