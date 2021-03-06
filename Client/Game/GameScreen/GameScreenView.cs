﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Game
{
    public partial class GameScreenView : Form
    {
        public gameModel gameModel;
        public int gamesizeX = 1024;
        public int gamesizeY = 768;
        private float scaleX;
        private float scaleY;

        public GameScreenView()
        {
            InitializeComponent();
            Cursor.Hide();
            scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            this.WindowState = FormWindowState.Maximized;   //set fullscreen
            viewTimer.Start();
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //zet graphics op correcte grootte
            g.ScaleTransform(scaleX, scaleY);
            //arena
            g.DrawLine(new Pen(Brushes.White), new Point(gamesizeX / 2, 0), new Point(gamesizeX / 2, gamesizeY));

            //players + ball 
            g.FillRectangle(Brushes.White, gameModel.player_1);
            g.FillRectangle(Brushes.White, gameModel.player_2);
            g.FillRectangle(Brushes.Red, gameModel.ball);

            //score
            g.DrawString(gameModel.score_Player_1, new Font("Comic sans", 50), Brushes.White, gamesizeX / 2 - 100, 10);
            g.DrawString(gameModel.score_Player_2, new Font("Comic sans", 50), Brushes.White, gamesizeX / 2 + 25, 10);
        }

        private void viewTimer_Tick(object sender, EventArgs e)
        {
            field.Refresh();
        }

        private void GameScreenView_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
