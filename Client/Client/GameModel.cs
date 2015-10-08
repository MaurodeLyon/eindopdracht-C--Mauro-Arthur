using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Client.Model
{
    class GameModel
    {
        private Timer modelTimer;

        public GameModel()
        {
            modelTimer = new Timer(10);
            modelTimer.Elapsed += onTimedEvent;
        }

        private void onTimedEvent(object obj, ElapsedEventArgs e)
        {
            //interval
        }
    }
}
