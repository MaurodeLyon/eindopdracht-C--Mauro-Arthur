using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.MainMenuGame
{
    public partial class MenuScreenView : Form
    {
        private MainMenuModel model;

        public MenuScreenView()
        {
            InitializeComponent();
            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            this.WindowState = FormWindowState.Maximized;   //set fullscreen
            model = new MainMenuModel(this);
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameScreenView GameScreenView = new GameScreenView();
            GameScreenView.Show();
            FakeServerTest fakeServer = new FakeServerTest(GameScreenView);
        }

        private void scoreboardButton_Click(object sender, EventArgs e)
        {
            // insert score screen
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string username, roomname;
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server

            //Temporary fix to startgame until server connection
            gameButton.Enabled = true;
            gameButton.Text = "Start game";
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            string username, roomname;
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server
        }
    }
}
