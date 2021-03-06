﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Game.ScoreBoardScreen;

namespace Game.MainMenuGame
{
    public partial class MenuScreenView : Form
    {
        private MainMenuModel model;
        private string username, roomname;

        public MenuScreenView()
        {
            InitializeComponent();
            model = new MainMenuModel(this);
            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            this.WindowState = FormWindowState.Maximized;   //set fullscreen
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            DataHandler.SendString(model.client, "04" + roomname);
            gameButton.Enabled = false;
        }

        private void scoreboardButton_Click(object sender, EventArgs e)
        {
            // insert score screen
            ScoreboardModel model2 = new ScoreboardModel(new ScoreboardView(), model.client);
            model.done = true;
            model2.view.ShowDialog();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server
            DataHandler.SendString(model.client, "01" + username + ":" + roomname);
            scoreboardButton.Enabled = false;
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server
            DataHandler.SendString(model.client, "02" + username + ":" + roomname);
            scoreboardButton.Enabled = false;
        }
    }
}
