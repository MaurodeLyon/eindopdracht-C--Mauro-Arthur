﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameView : Form
    {
        private gameModel gameModel;

        public GameView()
        {
            InitializeComponent();
            Cursor.Hide();                                  //hide cursor
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            gameModel = new gameModel(this);
            viewTimer.Enabled = true;
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            //arena
            g.DrawLine(new Pen(Brushes.White), new Point(field.Width / 2, 0), new Point(field.Width / 2, field.Height));

            //players + ball 
            g.FillRectangle(Brushes.White, gameModel.player_1);
            g.FillRectangle(Brushes.White, gameModel.player_2);
            g.FillRectangle(Brushes.Red, gameModel.ball);

            //score
            g.DrawString(gameModel.score_Player_1, new Font("Comic sans", 50), Brushes.White, field.Width / 2 - 100, 10);
            g.DrawString(gameModel.score_Player_2, new Font("Comic sans", 50), Brushes.White, field.Width / 2 + 25, 10);

        }

        private void GameView_KeyDown(object sender, KeyEventArgs e)
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

        private void GameView_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    gameModel.direction = 0;
                    break;
                case Keys.Down:
                    gameModel.direction = 0;
                    break;
                default:
                    break;
            }
        }

        private void viewTimer_Tick(object sender, EventArgs e)
        {
            field.Refresh();
        }
    }
}