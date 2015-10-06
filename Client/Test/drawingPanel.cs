using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test 
{
    public partial class drawingPanel : Form
    {
        private Test test;
        public drawingPanel()
        {
            InitializeComponent();
            test = new Test(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            test.drawOnPanel(sender,e);
        }
    }
}
