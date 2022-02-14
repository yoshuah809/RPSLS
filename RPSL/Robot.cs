using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    public class Robot : Player
    {
      
        Random ComputerChoice = new Random();
        public Robot()
        {
            AddGesture();

        }


        public override void ChooseGesture()
        {
            int val = ComputerChoice.Next(0, 5);
            gestureChoosen = gestures[val];

            return;

        }
    }
}