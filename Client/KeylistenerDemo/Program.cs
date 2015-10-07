using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeylistenerDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private void NewDialog_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    {
                        MethodToOutputSound(AEnum);
                        break;
                    }
                case Keys.B:
                    {
                        MethodToOutputSound(BEnum);
                        break;
                    }
                case Keys.F11:
                    {
                        DifferentMethod();
                        break;
                    }
                case Keys.Escape:
                    {
                        this.Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
