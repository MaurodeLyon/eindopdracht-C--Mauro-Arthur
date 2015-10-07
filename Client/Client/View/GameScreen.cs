using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
            Cursor.Hide(); // hide cursor
            viewTimer.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;    //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //set fullscreen
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
