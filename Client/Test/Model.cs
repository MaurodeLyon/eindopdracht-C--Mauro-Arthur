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
    class Model
    {
        private drawingPanel panel;

        private System.Timers.Timer modelTimer;

        public int x, y;

        public Model(drawingPanel panel)
        {
            this.panel = panel;
            x = panel.Width / 2;
            y = panel.Height / 2;
            modelTimer = new System.Timers.Timer(10);
            modelTimer.Elapsed += onTimedEvent;
        }

        private void onTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // events every interval
        }

        public void drawOnPanel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            /* for (int i = 0; i < 10000; i++)
             {
                 g.DrawLine(new Pen(Color.Black), new Point(r.Next(500), r.Next(500)), new Point(r.Next(500), r.Next(500)));
             }*/


            g.FillRectangle(Brushes.Black, x, y, 10, 10);

        }

        public void move(int direction)
        {
            switch (direction)
            {
                case 0: break;//idle
                case 1: y--; break;//up
                case 2: y++; break;//down
                case 3: x--; break;//left
                case 4: x++; break;//right
                default: break;
            }
        }
    }
}
