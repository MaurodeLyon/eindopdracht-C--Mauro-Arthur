﻿using Game.EndScreen;
using Game.MainMenuGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuScreenView());
            //Application.Run(new GameScreenView());
            //Application.Run(new EndScreenView(6, 3));
        }
    }
}
