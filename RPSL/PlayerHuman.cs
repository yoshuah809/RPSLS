using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    public class PlayerHuman : Player
    {
        //public PlayerHuman(string name)
        //{
        // this.name = "PlayerFlesh";

        //}
        public PlayerHuman()
        {
            AddGesture();
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a Gesture of Scissors, Paper, Rock, Lizard, or Spock");

            gestureChoosen = Console.ReadLine();
            return;

        }


    }
}