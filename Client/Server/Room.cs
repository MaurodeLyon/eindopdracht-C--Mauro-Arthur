using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Server
{
    class Room
    {
        public List<GameClient> clients { get; }
        public String roomname { get; }
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


        public Room(string roomname)
        {
            this.roomname = roomname;
            this.clients = new List<GameClient>();

            modelTimer = new System.Timers.Timer(10);
            modelTimer.Elapsed += onTimedEvent;
            modelTimer.Enabled = true;

            field = new Rectangle(0, 0, 1024, 768);
            ball = new Rectangle(field.Width / 2 - 10, field.Height / 2 - 10, 20, 20);
        }

        public void startGame()
        {
            if (amountPlayers == 2)
            {
                Thread task = new Thread(new ThreadStart(handleGame));
                task.Start();
                DataHandler.writeData(clients[0].client, "04");
                DataHandler.writeData(clients[1].client, "04");
            }
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

        public void handleGame()
        {
            bool done = false;
            while (!done)
            {
                //HANDLE UPDATING AND SENDING INFORMATION
                GameClient client_1 = clients[0];
                GameClient client_2 = clients[1];
                //send ball,position other player and score to client 1
                DataHandler.writeData(client_1.client, $"05 {ball.X}:{ball.Y}:{player_2.X}:{player_2.Y}:{score_Player_1}:{score_Player_2}");
                //send ball,position other player and score to client 2
                DataHandler.writeData(client_2.client, $"05 {ball.X}:{ball.Y}:{player_1.X}:{player_1.Y}:{score_Player_2}:{score_Player_1}");
            }
        }
    }
}