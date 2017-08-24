using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpolo.Game_Logic
{
    public class BallLogic
    {
        private Random randomNumber = new Random();
        public BallLogic()
        {            
            ShowBox();

        }

        public void ShowBox()
        {
            MessageBox.Show("Random number = " + randomNumber.Next(1, 10));
            MessageBox.Show("Random number = " + randomNumber.Next(1, 10));
        }

        
    }
}
