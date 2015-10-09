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
    public partial class MainMenuView : Form
    {
        private MainMenuModel model;

        public MainMenuView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            model = new MainMenuModel(this);
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
