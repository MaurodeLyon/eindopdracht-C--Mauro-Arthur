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
        private int x= 500,y = 500;
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

        private void keyListener(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    y += 20;
                    test.ellipse = new Rectangle(x,y,10,10);
                    panel1.Update();
                    break;
                case Keys.Down:
                    y -= 20;
                    test.ellipse = new Rectangle(x, y, 10, 10);
                    panel1.Update();
                    break;
                case Keys.Left:
                    x -= 20;
                    test.ellipse = new Rectangle(x, y, 10, 10);
                    panel1.Update();
                    break;
                case Keys.Right:
                    x += 20;
                    test.ellipse = new Rectangle(x, y, 10, 10);
                    panel1.Update();
                    break;
                default: break;
            }
        }
    }
}
