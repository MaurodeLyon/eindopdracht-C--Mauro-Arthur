using Game.MainMenuGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.EndScreen
{
    public partial class EndScreenView : Form
    {
        private EndScreenModel endScreemModel;

        public EndScreenView(int score1, int score2)
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
            endScreemModel = new EndScreenModel(this);
            scoreP1.Text = score1.ToString();
            scoreP2.Text = score2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(restart).Start();
            Application.Exit();
        }

        private void restart()
        {
            Application.Run(new MenuScreenView());
        }
    }
}
