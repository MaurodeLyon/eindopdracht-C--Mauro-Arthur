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

namespace Game.MainMenuGame
{
    public partial class MenuScreenView : Form
    {
        private MainMenuModel model;
        private string username, roomname;
        public MenuScreenView()
        {
            InitializeComponent();
            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);
            //this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            //this.TopMost = true;                            //set form to the front
            //this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen
            //this.WindowState = FormWindowState.Maximized;   //set fullscreen
            model = new MainMenuModel(this);
            Thread responseThread = new Thread(new ThreadStart(HandleResponse));
            responseThread.Start();
        }

        private void HandleResponse()
        {
            while (true)
            {
                while (model.client.GetStream().DataAvailable)
                {
                    string response = DataHandler.readData(model.client);
                    string code = response.Substring(0, 2);
                    response = response.Replace(code, "");
                    string[] param = response.Split(':');

                    switch (code)
                    {
                        case "03":
                            AmountConnectedLabel.Invoke((MethodInvoker)(() => AmountConnectedLabel.Text = param[0] + "/2 players ready"));
                            gameButton.Invoke((MethodInvoker)(() => gameButton.Enabled = true));
                            gameButton.Invoke((MethodInvoker)(() => gameButton.Text = "Start game"));
                            break;
                        case "04":
                            //this.Hide();
                            this.Invoke((MethodInvoker)(() => this.Hide()));
                            GameScreenView GameScreenView = new GameScreenView(model.client);
                            GameScreenView.Show();
                            break;
                        default: break;
                    }
                }
            }
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            DataHandler.writeData(model.client, "04" + roomname);
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
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server
            DataHandler.writeData(model.client, "01" + username + ":" + roomname);
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
            roomname = RoomnameBox.Text;
            //send to server
            DataHandler.writeData(model.client, "02" + username + ":" + roomname);
        }
    }
}
