using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Test
{
    class Test
    {
        private drawingPanel panel;
        private Rectangle ellipse;
        public Test(drawingPanel panel)
        {
            this.panel = panel;
            ellipse = new Rectangle(panel.Width/2,panel.Height/2,10,10);
        }

        public void drawOnPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(Color.Black), ellipse);
            
        }
    }
}
