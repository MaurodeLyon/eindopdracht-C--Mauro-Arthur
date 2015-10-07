using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;    //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //set fullscreen
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameScreen().Show();            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
