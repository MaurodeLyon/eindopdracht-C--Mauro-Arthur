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
        private Model model;
        public drawingPanel()
        {
            InitializeComponent();
            ViewTimer.Enabled = true;
            model = new Model(this);
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            model.drawOnPanel(sender, e);
        }

        private void drawingPanel_KeyDown(object sender, KeyEventArgs e)
        {
            model.direction = 0;
            
            switch (e.KeyData)
            {
                case Keys.Up:
                    model.direction = 1;
                    break;
                case Keys.Down:
                    model.direction = 2;
                    break;
                case Keys.Left:
                    model.direction = 3;
                    break;
                case Keys.Right:
                    model.direction = 4;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    model.direction = 0;
                    break;
            }
        }

        private void ViewTimer_Tick(object sender, EventArgs e)
        {
            field.Refresh();
        }
    }
}
