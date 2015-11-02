using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.ScoreBoardScreen
{
    public partial class ScoreboardView : Form
    {
        public ScoreboardView()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void appendText(String d)
        {
            richTextBox1.Invoke((MethodInvoker)(() =>richTextBox1.AppendText(d + Environment.NewLine )));        }
        }
}
