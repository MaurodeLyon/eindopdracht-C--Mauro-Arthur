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

namespace Game.ScoreBoardScreen
{
    public partial class ScoreboardView : Form
    {
        private float scaleX;
        private float scaleY;

        public ScoreboardView()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            this.WindowState = FormWindowState.Maximized;   //set fullscreen
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void appendText(String d)
        {
            richTextBox1.Invoke((MethodInvoker)(() => richTextBox1.AppendText(d + Environment.NewLine)));
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
