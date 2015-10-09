using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.MainMenuGame
{
    class MainMenuModel
    {
        private MainMenuView form;

        public MainMenuModel(MainMenuView form)
        {
            this.form = form;
            //try to connect to server
        }
    }
}
