using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.EndScreen
{
    public partial class EndScreenView : Form
    {
        private EndScreenModel endScreemModel;

        public EndScreenView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    //remove borders
            this.TopMost = true;                            //set form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //set fullscreen 
            endScreemModel = new EndScreenModel(this);
        }
    }
}
