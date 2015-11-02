using Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Game
{
    public class gameModel
    {
        public GameScreenView GameScreenView;
        public FakeServerTest fakeServerTest;
        public ConnectionToServer connectionToServer;

        public Rectangle player_1;
        public Rectangle player_2;
        public Rectangle ball;

        public string score_Player_1;
        public string score_Player_2;

        public gameModel(GameScreenView GameScreenView)
        {
            player_1 = new Rectangle(GameScreenView.field.Width / 20, GameScreenView.field.Height / 2 - 50, 25, 100);
            player_2 = new Rectangle(GameScreenView.field.Width - GameScreenView.field.Width / 20, GameScreenView.field.Height / 2 - 50, 25, 100);
            ball = new Rectangle(GameScreenView.field.Width / 2 - 10, GameScreenView.field.Height / 2 - 10, 20, 20);
            score_Player_1 = "0";
            score_Player_2 = "0";
            GameScreenView.Refresh();
            this.GameScreenView = GameScreenView;
            GameScreenView.gameModel = this;
        }

    }
}
